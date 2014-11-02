<%@ Control Language="C#"
    AutoEventWireup="true"
    CodeBehind="MenuOfLinksUserControl.ascx.cs"
    Inherits="_01.MenuOfLinksControl.MenuOfLinksUserControl" %>

<%@ Import Namespace="_01.MenuOfLinksControl.Models" %>

<asp:DataList runat="server" ID="DataListMenuOfLinks"
       >
    <HeaderTemplate>
        <ul> Check out the most famous sites throughout the world!
    </HeaderTemplate>
    <ItemTemplate>
        <li>
            <a runat="server" href="<%# ((LinkForMenu) Container.DataItem).Url %>" target="_blank"><%# ((LinkForMenu) Container.DataItem).Title %></a>
        </li>
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:DataList>
