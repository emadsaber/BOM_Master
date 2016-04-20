using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BOMParser;
using System.IO;
namespace BOM_Master.PL
{
    public partial class frmComponentsGenerator : Form
    {
        #region Constructors
        public frmComponentsGenerator()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the default Lookup file name used to analyze components types.
        /// </summary>
        private string ComponentsLookupFileName
        {
            get { return "components.clf"; }
        }
        /// <summary>
        /// Indicates if user added or removed a row, so he should save before closing.
        /// </summary>
        private bool IsSavingRequired { set; get; }
        #endregion
        
        #region Events
        /// <summary>
        /// Form load event. Loads the current lookup table if exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmComponentsGenerator_Load(object sender, EventArgs e)
        {
            LoadLookupTable();
        }
        private void txtPrefix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //(Enter)
            {
                if (IsComponentExist(txtPrefix.Text)) { ep1.SetError(txtPrefix, "Duplicated prefix!!"); e.Handled = true; }
                txtMeaning.Focus();
                e.Handled = true;
            }
        }
        private void txtMeaning_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //(Enter)
            {
                if (txtPrefix.Text == "") return;
                AddComponentToGrid();
                ClearFields();
                e.Handled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveLookupTable())
            {
                MessageBox.Show("Lookup table saved successfully :)");
            }
            else
            {
                MessageBox.Show("Failed to save lookup table :(");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void dgvComponents_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.IsSavingRequired = true;
        }
        private void dgvComponents_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.IsSavingRequired = true;
        }

        #region Navigation
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (dgvComponents.Rows.Count > 0)
            {
                SetPosition(0);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (dgvComponents.Rows.Count > 0 && this.dgvComponents.CurrentRow.Index > 0)
            {
                SetPosition(this.dgvComponents.CurrentRow.Index - 1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dgvComponents.Rows.Count > 0 && this.dgvComponents.CurrentRow.Index < this.dgvComponents.Rows.Count - 1)
            {
                SetPosition(this.dgvComponents.CurrentRow.Index + 1);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (dgvComponents.Rows.Count > 0)
            {
                SetPosition(this.dgvComponents.Rows.Count - 1);
            }
        }
        #endregion
        
        #endregion

        #region Methods
        /// <summary>
        /// Loads the lookup table if exists to the datagridview.
        /// </summary>
        private void LoadLookupTable()
        {
            try
            {
                if (!System.IO.File.Exists(this.ComponentsLookupFileName)) return;
                Dictionary<string, string> _lookupTable = GetLookupTable();
                foreach (string key in _lookupTable.Keys)
                {
                    dgvComponents.Rows.Add(key, _lookupTable[key]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading existing lookup table: " + ex.Message);
            }
        }
        /// <summary>
        /// Gets the lookup table as a dictionary by parsing the lookup file.
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, string> GetLookupTable()
        {
            try
            {
                ComponentsLookupBuilder clb = new ComponentsLookupBuilder(this.ComponentsLookupFileName);
                return clb.GetComponentsLookupTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parsing components lookup file failed: " + ex.Message);
                return new Dictionary<string, string>();
            }
        }
        /// <summary>
        /// Saves the lookup table to the defualt filename
        /// </summary>
        /// <returns></returns>
        private bool SaveLookupTable()
        {
            StreamWriter sw = null;
            try
            {
                if (!dgvComponents.Columns.Contains("Prefix")) { MessageBox.Show("Where is the Prefix column?"); return false; }
                if (!dgvComponents.Columns.Contains("Meaning")) { MessageBox.Show("Where is the Meaning column?"); return false; }
                sw = new StreamWriter(this.ComponentsLookupFileName);
                
                for (int i = 0; i < dgvComponents.Rows.Count; i++)
                {
                    string prefix = dgvComponents.Rows[i].Cells["Prefix"].Value.ToString();
                    string meaning = dgvComponents.Rows[i].Cells["Meaning"].Value.ToString();
                    sw.WriteLine(String.Format("{0}${1}",prefix,meaning));
                }
                sw.Close();
                ep1.Clear();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save lookup table: " + ex.Message);
                if (sw != null) sw.Close();
                return false;
            }
        }
        /// <summary>
        /// Checks if the current prefix has been added before in the grid.
        /// </summary>
        /// <param name="prefix">The prefix name.</param>
        /// <returns></returns>
        private bool IsComponentExist(string prefix)
        {
            if (dgvComponents.Rows.Count == 0) return false;
            foreach (DataGridViewRow row in dgvComponents.Rows)
            {
                if (row.Cells["Prefix"].Value.ToString() == prefix.ToUpper()) return true;
            }
            return false;
        }
        /// <summary>
        /// Checks the length of prefix is greater than 2 characters and less than 4 characters.
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        private bool IsPrefixValid(string prefix)
        {
            if (prefix.Length < 2) return false;
            if (prefix.Length > 3) return false;
            return true;
        }
        /// <summary>
        /// Adds the current component to grid.
        /// </summary>
        private void AddComponentToGrid() 
        {
            if (!IsPrefixValid(txtPrefix.Text))
            {
                ep1.SetError(txtMeaning, "Invalid prefix length");
                return;
            }
            if (!IsComponentExist(txtPrefix.Text))
            {
                dgvComponents.Rows.Add(txtPrefix.Text.ToUpper(), txtMeaning.Text);
                btnLast_Click(this, new EventArgs());
                IsSavingRequired = true;
                ep1.Clear();
                return;
            }
            ep1.SetError(txtMeaning, "Duplicated prefix!!");
        }
        /// <summary>
        /// Clears the fields and focus the prefix field.
        /// </summary>
        private void ClearFields()
        {
            this.txtPrefix.Text = "";
            this.txtMeaning.Text = "";
            this.txtPrefix.Focus();
        }
        /// <summary>
        /// Sets the current row in the grid view.
        /// </summary>
        /// <param name="position">Required row's index.</param>
        private void SetPosition(int position)
        {
            this.dgvComponents.CurrentCell = this.dgvComponents[0, position];
        }
        /// <summary>
        /// Closes the form and cofirms the user if there is any updates to the Lookup table
        /// </summary>
        private void CloseForm()
        {
            if (IsSavingRequired)
            {
                DialogResult dr = MessageBox.Show("Any changes not saved will be lost! Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == System.Windows.Forms.DialogResult.Yes) this.Close();
            }
        }
        #endregion
    }
}
