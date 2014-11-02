<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumberGenerator.aspx.cs" Inherits="_01.RandomNumberGenerator.RandomNumberGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label for="from">From: </label>
        <input id="from" type="number" runat="server" />
        <br />
        <label for="to">To: </label>
        <input id="to" type="number" runat="server" />
        <br />
        <input id="submit" type="submit" value="Generate random number" runat="server" onserverclick="submit_ServerClick" />
        <br />
        <span id="randomNumber" runat="server"></span>
    </div>
    </form>
</body>
</html>
