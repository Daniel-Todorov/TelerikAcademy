using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.SampleHelloApp
{
    public partial class HelloPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.labelHelloFromCodeBehind.Text = "Hello, ASP.NET! (from code behind)";
            this.labelCurrentAssembleLocation.Text = "The current assemble is located at " + Assembly.GetExecutingAssembly().Location;
        }
    }
}