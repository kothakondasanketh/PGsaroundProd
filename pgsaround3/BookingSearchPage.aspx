<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeFile="BookingSearchPage.aspx.cs" Inherits="Views_BookingSearchPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 139px;
        }
        .style3
        {
            width: 142px;
        }
        .style4
        {
            width: 150px;
        }
        .style5
        {
            width: 168px;
        }
        .style6
        {
            width: 145px;
        }
        .style7
        {
            width: 147px;
        }
        .style8
        {
            width: 121px;
        }
        .style9
        {
            width: 64px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                    <table class="style1">
                        <tr>
                            <td class="style9">
                                Gender&nbsp;
                            </td>
                            <td>
    
                    <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" 
                        
            Width="131px" onselectedindexchanged="DropDownList5_SelectedIndexChanged">
                        <asp:ListItem Value="1">Men</asp:ListItem>
                        <asp:ListItem Value="2">Women</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
    
                    <br />
                    <table class="style1">
                        <tr>
                            <td class="style2">
    
                                Select Country<br />
    
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" 
                        
            Width="131px" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Selected="True">India</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td class="style3">
                                <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                            </td>
                            <td class="style4">
                                Select State<br />
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" Height="21px" 
                        onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
            Width="144px">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td class="style5">
                                <br />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                            </td>
                            <td class="style6">
                                Select City<br />
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" 
                        onselectedindexchanged="DropDownList3_SelectedIndexChanged" 
            Width="137px">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td class="style8">
                                <br />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                            </td>
                            <td class="style7">
                                Select Area<br />
                    <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" 
                        Font-Bold="True" Font-Italic="True" ForeColor="#336666" 
                        onselectedindexchanged="DropDownList4_SelectedIndexChanged" 
            Width="142px">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td>
                                <br />
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <table class="style1">
                        <tr>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <table class="style1">
                        <tr>
                            <td>
                   <asp:GridView  ID="GridView1" runat="server" 
                        AllowSorting="True" BackColor="Teal" AutoGenerateColumns="false"
                        BorderColor="#99D9EA" BorderWidth="3px" CaptionAlign="Top" CellPadding="4" 
                        Font-Bold="True" Font-Italic="False" Font-Size="Medium" GridLines="Horizontal" 
                        Height="174px" HorizontalAlign="Justify" style="margin-top: 0px" 
                        Width="800px" AutoGenerateSelectButton="True" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged"  PageSize="50" 
                                    onrowcommand="GridView1_RowCommand">
                        <FooterStyle BackColor="White" ForeColor="#009999" />
                        <HeaderStyle BackColor="#99D9EA" Font-Bold="True" ForeColor="Teal" />
                        <PagerStyle BackColor="#99D9EA" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#006666" />
                        <SelectedRowStyle BackColor="#CFEAFA" Font-Bold="True" ForeColor="#006666" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                          <Columns>
                   <asp:TemplateField>
  <ItemTemplate>
    <asp:LinkButton ID="ViewDetailsButton" runat="server"  
      CommandName="ViewDetails" 
      CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
      Text="ViewDetails" ForeColor="#006666"  />
  </ItemTemplate> 
</asp:TemplateField>
                           <asp:BoundField DataField="UserID" HeaderText="PG ID" />
                        <asp:BoundField DataField="PGName" HeaderText="PGName" />
                        <asp:BoundField DataField="PGAddress" HeaderText="PGAddress"/>
                         <asp:BoundField DataField="PGPhno" HeaderText="PGPhno"/>
                         <asp:BoundField DataField="Avialability" HeaderText="Avialability"/>
                         <asp:BoundField DataField="CostPerDay" HeaderText="CostPerDay"/>
                         <asp:BoundField DataField="CostPerMonth" HeaderText="CostPerMonth"/>
                        <asp:BoundField DataField="Area" HeaderText="Area"/>
                        </Columns>
                    </asp:GridView>
    
                            </td>
                        </tr>
                    </table>
    
                    <br />
                    <asp:ListView ID="ListView1" runat="server"   >
                    
                      <ItemTemplate>
          <tr id="Tr1" runat="server" >
           
            <td>
             <asp:Label ID="Label5"  runat="Server" Text='PGName: ' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
              <asp:Label ID="PGName" runat="Server" Text='<%#Eval("PGName") %>' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
            </td>
             
            <td valign="top">
             <asp:Label ID="Label6" runat="Server" Text=', Address: ' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
              <asp:Label ID="Address" runat="Server" Text='<%#Eval("PGAddress") %>' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
            </td>
             
             <td valign="top">
              <asp:Label ID="Label7" runat="Server" Text=', Phone No: ' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
              <asp:Label ID="PhoneNo" runat="Server" Text='<%#Eval("PGPhno") %>' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>

            </td>
            
             <td valign="top">
              <asp:Label ID="Label8" runat="Server" Text=', Cost per Day: ' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
              <asp:Label ID="CostPerDay" runat="Server" Text='<%#Eval("CostPerDay") %>' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
            </td>
             
             <td valign="top">
              <asp:Label ID="Label9" runat="Server" Text=', Cost Per Month: ' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
              <asp:Label ID="CostPerMonth" runat="Server" Text='<%#Eval("CostPerMonth") %>' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
            </td>
             
              <td valign="top">
               <asp:Label ID="Label10" runat="Server" Text=', Availability: ' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
              <asp:Label ID="Availability" runat="Server" Text='<%#Eval("Avialability") %>' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large" />
            </td>
            
              <td valign="top">
               <asp:Label ID="Label11" runat="Server" Text=', Area: '  ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large" />
              <asp:Label ID="Area" runat="Server" Text='<%#Eval("Area") %>' ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large" />
            </td>
          </tr>
        </ItemTemplate>
                    </asp:ListView>
    
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" BackColor="#669999" Font-Bold="True" 
                        Font-Underline="True" ForeColor="#006666" style="margin-left: 2px" 
                        Text="Proceed" ToolTip="Press here to Continue" Width="105px" 
                        onclick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
