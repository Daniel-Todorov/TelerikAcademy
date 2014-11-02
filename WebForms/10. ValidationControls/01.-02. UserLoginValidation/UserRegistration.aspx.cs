using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01._02.UserLoginValidation
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidatorAccept_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = this.CheckBoxAccept.Checked;
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.Page.Validate();

            if (Page.IsValid)
            {
                this.LabelValidatonResult.Text = "All info is valid. Good job, pal!";
            }
        }
    }
}