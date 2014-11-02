<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostbackWihtoutViewStateDemo.aspx.cs" Inherits="_04.PostBackWithoutViewState.PostbackWihtoutViewStateDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PostBack without ViewState</title>
</head>
<body>
    <form id="form1" runat="server">
        Enter some sample text and remove focus from the input box to trigger AutoPostBack and view the result: 
    <asp:TextBox runat="server" ID="TextBoxSample" AutoPostBack="true"></asp:TextBox>
    </form>
    <script>
        //Apperantly if we remove the view state an error will occure.
        var viewStateElement = document.getElementById('__VIEWSTATE');
        viewStateElement.parentNode.removeChild(viewStateElement);
    </script>
</body>
</html>
