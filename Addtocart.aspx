<%@ Page Language="C#" AutoEventWireup="true" masterpagefile="~/MasterPage2.master" CodeFile="~/Addtocart.aspx.cs" Inherits="Description" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <asp:FormView ID="FormView1" runat="server" Width="16px" Height="244px">
            <ItemTemplate>
                <table style="background-color:aliceblue; width:870px;height:242px">
                    <tr>
                        <td style="width:250px;">
                            <asp:Image ID="Image1" runat="server" Height="193px" Width="160px" style="padding-left:50px;" ImageUrl='<%#Bind("image") %>'/>
                        </td>
                        <td style="width:100px">
                            <strong>Description : </strong>
                        </td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%#Bind("bname") %>'></asp:Label>
                        </td>
                    </tr>
                </table>
                
            </ItemTemplate>
        </asp:FormView>


        
            <ajax:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="Button1"
              PopupControlID="Panel1" BackgroundCssClass="modalBackground">
            </ajax:ModalPopupExtender>
            

            <asp:Panel ID="Panel1" runat="server" Width="330px" Height="172px" BorderColor="Black" BorderWidth="2px" BackColor="White" style="display:none;" >
             <table class="auto-style1">
                    <tr>
                        <td colspan="2" style="background-color: #FF9933">&nbsp;</td>
                    </tr>
                    <tr>
                        <td style="text-align:center;">Book Added To Your Cart</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <%--<tr>
                        <td style="padding-left:6px;">
                            <asp:Button ID="btnshop1" runat="server" Text="Continue Shopping" OnClick="btnshop1_Click" style="background-color:ButtonFace;height:30px;"/>
                        </td>
                        <td>
                            <asp:Button ID="btncheckout1" runat="server" Text="Checkout" OnClick="btncheckout1_Click" style="background-color:ButtonFace;height:30px;" />
                        </td>
                    </tr>--%>
                </table>
            </asp:Panel>
            
            
    <asp:Button ID="Button1" runat="server" Text="Add To Cart" style="margin-left: 55px; margin-top: 19px;" Width="91px" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" Width="84px" style="margin-left: 16px" OnClick="Button2_Click" />
            <br/>
            <br/>
            <br/>
            &nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
        
    </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder3">
                            <p>
    <ajax:ToolkitScriptManager ID="script1" runat="server"></ajax:ToolkitScriptManager>

                                <br />
                            </p>
                        </asp:Content>

