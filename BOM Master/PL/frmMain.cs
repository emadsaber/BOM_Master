using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BOMParser;
using System.Threading;
using CrystalDecisions.Shared;
namespace BOM_Master
{
    public partial class frmMain : Form
    {
        #region Constructors
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        private string Version
        {
            get
            {
                return "1.0.0.5";
            }
        }

        #endregion

        #region Fields
        private List<string> _fileNames;//holds filenames after browsing
        private DataTable _dt;
        #endregion

        #region Delegates
        delegate void picLoading_DLGT(bool state);
        delegate void dataGridView_DLGT(DataGridView dgv, DataTable dt);
        delegate void EnabledControls_DLGT(Control b, bool isEnabled);
        #endregion

        #region Methods
        /// <summary>
        /// Thread-Safe show and hide the loading picture.
        /// </summary>
        /// <param name="state">True => Show, False => Hide</param>
        private void ShowLoading(bool state)
        {
            if(picLoading.InvokeRequired){
                this.Invoke(new picLoading_DLGT(ShowLoading),state);
            }else{
                picLoading.Visible = state;
            }
        }
        /// <summary>
        /// Thread-Safe setting datatable to the gridview.
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="dt"></param>
        private void SetDataSource(DataGridView dgv, DataTable dt)
        {
            if (dgv.InvokeRequired)
            {
                this.Invoke(new dataGridView_DLGT(SetDataSource), dgv, dt);
            }
            else
            {
                dgv.DataSource = dt;
            }
        }
        /// <summary>
        /// Thread-Safe set the status to the status bar.
        /// </summary>
        /// <param name="status"></param>
        private void SetStatus(string status)
        {
            lblStatus.Text = status;
        }
        /// <summary>
        /// Thread-Safe set the controls to be Enabled or Disabled.
        /// </summary>
        /// <param name="c">Target control</param>
        /// <param name="isEnabled">Enabled or Disabled</param>
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += " - Version: " + Version;
            _dt = new DataTable();
        }
        /// <summary>
        /// Browsing the files and set the files names to the display and setting filenames variables.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ShowLoading(true);
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select raw files";
                    ofd.Multiselect = true;
                    ofd.CheckFileExists = true;
                    ofd.DefaultExt = "Excel Files | *.xls";
                    ofd.Filter = "Excel Files | *.xls";
                    ofd.ShowDialog();
                    if (_fileNames == null) _fileNames = new List<string>();
                    _fileNames.AddRange(ofd.FileNames);
                    for (int i = 0; i < ofd.FileNames.Length; i++)
                    {
                        lstFileNames.Items.Add(ofd.SafeFileNames[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Browsing files" + ex.Message);
            }
            ShowLoading(false);
        }
        /// <summary>
        /// Parsing files and displaying output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                Thread th = new Thread(() =>
                {
                    ShowLoading(true);
                    if (_fileNames == null || _fileNames.Count == 0)
                    {
                        MessageBox.Show("Please select files to parse");
                        ShowLoading(false);
                        return;
                    }
                    ExcelFile[] _excelFiles = new ExcelFile[_fileNames.Count];
                    for (int i = 0; i < _fileNames.Count; i++)
                    {
                        _excelFiles[i] = new ExcelFile(_fileNames[i]);
                    }
                    Combiner c = new Combiner();
                    c.StatusChanged += ExcelFile_StatusChanged;
                    try
                    {
                        _dt = c.Combine(_excelFiles);
                        SetDataSource(this.dataGridView1,_dt);
                       // _dt.ExportToExcel("C:\\output.xls");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ShowLoading(false);
                });
                th.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parsing Error: " + ex.Message);
            }
        }
        /// <summary>
        /// Handles the status changing event and sets the status to the status bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExcelFile_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            SetStatus(e.Status);
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ShowLoading(true);
            frmShowReport frm = new frmShowReport();
            rptBOM rep = new rptBOM();
            rep.SetDataSource(_dt);
            
            rep.SetParameterValue("Code", txtCode.Text);
            rep.SetParameterValue("SKU", txtSKU.Text);
            rep.SetParameterValue("IssuingDate", dtpIssueDate.Value.ToString());
            rep.SetParameterValue("IssuedBy", txtIssuedBy.Text);
            rep.SetParameterValue("MeterSpecifications", txtMeterSpecs.Text);
            rep.SetParameterValue("Revision", txtRevision.Text);

            frm.crystalReportViewer1.ReportSource = rep;
            frm.Show();
            ShowLoading(false);
        }
        private void btnComponentsGenerator_Click(object sender, EventArgs e)
        {
            new PL.frmComponentsGenerator().ShowDialog();
        }

        private void btnDeleteCurrentItem_Click(object sender, EventArgs e)
        {
            if (lstFileNames.Items.Count == 0) return;
            if (lstFileNames.SelectedIndex == -1) return;
            _fileNames.RemoveAt(lstFileNames.SelectedIndex);
            lstFileNames.Items.RemoveAt(lstFileNames.SelectedIndex);
        }

        private void btnDeleteAllItems_Click(object sender, EventArgs e)
        {
            _fileNames.Clear();
            lstFileNames.Items.Clear();
        }
        #endregion
    }
}
