<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Choice.aspx.cs" Inherits="Choice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <p>
        Dear user, You have a choice that you can either buy this book as is or you can gain 70% off by giving a test.</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Take Test" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Continue to buy" />
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

