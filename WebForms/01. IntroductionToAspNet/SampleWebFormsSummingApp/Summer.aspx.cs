using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsSummingApp
{
    public partial class Summer : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.labelFirstNumber.Text = "First number: ";
            this.labelSecondNumber.Text = "Second number: ";
            this.labelSum.Text = "Total sum: ";
            this.buttonAdd.Text = "Sum";
            this.Sum.Text = string.Empty;
        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            double firstNumberToAdd = 0;
            double secondNumberToAdd = 0;

            this.labelErrorMessage.Text = string.Empty;

            try
            {
                firstNumberToAdd = double.Parse(this.firstNumber.Text);
                secondNumberToAdd = double.Parse(this.secondNumber.Text);
            }
            catch (Exception)
            {
                this.Sum.Text = "Invalid numbers!";
                return;
            }

            double sum = firstNumberToAdd + secondNumberToAdd;
            this.Sum.Text = sum.ToString();
        }
    }
}