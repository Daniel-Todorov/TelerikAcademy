<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="_01._02.UserLoginValidation.UserRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
</head>
<body>
    <h1>Registration</h1>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Logon Info</legend>
            Username:
            <asp:TextBox runat="server" ID="TextBoxUsername"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server"
                ErrorMessage="Username is required."
                Text="* Username is required."
                ForeColor="Red"
                ControlToValidate="TextBoxUsername"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <br />
            Password:
            <asp:TextBox runat="server" ID="TextBoxPassword"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server"
                ErrorMessage="Password is required."
                Text="* Password is required."
                ForeColor="Red"
                ControlToValidate="TextBoxPassword"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <br />
            Repeat Password:
            <asp:TextBox runat="server" ID="TextBoxRepeatedPassword"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorRepeatedPassword" runat="server"
                ErrorMessage="Repeat Password is required."
                Text="* Repeat Password is required."
                ForeColor="Red"
                ControlToValidate="TextBoxRepeatedPassword"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidatorRepeatedPassword" runat="server"
                ErrorMessage="Repeated Password must be same as Password."
                Text="* Repeated Password must be same as Password."
                ForeColor="Red"
                ControlToValidate="TextBoxRepeatedPassword"
                ControlToCompare="TextBoxPassword"
                ValueToCompare="Text"
                Type="String"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:CompareValidator>
            <br />
        </fieldset>
        <fieldset>
            <legend>Personal Info</legend>
            First Name:
            <asp:TextBox runat="server" ID="TextBoxFirstName"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server"
                ErrorMessage="First Name is required."
                Text="* First Name is required."
                ForeColor="Red"
                ControlToValidate="TextBoxFirstName"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <br />
            Last Name:
            <asp:TextBox runat="server" ID="TextBoxLastName"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server"
                ErrorMessage="Last Name is required."
                Text="* Last Name is required."
                ForeColor="Red"
                ControlToValidate="TextBoxLastName"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <br />
            Age:
            <asp:TextBox runat="server" ID="TextBoxAge"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge" runat="server"
                ErrorMessage="Age is required."
                Text="* Age is required."
                ForeColor="Red"
                ControlToValidate="TextBoxAge"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidator1" runat="server"
                ErrorMessage="Age must be between 18 and 81 years."
                Text="* Age must be between 18 and 81 years."
                ForeColor="Red"
                ControlToValidate="TextBoxAge"
                EnableClientScript="true"
                Display="Dynamic"
                MinimumValue="18"
                MaximumValue="81">
            </asp:RangeValidator>
            <br />
            Email:
            <asp:TextBox runat="server" ID="TextBoxEmail"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"
                ErrorMessage="Email is required."
                Text="* Email is required."
                ForeColor="Red"
                ControlToValidate="TextBoxEmail"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ErrorMessage="Valid Email is required."
                Text="* Valid Email is required."
                ForeColor="Red"
                ControlToValidate="TextBoxEmail"
                EnableClientScript="true"
                ValidationExpression="^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$"
                Display="Dynamic">
            </asp:RegularExpressionValidator>
            <br />
        </fieldset>
        <fieldset>
            <legend>Address Info</legend>
            Local Address:
            <asp:TextBox runat="server" ID="TextBoxLocalAddress"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLocalAddress" runat="server"
                ErrorMessage="Local Address is required."
                Text="* Local Address is required."
                ForeColor="Red"
                ControlToValidate="TextBoxLocalAddress"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <br />
            Phone:
            <asp:TextBox runat="server" ID="TextBoxPhone"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" runat="server"
                ErrorMessage="Phone is required."
                Text="* Phone is required."
                ForeColor="Red"
                ControlToValidate="TextBoxPhone"
                EnableClientScript="true"
                Display="Dynamic">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server"
                ErrorMessage="The phone must be in format xxxx-xx-xx-xx."
                Text="* The phone must be in format xxxx xx xx xx."
                ForeColor="Red"
                ControlToValidate="TextBoxPhone"
                EnableClientScript="true"
                ValidationExpression="\d{4}\s\d{2}\s\d{2}\s\d{2}"
                Display="Dynamic">
            </asp:RegularExpressionValidator>
            <br />
            <asp:CheckBox runat="server" ID="CheckBoxAccept" Text="I Accept" />
            <asp:CustomValidator ID="CustomValidatorAccept" runat="server"
                ErrorMessage="Accept is required."
                Text="* Accept is required."
                ForeColor="Red"
                EnableClientScript="true"
                OnServerValidate="CustomValidatorAccept_ServerValidate"
                ClientValidationFunction="CustomValidatorAccept_ServerValidate">
            </asp:CustomValidator>
        </fieldset>
        <asp:Button runat="server" ID="ButtonRegister" Text="Register" OnClick="ButtonRegister_Click" />
        <hr />
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
        <hr />
        <asp:Label runat="server" ID="LabelValidatonResult"></asp:Label>
    </form>
</body>
</html>
