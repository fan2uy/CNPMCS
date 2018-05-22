using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmFine_Load(object sender, EventArgs e)
        {
            txtFine.Value = Properties.Settings.Default.dailyFine;
            txtDaysToIssue.Value= Properties.Settings.Default.daysToIssue;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dailyFine =Convert.ToInt32(txtFine.Value);
            Properties.Settings.Default.daysToIssue =Convert.ToInt32(txtDaysToIssue.Value);
            Properties.Settings.Default.Save();
            this.Close();    
        }
    }
}
