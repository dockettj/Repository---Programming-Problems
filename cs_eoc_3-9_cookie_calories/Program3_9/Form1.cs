using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program3_9
{
    public partial class frmCookieCalories : Form
    {
        public frmCookieCalories()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double cookies; //To hold cookies eaten
            double calories;
            calories = 75;
            double caloriesconsumed;
            cookies = double.Parse(txtCookiesAte.Text);
            caloriesconsumed = cookies * calories;
            lblOutput.Text = caloriesconsumed.ToString();
            
            //What happens when the user clicks on the "Calculate" button?
            //Your output should read something like "Total calories consumed is (Number)."
        }
    }
}
