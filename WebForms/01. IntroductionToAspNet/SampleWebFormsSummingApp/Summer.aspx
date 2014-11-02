<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summer.aspx.cs" Inherits="SampleWebFormsSummingApp.Summer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="labelFirstNumber" runat="server"></asp:Label>
        <asp:TextBox ID="firstNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="labelSecondNumber" runat="server"></asp:Label>
        <asp:TextBox ID="secondNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="buttonAdd" runat="server" OnClick="buttonAdd_Click" />
        <hr />
        <asp:Label ID="labelSum" runat="server"></asp:Label>
        <asp:Label ID="Sum" runat="server"></asp:Label>
        <hr />
        <asp:Label ID="labelErrorMessage" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
