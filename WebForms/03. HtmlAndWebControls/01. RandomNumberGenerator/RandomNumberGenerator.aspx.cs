using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.RandomNumberGenerator
{
    public partial class RandomNumberGenerator : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_ServerClick(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                int from = int.Parse(this.from.Value);
                int to = int.Parse(this.to.Value);

                if (from >= to)
                {
                    throw new ArgumentException("'From' must have lower value than 'to'");
                }

                double randomNumberInRange = random.Next(from, to + 1);

                this.randomNumber.InnerText = randomNumberInRange.ToString();
            }
            catch (Exception ex)
            {
                this.randomNumber.InnerText = ex.Message;
            }
        }
    }
}