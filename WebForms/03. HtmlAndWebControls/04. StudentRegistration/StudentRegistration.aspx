<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="_04.StudentRegistration.StudentRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="firstName">First name: </label>
        <input id="firstName" runat="server" type="text" />
        <br />
        <label for="lastName">Last name: </label>
        <input id="lastName" runat="server" type="text" />
        <br />
        <label for="facultyNumber">Faculty number: </label>
        <input id="facultyNumber" runat="server" type="text" />
        <br />
        <label for="university">University: </label>
        <asp:DropDownList ID="university" runat="server">
            <asp:ListItem Selected="True" Value="TU-Sofia">TU-Sofia</asp:ListItem>
            <asp:ListItem Value="MU-Sofia">MU-Sofia</asp:ListItem>
            <asp:ListItem Value="UNSS">UNSS</asp:ListItem>
        </asp:DropDownList>
        <br />
        <label for="specialty">Specialty: </label>
        <asp:DropDownList ID="specialty" runat="server">
            <asp:ListItem Selected="True" Value="Medicine">Medicine</asp:ListItem>
            <asp:ListItem Value="Law">Law</asp:ListItem>
            <asp:ListItem Value="Europeistics">Europeistics</asp:ListItem>
            <asp:ListItem Value="Architecture">Architecture</asp:ListItem>
            <asp:ListItem Value="Psycology">Psycology</asp:ListItem>
        </asp:DropDownList>
        <br />
        <label for="courses">Courses: </label>
        <asp:ListBox ID="courses" runat="server" SelectionMode="Multiple">
            <asp:ListItem Value="Topographic Anatomy">Topographic Anatomy</asp:ListItem>
            <asp:ListItem Value="Emergency Medicine">Emergency Medicine</asp:ListItem>
            <asp:ListItem Value="Administrative Law">Administrative Law</asp:ListItem>
            <asp:ListItem Value="Criminalistics">Criminalistics</asp:ListItem>
            <asp:ListItem Value="Football">Football</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" />
        <hr />
    </div>
    <div id="result" runat="server">
        
    </div>
    </form>
</body>
</html>
