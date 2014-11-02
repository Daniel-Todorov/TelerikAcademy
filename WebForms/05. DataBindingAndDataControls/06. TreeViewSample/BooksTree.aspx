<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooksTree.aspx.cs" Inherits="_06.TreeViewSample.BooksTree" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TreeView ID="trvBooks" runat="server" DataSourceID="dsBooksXml" OnSelectedNodeChanged="trvBooks_SelectedNodeChanged">
        </asp:TreeView>
        <asp:XmlDataSource runat="server" ID="dsBooksXml" DataFile="~/Resources/books.xml"></asp:XmlDataSource>
        <asp:TreeView ID="trvBookDetails" runat="server">
            <Nodes>
            </Nodes>
        </asp:TreeView>
    </form>
</body>
</html>
