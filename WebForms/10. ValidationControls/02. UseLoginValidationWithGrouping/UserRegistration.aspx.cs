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
            this.LabelValidatonResult.Text = string.Empty;
            this.LabelValidatonResult.ForeColor = System.Drawing.Color.Red;

            this.Page.Validate("LogonInfo");
            if (!IsGroupValid("LogonInfo"))
            {
                this.LabelValidatonResult.Text += "Logon Info is not valid.<br>";
            }

            this.Page.Validate("PersonalInfo");
            if (!IsGroupValid("PersonalInfo"))
            {
                this.LabelValidatonResult.Text += "Personal Info is not valid.<br>";
            }

            this.Page.Validate("AddressInfo");
            if (!IsGroupValid("AddressInfo"))
            {
                this.LabelValidatonResult.Text += "Address Info is not valid.<br>";
            }

            this.Page.Validate();
            if (this.Page.IsValid)
            {
                this.LabelValidatonResult.Text = "All info is correct. Good job, pal!";
                this.LabelValidatonResult.ForeColor = System.Drawing.Color.Green;
            }
        }

        private bool IsGroupValid(string sValidationGroup)
        {
            foreach (BaseValidator validator in Page.Validators)
            {
                if (validator.ValidationGroup == sValidationGroup)
                {
                    bool fValid = validator.IsValid;
                    if (fValid)
                    {
                        validator.Validate();
                        fValid = validator.IsValid;
                        validator.IsValid = true;
                    }
                    if (!fValid)
                        return false;
                }

            }
            return true;
        }
    }
}