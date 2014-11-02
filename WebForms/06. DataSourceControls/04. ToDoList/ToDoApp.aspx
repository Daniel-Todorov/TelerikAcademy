<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ToDoApp.aspx.cs" Inherits="_04.ToDoList.ToDoApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ListView runat="server" ID="ListViewCategories"
            ItemType="_04.ToDoList.Category"
            InsertItemPosition="LastItem"
            DataKeyNames="Id"
            SelectMethod="ListViewCategories_GetData"
            DeleteMethod="ListViewCategories_DeleteItem"
            InsertMethod="ListViewCategories_InsertItem"
            UpdateMethod="ListViewCategories_UpdateItem">
            <LayoutTemplate>
                <hr />
                <h2>Categories:</h2>
                <ul>
                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                </ul>
                <hr />
            </LayoutTemplate>
            <ItemTemplate>
                <li>
                    <%#: Item.Name %>
                    <asp:Button runat="server" ID="ButtonEditCategory"
                        CommandName="Edit" Text="Edit" />
                    <asp:Button runat="server" ID="ButtonDeleteCategory"
                        CommandName="Delete" Text="Remove" />
                </li>
            </ItemTemplate>
            <EditItemTemplate>
                <li>
                    <asp:TextBox runat="server" ID="TextBoxEditCategory" Text="<%# BindItem.Name %>"></asp:TextBox>
                    <asp:Button ID="ButtonUpdate" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="ButtonCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                </li>
            </EditItemTemplate>
            <InsertItemTemplate>
                <hr />
                <asp:TextBox runat="server" ID="TextBoxCategoryName" Text="<%# BindItem.Name %>"></asp:TextBox>
                <asp:Button ID="ButtonInsertCategory" runat="server" CommandName="Insert" Text="Add Category" />
                <asp:Button ID="ButtonCancelCategory" runat="server" CommandName="Cancel" Text="Clear" />
            </InsertItemTemplate>
            <EmptyItemTemplate>
                <div>No categories available. Please, add a new one!</div>
            </EmptyItemTemplate>
            <EmptyDataTemplate>
                <h2>Categories:</h2>
                <div>No categories available. Please, add a new one!</div>
            </EmptyDataTemplate>
        </asp:ListView>

        <asp:ListView ID="ListViewToDos" runat="server"
            ItemType="_04.ToDoList.Todo"
            InsertItemPosition="LastItem"
            DataKeyNames="Id"
            SelectMethod="ListViewToDos_GetData"
            InsertMethod="ListViewToDos_InsertItem"
            DeleteMethod="ListViewToDos_DeleteItem"
            UpdateMethod="ListViewToDos_UpdateItem">
            <LayoutTemplate>
                <hr />
                <h2>ToDos</h2>
                <ul>
                    <asp:PlaceHolder runat="server" ID="ItemPlaceHolder"></asp:PlaceHolder>
                </ul>
            </LayoutTemplate>
            <ItemTemplate>
                <li>Title: <%#: Item.Title %><br />
                    Body: <%# Item.Body %><br />
                    Date of Last Change: <%#: Item.DateOfLastChange.ToLongDateString() %><br />
                    Category: <%#: Item.Category.Name %><br />
                    <asp:Button runat="server" ID="ButtonEditToDo"
                        CommandName="Edit" Text="Edit" />
                    <asp:Button runat="server" ID="ButtonDeleteToDo"
                        CommandName="Delete" Text="Remove" />
                </li>
            </ItemTemplate>
            <ItemSeparatorTemplate>
                <hr />
            </ItemSeparatorTemplate>
            <EditItemTemplate>
                Title:
                <asp:TextBox runat="server" ID="TExtBoxEditToDoTitle" Text="<%# BindItem.Title %>"></asp:TextBox>
                <br />
                Body:
                <asp:TextBox runat="server" ID="TextBoxEditToDoBody" Text="<%# BindItem.Body %>" Rows="10" Columns="30"></asp:TextBox>
                <br />
                <asp:DropDownList runat="server" ID="DropDownListEditToDoCategory"
                    SelectMethod="SelectCategoriesForDropDownInsert"
                    SelectedValue="<%# BindItem.CategoryId %>"
                    DataTextField="Name"
                    DataValueField="Id"
                    AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <asp:Button runat="server" CommandName="Update" Text="Update" ID="UpdateButton" />
                <asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Title:
                <asp:TextBox runat="server" ID="TextBoxInsertToDoTitle" Text="<%# BindItem.Title %>"></asp:TextBox>
                <br />
                Body:
                <asp:TextBox runat="server" ID="TextBoxInsertToDoBody" Text="<%# BindItem.Body %>"></asp:TextBox>
                <br />
                Category:
                <asp:DropDownList runat="server" ID="DropDownListInsertToDoCategory"
                    SelectMethod="SelectCategoriesForDropDownInsert"
                    SelectedValue="<%# BindItem.CategoryId %>"
                    DataTextField="Name"
                    DataValueField="Id" AutoPostBack="True">
                </asp:DropDownList>
                <br />
                <asp:Button ID="ButtonInsertToDo" runat="server" CommandName="Insert" Text="Add ToDo" />
                <asp:Button ID="ButtonCancelToDo" runat="server" CommandName="Cancel" Text="Clear" />
            </InsertItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
