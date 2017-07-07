<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage3.master" CodeFile="Billing.aspx.cs" Inherits="Billing" %>




    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style4">
            <tr>
                <td colspan="2" style="text-align:center; font-size: large; background-color: #000000; color: #FFFFFF; font-weight: bolder;">Card Details :</td>
                
            </tr>
            <tr>
                <td>Enter 16 digit card number :</td>
                <td>
                    <asp:TextBox ID="TextBox25" runat="server" Width="168px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>CVV Number :</td>
                <td>
                    <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Expiry Date :</td>
                <td>
                    <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="text-align: center" colspan="2">
                    &nbsp;</td>
                
            </tr>
        </table>
        </asp:Panel>

        <asp:Panel ID="Panel2" runat="server">
    <table style="width: 509px; position: static; height: 100px">
            <tr>
                <td colspan="2" style="text-align:center; font-size: large; background-color: #000000; color: #FFFFFF; font-weight: bolder;">
                 Verify Shipping And Billing Address :</td>
            </tr>
            
            <tr>
                <td class="auto-style1">
                    Name :</td>
                <td style="width: 100px; height: 21px">
                    <asp:TextBox ID="TextBox1" runat="server" Style="position: static"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;Billing
                    Address :</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox19" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    City :&nbsp; <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                    <br />
                    State :
                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    Shipping Address :</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox22" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    City :&nbsp;
                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                    <br />
                    State :
                    <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    E-mail</td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox4" runat="server" Style="position: static" Width="119px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label11" runat="server" Style="position: static" Text="Mobile no :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox9" runat="server" Style="position: static"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style2">
                </td>
                <td style="width: 100px">
                </td>
            </tr>
            <tr>
                <td style="width: 100px; text-align: center;" colspan="2" align="center">
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit Order" OnClick="btnsubmit_Click" />
                </td>              
            </tr>
        </table>
        </asp:Panel>

        <asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Label ID="lblconfirm" runat="server"></asp:Label>
        </asp:Panel>
        
</asp:Content>