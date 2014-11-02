<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="_06.SimpleCalculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 380px; width: 379px">
    <form id="form1" runat="server">
        <asp:TextBox ID="result" runat="server" Height="34px" Width="369px"></asp:TextBox>
        <p>
            <asp:Button CommandName="Number" CommandArgument="1" OnCommand="btn_Command" ID="btn1" runat="server" style="margin-left: 28px" Text="1" Width="50px" />
            <asp:Button CommandName="Number" CommandArgument="2" OnCommand="btn_Command" ID="btn2" runat="server" style="margin-left: 27px" Text="2" />
            <asp:Button CommandName="Number" CommandArgument="3" OnCommand="btn_Command" ID="btn3" runat="server" style="margin-left: 33px" Text="3" />
            <asp:Button CommandName="Operation" CommandArgument="Plus" OnCommand="btn_Command" ID="btnPlus" runat="server" style="margin-left: 32px" Text="+" />
        </p>                
        <p>                 
            <asp:Button CommandName="Number" CommandArgument="4" OnCommand="btn_Command" ID="btn4" runat="server" style="margin-left: 30px" Text="4" />
            <asp:Button CommandName="Number" CommandArgument="5" OnCommand="btn_Command" ID="btn5" runat="server" style="margin-left: 27px" Text="5" />
            <asp:Button CommandName="Number" CommandArgument="6" OnCommand="btn_Command" ID="btn6" runat="server" style="margin-left: 27px" Text="6" />
            <asp:Button CommandName="Operation" CommandArgument="Minus" OnCommand="btn_Command" ID="btnMinus" runat="server" style="margin-left: 28px" Text="-" />
            </p>            
        <p>                 
            <asp:Button CommandName="Number" CommandArgument="7" OnCommand="btn_Command" ID="btn7" runat="server" style="margin-left: 33px" Text="7" />
            <asp:Button CommandName="Number" CommandArgument="8" OnCommand="btn_Command" ID="btn8" runat="server" style="margin-left: 26px" Text="8" />
            <asp:Button CommandName="Number" CommandArgument="9" OnCommand="btn_Command" ID="btn9" runat="server" style="margin-left: 25px" Text="9" Width="53px" />
            <asp:Button CommandName="Operation" CommandArgument="Multiply" OnCommand="btn_Command" ID="btnMultiply" runat="server" style="margin-left: 24px" Text="x" />
        </p>                
        <p>                 
            <asp:Button CommandName="Operation" CommandArgument="Clear" OnCommand="btn_Command" ID="btnClear" runat="server" style="margin-left: 33px" Text="Clear" />
            <asp:Button CommandName="Number" CommandArgument="0" OnCommand="btn_Command" ID="btn0" runat="server" style="margin-left: 28px" Text="0" />
            <asp:Button CommandName="Operation" CommandArgument="Divide" OnCommand="btn_Command" ID="btnDivide" runat="server" style="margin-left: 26px" Text="/" Width="55px" />
            <asp:Button CommandName="Operation" CommandArgument="Sqrt" OnCommand="btn_Command" ID="btnSqrt" runat="server" style="margin-left: 25px" Text="Sqrt" />
        </p>
        <p>
            <asp:Button CommandName="Operation" CommandArgument="Equal" OnCommand="btn_Command" ID="btnEqual" runat="server" style="margin-left: 19px" Text="=" Width="339px" />
        </p>
        <div id="argumentKeeper" runat="server" hidden="hidden">

        </div>
        <div id="operationKeeper" runat="server" hidden="hidden">

        </div>
    </form>
</body>
</html>
