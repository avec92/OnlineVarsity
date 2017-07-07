<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="AspList.aspx.cs" Inherits="AspList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" OnItemCommand="DataList1_ItemCommand" RepeatColumns="2" RepeatDirection="Horizontal" Width="588px" CellPadding="4" CellSpacing="4" GridLines="Horizontal" style="margin-left: 0px; margin-right: 0px;">
        
        <HeaderStyle BackColor="#333333" Font-Bold="True" Font-Size="Larger" ForeColor="White"
                HorizontalAlign="Center" VerticalAlign="Middle" />
<ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%#Bind("image") %>' CommandArgument='<%#Bind("bid") %>' CommandName="ID" Width="100px" Height="120px"/>
            <br />
           <b> Name :  </b>
            <asp:Label ID="lblname" runat="server" Text='<%#Bind("bname") %>'></asp:Label>
            <br /> 
           <b> Author : </b> 
            <asp:Label ID="lblauthor" runat="server" Text='<%#Bind("AuthorName") %>'></asp:Label>           
            <br />
    <b>         Quantity: </b>
            <asp:Label ID="Label1" runat="server" Text='<%#Bind("qty") %>'></asp:Label>
            <br /> 
           <b> Price(Rs.) : </b>
            <asp:Label ID="lblprice" runat="server" Text='<%#Bind("price") %>'></asp:Label>
            <br />
            
        </ItemTemplate>
</asp:DataList>
<%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineVarsityConnectionString %>" SelectCommand="SELECT [image], [bname], [qty], [AuthorName], [price] FROM [Data] WHERE (([qty] &gt; @qty) AND ([Subject] = @Subject))">
    <SelectParameters>
        <asp:Parameter DefaultValue="0" Name="qty" Type="Int32" />
        <asp:Parameter DefaultValue="Asp.net" Name="Subject" Type="String" />
    </SelectParameters>
</asp:SqlDataSource>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

