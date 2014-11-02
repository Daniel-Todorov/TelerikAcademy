<%@ Page Title="Articles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="NewsSite.Articles" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <%--DOTO: Remove title as in the given example--%>
    <h2><%: Title %></h2>

    <asp:ListView runat="server" ID="ListViewArticles"
        InsertItemPosition="LastItem"
        ItemType="NewsSite.Models.Article"
        DataKeyNames="Id"
        SelectMethod="ListViewArticles_GetData"
        UpdateMethod="ListViewArticles_UpdateItem"
        DeleteMethod="ListViewArticles_DeleteItem"
        InsertMethod="ListViewArticles_InsertItem">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton runat="server" ID="ButtonSortArticleTitles" CssClass="btn btn-default col-md-2"
                    CommandName="Sort"
                    CommandArgument="Title"
                    Text="Sort by Title" />
                <asp:LinkButton runat="server" ID="ButtonSortArticleDates" CssClass="btn btn-default col-md-2"
                    CommandName="Sort"
                    CommandArgument="DateCreated"
                    Text="Sort by Date" />
                <asp:LinkButton runat="server" ID="ButtonSortArticleCategories" 
                    CssClass="btn btn-default col-md-2" 
                    CommandName="Sort"
                    CommandArgument="Category.Name"
                    Text="Sort by Category" />
                <%--<asp:LinkButton runat="server" ID="ButtonSortArticleLikes" CssClass="btn btn-default col-md-2"
                    CommandName="Sort"
                    CommandArgument="Likes"
                    Text="Sort by Likes" />--%>
            </div>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>

            <%--            <asp:Panel runat="server" ID="PanelInsertNewArticle" Visible="true">
                <div class="row">
                    <h3>Title:
                        <asp:TextBox Text='<%# Item.Title %>' runat="server" ID="TextBoxInsertTitle"
                            ValidationGroup="inserts" />
                        <br />
                        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidatorArticleTitleInsert"
                            ControlToValidate="TextBoxInsertTitle"
                            ErrorMessage="Title is required!"
                            EnableClientScript="false"
                            ForeColor="DarkRed"
                            ValidationGroup="inserts">Title is required!</asp:RequiredFieldValidator>
                    </h3>
                    <p>
                        <asp:DropDownList runat="server" ID="DropDownListCategoriesInsert"
                            ItemType="NewsSite.Models.Category"
                            DataTextField="Name"
                            DataValueField="Id"
                            SelectedValue="<%#: BindItem.CategoryId %>"
                            ValidationGroup="inserts"
                            SelectMethod="DropDownListCategoriesEdit_GetData">
                        </asp:DropDownList>
                    </p>
                    <p>
                        Content:
                        <asp:TextBox runat="server" ID="TextBoxInsertContent"
                            Text='<%# Bind("Content") %>'
                            ValidationGroup="inserts"
                            TextMode="MultiLine"
                            Rows="6"
                            Columns="20">
                        </asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidatorInsertContent"
                            ControlToValidate="TextBoxInsertContent"
                            ErrorMessage="Content is required!"
                            EnableClientScript="false"
                            ForeColor="DarkRed"
                            ValidationGroup="edits">Content is required!</asp:RequiredFieldValidator>
                        <div>
                            <asp:LinkButton runat="server" ID="ButtonInsertArticle" CssClass="btn btn-success"
                                Text="Insert"
                                CausesValidation="true"
                                ValidationGroup="inserts" />
                            <asp:LinkButton runat="server" ID="ButtonCancelInsert" CssClass="btn btn-danger"
                                CommandName="Cancel"
                                Text="Cancel"
                                CausesValidation="false" />
                        </div>
                </div>
            </asp:Panel>--%>
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
                <h3><%#: Item.Title %>
                    <asp:LinkButton runat="server" ID="ButtonEditArticle" CssClass="btn btn-info"
                        CommandName="Edit"
                        Text="Edit" />
                    <asp:LinkButton runat="server" ID="ButtonDeleteArticle" CssClass="btn btn-danger"
                        CommandName="Delete"
                        Text="Delete" />
                </h3>
                <p>Category: <%#: Item.Category.Name %></p>
                <p>
                    <%# Item.Content.Length > 300 ? string.Format("{0}...", Item.Content.Substring(0, 300)) : Item.Content %>
                </p>
                <p>Likes count: <%# Item.Likes.Count(l => l.Value > 0) - Item.Likes.Count(l => l.Value < 0) %></p>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: <%#: Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            <div class="row">
                <h3>
                    <div class="col-md-3">
                        <asp:TextBox Text='<%# Bind("Title") %>' runat="server" ID="TextBoxEditTitle"
                            ValidationGroup="edits" />
                        <asp:LinkButton runat="server" ID="ButtonUpdateArticle" CssClass="btn btn-success"
                            CommandName="Update"
                            Text="Save"
                            CausesValidation="true"
                            ValidationGroup="edits" />
                        <asp:LinkButton runat="server" ID="ButtonCancelUpdate" CssClass="btn btn-danger"
                            CommandName="Cancel"
                            Text="Cancel"
                            CausesValidation="false" />
                        <br />
                        <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1"
                            ControlToValidate="TextBoxEditTitle"
                            ErrorMessage="Title is required!"
                            EnableClientScript="false"
                            ForeColor="DarkRed"
                            ValidationGroup="edits">Title is required!</asp:RequiredFieldValidator>
                </h3>
                <br />
                <asp:DropDownList runat="server" ID="DropDownListCategoriesEdit"
                    ItemType="NewsSite.Models.Category"
                    DataTextField="Name"
                    DataValueField="Id"
                    SelectedValue="<%#: BindItem.CategoryId %>"
                    ValidationGroup="edits"
                    SelectMethod="DropDownListCategoriesEdit_GetData">
                </asp:DropDownList>
                <br />
                <asp:TextBox runat="server" ID="TextBoxEditContent" CssClass="col-md-12"
                    Text='<%# Bind("Content") %>'
                    ValidationGroup="edits"
                    TextMode="MultiLine"
                    Rows="7">
                </asp:TextBox>
                <br />
                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2"
                    ControlToValidate="TextBoxEditContent"
                    ErrorMessage="Content is required!"
                    EnableClientScript="false"
                    ForeColor="DarkRed"
                    ValidationGroup="edits">Content is required!</asp:RequiredFieldValidator>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: <%#: Item.DateCreated %></i>
                </div>
            </div>
        </EditItemTemplate>
        <InsertItemTemplate>
            <div class="row">
                <h3>Title:
                        <asp:TextBox Text='<%# BindItem.Title %>' runat="server" ID="TextBoxInsertTitle"
                            ValidationGroup="inserts" />
                    <br />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidatorArticleTitleInsert"
                        ControlToValidate="TextBoxInsertTitle"
                        ErrorMessage="Title is required!"
                        EnableClientScript="false"
                        ForeColor="DarkRed"
                        ValidationGroup="inserts">Title is required!</asp:RequiredFieldValidator>
                </h3>
                <p>
                    Category: 
                    <asp:DropDownList runat="server" ID="DropDownListCategoriesInsert"
                        ItemType="NewsSite.Models.Category"
                        DataTextField="Name"
                        DataValueField="Id"
                        SelectedValue="<%#: BindItem.CategoryId %>"
                        ValidationGroup="inserts"
                        SelectMethod="DropDownListCategoriesEdit_GetData">
                    </asp:DropDownList>
                </p>
                <p>
                    Content:
                        <asp:TextBox runat="server" ID="TextBoxInsertContent"
                            Text='<%# Bind("Content") %>'
                            ValidationGroup="inserts"
                            TextMode="MultiLine"
                            Rows="6"
                            Columns="30">
                        </asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidatorInsertContent"
                        ControlToValidate="TextBoxInsertContent"
                        ErrorMessage="Content is required!"
                        EnableClientScript="false"
                        ForeColor="DarkRed"
                        ValidationGroup="inserts">Content is required!</asp:RequiredFieldValidator>
                    <div>
                        <asp:LinkButton runat="server" ID="ButtonInsertArticle" CssClass="btn btn-success"
                            Text="Insert"
                            CommandName="Insert"
                            CausesValidation="true"
                            ValidationGroup="inserts" />
                        <asp:LinkButton runat="server" ID="ButtonCancelInsert" CssClass="btn btn-danger"
                            CommandName="Cancel"
                            Text="Cancel"
                            CausesValidation="false" />
                    </div>
            </div>
            <hr />
        </InsertItemTemplate>
    </asp:ListView>

    <%--  <div runat="server" id="btnWrapper">
        <asp:LinkButton Text="Insert" ID="LinkButtonInsert" runat="server" OnClick="LinkButtonInsert_Click" />
    </div>

    <asp:UpdatePanel runat="server" ID="UpdatePanelInsertArticle" CssClass="panel">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="LinkButtonInsert" EventName="Click" />
        </Triggers>
        <ContentTemplate>
            <asp:FormView runat="server" ID="FormViewInsertArticle" DefaultMode="Insert" ItemType="NewsSite.Models.Article"
                InsertMethod="FormViewInsertArticle_InsertItem" Visible="false">
                <InsertItemTemplate>
                    <div class="row">
                        <h3>Title:
                        <asp:TextBox Text='<%# Item.Title %>' runat="server" ID="TextBoxInsertTitle"
                            ValidationGroup="inserts" />
                            <br />
                            <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidatorArticleTitleInsert"
                                ControlToValidate="TextBoxInsertTitle"
                                ErrorMessage="Title is required!"
                                EnableClientScript="false"
                                ForeColor="DarkRed"
                                ValidationGroup="inserts">Title is required!</asp:RequiredFieldValidator>
                        </h3>
                        <p>
                            <asp:DropDownList runat="server" ID="DropDownListCategoriesInsert"
                                ItemType="NewsSite.Models.Category"
                                DataTextField="Name"
                                DataValueField="Id"
                                SelectedValue="<%#: BindItem.CategoryId %>"
                                ValidationGroup="inserts"
                                SelectMethod="DropDownListCategoriesEdit_GetData">
                            </asp:DropDownList>
                        </p>
                        <p>
                            Content:
                        <asp:TextBox runat="server" ID="TextBoxInsertContent"
                            Text='<%# Bind("Content") %>'
                            ValidationGroup="inserts"
                            TextMode="MultiLine"
                            Rows="6"
                            Columns="20">
                        </asp:TextBox>
                            <br />
                            <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidatorInsertContent"
                                ControlToValidate="TextBoxInsertContent"
                                ErrorMessage="Content is required!"
                                EnableClientScript="false"
                                ForeColor="DarkRed"
                                ValidationGroup="edits">Content is required!</asp:RequiredFieldValidator>
                            <div>
                                <asp:LinkButton runat="server" ID="ButtonInsertArticle" CssClass="btn btn-success"
                                    Text="Insert"
                                    CausesValidation="true"
                                    ValidationGroup="inserts" />
                                <asp:LinkButton runat="server" ID="ButtonCancelInsert" CssClass="btn btn-danger"
                                    CommandName="Cancel"
                                    Text="Cancel"
                                    CausesValidation="false" />
                            </div>
                    </div>
                    <asp:LinkButton runat="server" ID="LinkButtonCreate" CssClass="link-button" Text="Insert" CommandName="Insert" />
                    <asp:LinkButton runat="server" ID="LinkButtonCancel" CssClass="link-button" Text="Cancel" CommandName="Cancel" />
                </InsertItemTemplate>
            </asp:FormView>
        </ContentTemplate>
    </asp:UpdatePanel>--%>
</asp:Content>
