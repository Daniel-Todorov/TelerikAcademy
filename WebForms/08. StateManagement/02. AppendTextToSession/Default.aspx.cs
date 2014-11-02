using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.AppendTextToSession
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAddText_Click(object sender, EventArgs e)
        {
            string textToAdd = this.TextBoxToAdd.Text;

            if (this.Session.Contents["result"] == null)
            {
                this.Session.Contents["result"] = new List<string>() {textToAdd};

                this.TextBoxToAdd.Text = string.Empty;
                this.LabelResult.Text = textToAdd;

                return;
            }

            var result = (List<string>) this.Session.Contents["result"];
            result.Add(textToAdd);

            this.Session.Contents["result"] = result;
            this.TextBoxToAdd.Text = string.Empty;
            this.LabelResult.Text = string.Join("; ", result.ToArray());
        }
    }
}