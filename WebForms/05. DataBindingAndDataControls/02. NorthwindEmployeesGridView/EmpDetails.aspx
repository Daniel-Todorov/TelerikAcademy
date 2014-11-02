<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpDetails.aspx.cs" Inherits="_02.NorthwindEmployeesGridView.EmpDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Details</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DetailsView ID="dlvEmployee" runat="server" AutoGenerateRows="False" DataSourceID="dsEmployee">
            <Fields>
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName"></asp:BoundField>
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName"></asp:BoundField>
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title"></asp:BoundField>
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" SortExpression="BirthDate"></asp:BoundField>
                <asp:BoundField DataField="HireDate" HeaderText="HireDate" SortExpression="HireDate"></asp:BoundField>
                <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"></asp:BoundField>
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City"></asp:BoundField>
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country"></asp:BoundField>
                <asp:BoundField DataField="HomePhone" HeaderText="HomePhone" SortExpression="HomePhone"></asp:BoundField>
            </Fields>
        </asp:DetailsView>
        <hr />
        <asp:Button ID="btnBack" runat="server" Text="Back" />
        <asp:SqlDataSource
            runat="server"
            ID="dsEmployee"
            ConnectionString='<%$ ConnectionStrings:NorthwindConnectionString %>'
            SelectCommand="SELECT [LastName], [FirstName], [Title], [BirthDate], [HireDate], [Address], [City], [Country], [HomePhone] FROM [Employees] WHERE ([EmployeeID] = @EmployeeID)">
            <SelectParameters>
                <asp:QueryStringParameter QueryStringField="id" Name="EmployeeID" Type="Int32"></asp:QueryStringParameter>
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
