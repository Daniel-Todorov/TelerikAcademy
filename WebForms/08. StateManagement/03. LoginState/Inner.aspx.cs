using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.LoginState
{
    public partial class Inner : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Request.Cookies["isLogged"] == null || this.Request.Cookies["isLogged"].Value != "true")
            {
                this.Response.Redirect("~/Login.aspx");
            }
        }
    }
}