<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="ClientUpdateDetailsPage.aspx.cs" Inherits="Views_ClientUpdateDetailsPage" %>

<%@ Register assembly="SlimeeLibrary" namespace="SlimeeLibrary" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        #Div2
        {
            height: 432px;
        }
        #Div3
        {
            height: 159px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="Div2" runat="server" >
    
        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox_Username" runat="server" Width="150px" ReadOnly="True"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox_Name" runat="server" 
            Width="150px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label31" runat="server" Font-Bold="True" Font-Size="Medium" 
            Text="Status :"></asp:Label>
        <asp:Label ID="Label_Status" runat="server" Font-Bold="True" Font-Size="Medium" 
            ForeColor="#CC0000"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Passwd" runat="server" 
            Width="150px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label15" runat="server" Text="Email ID"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Emailid" runat="server" Width="150px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Passwdcnfm" runat="server" 
            Width="150px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label16" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Age" runat="server" Width="150px"></asp:TextBox>
        <br />
        <asp:Label ID="Label17" runat="server" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList_Gender" runat="server" Height="21px" 
             Width="111px">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="Label18" runat="server" Text="Phone No"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox_Phno" runat="server" Width="150px"></asp:TextBox>
        <br />
        <asp:Label ID="Label19" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="TextBox_Address" runat="server" Height="51px" 
            style="margin-left: 85px" TextMode="MultiLine" Width="354px"></asp:TextBox>
&nbsp;&nbsp;<br />
        <asp:Label ID="Label14" runat="server" Text="D.O.B"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <cc1:DatePicker ID="DatePicker1" runat="server" AutoPostBack="false" Width="100px" 
                        PaneWidth="150px"  
                        SelectedDate="" 
            onselecteddatechanged="DropDownList_Country_SelectedIndexChanged">
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
        <asp:Label ID="Label20" runat="server" Text="Country"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_Country" runat="server" Height="22px" AutoPostBack="True"
             Width="149px" 
            onselectedindexchanged="DropDownList_Country_SelectedIndexChanged">
           
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:Label ID="Label21" runat="server" Text="State"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_State" runat="server" Height="24px" AutoPostBack="True"
            Width="155px" 
            onselectedindexchanged="DropDownList_State_SelectedIndexChanged">
           
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label12" runat="server" Text="City"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_City" runat="server" Height="23px" AutoPostBack="True"
           Width="160px" 
            onselectedindexchanged="DropDownList_City_SelectedIndexChanged">
          
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label13" runat="server" Text="Area"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_Area" runat="server" Height="22px" AutoPostBack="True"
           Width="167px" 
            onselectedindexchanged="DropDownList_Area_SelectedIndexChanged">
            
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" Text="P G Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox_PGName" runat="server" Width="150px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label23" runat="server" Text="Availability"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox_PGAvailability" runat="server" 
            Width="150px"></asp:TextBox>
        <br />
        <asp:Label ID="Label24" runat="server" Text="PG Phnone No"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
            ID="TextBox_PGPhno" runat="server" 
            Width="150px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label25" runat="server" Text="Cost Per Day"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox_PGCostPerDay" runat="server" Width="150px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label27" runat="server" Text="Cost Per Month"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox_PGCostPerMonth" runat="server" Width="96px" 
            Height="20px"></asp:TextBox>
        <br />
        <asp:Label ID="Label30" runat="server" Text="P G Address"></asp:Label>
        <asp:TextBox ID="TextBox_PGAddress" runat="server" Height="51px" 
            style="margin-left: 53px" TextMode="MultiLine" Width="354px"></asp:TextBox>
&nbsp;&nbsp;<br />
        <br />
        <asp:Button ID="Button_SubmitPG" runat="server" Height="22px" 
            Text="Update" onclick="Button_SubmitPG_Click" />
        &nbsp;<br />
    
    </div>
    </form>
</body>
</html>
