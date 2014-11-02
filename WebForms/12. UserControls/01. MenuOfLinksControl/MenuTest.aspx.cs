using _01.MenuOfLinksControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.MenuOfLinksControl
{
    public partial class MenuTest : System.Web.UI.Page
    {
        private List<LinkForMenu> links;

        public MenuTest()
        {
            this.links = new List<LinkForMenu>()
            {
                new LinkForMenu()
                {
                     Title = "Google",
                      Url = "https://www.google.bg"
                },
                new LinkForMenu()
                {
                     Title = "Facebook",
                      Url = "https://www.facebook.com"
                },
                new LinkForMenu()
                {
                     Title = "Telerik Academy",
                      Url = "http://telerikacademy.com/"
                }
            };
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.MenuOfLinks.Links = this.links;
            this.MenuOfLinks.FontSize = 30;
            this.MenuOfLinks.TextColor = System.Drawing.Color.Red;
        }
    }
}