<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlEscaping.aspx.cs" Inherits="_03.HtmlEscaping.HtmlEscaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="textBoxOriginal" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="buttonEscapeHtml" runat="server" Text="Escape text" OnClick="buttonEscapeHtml_Click" />
        <hr />
        <asp:Label ID="labelEscapedText" runat="server" Mode="Encode"></asp:Label>
        <asp:TextBox ID="textBoxEscaped" runat="server" Mode="Encode"></asp:TextBox>
    </div>
    </form>
</body>
</html>
