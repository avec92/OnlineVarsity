<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Result.aspx.cs" Inherits="Result" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    You have scored
<asp:Label ID="Label1" runat="server"></asp:Label>
%.
<asp:Label ID="Label2" runat="server"></asp:Label>
&nbsp;&nbsp; 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Proceed without discount" />
&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Get the Discount" />
</asp:Content>

