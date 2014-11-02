using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.ShowBrowserInfo
{
    public partial class BrowserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var browserType = this.Request.Browser.Type;
            var userIp = this.Request.UserHostAddress;

            this.BrowserType.InnerText = browserType;
            this.UserIp.InnerText = userIp.ToString();
        }
    }
}