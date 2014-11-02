<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_03.NorthwindEmployeesFormView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Northwind Employees</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FormView ID="fmvEmployees" runat="server" DataSourceID="dsNorthwindEmployees" AllowPaging="true">
            <ItemTemplate>
                First Name:
                <asp:Label Text='<%# Bind("FirstName") %>' runat="server" ID="FirstNameLabel" /><br />
                Last Name:
                <asp:Label Text='<%# Bind("LastName") %>' runat="server" ID="LastNameLabel" /><br />
                Title:
                <asp:Label Text='<%# Bind("Title") %>' runat="server" ID="TitleLabel" /><br />
                Birth Date:
                <asp:Label Text='<%# Bind("BirthDate") %>' runat="server" ID="BirthDateLabel" /><br />
                Hire Date:
                <asp:Label Text='<%# Bind("HireDate") %>' runat="server" ID="HireDateLabel" /><br />
                Address:
                <asp:Label Text='<%# Bind("Address") %>' runat="server" ID="AddressLabel" /><br />
                City:
                <asp:Label Text='<%# Bind("City") %>' runat="server" ID="CityLabel" /><br />
                Country:
                <asp:Label Text='<%# Bind("Country") %>' runat="server" ID="CountryLabel" /><br />
                Home Phone:
                <asp:Label Text='<%# Bind("HomePhone") %>' runat="server" ID="HomePhoneLabel" /><br />
            </ItemTemplate>
        </asp:FormView>
        <asp:SqlDataSource 
            runat="server" 
            ID="dsNorthwindEmployees" 
            ConnectionString='<%$ ConnectionStrings:NorthwindConnectionString %>' 
            SelectCommand="SELECT [LastName], [FirstName], [Title], [BirthDate], [HireDate], [Address], [City], [Country], [HomePhone] FROM [Employees]">
        </asp:SqlDataSource>
    </form>
</body>
</html>
