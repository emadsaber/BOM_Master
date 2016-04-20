namespace BOM_Master
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComponentsGenerator = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.txtRevision = new System.Windows.Forms.TextBox();
            this.txtIssuedBy = new System.Windows.Forms.TextBox();
            this.txtMeterSpecs = new System.Windows.Forms.TextBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFileNames = new System.Windows.Forms.ListBox();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnDeleteAllItems = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDeleteCurrentItem = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(927, 582);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComponentsGenerator);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lstFileNames);
            this.groupBox1.Controls.Add(this.picLoading);
            this.groupBox1.Controls.Add(this.btnShowReport);
            this.groupBox1.Controls.Add(this.btnParse);
            this.groupBox1.Controls.Add(this.btnDeleteAllItems);
            this.groupBox1.Controls.Add(this.btnDeleteCurrentItem);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // btnComponentsGenerator
            // 
            this.btnComponentsGenerator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComponentsGenerator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnComponentsGenerator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnComponentsGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponentsGenerator.Location = new System.Drawing.Point(13, 482);
            this.btnComponentsGenerator.Name = "btnComponentsGenerator";
            this.btnComponentsGenerator.Size = new System.Drawing.Size(282, 34);
            this.btnComponentsGenerator.TabIndex = 4;
            this.btnComponentsGenerator.Text = "Components Generator";
            this.btnComponentsGenerator.UseVisualStyleBackColor = true;
            this.btnComponentsGenerator.Click += new System.EventHandler(this.btnComponentsGenerator_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dtpIssueDate);
            this.groupBox3.Controls.Add(this.txtRevision);
            this.groupBox3.Controls.Add(this.txtIssuedBy);
            this.groupBox3.Controls.Add(this.txtMeterSpecs);
            this.groupBox3.Controls.Add(this.txtSKU);
            this.groupBox3.Controls.Add(this.txtCode);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 197);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report Parameters";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpIssueDate.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssueDate.Location = new System.Drawing.Point(107, 107);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(165, 23);
            this.dtpIssueDate.TabIndex = 3;
            // 
            // txtRevision
            // 
            this.txtRevision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRevision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRevision.Location = new System.Drawing.Point(107, 161);
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.Size = new System.Drawing.Size(165, 23);
            this.txtRevision.TabIndex = 5;
            // 
            // txtIssuedBy
            // 
            this.txtIssuedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIssuedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIssuedBy.Location = new System.Drawing.Point(107, 134);
            this.txtIssuedBy.Name = "txtIssuedBy";
            this.txtIssuedBy.Size = new System.Drawing.Size(165, 23);
            this.txtIssuedBy.TabIndex = 4;
            // 
            // txtMeterSpecs
            // 
            this.txtMeterSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeterSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMeterSpecs.Location = new System.Drawing.Point(107, 80);
            this.txtMeterSpecs.Name = "txtMeterSpecs";
            this.txtMeterSpecs.Size = new System.Drawing.Size(165, 23);
            this.txtMeterSpecs.TabIndex = 2;
            // 
            // txtSKU
            // 
            this.txtSKU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSKU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSKU.Location = new System.Drawing.Point(107, 53);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(165, 23);
            this.txtSKU.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCode.Location = new System.Drawing.Point(108, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(165, 23);
            this.txtCode.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(33, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Revision";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Issue Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(60, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "SKU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(23, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Issued By";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Meter Specs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstFileNames
            // 
            this.lstFileNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFileNames.FormattingEnabled = true;
            this.lstFileNames.ItemHeight = 20;
            this.lstFileNames.Location = new System.Drawing.Point(12, 78);
            this.lstFileNames.Name = "lstFileNames";
            this.lstFileNames.Size = new System.Drawing.Size(217, 104);
            this.lstFileNames.TabIndex = 1;
            // 
            // picLoading
            // 
            this.picLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picLoading.Image = global::BOM_Master.Properties.Resources.loading2;
            this.picLoading.Location = new System.Drawing.Point(13, 522);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(33, 34);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 3;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShowReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Location = new System.Drawing.Point(12, 442);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(281, 34);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnParse.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnParse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnParse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.Location = new System.Drawing.Point(12, 402);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(281, 34);
            this.btnParse.TabIndex = 2;
            this.btnParse.Text = "Parse Files >>>";
            this.btnParse.UseVisualStyleBackColor = false;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnDeleteAllItems
            // 
            this.btnDeleteAllItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAllItems.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteAllItems.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteAllItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteAllItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteAllItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllItems.ImageKey = "deleteAll.png";
            this.btnDeleteAllItems.ImageList = this.imageList1;
            this.btnDeleteAllItems.Location = new System.Drawing.Point(235, 135);
            this.btnDeleteAllItems.Name = "btnDeleteAllItems";
            this.btnDeleteAllItems.Size = new System.Drawing.Size(58, 47);
            this.btnDeleteAllItems.TabIndex = 0;
            this.btnDeleteAllItems.UseVisualStyleBackColor = false;
            this.btnDeleteAllItems.Click += new System.EventHandler(this.btnDeleteAllItems_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "deleteAll.png");
            this.imageList1.Images.SetKeyName(1, "deleteItem.png");
            // 
            // btnDeleteCurrentItem
            // 
            this.btnDeleteCurrentItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCurrentItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCurrentItem.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDeleteCurrentItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteCurrentItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeleteCurrentItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCurrentItem.ImageKey = "deleteItem.png";
            this.btnDeleteCurrentItem.ImageList = this.imageList1;
            this.btnDeleteCurrentItem.Location = new System.Drawing.Point(235, 78);
            this.btnDeleteCurrentItem.Name = "btnDeleteCurrentItem";
            this.btnDeleteCurrentItem.Size = new System.Drawing.Size(58, 47);
            this.btnDeleteCurrentItem.TabIndex = 0;
            this.btnDeleteCurrentItem.UseVisualStyleBackColor = false;
            this.btnDeleteCurrentItem.Click += new System.EventHandler(this.btnDeleteCurrentItem_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.FlatAppearance.CheckedBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(12, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(281, 32);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 582);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(612, 563);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.Text = "Ready...";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 582);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ListBox lstFileNames;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRevision;
        private System.Windows.Forms.TextBox txtIssuedBy;
        private System.Windows.Forms.TextBox txtMeterSpecs;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnComponentsGenerator;
        private System.Windows.Forms.Button btnDeleteAllItems;
        private System.Windows.Forms.Button btnDeleteCurrentItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

