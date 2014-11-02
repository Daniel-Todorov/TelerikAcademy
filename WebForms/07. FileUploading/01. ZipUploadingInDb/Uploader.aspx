<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uploader.aspx.cs" Inherits="_01.ZipUploadingInDb.Uploader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FileUpload runat="server" ID="UploadedFile" />
        <br />
        <hr />
        <asp:Button runat="server" ID="ButtonUploadFile" OnClick="ButtonUploadFile_Click" Text="Upload" />
        <br />
        <hr />
        <br />
        <asp:Label runat="server" ID="LabelResult"></asp:Label>
    </form>
</body>
</html>
