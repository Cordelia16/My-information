//**************************************************************** 
// Programmer: Somaly Ngov
// Date: 27/02/2020
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64-bit 
// Purpose: This program will show you how to display some information about yourself
//****************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caity
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuburb_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Ngunnawal";
            //It will shows the suburb's name to the textfield.
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            lbl1.Text = "Caity";
            //It will shows your name to the textfield.
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            lbl1.Text = "CIT237518";
            //It will shows your ID to the textfield.
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
       
        }

        private void lbName_Load(object sender, EventArgs e)
        {

        }
    }
}
