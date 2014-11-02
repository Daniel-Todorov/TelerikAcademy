using _01.MenuOfLinksControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.MenuOfLinksControl
{
    public partial class MenuOfLinksUserControl : System.Web.UI.UserControl
    {
        public List<LinkForMenu> Links { get; set; }

        public System.Drawing.Color TextColor { get; set; }

        public int FontSize { get; set; }

        public MenuOfLinksUserControl()
        {
            this.Links = new List<LinkForMenu>();
            this.FontSize = 12;
            this.TextColor = System.Drawing.Color.Black;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.DataListMenuOfLinks.ForeColor = this.TextColor;
            this.DataListMenuOfLinks.Font.Size = FontUnit.Point(this.FontSize);

            this.DataListMenuOfLinks.DataSource = this.Links;
            this.DataBind();
        }
    }
}