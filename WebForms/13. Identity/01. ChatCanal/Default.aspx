<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_01.ChatCanal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section>
        <header>
            <h1>Welcome to Chat Canal!</h1>
        </header>
        <section>
            <asp:Panel runat="server" ID="PanelPleaseLogIn">
                <asp:Label runat="server" ID="LabelPleaseLogIn">Please, log in from <a href="Account/Login.aspx">here</a> to use the chat!</asp:Label>
            </asp:Panel>
            <asp:ListView runat="server" ID="ListViewMessages"
                ItemType="_01.ChatCanal.Models.Message"
                DataKeyNames="Id"
                InsertItemPosition="LastItem"
                SelectMethod="ListViewMessages_GetData"
                InsertMethod="ListViewMessages_InsertItem"
                DeleteMethod="ListViewMessages_DeleteItem"
                UpdateMethod="ListViewMessages_UpdateItem">
                <EditItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button runat="server" CommandName="Update" Text="Update" ID="UpdateButton" />
                            <asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" />
                        </td>
                        <td>
                            <asp:TextBox Text='<%# Bind("Text") %>' runat="server" ID="TextTextBox" /></td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="">
                        <tr>
                            <td>No messages in the database yet.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button runat="server" CommandName="Insert" Text="Post" ID="InsertButton" />
                            <asp:Button runat="server" CommandName="Cancel" Text="Clear" ID="CancelButton" />
                        </td>
                        <td>&nbsp;</td>
                        <td>
                            <asp:TextBox Text='<%# Bind("Text") %>' runat="server" ID="TextTextBox" /></td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" Visible='<%# Context.User.IsInRole("Admin") %>' />
                            <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" Visible='<%# Context.User.IsInRole("Moderator") %>' />
                        </td>
                        <td>
                            <asp:Label Text='<%# Eval("Text") %>' runat="server" ID="TextLabel" /></td>
                        <td>
                            <asp:Label Text='<%# Eval("DateSent") %>' runat="server" ID="DateSentLabel" /></td>
                        <td>
                            <asp:Label Text='<%# Eval("SenderName") %>' runat="server" ID="UserIdLabel" /></td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table runat="server" id="itemPlaceholderContainer" style="" border="0">
                                    <tr runat="server" style="">
                                        <th runat="server"></th>
                                        <th runat="server">Text</th>
                                        <th runat="server">Date Sent</th>
                                        <th runat="server">User</th>
                                    </tr>
                                    <tr runat="server" id="itemPlaceholder"></tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="">
                                <asp:DataPager runat="server" ID="DataPager1" PageSize="20">
                                    <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                                        <asp:NumericPagerField></asp:NumericPagerField>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </section>
    </section>

</asp:Content>
