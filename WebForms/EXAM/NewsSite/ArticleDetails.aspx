<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleDetails.aspx.cs" Inherits="NewsSite.ArticleDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView runat="server" ID="ListViewArticleDetails"
        ItemType="NewsSite.Models.Article"
        SelectMethod="ListViewArticleDetails_GetData">
        <ItemTemplate>
            <table cellspacing="0" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <td colspan="2">
                            <div runat="server" visible="<%# Context.User.Identity.IsAuthenticated %>">
                                <div class="like-control col-md-1">
                                    <div>Likes</div>
                                    <div>
                                        <a class="btn btn-default glyphicon glyphicon-chevron-up" href="#"></a>
                                        <span class="like-value"><%# Item.Likes.Count(l => l.Value > 0) - Item.Likes.Count(l => l.Value < 0) %></span>
                                        <a class="btn btn-default glyphicon glyphicon-chevron-down" href="#"></a>
                                    </div>
                                </div>
                            </div>
                            <h2><%#: Item.Title %> <small>Category: <%#: Item.Category.Name %></small></h2>
                            <p><%#: Item.Content %></p>
                            <p>
                                <span>Author: <%#: Item.Author.UserName %></span>
                                <span class="pull-right"><%# Item.DateCreated %></span>
                            </p>
                        </td>
                    </tr>
                </tbody>
            </table>
        </ItemTemplate>
        <EmptyDataTemplate>
            Such article does not exist!
        </EmptyDataTemplate>
    </asp:ListView>

    <%--    <table cellspacing="0" style="border-collapse:collapse;">
		<tbody><tr>
			<td colspan="2">
							
				<div>			
					<div class="like-control col-md-1">
						<div>Likes</div>
						<div>
							<a class="btn btn-default glyphicon glyphicon-chevron-up" href="#"></a>
							<span class="like-value">0</span>
							<a class="btn btn-default glyphicon glyphicon-chevron-down" href="#"></a>
						</div>
					</div>    
				</div>
				<h2>Where can I get some? <small>Category: Education</small></h2>
				<p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don&amp;#39;t look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn&amp;#39;t anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.</p>
				<p>
					<span>Author: Anonimous</span>
					<span class="pull-right">10/31/2014 11:02:29 AM</span>
				</p>
			</td>
		</tr>
		</tbody>
	</table>--%>
</asp:Content>
