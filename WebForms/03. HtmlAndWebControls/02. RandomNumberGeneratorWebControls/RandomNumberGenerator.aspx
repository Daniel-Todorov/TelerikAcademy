<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumberGenerator.aspx.cs" Inherits="_02.RandomNumberGeneratorWebControls.RandomNumberGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="labelFrom" runat="server">From: </asp:Label>
        <asp:TextBox ID="from" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="labelTo" runat="server">To: </asp:Label>
        <asp:TextBox ID="to" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="submit" OnClick="submit_Click" Text="Generate random number" runat="server" />
        <br />
        <asp:Label ID="randomNumber" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
