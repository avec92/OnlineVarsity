﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="MyInformation.aspx.cs" Inherits="MyInformation" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <ajax:ToolkitScriptManager ID="script1" runat="server"></ajax:ToolkitScriptManager>
    
    <style type="text/css">
        .modalBackground
        {
            background-color:gray;
            filter:alpha(capacity=80);
            opacity:0.8;
            z-index:10000;
        }
    </style>

    <asp:DataList ID="DataList1" runat="server" RepeatColumns="1" RepeatDirection="Horizontal" Width="331px" Height="110px">
        <HeaderStyle BackColor="#333333" Font-Bold="True" Font-Size="Larger" ForeColor="White"
                HorizontalAlign="Center" VerticalAlign="Middle" />
        <HeaderTemplate>
            Personal Information
        </HeaderTemplate>
        <ItemTemplate>
           <table>
            <tr>
              <td style="width:150px"> <b> User Id :</b> </td>
              <td><asp:Label ID="Label1" runat="server" Text='<%#Bind("sid") %>'></asp:Label></td>
            </tr>
            <tr> 
              <td style="width:150px"><b>Name :</b> </td>
              <td><asp:Label ID="Label2" runat="server" Text='<%#Bind("sname") %>'></asp:Label> </td>
            </tr>
            <tr>
              <td style="width:150px"><b> Password :</b></td>
              <td><asp:Label ID="Label3" runat="server" Text='<%#Bind("spass") %>'></asp:Label> </td>
            </tr>
            <tr>
              <td style="width:150px"><b> Email Id :</b> </td>
              <td><asp:Label ID="Label4" runat="server" Text='<%#Bind("semail") %>'></asp:Label> </td>
            </tr>
            <tr>
              <td colspan="2"> <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Red" OnClick="LinkButton1_Click">Edit</asp:LinkButton> </td>
            </tr>
           </table>
        </ItemTemplate>
    </asp:DataList>

    <ajax:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="LinkButton1" PopupControlID="Panel1" BackgroundCssClass="modalBackground">
    </ajax:ModalPopupExtender>

    <asp:Panel ID="Panel1" runat="server" Width="330px" Height="250px" BorderColor="Black" BorderWidth="2px" BackColor="White" style="display:none;">
        <table style="width:330px; height:250px; padding-left:6px">
           <tr>
               <td colspan="2" style="background-color: #FF9933">&nbsp;</td>
           </tr>
           <tr>
               <td> User Id : </td>               
               <td> <asp:TextBox ID="txtid" runat="server" ReadOnly="true"></asp:TextBox> </td>
           </tr>
           <tr>
               <td> Name : </td>
               <td> <asp:TextBox ID="txtname" runat="server" > </asp:TextBox></td>
           </tr>
           <tr>
               <td> Password : </td>
               <td> <asp:TextBox ID="txtpass" runat="server" ></asp:TextBox> </td>
           </tr>
           <tr>
               <td> Email Id </td>
               <td> <asp:TextBox ID="txtemail" runat="server"></asp:TextBox> </td>
           </tr>
           <tr>
               <td> <asp:Button ID="btnupdate" runat="server" Text="Update"  style="background-color:ButtonFace;" OnClick="btnupdate_Click"/></td>
               <td> <asp:Button ID="btncancel" runat="server" Text="Cancel" style="background-color:ButtonFace;"/></td>
           </tr>
        </table>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>

