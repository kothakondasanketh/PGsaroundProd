<%@ Page Title="" Language="C#" Async="true"  AutoEventWireup="true" CodeFile="ClientRegPage.aspx.cs" Inherits="Views_ClientRegPage" %>
<%@ Register assembly="SlimeeLibrary" namespace="SlimeeLibrary" tagprefix="cc1" %>

<html xmlns="http://www.w3.org/1999/xhtml">


 


    <head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        #I1
        {
            width: 1294px;
        }
        #Frame1
        {
            width: 1296px;
            height: 340px;
        }
        #Div2
        {
            height: 311px;
            width: 868px;
            margin-top: 0px;
        }
        #Div3
        {
            height: 159px;
        }
        #FORM1
        {
            width: 869px;
            height: 314px;
        }
    </style>
    </head>
  
   
     <form id="Form1" runat="server" enctype="multipart/form-data">
    <div id="Div2" runat="server" >
    
        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox_Username" runat="server" Width="150px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Owner Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox_Name" runat="server" 
            Width="150px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Passwd" runat="server" 
            Width="150px" AutoPostBack="true"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label15" runat="server" Text="Email ID"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Emailid" runat="server" Width="150px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Passwdcnfm" runat="server" 
            Width="150px" AutoPostBack="true"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
        <cc1:DatePicker ID="DatePicker1" runat="server" AutoPostBack="true" Width="100px" 
                        PaneWidth="150px"  
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
  
 

                     
        <br />
        <asp:Label ID="Label20" runat="server" Text="Country"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_Country" runat="server" Height="22px" AutoPostBack="True"
            onselectedindexchanged="DropDownList7_SelectedIndexChanged" Width="149px">
           
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:Label ID="Label21" runat="server" Text="State"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_State" runat="server" Height="24px" AutoPostBack="True"
            onselectedindexchanged="DropDownList_State_SelectedIndexChanged" 
            Width="155px">
           
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label12" runat="server" Text="City"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_City" runat="server" Height="23px" AutoPostBack="True"
            onselectedindexchanged="DropDownList_City_SelectedIndexChanged" 
            Width="160px">
          
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
        <br />
        <asp:Label ID="Label32" runat="server" Text="PG Serving"></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList_Gender0" runat="server" Height="21px" 
             Width="111px" AutoPostBack="True">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Boys</asp:ListItem>
            <asp:ListItem>Girls</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" Text="P G Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox_PGName" runat="server" Width="150px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label23" runat="server" Text="Availability"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox_PGAvailability" runat="server" 
            Width="150px"></asp:TextBox>
        <br />
        <asp:Label ID="Label24" runat="server" Text="PG Phnone No"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
            ID="TextBox_PGPhno" runat="server" 
            Width="150px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label25" runat="server" Text="Cost Per Day"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox_PGCostPerDay" runat="server" Width="150px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:Label ID="Label27" runat="server" Text="Cost Per Month"></asp:Label>
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_PGCostPerMonth" runat="server" Width="150px"></asp:TextBox>
        <br />
        <asp:Label ID="Label30" runat="server" Text="P G Address"></asp:Label>
        <asp:TextBox ID="TextBox_PGAddress" runat="server" Height="51px" 
            style="margin-left: 53px" TextMode="MultiLine" Width="354px"></asp:TextBox>
