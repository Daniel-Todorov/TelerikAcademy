<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_05.NorthwindEmployeesListView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListView ID="lsvEmployees" runat="server" DataSourceID="dsNorthwindEmployees">
            <LayoutTemplate>
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
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                    </tbody>
                </table>
            </LayoutTemplate>
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
        </asp:ListView>
        <asp:DataPager ID="dpEmployees" runat="server" PagedControlID="lsvEmployees" PageSize="3">
            <Fields>
                <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowFirstPageButton="false" ShowLastPageButton="false" ShowNextPageButton="false" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowFirstPageButton="false" ShowLastPageButton="false" ShowNextPageButton="true" />
            </Fields>
        </asp:DataPager>
        <asp:SqlDataSource
            runat="server"
            ID="dsNorthwindEmployees"
            ConnectionString='<%$ ConnectionStrings:NorthwindConnectionString %>'
            SelectCommand="SELECT [LastName], [FirstName], [Title], [BirthDate], [HireDate], [Address], [City], [Country], [HomePhone] FROM [Employees]"></asp:SqlDataSource>
    </form>
</body>
</html>
