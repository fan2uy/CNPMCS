using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SplashForm : Form
    {
       public static bool focusclose = false;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Leave(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void SplashForm_Deactivate(object sender, EventArgs e)
        {
            if(focusclose==true)
            this.Close();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
        
            label1.Text = "Library Management System\nVersion 1.0\nDeveloped By : Arun Kumar.C\nEmail : arunakc421@gmail.com";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // this.Close();



               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://librarymanagementsystemdotnet.sourceforge.net/"); 
        }
    }
}