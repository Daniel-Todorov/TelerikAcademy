using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.LoginState
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Request.Cookies["isLogged"] != null && this.Request.Cookies["isLogged"].Value == "true")
            {
                this.Response.Redirect("~/Inner.aspx", true);
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            this.Response.Cookies.Add(new HttpCookie("isLogged", "true") { Expires = DateTime.Now.AddMinutes(1) });

            this.Response.Redirect("~/Inner.aspx", true);
        }
    }
}