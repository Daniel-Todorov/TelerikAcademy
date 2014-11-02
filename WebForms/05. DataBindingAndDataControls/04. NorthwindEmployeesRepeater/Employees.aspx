<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_04.NorthwindEmployeesRepeater.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Northwind Employees</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="rptEmployees" runat="server" DataSourceID="dsNorthwindEmployees">
            <HeaderTemplate>
                <table border="1">
                    <thead>
                        <tr>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Title</th>
                            <th>Birth Date</th>
                            <th>Hire Date</th>
                            <th>Address</th>
                            <th>City</th>
                            <th>Country</th>
                            <th>Home Phone</th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("FirstName") %></td>
                    <td><%# Eval("LastName") %></td>
                    <td><%# Eval("Title") %></td>
                    <td><%# Eval("BirthDate") %></td>
                    <td><%# Eval("HireDate") %></td>
                    <td><%# Eval("Address") %></td>
                    <td><%# Eval("City") %></td>
                    <td><%# Eval("Country") %></td>
                    <td><%# Eval("HomePhone") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:SqlDataSource 
            runat="server" 
            ID="dsNorthwindEmployees" 
            ConnectionString='<%$ ConnectionStrings:NorthwindConnectionString %>' 
            SelectCommand="SELECT [LastName], [FirstName], [Title], [BirthDate], [HireDate], [Address], [City], [Country], [HomePhone] FROM [Employees]">
        </asp:SqlDataSource>
    </form>
</body>
</html>