&nbsp;&nbsp;<br />
        <br />
        <asp:Label ID="Label34" runat="server" Text="Country"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_Country0" runat="server" Height="22px" AutoPostBack="True"
            onselectedindexchanged="DropDownList7_SelectedIndexChanged" Width="149px">
           
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label35" runat="server" Text="State"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_State0" runat="server" Height="24px" AutoPostBack="True"
          
            Width="155px" 
            onselectedindexchanged="DropDownList_State0_SelectedIndexChanged">
           
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label36" runat="server" Text="City"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_City0" runat="server" Height="23px" AutoPostBack="True"
           
            Width="160px" 
            onselectedindexchanged="DropDownList_City0_SelectedIndexChanged">
          
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label37" runat="server" Text="Area"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_Area0" runat="server" Height="22px" AutoPostBack="True"
            Width="167px" 
            onselectedindexchanged="DropDownList_Area0_SelectedIndexChanged">
            
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label31" runat="server" Text="Animities" Font-Bold="True"></asp:Label>
        <br />
        &nbsp;<br />
        <asp:CheckBox ID="CheckBox_AC" runat="server" Text="AC" 
            oncheckedchanged="CheckBox_AC_CheckedChanged" AutoPostBack="True" />
        &nbsp;<asp:CheckBox ID="CheckBox_NonAc" runat="server" Text=" Non AC" 
            oncheckedchanged="CheckBox_NonAc_CheckedChanged" AutoPostBack="True" />
        &nbsp;<asp:CheckBox ID="CheckBox_NIFood" runat="server" 
            Text="North Indian Food" oncheckedchanged="CheckBox_NIFood_CheckedChanged" 
            AutoPostBack="True" />
        &nbsp;<asp:CheckBox ID="CheckBox_SIFood" runat="server" 
            Text="South Indian Food" oncheckedchanged="CheckBox_SIFood_CheckedChanged" 
            AutoPostBack="True" />
        &nbsp;<asp:CheckBox ID="CheckBox_Internet" runat="server" Text="Internet/Wifi" 
            oncheckedchanged="CheckBox_Internet_CheckedChanged" AutoPostBack="True" />
        &nbsp;<asp:CheckBox ID="CheckBox_Hotwater" runat="server" Text="Hot Water" 
            oncheckedchanged="CheckBox_Hotwater_CheckedChanged" AutoPostBack="True" />
        &nbsp;<asp:CheckBox ID="CheckBox_TV" runat="server" Text="TV" 
            oncheckedchanged="CheckBox_TV_CheckedChanged" AutoPostBack="True" />
        <br />
        <br />
&nbsp;<asp:CheckBox ID="CheckBox_Food3times" runat="server" Text="3 Times Food" 
            oncheckedchanged="CheckBox_Food3times_CheckedChanged" 
            AutoPostBack="True" />
        &nbsp;
        &nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox_NoFood" runat="server" Text="No Food" 
            oncheckedchanged="CheckBox_NoFood_CheckedChanged" AutoPostBack="True" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:CheckBox ID="CheckBox_Parkingspace" runat="server" Text="Parking Space" 
            oncheckedchanged="CheckBox_Parkingspace_CheckedChanged" 
            AutoPostBack="True" />
        &nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox_Laundry" runat="server" Text="Laundry" 
            oncheckedchanged="CheckBox_Laundry_CheckedChanged" AutoPostBack="True" />
        <br />
        <br />
        <asp:Label ID="Label38" runat="server" Text="PG Profile Image"></asp:Label>
&nbsp;
         <asp:fileupload ID="Fileuploaderprofilepic" runat="server" Width="220px" 
            Height="21px" ></asp:fileupload>
        
        
        <br />
        <br />
        <asp:Label ID="Label39" runat="server" Text="Image 1"></asp:Label>
         &nbsp;
         <asp:fileupload ID="Fileuploaderimg1" runat="server" Width="220px" 
            Height="21px"></asp:fileupload>
        
        
&nbsp;
        <br />
        <br />
        <asp:Label ID="Label40" runat="server" Text="Image 2"></asp:Label>
&nbsp;
         <asp:fileupload ID="Fileuploaderimg2" runat="server" Width="220px" 
            Height="21px"></asp:fileupload>
        
        
        <br />
        
        
        <br />
        <asp:Label ID="Label41" runat="server" Text="Image 3"></asp:Label>
&nbsp;
         <asp:fileupload ID="Fileuploaderimg3" runat="server" Width="220px" 
            Height="21px"></asp:fileupload>
        
        
        <br />
        
        
        <br />
        <asp:Label ID="Label42" runat="server" Text="Image 4"></asp:Label>
&nbsp;
         <asp:fileupload ID="Fileuploaderimg4" runat="server" Width="220px" 
            Height="21px"></asp:fileupload>
        
        
        <br />
        
        
        <br />
        <asp:Label ID="Label43" runat="server" Text="Image 5"></asp:Label>
&nbsp;
         <asp:fileupload ID="Fileuploaderimg5" runat="server" Width="220px" 
            Height="21px"></asp:fileupload>
        
        
        <br />
        
        
        <br />
&nbsp;
        <br />
        <asp:Button ID="Button_SubmitPG" runat="server" Height="22px" onclick="Button_SubmitPG_Click" 
            Text="Submit" />
        &nbsp;<asp:Button ID="Button_SubmitPG0" runat="server" Height="22px" onclick="Button_SubmitPG0_Click" 
            Text="Back" />
        <br />
        <br />
    
    </div>
        </form>
    
        
    
    
 
</html>



