<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_02.NorthwindEmployeesGridView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Northwind Employees</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="grvEmployees" runat="server" DataSourceID="dsNorthwind" AutoGenerateColumns="False" DataKeyNames="EmployeeID">
            <Columns>
                <asp:HyperLinkField HeaderText="Employee's name" DataTextField="FullName" DataNavigateUrlFields="Url"></asp:HyperLinkField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource
            runat="server"
            ID="dsNorthwind"
            ConnectionString='<%$ ConnectionStrings:NorthwindConnectionString %>'
            SelectCommand="SELECT [EmployeeId], 'EmpDetails.aspx?id=' + CAST([EmployeeID] AS varchar) AS [Url], [FirstName] + ' ' + [LastName] AS [FullName] FROM [Employees]"></asp:SqlDataSource>
    </form>
</body>
</html>
