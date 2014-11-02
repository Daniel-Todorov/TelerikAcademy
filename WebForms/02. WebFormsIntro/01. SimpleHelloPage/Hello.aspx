<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hello.aspx.cs" Inherits="_01.SimpleHelloPage.Hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span>Name: </span>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="buttonSayHello" runat="server" Text="Say Hello" OnClick="buttonSayHello_Click" />
        <br />
        <asp:Label ID="labelSayHello" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
