<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="CPPList.aspx.cs" Inherits="CPPList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" Width="282px" OnItemCommand="DataList1_ItemCommand">
    <AlternatingItemStyle BackColor="White" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <ItemStyle BackColor="#E3EAEB" />
    <ItemTemplate>
        image:
        <asp:Label ID="imageLabel" runat="server" Text='<%# Eval("image") %>' />
        <br />
        bname:
        <asp:Label ID="bnameLabel" runat="server" Text='<%# Eval("bname") %>' />
        <br />
        qty:
        <asp:Label ID="qtyLabel" runat="server" Text='<%# Eval("qty") %>' />
        <br />
        AuthorName:
        <asp:Label ID="AuthorNameLabel" runat="server" Text='<%# Eval("AuthorName") %>' />
        <br />
        price:
        <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
        <br />
        <br />
    </ItemTemplate>
    <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
</asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineVarsityConnectionString %>" SelectCommand="SELECT [image], [bname], [qty], [AuthorName], [price] FROM [Data] WHERE (([qty] &gt; @qty) AND ([Subject] = @Subject))">
        <SelectParameters>
            <asp:Parameter DefaultValue="0" Name="qty" Type="Int32" />
            <asp:Parameter DefaultValue="C++" Name="Subject" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

