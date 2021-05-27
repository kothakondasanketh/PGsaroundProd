<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeFile="BookingsPage.aspx.cs" Inherits="Views_BookingsPage" %>

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
            width: 57px;
        }
        .style4
        {
            width: 989px;
        }
        .style5
        {
            width: 57px;
            height: 18px;
        }
        .style6
        {
            width: 989px;
            height: 18px;
        }
    </style>
</head>

<body style="height: 456px">
    <form id="form1" runat="server">
    <div>
    <asp:panel ID="Panel1" runat="server" Height="506px">
        <table class="style1">
            <tr>
                <td class="style5">
                    Bookings</td>
                <td class="style6">
                    </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td rowspan="2" class="style4">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AllowSorting="True" BackColor="#99D9EA"  AutoGenerateColumns="false"
                        BorderColor="#99D9EA" BorderWidth="3px" CaptionAlign="Top" CellPadding="4" 
                        Font-Bold="True" Font-Italic="False" Font-Size="Medium" GridLines="Horizontal" 
                        Height="255px" HorizontalAlign="Justify" style="margin-top: 0px; margin-left: 0px; margin-right: 0px;" 
                        Width="843px" PageSize="50" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        
                       
                        AutoGenerateSelectButton="True" >
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
                       <%-- <asp:TemplateField  >
                        <ItemTemplate>
                        <asp:LinkButton ID="ViewLinkbutton" runat="server" Text="View Order" ForeColor="#006666" NavigateUrl="./OrderDetailsPage.aspx" OnClick="GridView1_SelectedIndexChanged"/>
                       
                        </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:BoundField HeaderText="Order No" DataField="OrderNo" />
                        <asp:BoundField HeaderText="Status" DataField="Status" />
                         
                          <asp:BoundField HeaderText="PG Address" DataField="Address" />
                         <asp:BoundField HeaderText="From Date" DataField="FromDate" />
                          <asp:BoundField HeaderText="To Date" DataField="ToDate" />
                           <asp:BoundField HeaderText="Total Cost" DataField="TotalCost" />
                           <asp:BoundField HeaderText="Area" DataField="Area" />
                        </Columns>
                    </asp:GridView>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
            </tr>
        </table>
    </asp:panel>
    </div>
    </form>
</body>
</html>
