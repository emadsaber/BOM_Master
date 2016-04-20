using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Interop.Excel;

namespace BOMParser
{
    public class Parser:Base
    {
        #region Constructors
        /// <summary>
        /// Initializes the parser, and the default lookup filename is "components.clf"
        /// </summary>
        public Parser()
        {
            this.ComponentsLookupFileName = "components.clf";
        }
        /// <summary>
        /// Initializes the parser with a full path to lookup file.
        /// </summary>
        /// <param name="componentsLookupFilename">Full path to lookup file.</param>
        public Parser(string componentsLookupFilename)
        {
            this.ComponentsLookupFileName = componentsLookupFilename;
        }
        #endregion

        #region Fields
        //Dictionary of lookup table.
        Dictionary<string, string> _componentsLookup;
        //Raw datatable generated from raw file.
        private System.Data.DataTable _rawDataTable;
        //Parsed datatable using the parser module.
        private System.Data.DataTable _componentsDataTable;
        #endregion

        #region Properties
        /// <summary>
        /// The name of file, which contains the translation dictionary.
        /// </summary>
        public string ComponentsLookupFileName { set; get; }
        #endregion

        #region Methods
        /// <summary>
        /// Parses the whole excel file and returns the result datatable.
        /// </summary>
        /// <param name="file">ExcelFile that contains the raw data.</param>
        /// <returns></returns>
        public System.Data.DataTable ParseFile(ExcelFile file)
        {
            this.Status = "Getting raw data table...";
            this._rawDataTable = file.RawDataTable;
            this.Status = "Initializing components data table...";
            InitComponentsDataTable(_rawDataTable.Columns);
            this._componentsLookup = new ComponentsLookupBuilder(ComponentsLookupFileName).GetComponentsLookupTable();
            for (int i = 0; i < _rawDataTable.Rows.Count; i++)
            {
                Component c = ParseRow(_rawDataTable.Rows[i]);
                c.SerialNumber = (i + 1).ToString();
                c.PCB_Name = GetFileName(file.FileName);
                _componentsDataTable.Rows.Add(  c.SerialNumber,
                                                c.PCB_Name,
                                                c.Type,
                                                c.Code,
                                                c.SewedyPartNumber,
                                                c.PartRef,
                                                c.Description,
                                                c.Manufacturer,
                                                c.Quantity
                                              );
                
            }
             return _componentsDataTable.Select().OrderBy(u => u["Code"]).CopyToDataTable();
        }
        /// <summary>
        /// Initialized the DataTable that will contain the final components data.
        /// </summary>
        /// <param name="rawColumns">The columns in the raw datatable.</param>
        private void InitComponentsDataTable(DataColumnCollection rawColumns)
        {
            _componentsDataTable = new System.Data.DataTable();
            _componentsDataTable.Columns.Add("SN", Type.GetType("System.String"));
            _componentsDataTable.Columns.Add("PCB", Type.GetType("System.String"));
            _componentsDataTable.Columns.Add("Type", Type.GetType("System.String"));
            _componentsDataTable.Columns.Add("Code", Type.GetType("System.String"));
            _componentsDataTable.Columns.Add("SewedyPartNo", Type.GetType("System.String"));
            _componentsDataTable.Columns.Add("PartRef", Type.GetType("System.String"));
            _componentsDataTable.Columns.Add("Description", Type.GetType("System.String"));
            _componentsDataTable.Columns.Add("Manufacturer", Type.GetType("System.String"));
            _componentsDataTable.Columns.Add("Quantity", Type.GetType("System.String"));
        }
        /// <summary>
        /// Gets the file name without extension. That helps in PCB Name
        /// </summary>
        /// <param name="filename">The file name with extension and may be the full path.</param>
        /// <returns></returns>
        private string GetFileName(string filename)
        {
            int _lastIndexOfDot = filename.LastIndexOf('.');
            int _lastIndexOfBackSlash = filename.LastIndexOf('\\');
            if (_lastIndexOfDot < _lastIndexOfBackSlash) { throw new Exception("Invalid file name"); }
            return filename.Substring(_lastIndexOfBackSlash + 1, (_lastIndexOfDot - _lastIndexOfBackSlash - 1));
        }
        /// <summary>
        /// Gets the component type depending on its code (ex: RT0001 => translates to Resistor)
        /// </summary>
        /// <param name="componentCode">The component's code like (RTXXXX)</param>
        /// <returns>The type of component, like Resistor.</returns>
        private string GetComponentType(string componentCode)
        {
            if (_componentsLookup == null) _componentsLookup = new ComponentsLookupBuilder(ComponentsLookupFileName).GetComponentsLookupTable();
            if (!_componentsLookup.ContainsKey(GetComponentPrefix(componentCode).ToUpper())) return componentCode;
            return _componentsLookup[componentCode.Substring(0, 2)];
        }
        private string GetComponentPrefix(string code)
        {
            int _indexOfFirstNumber = -1;
            for (int i = 1; i < code.Length; i++)
            {
                int temp = 0;//not needed just for using TryParse()
                if (Int32.TryParse(code[i].ToString(), out temp))
                {
                    _indexOfFirstNumber = i;
                    break;
                }
            }
            return code.Substring(0, _indexOfFirstNumber);
        }
        /// <summary>
        /// Parse the raw row and orders the columns.
        /// </summary>
        /// <param name="row">Raw data row.</param>
        /// <returns>Parsed data row as needed in the output file.</returns>
        private Component ParseRow(DataRow row)
        {
            if (row == null) throw new ArgumentNullException("Can't parse an empty data row");
            Component c = new Component();
            //TODO: the following code is bad, sorry for that. please if you have time make it more dynamic. (EMAD SABER 20-3-2016)
            if (row.ItemArray.Length < 7) throw new Exception("Sorry, parsing failed. Columns count is less than expected.");
            c.Type = GetComponentType(row[1].ToString());
            c.Code = row[1].ToString();
            c.Manufacturer = row[2].ToString();
            c.SewedyPartNumber = row[3].ToString();
            c.PartRef = row[4].ToString();
            c.Description = row[5].ToString();
            c.Quantity = row[6].ToString();
            return c;
        }
        #endregion
    }
}
