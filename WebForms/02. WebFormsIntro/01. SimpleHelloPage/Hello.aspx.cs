using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.SimpleHelloPage
{
    public partial class Hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonSayHello_Click(object sender, EventArgs e)
        {
            this.labelSayHello.Text = "Hello, " + this.name.Text + "!";
            this.name.Text = string.Empty;
        }


    }
}