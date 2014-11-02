<%@ Page Title="Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="NewsSite.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--TODO: Remove title as shown at the sample html--%>
    <h2><%: Title %>.</h2>

    <asp:ListView runat="server" ID="ListViewCategories"
        InsertItemPosition="LastItem"
        ItemType="NewsSite.Models.Category"
        DataKeyNames="Id"
        SelectMethod="ListViewCategories_GetData"
        UpdateMethod="ListViewCategories_UpdateItem"
        InsertMethod="ListViewCategories_InsertItem"
        DeleteMethod="ListViewCategories_DeleteItem">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton runat="server" ID="ButtonSortCategoryNames" CssClass="btn btn-default"
                    CommandName="Sort"
                    CommandArgument="Name"
                    Text="Sort by Name" />
            </div>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            <div class="row">
                <asp:DataPager runat="server" ID="DataPager1" PageSize="5">
                    <Fields>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="False" ShowNextPageButton="False" ShowPreviousPageButton="True" PreviousPageText="Previous"></asp:NextPreviousPagerField>
                        <asp:NumericPagerField></asp:NumericPagerField>
                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="False" ShowNextPageButton="True" ShowPreviousPageButton="False" NextPageText="Next"></asp:NextPreviousPagerField>
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="row">
                <div class="col-md-3"><%# Item.Name %></div>
                <asp:LinkButton runat="server" ID="ButtonEditCategory" CssClass="btn btn-info"
                    CommandName="Edit"
                    Text="Edit" />
                <asp:LinkButton runat="server" ID="ButtonDeleteCategory" CssClass="btn btn-danger"
                    CommandName="Delete"
                    Text="Delete" />
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox Text='<%# Bind("Name") %>' runat="server" ID="TextBoxEditName"
                        ValidationGroup="edits" />
                    <br />
                    <asp:RequiredFieldValidator runat="server" ID="rfvEditCategoryName"
                        ControlToValidate="TextBoxEditName"
                        ErrorMessage="Name is required!"
                        EnableClientScript="false"
                        ForeColor="DarkRed"
                        ValidationGroup="edits">Name is required!</asp:RequiredFieldValidator>
                </div>
                <asp:LinkButton runat="server" ID="ButtonUpdateCategory" CssClass="btn btn-success"
                    CommandName="Update"
                    Text="Save"
                    CausesValidation="true"
                    ValidationGroup="edits" />
                <asp:LinkButton runat="server" ID="ButtonCancelEdit" CssClass="btn btn-danger"
                    CommandName="Cancel"
                    Text="Cancel"
                    CausesValidation="false" />
            </div>
        </EditItemTemplate>
        <InsertItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox Text='<%# Bind("Name") %>' runat="server" ID="TextBoxInsertName"
                        ValidationGroup="inserts" />
                    <br />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidatorInsertName"
                        ControlToValidate="TextBoxInsertName"
                        ErrorMessage="Name is required!"
                        EnableClientScript="false"
                        ForeColor="DarkRed"
                        ValidationGroup="inserts"></asp:RequiredFieldValidator>
                </div>
                <asp:LinkButton runat="server" ID="ButtonInsertCategory" CssClass="btn btn-info"
                    CommandName="Insert"
                    Text="Save"
                    CausesValidation="true"
                    ValidationGroup="inserts" />
                <asp:LinkButton runat="server" ID="ButtonCancelInsert" CssClass="btn btn-danger"
                    CommandName="Cancel"
                    Text="Cancel"
                    CausesValidation="false" />
            </div>
        </InsertItemTemplate>
        <EmptyDataTemplate>
            <div class="row">
                <div class="col-md-3">
                    No categories.
                </div>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</asp:Content>
