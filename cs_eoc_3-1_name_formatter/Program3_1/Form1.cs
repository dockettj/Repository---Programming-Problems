using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFormat1_Click(object sender, EventArgs e)
        {
            //What happens when the user clicks on the "Format 1" button?
            string tfml;
            //Geez, really long name for a string. 
            //Maybe try TFML?
            //Yep, that works. Combine the names withe a space between them.  Assign the result to the variable created. 
            tfml = txtTitle.Text + " " + txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;

            //Display the fullname variable in the label control. 
            lblNameOutput.Text = tfml;
        }

        private void btnFormat2_Click(object sender, EventArgs e)
        {
            //What happens when the user clicks on the "Format 2" button?
            string fml;
            //So happy I set the precedent to make the name shorter. 
            //The original firstnamemiddlenamelastname string was way too long. 
            //This is more so the person who checks this code if ever sees that I am a real thinker. 
            fml = txtFirstName.Text + " " + txtMiddleName.Text + " " + txtLastName.Text;
            lblNameOutput.Text = fml;
        }

        private void btnFormat3_Click(object sender, EventArgs e)
        {
            //What happens when the user clicks on the "Format 3" button?
            string fl;
            //So happy I shortened the string names. Like on a scale from 1-10 I would say it's a solid 8 on how happy I am.
            fl = txtFirstName.Text + " " + txtLastName.Text;
            lblNameOutput.Text = fl;
        }

        private void btnFormat4_Click(object sender, EventArgs e)
        {
            //What happens when the user clicks on the "Format 4" button?
            //Comas happen. That's what.
            string lfmt;
            lfmt = txtLastName.Text + ", " + txtFirstName.Text + " " + txtMiddleName.Text + ", " + txtTitle.Text;
            lblNameOutput.Text = lfmt;
        }

        private void btnFormat5_Click(object sender, EventArgs e)
        {
            //What happens when the user clicks on the "Format 5" button?
            string lfm;
            lfm = txtLastName.Text + ", " + txtFirstName.Text + " " + txtMiddleName.Text;
            lblNameOutput.Text = lfm;
        }

        private void btnFormat6_Click(object sender, EventArgs e)
        {
            //What happens when the user clicks on the "Format 6" button?
            string lf;
            lf = txtLastName.Text + ", " + txtFirstName.Text;
            lblNameOutput.Text = lf;
        }
        // Love the comments
        // You should probably use string names that make sense to the next person working on your code, though.
        // -0
    }
}
