<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01.NorthwindEmployeesAndOrders.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" ID="ScriptManager"></asp:ScriptManager>

        <asp:UpdatePanel runat="server" ID="UpdatePannelEmployees2">
            <ContentTemplate>
                <asp:GridView runat="server" ID="GridViewEmployees2"
                    AutoGenerateColumns="False"
                    DataKeyNames="EmployeeID"
                    DataSourceID="SqlDataSourceEmployees" OnSelectedIndexChanged="GridViewEmployees2_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True"></asp:CommandField>
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName"></asp:BoundField>
                        <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName"></asp:BoundField>
                        <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title"></asp:BoundField>
                        <asp:BoundField DataField="City" HeaderText="City" SortExpression="City"></asp:BoundField>
                        <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country"></asp:BoundField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource runat="server" ID="SqlDataSourceEmployees" ConnectionString='<%$ ConnectionStrings:NorthwindContext %>' SelectCommand="SELECT [EmployeeID], [LastName], [FirstName], [Title], [City], [Country] FROM [Employees]"></asp:SqlDataSource>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:UpdatePanel runat="server" ID="UpdatePanelOrders"
            UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="GridViewEmployees2" EventName="SelectedIndexChanged" />
            </Triggers>
            <ContentTemplate>
                <asp:GridView runat="server" ID="GridViewOrders2" AutoGenerateColumns="False" DataKeyNames="OrderID">
                    <Columns>
                        <asp:BoundField DataField="OrderID" HeaderText="ID" ReadOnly="True" InsertVisible="False" SortExpression="OrderID"></asp:BoundField>
                        <asp:BoundField DataField="OrderDate" HeaderText="Order Date" SortExpression="OrderDate"></asp:BoundField>
                        <asp:BoundField DataField="Freight" HeaderText="Freight" SortExpression="Freight"></asp:BoundField>
                        <asp:BoundField DataField="ShipAddress" HeaderText="Ship Address" SortExpression="ShipAddress"></asp:BoundField>
                        <asp:BoundField DataField="ShipCountry" HeaderText="Ship Country" SortExpression="ShipCountry"></asp:BoundField>
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource runat="server" ID="SqlDataSourceOrders" ConnectionString='<%$ ConnectionStrings:NorthwindContext %>' SelectCommand="SELECT [OrderID], [OrderDate], [Freight], [ShipAddress], [ShipCountry] FROM [Orders] WHERE ([EmployeeID] = @EmployeeID)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridViewEmployees2" PropertyName="SelectedValue" DefaultValue="0" Name="EmployeeID" Type="Int32"></asp:ControlParameter>
                    </SelectParameters>
                </asp:SqlDataSource>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:UpdateProgress runat="server" ID="UpdateProgress" AssociatedUpdatePanelID="UpdatePannelEmployees2">
            <ProgressTemplate>
                <img src="Resources/progress.jpg" />
            </ProgressTemplate>
        </asp:UpdateProgress>
    </form>
</body>
</html>
