<%@ Page Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="Upload.aspx.cs" Inherits="AddNotes" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table >
        <tr>
            <td style="width: 145px; text-align: left">
                Select Category</td>
            <td style="width: 100px">
                <asp:DropDownList ID="ddl2" runat="server" Width="164px" AutoPostBack="True">
<%--                    <asp:ListItem>Asp.net</asp:ListItem>
                    <asp:ListItem>C#</asp:ListItem>
                    <asp:ListItem>Java</asp:ListItem>
                    <asp:ListItem>C++</asp:ListItem>--%>
                    
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 145px; text-align: left">
                Enter Title of the book:</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 145px; text-align: left">
                Enter available qty:</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 145px; text-align: left">
                Enter author name:</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 145px; text-align: left">
                Enter Price:</td>
            <td style="width: 100px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 145px; text-align: left">
                Upload Image</td>
            <td style="width: 100px">
                <asp:FileUpload ID="photo" runat="server" style="margin-left: 89px" />
            </td>
        </tr>
        </table>
    <br />
    <table >
        <tr>
            <td style="width: 170px">
                Select File1 to Locate</td>
            <td style="width: 100px">
                <asp:FileUpload ID="fp1" runat="server" /></td>
        </tr>
        </table>
    
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
    &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        &nbsp;
         &nbsp;
</asp:Content>

