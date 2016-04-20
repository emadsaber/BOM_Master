using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BOMParser
{
    public class Combiner:Base
    {
        #region Methods
        /// <summary>
        /// Combines the output of multiple files into one datatable.
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public DataTable Combine(params ExcelFile[] files)
        {
            DataTable dt = new DataTable();
            foreach (ExcelFile file in files)
            {
                if (dt.Columns.Count == 0) dt = file.ParsedDataTable;
                dt.Merge(file.ParsedDataTable);
            }
            if (dt.Columns.Contains("SN"))
                dt = RepairSerialNo(dt);
            return dt;
        }
        /// <summary>
        /// Repairs the ordering of serial number field after joining BOMs. It will be 
        /// [1 , RowsCount] instead of starting from 1 for each BOM.
        /// </summary>
        /// <param name="dt">The datatable after repairing SN</param>
        /// <returns></returns>
        private DataTable RepairSerialNo(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["SN"] = (i + 1).ToString();
            }
            return dt;
        }
        #endregion
    }
}