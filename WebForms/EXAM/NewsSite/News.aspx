<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="NewsSite.News" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1><%: Title %></h1>

    <asp:Repeater runat="server" ID="RepeaterMostPopularArticles"
        ItemType="NewsSite.Models.Article"
        SelectMethod="RepeaterMostPopularArticles_GetData">
        <HeaderTemplate>
            <h2>Most popular articles</h2>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row">
                <h3>
                    <asp:HyperLink runat="server" ID="HtmlControlLinkToArticleDetails"
                        NavigateUrl='<%# string.Format("~/ArticleDetails.aspx?id={0}", Item.Id) %>'
                        Text='<%# Item.Title %>' />
                    <small><%#: Item.Category.Name %></small>
                </h3>
                <p>
                    <%# Item.Content.Length > 300 ? string.Format("{0}...", Item.Content.Substring(0, 300)) : Item.Content %>
                </p>
                <p>Likes: <%# Item.Likes.Count(l => l.Value > 0) - Item.Likes.Count(l => l.Value < 0) %></p>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: 10/31/2014 11:02:29 AM</i>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <asp:ListView runat="server" ID="ListViewAllCategories" GroupItemCount="2"
        ItemType="NewsSite.Models.Category"
        SelectMethod="ListViewAllCategories_GetData">
        <LayoutTemplate>
            <h2>All Categories</h2>
            <asp:PlaceHolder runat="server" ID="groupPlaceHolder"></asp:PlaceHolder>
        </LayoutTemplate>
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </GroupTemplate>
        <ItemTemplate>
            <div class="col-md-6">
                <h3><%#: Item.Name %></h3>
                <asp:ListView runat="server" ID="ListViewArticlesInCategory" ItemType="NewsSite.Models.Article" DataSource="<%# Item.Articles.OrderByDescending(a => a.DateCreated).Take(3) %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <a runat="server" href='<%# string.Format("~/ArticleDetails.aspx?id={0}", Item.Id) %>'>
                                <strong><%#: Item.Title %></strong>
                                <i><%#: Item.Author.UserName %></i>
                            </a>
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        No articles
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
