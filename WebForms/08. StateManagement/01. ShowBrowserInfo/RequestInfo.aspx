<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestInfo.aspx.cs" Inherits="_01.ShowBrowserInfo.BrowserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h1>Request Info</h1>
        </header>
        <section>
            <h2>Browser Type</h2>
            <p runat="server" id="BrowserType"></p>
        </section>
        <section>
            <h2>User IP</h2>
            <p runat="server" id="UserIp"></p>
        </section>
    </form>
</body>
</html>
