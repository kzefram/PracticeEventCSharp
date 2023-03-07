using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeEvents
{


    /*
     * Karen Bourgeois
     * Introduction to Programming
     * Module 2 Exercise
     * January 27, 2023
     */



    public partial class lblPracticeEvent : Form
    {
        public lblPracticeEvent()
        {
            InitializeComponent();
        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtNameBox.Text;
        }

        private void btnDisplayTitle_Click(object sender, EventArgs e)
        {
            lblOutput.Text = this.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Your output will be displayed here";
            txtNameBox.Text = string.Empty;
        }
    }
}
