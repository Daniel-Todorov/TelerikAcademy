<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="CarSearcher.aspx.cs" 
    Inherits="_01.CarSearcher.CarSearcher" 
    ViewStateMode="Enabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Searcher</title>
</head>
<body>
    <form id="form1" runat="server">
        <label for="ddlProducers">Producer: </label>
        <asp:DropDownList ID="ddlProducers" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProducers_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <label for="ddlModels">Model: </label>
        <asp:DropDownList ID="ddlModels" runat="server">
        </asp:DropDownList>
        <br />
        <label for="cblExtras">Extras: </label>
        <asp:CheckBoxList ID="cblExtras" runat="server">
        </asp:CheckBoxList>
        <br />
        <label for="ddlEngineType">Engine type: </label>
        <asp:DropDownList ID="ddlEngineType" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnCommand="btnSubmit_Command"/>
        <hr />
        <asp:Literal ID="ltrSearchResult" runat="server"></asp:Literal>
    </form>
</body>
</html>
