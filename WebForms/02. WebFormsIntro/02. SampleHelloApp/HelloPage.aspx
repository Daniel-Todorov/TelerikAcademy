<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloPage.aspx.cs" Inherits="_02.SampleHelloApp.HelloPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>Hello, ASP.NET! (from aspx code)</label>
        <br />
        <asp:Label ID="labelHelloFromCodeBehind" runat="server"></asp:Label>
        <br />
        <asp:Label ID="labelCurrentAssembleLocation" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
