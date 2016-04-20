using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOM_Master.PL
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrHide_Tick(object sender, EventArgs e)
        {
            tmrHide.Enabled = false;
            this.Hide();
            new frmMain().ShowDialog();
            this.Close();
        }
    }
}
