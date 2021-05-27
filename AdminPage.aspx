<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="Views_AdminPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            width: 1196px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 1192px">
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#006666" 
            Text="Label" Font-Size="Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Logout" onclick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        Clients&nbsp; 
        <br />
        <br />
        <br />
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateEditButton="True" 
                        AllowSorting="True" BackColor="#99D9EA"  
                        BorderColor="#99D9EA" BorderWidth="3px" CaptionAlign="Top" CellPadding="4" 
                        Font-Bold="True" Font-Italic="False" Font-Size="Medium" GridLines="Horizontal" 
                        Height="255px" HorizontalAlign="Justify" style="margin-top: 0px; margin-left: 0px; margin-right: 0px;" 
                        Width="1190px" PageSize="50" 
            onrowediting="GridView1_RowEditing" onrowupdated="GridView1_RowUpdated" 
            AutoGenerateColumns="False" onrowupdating="GridView1_RowUpdating">
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
                         
                           <asp:TemplateField HeaderText="Client ID" >
                        <ItemTemplate>
                          <asp:Label ID="LabelUserID" runat="server" 
                   Text='<%# Eval("UserID") %>' />
                        </ItemTemplate>
                        </asp:TemplateField>
                          <asp:BoundField DataField="PGName" HeaderText="PGName" />
                        <asp:BoundField DataField="PGAddress" HeaderText="PGAddress"/>
                         <asp:BoundField DataField="PGPhno" HeaderText="PGPhno"/>
                         <asp:BoundField DataField="Avialability" HeaderText="Avialability"/>
                         <asp:BoundField DataField="CostPerDay" HeaderText="CostPerDay"/>
                         <asp:BoundField DataField="CostPerMonth" HeaderText="CostPerMonth"/>
                        <asp:BoundField DataField="Area" HeaderText="Area"/>
                         
                       <asp:TemplateField HeaderText="Conformation Status" >
                        <ItemTemplate>
                          <asp:Label ID="LabelUpgrade" runat="server" 
                   Text='<%# Eval("ConfirmationStas") %>' />
                        </ItemTemplate>
                        <EditItemTemplate >
                        <asp:DropDownList runat="server" ID="DrpDwn1" >
                        
                        <asp:ListItem Text="Pending" Value="Pending"></asp:ListItem>
                        <asp:ListItem Text="Approved" Value="Approved"></asp:ListItem>
                        <asp:ListItem Text="NotApproved" Value="NotApproved"></asp:ListItem>

                        </asp:DropDownList>
                        </EditItemTemplate>
                        </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
    
    </div>
    <p>
        Bookings</p>
                   
                     <asp:GridView ID="GridView3" runat="server" AllowPaging="True" 
                        AllowSorting="True" BackColor="#99D9EA"  AutoGenerateColumns="false"
                        BorderColor="#99D9EA" BorderWidth="3px" CaptionAlign="Top" CellPadding="4" 
                        Font-Bold="True" Font-Italic="False" Font-Size="Medium" GridLines="Horizontal" 
                        Height="255px" HorizontalAlign="Justify" style="margin-top: 0px; margin-left: 0px; margin-right: 0px;" 
                        Width="850px" PageSize="50" 
                        onselectedindexchanged="GridView3_SelectedIndexChanged" 
                        
                       
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
                         <asp:BoundField HeaderText="Order No" DataField="OrderNo" />
                          <asp:BoundField HeaderText="ClientUserID" DataField="ClientUserID" />
                           <asp:BoundField HeaderText="CustomerUserID" DataField="CustomerUserID" />
                        <asp:BoundField HeaderText="Status" DataField="Status" />
                         
                         <asp:BoundField HeaderText="From Date" DataField="FromDate" />
                          <asp:BoundField HeaderText="To Date" DataField="ToDate" />

                          <asp:BoundField HeaderText="NoOfPersons" DataField="NoOfPersons" />
                          <asp:BoundField HeaderText="TotalNoOfDays" DataField="TotalNoOfDays" />
                         


                          <asp:BoundField HeaderText="Area" DataField="Area" />
                           <asp:BoundField HeaderText="Total Cost" DataField="TotalCost" />
                           
                            <asp:BoundField HeaderText="User1" DataField="User1" />
                             <asp:BoundField HeaderText="User2" DataField="User2" />
                              <asp:BoundField HeaderText="User3" DataField="User3" />
                               <asp:BoundField HeaderText="User4" DataField="User4" />
                                <asp:BoundField HeaderText="User5" DataField="User5" />
            
            </Columns>
                    </asp:GridView>
    </form>
</body>
</html>
