using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmBookCopy : Form
    {
        public string returnid { get; set; } 
        public frmBookCopy()
        {
            InitializeComponent();
        }

        private void frmBookCopy_Load(object sender, EventArgs e)
        {
            textBid.Focus();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            returnid = textBid.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}
