using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.RandomNumberGeneratorWebControls
{
    public partial class RandomNumberGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int from = int.Parse(this.from.Text);
                int to = int.Parse(this.to.Text);

                if (from >= to)
                {
                    throw new ArgumentException("'From' must have lower value than 'to'");
                }

                double randomNumberInRange = random.Next(from, to + 1);

                this.randomNumber.Text = randomNumberInRange.ToString();
            }
            catch (Exception ex)
            {
                this.randomNumber.Text = ex.Message;
            }
        }
    }
}