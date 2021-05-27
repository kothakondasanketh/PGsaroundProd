<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeFile="BookingsPage.aspx.cs" MasterPageFile="~/HomeMaster.master" Inherits="Views_BookingsPage" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="BookingPageContainer" runat="server" >
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


    <div class="content-wrapper">
   <p>Bookings</p>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AllowSorting="True" BackColor="#99D9EA"  AutoGenerateColumns="false"
                        BorderColor="#99D9EA" BorderWidth="3px" CaptionAlign="Top" CellPadding="4" 
                        Font-Bold="True" Font-Italic="False" Font-Size="Medium" GridLines="Horizontal" 
                        Height="255px" HorizontalAlign="Justify" style="margin-top: 0px; margin-left: 0px; margin-right: 0px;" 
                        Width="843px" PageSize="50" 
                        onselectedindexchanged="GridView1_SelectedIndexChanged" 
                        
                       
                        AutoGenerateSelectButton="True" >
                        <FooterStyle BackColor="White" ForeColor="#009999" />
                        <HeaderStyle BackColor="#394653" Font-Bold="True" ForeColor="Teal" />
                        <PagerStyle BackColor="#99D9EA" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#006666" />
                        <SelectedRowStyle BackColor="#CFEAFA" Font-Bold="True" ForeColor="#006666" />
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
       </div>

</asp:Content>