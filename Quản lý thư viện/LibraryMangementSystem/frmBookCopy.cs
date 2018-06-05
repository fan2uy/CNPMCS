using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frmBookCopy : Form
    {
        public string returnbn { get; set; } 
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
            returnbn = textBid.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}
