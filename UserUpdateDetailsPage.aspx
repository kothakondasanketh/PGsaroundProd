<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="UserUpdateDetailsPage.aspx.cs" MasterPageFile="~/HomeMaster.master" Inherits="Styles_UserUpdateDetailsPage" %>

<%@ Register assembly="SlimeeLibrary" namespace="SlimeeLibrary" tagprefix="cc1" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="Div2" class="row"  >
    <br />
      <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox_Username" runat="server" Width="200px" ReadOnly="True" 
            Height="30px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox_Name" runat="server" 
            Width="200px" Height="30px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Passwd" runat="server" 
            Width="200px" AutoPostBack="True" Height="30px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label15" runat="server" Text="Email ID"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Emailid" runat="server" Width="200px" Height="30px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Passwdcnfm" runat="server" 
            Width="200px" AutoPostBack="True" Height="30px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label16" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox_Age" runat="server" Width="200px" Height="30px"></asp:TextBox>
        <br />
        <asp:Label ID="Label17" runat="server" Text="Gender"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList_Gender" runat="server" Height="33px" 
            Width="111px">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label18" runat="server" Text="Phone No"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox_Phno" runat="server" Width="200px" Height="30px"></asp:TextBox>
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
        <asp:DropDownList ID="DropDownList_Country" runat="server" Height="33px" AutoPostBack="True"
          Width="180px" 
            onselectedindexchanged="DropDownList_Country_SelectedIndexChanged">
           
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:Label ID="Label21" runat="server" Text="State"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_State" runat="server" Height="33px" AutoPostBack="True"
           Width="180px" 
            onselectedindexchanged="DropDownList_State_SelectedIndexChanged">
           
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label12" runat="server" Text="City"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_City" runat="server" Height="33px" AutoPostBack="True"
            Width="180px" 
            onselectedindexchanged="DropDownList_City_SelectedIndexChanged">
          
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label13" runat="server" Text="Area"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList_Area" runat="server" Height="33px" AutoPostBack="True"
             Width="180px" 
            onselectedindexchanged="DropDownList_Area_SelectedIndexChanged">
            
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button_Submit" runat="server" Height="30px"
            Text="Update" onclick="Button_Submit_Click" Width="126px" />
        &nbsp;<br />
    
    </div>

</asp:Content>