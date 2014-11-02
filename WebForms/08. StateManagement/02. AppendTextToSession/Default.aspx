<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02.AppendTextToSession.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Text Appender</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox runat="server" ID="TextBoxToAdd"></asp:TextBox>
        <asp:Button runat="server" ID="ButtonAddText" Text="Add Text" OnClick="ButtonAddText_Click" />
        <br />
        <asp:Label runat="server" ID="LabelResult"></asp:Label>
    </form>
</body>
</html>
