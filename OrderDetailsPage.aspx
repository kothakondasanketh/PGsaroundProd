<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="OrderDetailsPage.aspx.cs" Inherits="Views_OrderDetailsPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 388px;
        }
        .style7
        {
            width: 274px;
        }
        .style8
        {
            width: 110px;
        }
        .style9
        {
            width: 274px;
            height: 44px;
        }
        .style10
        {
            width: 110px;
            height: 44px;
        }
        .style11
        {
            height: 44px;
        }
        .style13
        {
            width: 274px;
            height: 23px;
        }
        .style14
        {
            width: 110px;
            height: 23px;
        }
        .style15
        {
            height: 23px;
        }
        .style16
        {
            width: 132px;
        }
        .style17
        {
            width: 375px;
        }
    </style>
</head>
 <script type="text/javascript" language="javascript">     window.history.forward(1)</script>
<body style="height: 752px; width: 657px">
    <form id="form1" runat="server" style="height: 745px; width: 657px">
    <div style="height: 747px; width: 657px">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="style1">
            <tr>
                <td class="style17">
                    <asp:Image ID="Image1" runat="server" Height="78px" 
                        ImageUrl="~/Images/10168107_1418174595118200_2873410372663340315_n.png" 
                        Width="148px" />
                </td>
                <td class="style16">
                    <asp:Label ID="Label1" runat="server" Text="INVOICE" Font-Bold="True"></asp:Label>
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                <asp:LinkButton runat="server" Text="Print" ID="Print_button" OnClientClick="javascript:window.print();"></asp:LinkButton>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style17">
                    <asp:Label ID="Label_Odno" runat="server" Text="Order No:" Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label_OrderNo0" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                <td class="style16">
                    &nbsp;</td>
                <td class="style2">
                    Date:<asp:Label ID="Label_TodayDate" runat="server"></asp:Label>
                    <br />
                    Booking Date:<asp:Label ID="Label_BookingDate" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            </table>
    
        <table class="style1">
            <tr>
                <td class="style13">
             
                    <asp:Label ID="Label3" runat="server" Text="User Details" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Text="Name:"></asp:Label>
                    <asp:Label ID="Label_UserName" runat="server"></asp:Label>
                </td>
                <td class="style14">
                    </td>
                <td class="style15">
                    <asp:Label ID="Label2" runat="server" Text="PG Details" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="PG Name:"></asp:Label>
                    <asp:Label ID="Label_PGName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    <asp:Label ID="Label5" runat="server" Text="Phone No:"></asp:Label>
                    <asp:Label ID="Label_Userphno" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Address:"></asp:Label>
                    <asp:Label ID="Label_UserAddress" runat="server"></asp:Label>
                </td>
                <td class="style10">
                </td>
                <td class="style11">
                    <asp:Label ID="Label9" runat="server" Text="PG Contact No:"></asp:Label>
                    <asp:Label ID="Label_PGPHno" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="PG Address:"></asp:Label>
                    <asp:Label ID="Label_PGAddress" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
             
                    <asp:Label ID="Label10" runat="server" Text="Order Details" 
            Font-Bold="True"></asp:Label>
                <br />
        <asp:GridView ID="GridView_OrderDetails" runat="server" Height="16px" 
            Width="651px" AutoGenerateColumns="false">
            <Columns>
              <asp:BoundField HeaderText="Order No" DataField="OrderNo" />
                        <asp:BoundField HeaderText="Status" DataField="Status" />
                         
                         <asp:BoundField HeaderText="From Date" DataField="FromDate" />
                          <asp:BoundField HeaderText="To Date" DataField="ToDate" />
                          <asp:BoundField HeaderText="No Of Days" DataField="TotalNoOfDays" />
                           <asp:BoundField HeaderText="Total Cost" DataField="TotalCost" />
                           
            
            </Columns>
        </asp:GridView>
        <br />
             
                    <asp:Label ID="Label19" runat="server" Text="No Of Persons Allowed:" 
            Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label_NoOfPersons" runat="server"></asp:Label>
                <br />
        <br />
             
                    <asp:Label ID="Label11" runat="server" Text="Customers Details" 
            Font-Bold="True"></asp:Label>
                <br />
        <br />
             
                    <asp:Label ID="Label_usr1" runat="server" Text="User1:" 
            Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label_User1" runat="server"></asp:Label>
                <br />
             
                    <asp:Label ID="Label_usr2" runat="server" Text="User2:" 
            Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label_User2" runat="server"></asp:Label>
                <br />
             
                    <asp:Label ID="Label_usr3" runat="server" Text="User3:" 
            Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label_User3" runat="server"></asp:Label>
                <br />
             
                    <asp:Label ID="Label_usr4" runat="server" Text="User4:" 
            Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label_User4" runat="server"></asp:Label>
                <br />
             
                    <asp:Label ID="Label_usr5" runat="server" Text="User5:" 
            Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label_User5" runat="server"></asp:Label>
                <br />
        <br />
             
                    <asp:Label ID="Label17" runat="server" Text="Total Cost:" 
            Font-Bold="True"></asp:Label>
                    <asp:Label ID="Label_TotalCost" runat="server"></asp:Label>
                <br />
        <br />
             
                    <asp:Label ID="Label18" runat="server" 
            Text="Instructions: Please provide this invoice at PG on the date of joining." 
            Font-Bold="True"></asp:Label>
                <br />
    
    </div>
    </form>
</body>
</html>
