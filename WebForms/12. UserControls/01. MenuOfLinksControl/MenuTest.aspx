<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="MenuTest.aspx.cs"
    Inherits="_01.MenuOfLinksControl.MenuTest" %>

<%@ Register TagPrefix="ucMenuLinks" Src="~/MenuOfLinksUserControl.ascx" TagName="MenuOfLinks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu of Links Test</title>
</head>
<body>
    <form id="form1" runat="server">
        <ucMenuLinks:MenuOfLinks runat="server" ID="MenuOfLinks" />
    </form>
</body>
</html>
