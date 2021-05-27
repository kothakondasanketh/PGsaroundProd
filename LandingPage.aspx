<%@ Page Async="true" Language="C#" AutoEventWireup="true" MasterPageFile="~/HomeMaster.master"  CodeFile="LandingPage.aspx.cs" Inherits="Views_LandingPage" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>



<%--<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">--%>

<%--<html xmlns="http://www.w3.org/1999/xhtml">--%>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    

 
    <style type="text/css">
        #I1
        {
            width: 950px;
        }
        #Frame1
        {
            width: 1296px;
            height: 340px;
        }
        #Div2
        {
            height: 299px;
        }
        #Div3
        {
            height: 159px;
        }
    </style>
 
                        <asp:Label ID="Label_Errormsg" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
 
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ScriptManager 
        ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                        &nbsp;<div  >
    <asp:Panel runat="server" ID="panel1" Height=465 >
                    Select Gender
                    <asp:ComboBox ID="ComboBox5" runat="server" AutoCompleteMode="SuggestAppend" 
                        AutoPostBack="True" CaseSensitive="False" CssClass="CustomComboBoxStyle" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" 
                        onselectedindexchanged="ComboBox5_SelectedIndexChanged" Width="131px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem Value="1">Men</asp:ListItem>
                        <asp:ListItem Value="2">Women</asp:ListItem>
                    </asp:ComboBox>
                    </td>
                    <td class="style27">
                        &nbsp;&nbsp;&nbsp;</td>
                <td class="style37">
                    &nbsp;&nbsp;<%--<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" Height="21px" 
                        onselectedindexchanged="DropDownList2_SelectedIndexChanged" Width="144px">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>--%></td>
                <td class="style14">
                    &nbsp;&nbsp;<%--<asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" 
                        onselectedindexchanged="DropDownList3_SelectedIndexChanged" Width="137px">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>--%></td>
                <td class="style14">
                    &nbsp;&nbsp;<%--<asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" 
                        onselectedindexchanged="DropDownList4_SelectedIndexChanged" Width="142px">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>--%></td>
                <td>
                    <br />
                    &nbsp;</td>
            </tr>
            <tr>
                
                    <table class="style2">
                        <tr>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Select Country"></asp:Label>
                                <asp:ComboBox ID="ComboBox1" runat="server" AutoPostBack="True" 
                                    Font-Bold="True" Font-Italic="True" ForeColor="#336666"  AutoCompleteMode="SuggestAppend"   CssClass="CustomComboBoxStyle" 
                                    CaseSensitive="False" 
                                    onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="131px">
                                    <asp:ListItem>India</asp:ListItem>
                                </asp:ComboBox>
                            </td>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="Select State"></asp:Label>
                                <asp:ComboBox ID="ComboBox2" runat="server" AutoPostBack="True" 
                                    Font-Bold="True" Font-Italic="True" ForeColor="#336666"  
                                    AutoCompleteMode="SuggestAppend"   CssClass="CustomComboBoxStyle" 
                                    CaseSensitive="False" 
                                    onselectedindexchanged="ComboBox2_SelectedIndexChanged" Width="131px">
                                </asp:ComboBox>
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="Select City"></asp:Label>
                                <asp:ComboBox ID="ComboBox3" runat="server" AutoPostBack="True" 
                                    Font-Bold="True" Font-Italic="True" ForeColor="#336666"  
                                    AutoCompleteMode="SuggestAppend"   CssClass="CustomComboBoxStyle" 
                                    CaseSensitive="False" 
                                    onselectedindexchanged="ComboBox3_SelectedIndexChanged" Width="131px">
                                </asp:ComboBox>
                            </td>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="Select Area"></asp:Label>
                                <asp:ComboBox ID="ComboBox4" runat="server" AutoPostBack="True" 
                                    Font-Bold="True" Font-Italic="True" ForeColor="#336666"  AutoCompleteMode="SuggestAppend"   CssClass="CustomComboBoxStyle" 
                                     CaseSensitive="False" 
                                    onselectedindexchanged="DropDownList4_SelectedIndexChanged" Width="131px">
                                </asp:ComboBox>
                            </td>
                        </tr>
                    </table>
                
                    <br />
&nbsp;<td class="style27">
                        <asp:GridView ID="GridView1" runat="server" 
                        AllowSorting="True" BackColor="#99D9EA" AutoGenerateColumns="false"
                        BorderColor="#99D9EA" BorderWidth="3px" CaptionAlign="Top" CellPadding="4" 
                        Font-Bold="True" Font-Italic="False" Font-Size="Medium" GridLines="Horizontal" 
                        Height="174px" HorizontalAlign="Justify" style="margin-top: 0px" 
                        Width="1025">
                     <FooterStyle BackColor="White" ForeColor="#009999" />
                        <HeaderStyle BackColor="#99D9EA" Font-Bold="True" ForeColor="Teal" />
                        <PagerStyle BackColor="#99D9EA" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#006666" />
                        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                          <Columns>
                        <asp:BoundField DataField="PGName" HeaderText="PGName" />
                        <asp:BoundField DataField="PGAddress" HeaderText="PGAddress"/>
                         <asp:BoundField DataField="PGPhno" HeaderText="PGPhno"/>
                         <asp:BoundField DataField="Avialability" HeaderText="Avialability"/>
                         <asp:BoundField DataField="CostPerDay" HeaderText="CostPerDay"/>
                         <asp:BoundField DataField="CostPerMonth" HeaderText="CostPerMonth"/>
                        <asp:BoundField DataField="Area" HeaderText="Area"/>
                        </Columns>
                    </asp:GridView>
                    <br />
                    </asp:Panel>
          </div>
    
<%--    </form>
</body>
</html>--%>
</asp:Content>
