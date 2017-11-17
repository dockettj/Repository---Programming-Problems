using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program3_13
{
    public partial class frmPropertyTax : Form
    {
        public frmPropertyTax()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //What happens when the user clicks the "Calculate" button?
            //Your output should read something like "Sales tax is (number)."
            double homeValue;
            //To hold home value. 
            double propertyTax;
            //To hold the property tax value.
            propertyTax = (100 * .64);
            double salesTax;
            //To hold the said value.
            homeValue = double.Parse(txtPropertyValue.Text);
            salesTax = homeValue / propertyTax;
            lblOutput.Text = salesTax.ToString();
// In the future, set up a constant for your .64. Other than that, looks good. 
-0
        }
    }
}
