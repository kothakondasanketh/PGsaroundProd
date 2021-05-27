<%@ Page Language="C#"  Async="true" AutoEventWireup="true" CodeFile="BookingDetailsEntry.aspx.cs" Inherits="Views_BookingDetailsEntry" %>
<%@ Register Assembly="SlimeeLibrary" Namespace="SlimeeLibrary" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <style type="text/css">
        #form1
        {
            height: 1038px;
        }
    </style>
</head>
    <%--<head>
  <meta charset="utf-8">
  <title>jQuery UI Datepicker - Default functionality</title>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.10.4/themes/smoothness/jquery-ui.css">
  <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script>
      $(function () {
          $("#datepicker").datepicker();
      });
      function datepicker_onclick() {
         
      }


  </script>
</head>--%>
<div style="height:450px; width: 950px; margin-right: 0px">
    <form id="form1" runat="server" style="width: 950px; height: 450px">
    
    <body style="width: 950px; height: 450px">
    
                    <asp:ListView ID="ListView1" runat="server"    >
                    
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
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="No Of Persons :"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" 
                        Height="22px" Width="43px" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Selected="True">1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="1) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="102px">
                        
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
&nbsp;<asp:Label ID="Label16" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <br />
                    <div id="User2div" runat="server">
                    <asp:Label ID="Label17" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="2) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label19" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="102px">
                    
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
&nbsp;<asp:Label ID="Label20" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    </div>
                    <div id="User3div" runat="server">
                    <asp:Label ID="Label21" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="3) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label22" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label23" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList4" runat="server" Width="102px">
                    
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
&nbsp;<asp:Label ID="Label24" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                    </div>
                    <div id="User4div" runat="server">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="4) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label26" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList5" runat="server" Width="102px">
                    
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
&nbsp;<asp:Label ID="Label28" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                    </div>
                    <div id="User5div" runat="server">
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="5) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
&nbsp;
                    <asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label31" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList6" runat="server" Width="102px">
                    
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
&nbsp;<asp:Label ID="Label32" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                    </div>
                    <br />
&nbsp;<asp:RadioButton ID="RadioButton_Daily" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Daily" AutoPostBack="True" 
                        oncheckedchanged="RadioButton1_CheckedChanged" Checked="True" />
&nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton_Monthly" runat="server" Font-Bold="True" 
                        ForeColor="#275353" Text="Monthly" AutoPostBack="True" 
                        oncheckedchanged="RadioButton2_CheckedChanged" />
&nbsp;&nbsp;
                    <asp:Label ID="Label_noofmonth" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="No Of Months:"></asp:Label>
                    <asp:DropDownList ID="DropDownList_noofmonths" runat="server" Height="22px" 
                        onselectedindexchanged="DropDownList_noofmonths_SelectedIndexChanged" 
                        style="margin-left: 16px" Width="61px" AutoPostBack="True">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Label ID="Label33" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="From Date :"></asp:Label>
                    <br />
      <cc1:DatePicker ID="DatePicker1" runat="server" AutoPostBack="true" Width="100px" 
                        PaneWidth="150px" onselecteddatechanged="DatePicker1_SelectedDateChanged" 
                        SelectedDate="">
        <PaneTableStyle BorderColor="#707070" BorderWidth="1px" BorderStyle="Solid" />
        <PaneHeaderStyle BackColor="#0099FF" />
        <TitleStyle ForeColor="White" Font-Bold="true" />
        <NextPrevMonthStyle ForeColor="White" Font-Bold="true" />
        <NextPrevYearStyle ForeColor="#E0E0E0" Font-Bold="true" />
        <DayHeaderStyle BackColor="#E8E8E8" />
        <TodayStyle BackColor="#FFFFCC" ForeColor="#000000" Font-Underline="false" BorderColor="#FFCC99"/>
        <AlternateMonthStyle BackColor="#F0F0F0" ForeColor="#707070" Font-Underline="false"/>
        <MonthStyle BackColor="" ForeColor="#000000" Font-Underline="false"/>
    </cc1:DatePicker>
  
 

                     
                 <%--   <input id="datepicker0" type="text" onclick="return datepicker_onclick()" 
                        onclick="return datepicker_onclick()" />&nbsp;--%>
                      

   

  
 

                     
                    <br />
                      

   

  
 

                     
                    &nbsp;<asp:Label ID="Label34" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="To Date :"></asp:Label>
                     
                   <%-- <input id="datepicker" type="text" onclick="return datepicker_onclick()" onclick="return datepicker_onclick()" /><br />--%>
                    <br />
      <cc1:DatePicker ID="DatePicker2" runat="server" AutoPostBack="true" Width="100px" 
                        PaneWidth="150px" onselecteddatechanged="DatePicker2_SelectedDateChanged">
        <PaneTableStyle BorderColor="#707070" BorderWidth="1px" BorderStyle="Solid" />
        <PaneHeaderStyle BackColor="#0099FF" />
        <TitleStyle ForeColor="White" Font-Bold="true" />
        <NextPrevMonthStyle ForeColor="White" Font-Bold="true" />
        <NextPrevYearStyle ForeColor="#E0E0E0" Font-Bold="true" />
        <DayHeaderStyle BackColor="#E8E8E8" />
        <TodayStyle BackColor="#FFFFCC" ForeColor="#000000" Font-Underline="false" BorderColor="#FFCC99"/>
        <AlternateMonthStyle BackColor="#F0F0F0" ForeColor="#707070" Font-Underline="false"/>
        <MonthStyle BackColor="" ForeColor="#000000" Font-Underline="false"/>
    </cc1:DatePicker>
  
 

                     
                    <br />
                    <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Total Cost : "></asp:Label>
                     
                    <asp:Label ID="Label_TotalCost" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="nil"></asp:Label>
                     
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" BackColor="#006666" Font-Bold="True" 
                        onclick="Button1_Click" Text="Confirm" Width="108px"  />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
    </body>
   
    </form>
     </div>
</html>
