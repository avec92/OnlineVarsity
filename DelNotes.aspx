<%@ Page Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="DelNotes.aspx.cs" Inherits="notes" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="text-align: left">
                Select Subject</td>
            <td>
                <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="True" Width="204px">
                </asp:DropDownList></td>
        </tr>
    <tr>
        <td colspan="2">
            <asp:GridView ID="GridView1" runat="server">
            <Columns>
              <asp:TemplateField >
            <ItemTemplate>
            <asp:LinkButton ID="l2" runat="server" Text="Delete" commandname='<%#Eval("path") %>' OnCommand ="l2_click"></asp:LinkButton>
            </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField >
            <ItemTemplate>
            <asp:LinkButton ID="l1" runat="server" Text="Download" commandname='<%#Eval("path") %>' OnCommand ="l1_click"></asp:LinkButton>
            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            </asp:GridView>
        </td>
    </tr>
        <tr>
            <td colspan="2" style="height: 19px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
</table>
</asp:Content>

