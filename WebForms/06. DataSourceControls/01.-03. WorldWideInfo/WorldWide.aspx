<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorldWide.aspx.cs" Inherits="_01._03.WorldWideInfo.WorldWide" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>World Wide</title>
</head>
<body>
    <asp:EntityDataSource runat="server"
        ID="EntityDataSourceContinents"
        EnableDelete="True"
        EnableInsert="True"
        EnableFlattening="False"
        EnableUpdate="True"
        EntitySetName="Continents"
        ConnectionString="name=WorldWideEntities"
        DefaultContainerName="WorldWideEntities">
    </asp:EntityDataSource>
    <asp:EntityDataSource runat="server"
        ID="EntityDataSourceCountries"
        DefaultContainerName="WorldWideEntities"
        ConnectionString="name=WorldWideEntities"
        EnableFlattening="False"
        EnableDelete="True"
        EnableInsert="True"
        EnableUpdate="True"
        EntitySetName="Countries"
        Include="Continent"
        Where="it.continentID=@contId">
        <WhereParameters>
            <asp:ControlParameter Name="contId" Type="Int32" ControlID="ListBoxContinents" />
        </WhereParameters>
    </asp:EntityDataSource>

    <asp:EntityDataSource runat="server"
        ID="EntityDataSourceTowns"
        DefaultContainerName="WorldWideEntities"
        ConnectionString="name=WorldWideEntities"
        EnableFlattening="False"
        EnableDelete="True"
        EnableInsert="True"
        EnableUpdate="True"
        EntitySetName="Towns"
        Include="Country"
        Where="it.countryID=@countId">
        <WhereParameters>
            <asp:ControlParameter Name="countId" Type="Int32" ControlID="GridViewCountries" />
        </WhereParameters>
        <InsertParameters>
            <asp:ControlParameter Name="countryId" Type="Int32" ControlID="GridViewCountries" />
        </InsertParameters>
    </asp:EntityDataSource>


    <form id="form1" runat="server">

        <asp:ListBox runat="server"
            ID="ListBoxContinents"
            DataSourceID="EntityDataSourceContinents"
            AutoPostBack="True"
            DataTextField="name"
            DataValueField="id"
            Rows=" 5"></asp:ListBox>

        <asp:GridView runat="server"
            ID="GridViewCountries"
            AutoGenerateColumns="False"
            DataKeyNames="id"
            DataSourceID="EntityDataSourceCountries"
            AllowPaging="True"
            AllowSorting="True"
            PageSize="3">
            <Columns>
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" ShowSelectButton="True"></asp:CommandField>
                <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name"></asp:BoundField>
                <asp:BoundField DataField="language" HeaderText="Language" SortExpression="language"></asp:BoundField>
                <asp:BoundField DataField="population" HeaderText="Population" SortExpression="population"></asp:BoundField>

            </Columns>
        </asp:GridView>

        <asp:ListView runat="server"
            ID="ListViewTowns" DataSourceID="EntityDataSourceTowns" DataKeyNames="id" InsertItemPosition="LastItem">
            <AlternatingItemTemplate>
                <tr style="background-color: #FFF8DC;">
                    <td>
                        <asp:Button runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" />
                        <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("name") %>' runat="server" ID="nameLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("population") %>' runat="server" ID="populationLabel" /></td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color: #008A8C; color: #FFFFFF;">
                    <td>
                        <asp:Button runat="server" CommandName="Update" Text="Update" ID="UpdateButton" />
                        <asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" />
                    </td>
                    <td>
                        <asp:TextBox Text='<%# Bind("name") %>' runat="server" ID="nameTextBox" /></td>
                    <td>
                        <asp:TextBox Text='<%# Bind("population") %>' runat="server" ID="populationTextBox" /></td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button runat="server" CommandName="Insert" Text="Insert" ID="InsertButton" />
                        <asp:Button runat="server" CommandName="Cancel" Text="Clear" ID="CancelButton" />
                    </td>
                    <td>
                        <asp:TextBox Text='<%# Bind("name") %>' runat="server" ID="nameTextBox" /></td>
                    <td>
                        <asp:TextBox Text='<%# Bind("population") %>' runat="server" ID="populationTextBox" /></td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #DCDCDC; color: #000000;">
                    <td>
                        <asp:Button runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" />
                        <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("name") %>' runat="server" ID="nameLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("population") %>' runat="server" ID="populationLabel" /></td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table runat="server" id="itemPlaceholderContainer" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;" border="1">
                                <tr runat="server" style="background-color: #DCDCDC; color: #000000;">
                                    <th runat="server"></th>
                                    <th runat="server">name</th>
                                    <th runat="server">population</th>
                                </tr>
                                <tr runat="server" id="itemPlaceholder"></tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center; background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000;">
                            <asp:DataPager runat="server" ID="DataPager1">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True"></asp:NextPreviousPagerField>
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #008A8C; font-weight: bold; color: #FFFFFF;">
                    <td>
                        <asp:Button runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" />
                        <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" />
                    </td>
                    <td>
                        <asp:Label Text='<%# Eval("name") %>' runat="server" ID="nameLabel" /></td>
                    <td>
                        <asp:Label Text='<%# Eval("population") %>' runat="server" ID="populationLabel" /></td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
