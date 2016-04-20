using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Interop.Excel;

namespace BOMParser
{
    public class ExcelFile:Base
    {
        #region Fields
        private string _fileName;//Holds the file name and full path to file
        private Application _app;//Holds an object of the Excel Interop
        private Workbook _wb;//Holds a workbook variable, a workbook contains one or more sheets
        private Worksheet _sheet;//Holds a sheet object, sheet consists of rows and columns
        private System.Data.DataTable _rawDataTable;//The datatable that contains all rows and columns in a sheet
        private System.Data.DataTable _parsedDataTable;//The datatable that contains the final output data.
        #endregion

        #region Constructors
        /// <summary>
        /// Initiates an object with the file name with absolute path.
        /// </summary>
        /// <param name="fileName">Full path of the file.</param>
        public ExcelFile(string fileName)
        {
            this.FileName = fileName;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Sets and Gets the full file path.
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        /// <summary>
        /// Gets the datatable that contains raw input data without parsing.
        /// </summary>
        public System.Data.DataTable RawDataTable
        {
            get
            {
                if(_rawDataTable == null) _rawDataTable = GetRawDataTable();
                return _rawDataTable;
            }
        }
        /// <summary>
        /// Gets the parsed datatable depending on the raw datatable. If the raw data table has
        /// not been initialized, the property will fill it depending on the file.
        /// </summary>
        public System.Data.DataTable ParsedDataTable
        {
            get
            {
                if (_rawDataTable == null) _rawDataTable = GetRawDataTable();
                if (_parsedDataTable == null) _parsedDataTable = new Parser().ParseFile(this);
                return _parsedDataTable;
            }
        }
        /// <summary>
        /// Gets and sets the total columns count in the raw excel file.
        /// </summary>
        public int ColumnsCount { get; set; }
        /// <summary>
        /// Gets and sets the total rows count in the raw excel file.
        /// </summary>
        public int RowsCount { get; set; }
        /// <summary>
        /// Gets the index of first cell in first row if all cells are processed serially.
        /// </summary>
        public int FirstRowIndex { get { return this.ColumnsCount + 1; } }
        #endregion
        
        #region Methods
        /// <summary>
        /// Returns the raw file represented in a datatable.
        /// </summary>
        /// <returns></returns>
        private System.Data.DataTable GetRawDataTable()
        {
            List<string> _allCells = ReadAllCells();
            List<string> _colNames = GetColumnsNames(_allCells);
            _rawDataTable = InitDataTableColumns(_colNames);
            DefragCells(_allCells);
            this.Status = "Getting raw data successful :)";
            return _rawDataTable;
        }
        /// <summary>
        /// Gets all cells serially. One column only contains all raw data.
        /// </summary>
        /// <returns></returns>
        private List<string> ReadAllCells()
        {
            this.Status = "Reading all cells";
            _app = new Application();
            _wb = _app.Workbooks.Open(this._fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            _sheet = (Worksheet)_wb.Sheets["Sheet1"];
            Range _excelRange = _sheet.UsedRange;
            this.ColumnsCount = _excelRange.Columns.Count;
            this.RowsCount = _excelRange.Rows.Count;
            List<string> _allCells = new List<string>();
            foreach (Range row in _excelRange)
            {
                _allCells.Add(row.Value2.ToString());
            }
            _wb.Close();
            return _allCells;
        }
        /// <summary>
        /// Gets a list contains the columns names.
        /// </summary>
        /// <param name="allCells"></param>
        /// <returns></returns>
        private List<string> GetColumnsNames(List<string> allCells)
        {
            this.Status = "Getting columns names";
            if (this.ColumnsCount > allCells.Count) { throw new IndexOutOfRangeException("Columns count is less than the total cells count"); }
            List<string> ret = new List<string>();
            for (int i = 0; i < this.ColumnsCount; i++)
            {
                ret.Add(allCells[i]);
            }
            return ret;
        }
        /// <summary>
        /// Initializes the datatable by addding columns names. All columns of type (System.String).
        /// </summary>
        /// <param name="colNames"></param>
        /// <returns></returns>
        private System.Data.DataTable InitDataTableColumns(List<string> colNames)
        {
            this.Status = "Initializing data table";
            System.Data.DataTable _dt = new System.Data.DataTable();
            foreach (string colName in colNames)
            {
                _dt.Columns.Add(colName, Type.GetType("System.String"));
            }
            return _dt;
        }
        /// <summary>
        /// Fills the datatbale after splitting all cells to rows.
        /// </summary>
        /// <param name="allCells"></param>
        private void DefragCells(List<string> allCells)
        {
            this.Status = "Defragging cells";
            if (_rawDataTable == null) throw new NullReferenceException("RawDataTable has not been initialized, please call InitDataTableColumns(colNames) first.");
            for (int i = this.FirstRowIndex-1; i < allCells.Count; i += this.ColumnsCount)
            {
                _rawDataTable.Rows.Add(allCells.GetRange(i, this.ColumnsCount).ToArray());
            }
        }
        #endregion
    }
}
