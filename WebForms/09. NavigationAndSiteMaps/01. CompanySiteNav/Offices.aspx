<%@ Page Title="" Language="C#" MasterPageFile="~/HeaderNavMasterPage.Master" AutoEventWireup="true" CodeBehind="Offices.aspx.cs" Inherits="_01.CompanySiteNav.Offices" %>

<asp:Content ID="ContentOffices" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h2>Hello from our Offices page</h2>
    <aside>
        <asp:Menu runat="server" ID="MenuOffices" DataSourceID="SiteMapDataSource"></asp:Menu>
    </aside>
    <asp:SiteMapDataSource ID="SiteMapDataSource" runat="server" 
        ShowStartingNode="False" StartingNodeOffset="1" />
</asp:Content>

