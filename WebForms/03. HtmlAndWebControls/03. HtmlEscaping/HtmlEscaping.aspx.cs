using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.HtmlEscaping
{
    public partial class HtmlEscaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonEscapeHtml_Click(object sender, EventArgs e)
        {
            string input = this.textBoxOriginal.Text;
            this.textBoxEscaped.Text = input; //Textbox has build-in excaping
            this.labelEscapedText.Text = Server.HtmlEncode(input);
        }
    }
}