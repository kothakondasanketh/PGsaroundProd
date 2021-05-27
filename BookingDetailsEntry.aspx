<%@ Page Language="C#"  Async="true" AutoEventWireup="true" CodeFile="BookingDetailsEntry.aspx.cs" MasterPageFile="~/HomeMaster.master" Inherits="Views_BookingDetailsEntry" %>
<%@ Register Assembly="SlimeeLibrary" Namespace="SlimeeLibrary" TagPrefix="cc1" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="c2">

    <section class="content-wrapper">
				
		
		
    	<div class="row">
		
        	 <div>
    
    
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
                    <table style="width: 100%">
                        <tr>
                            <td style="width: 284px">
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="No Of Persons :"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" 
                       Width="79px" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td style="width: 60px">
                                &nbsp;</td>
                            <td style="width: 184px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="1) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
                            </td>
                            <td style="width: 60px">
                    <asp:Label ID="Label14" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Width="50px"></asp:TextBox>
                            </td>
                            <td style="width: 184px">
                                <asp:Label ID="Label15" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="80px">
                        
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label16" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:Label ID="Label17" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="2) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" Width="150px"></asp:TextBox>
                            </td>
                            <td style="width: 60px">
                    <asp:Label ID="Label18" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox6" runat="server" Width="50px"></asp:TextBox>
                            </td>
                            <td style="width: 184px">
                                <asp:Label ID="Label19" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList3" runat="server" Width="80px">
                    
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label20" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox8" runat="server" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:Label ID="Label21" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="3) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox9" runat="server" Width="150px"></asp:TextBox>
                            </td>
                            <td style="width: 60px">
                    <asp:Label ID="Label22" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox10" runat="server" Width="50px"></asp:TextBox>
                            </td>
                            <td style="width: 184px">
                                <asp:Label ID="Label23" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList4" runat="server" Width="80px">
                    
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label24" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox12" runat="server" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:Label ID="Label25" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="4) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox13" runat="server" Width="150px"></asp:TextBox>
                            </td>
                            <td style="width: 60px">
                    <asp:Label ID="Label26" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox14" runat="server" Width="50px"></asp:TextBox>
                            </td>
                            <td style="width: 184px">
                                <asp:Label ID="Label27" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList5" runat="server" Width="80px">
                    
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="Label28" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox16" runat="server" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:Label ID="Label29" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="5) Name :"></asp:Label>
                    <asp:TextBox ID="TextBox17" runat="server" Width="150px"></asp:TextBox>
                            </td>
                            <td style="width: 60px">
                    <asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Age :"></asp:Label>
                    <asp:TextBox ID="TextBox18" runat="server" Width="50px"></asp:TextBox>
                            </td>
                            <td style="width: 184px">
                                <asp:Label ID="Label31" runat="server" Font-Bold="True" ForeColor="#275353" Text="Gender :"></asp:Label>
                    <asp:DropDownList ID="DropDownList6" runat="server" Width="80px">
                    
                        <asp:ListItem Value="1">Male</asp:ListItem>
                        <asp:ListItem Value="2">Female</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td>
                     <asp:Label ID="Label32" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="ID Number :"></asp:Label>
                    <asp:TextBox ID="TextBox20" runat="server" Width="100px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:RadioButton ID="RadioButton_Daily" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Daily" AutoPostBack="True" 
                        oncheckedchanged="RadioButton1_CheckedChanged" Checked="True" />
                    <asp:RadioButton ID="RadioButton_Monthly" runat="server" Font-Bold="True" 
                        ForeColor="#275353" Text="Monthly" AutoPostBack="True" 
                        oncheckedchanged="RadioButton2_CheckedChanged" />
                            </td>
                            <td style="width: 60px">
                                &nbsp;</td>
                            <td style="width: 184px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                     <asp:Label ID="Label_noofmonth" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="No Of Months:"></asp:Label>
                    <asp:DropDownList ID="DropDownList_noofmonths" runat="server"  
                        onselectedindexchanged="DropDownList_noofmonths_SelectedIndexChanged" 
                        style="margin-left: 16px" Width="61px" AutoPostBack="True">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                    </asp:DropDownList>
                            </td>
                            <td style="width: 60px">
                                &nbsp;</td>
                            <td style="width: 184px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:Label ID="Label33" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="From Date :"></asp:Label>
                    
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
                            </td>
                            <td style="width: 60px">
                    <asp:Label ID="Label34" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="To Date :"></asp:Label>
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
                            </td>
                            <td style="width: 184px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:Label ID="Label35" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="Total Cost : "></asp:Label>
                     
                    <asp:Label ID="Label_TotalCost" runat="server" Font-Bold="True" ForeColor="#275353" 
                        Text="nil"></asp:Label>
                            </td>
                            <td style="width: 60px">
                                &nbsp;</td>
                            <td style="width: 184px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 284px">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Confirm" Width="108px"  />
                      
   
   	                        </td>
                            <td style="width: 60px">
                                &nbsp;</td>
                            <td style="width: 184px">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                     <br />
                         <br />
                      
   
   	</div>
		
        	 </div>
             </section>
</asp:Content>
