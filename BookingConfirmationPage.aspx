<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="BookingConfirmationPage.aspx.cs" MasterPageFile="~/HomeMaster.master" Inherits="Views_BookingConfirmationPage" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="c3" >

	  <section class="content-wrapper">
					
		
		<div class="row">
		
			 <div>
		<table class="style1">
			<tr>
				<td class="style2">
					<asp:Label ID="Label19" runat="server" Font-Bold="True" 
						Font-Names="Arial Black" Font-Size="Large" Font-Underline="True" 
						ForeColor="#FF9900" Text="PG Details "></asp:Label>
				</td>
				<td class="style12">
					<asp:Label ID="Label_OrderSubmit" runat="server" Font-Bold="True" 
						Font-Names="Arial Black" Font-Size="Small" Font-Underline="True" 
						ForeColor="Red"></asp:Label>
				</td>
			</tr>
		</table>
	
		<br />
	
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
		<asp:Label ID="Label20" runat="server" Font-Bold="True" 
			Font-Names="Arial Black" Font-Size="Large" Font-Underline="True" 
			ForeColor="#FF9900" Text="User Details "></asp:Label>
		<br />
	
					<br />
	
					<asp:ListView ID="ListView2" runat="server"    >
					
					  <ItemTemplate>
		  <tr id="Tr2" runat="server" >
		   
			<td>
			 <asp:Label ID="Label12"  runat="Server" Text='Name: ' ForeColor="#275353" 
					Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="PGName0" runat="Server" Text='<%#Eval("Name") %>' 
					ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			</td>
			 
			<td valign="top">
			 <asp:Label ID="Label13" runat="Server" Text=', Address: ' ForeColor="#275353" 
					Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="Address0" runat="Server" Text='<%#Eval("Address") %>' 
					ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			</td>
			 
			 <td valign="top">
			  <asp:Label ID="Label14" runat="Server" Text=', Phone No: ' ForeColor="#275353" 
					 Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="PhoneNo" runat="Server" Text='<%#Eval("PhoneNo") %>' 
					 ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>

			</td>
			
			 <td valign="top">
			  <asp:Label ID="Label15" runat="Server" Text=', Email ID: ' ForeColor="#275353" 
					 Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="EmailID" runat="Server" Text='<%#Eval("EmailID") %>' 
					 ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			</td>
			 
			 <td valign="top">
			  <asp:Label ID="Label16" runat="Server" Text=', Age: ' 
					 ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="Age" runat="Server" Text='<%#Eval("Age") %>' 
					 ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			</td>
			 
			  <td valign="top">
			   <asp:Label ID="Label17" runat="Server" Text=', City: ' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="City" runat="Server" Text='<%#Eval("City") %>' 
					  ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>
			
			  <td valign="top">
			   <asp:Label ID="Label18" runat="Server" Text=', Area: '  ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			  <asp:Label ID="Area0" runat="Server" Text='<%#Eval("Area") %>' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>
		  </tr>
		</ItemTemplate>
					</asp:ListView>
	
		<br />
		<br />
		<asp:Label ID="Label28" runat="server" Font-Bold="True" 
			Font-Names="Arial Black" Font-Size="Large" Font-Underline="True" 
			ForeColor="#FF9900" Text="Order Details "></asp:Label>
		<br />
		<br />
	
				  <%--  <asp:ListView ID="ListView3" runat="server" 
			onselectedindexchanged="ListView3_SelectedIndexChanged"    >
					
					  <ItemTemplate>
		  <tr id="Tr3" runat="server" >
		   
		 
			 
			<td valign="top">
			 <asp:Label ID="Label22" runat="Server" Text='FromDate: ' ForeColor="#275353" 
					Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="FromDate" runat="Server" Text='<%#Eval("FromDate") %>' 
					ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			</td>
			 
			 <td valign="top">
			  <asp:Label ID="Label23" runat="Server" Text=', ToDate: ' ForeColor="#275353" 
					 Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="ToDate" runat="Server" Text='<%#Eval("ToDate") %>' 
					 ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>

			</td>
			
			 <td valign="top">
			  <asp:Label ID="Label24" runat="Server" Text=', NoOfPersons: ' ForeColor="#275353" 
					 Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="NoOfPersons" runat="Server" Text='<%#Eval("NoOfPersons") %>' 
					 ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			</td>
			 
			 <td valign="top">
			  <asp:Label ID="Label25" runat="Server" Text=', TotalNoOfDays: ' 
					 ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="TotalNoOfDays" runat="Server" Text='<%#Eval("TotalNoOfDays") %>' 
					 ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large"/>
			</td>
			 
			  <td valign="top">
			   <asp:Label ID="Label26" runat="Server" Text=', TotalCost: ' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large"/>
			  <asp:Label ID="TotalCost" runat="Server" Text='<%#Eval("TotalCost") %>' 
					  ForeColor="#275353" Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>
			
			  <td valign="top">
			   <asp:Label ID="Label27" runat="Server" Text=', Status: '  ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			  <asp:Label ID="Status" runat="Server" Text='<%#Eval("Status") %>' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>

		  

			 <td valign="top">
			   <asp:Label ID="Label3" runat="Server" Text=', Area: '  ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			  <asp:Label ID="Label4" runat="Server" Text='<%#Eval("Area") %>' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>

			   <td valign="top">
			   <asp:Label ID="Label1" runat="Server" Text=', User1: '  ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			  <asp:Label ID="User1" runat="Server" Text='<%#Eval("User1") %>' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>
			   <td valign="top">
			   <asp:Label ID="Label2" runat="Server" Text=', User2: '  ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			  <asp:Label ID="Label29" runat="Server" Text='<%#Eval("User2") %>' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>
			   <td valign="top">
			   <asp:Label ID="Label30" runat="Server" Text=', User3: '  ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			  <asp:Label ID="Label31" runat="Server" Text='<%#Eval("User3") %>' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>
			   <td valign="top">
			   <asp:Label ID="Label32" runat="Server" Text=', User4: '  ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			  <asp:Label ID="Label33" runat="Server" Text='<%#Eval("User4") %>' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>
			   <td valign="top">
			   <asp:Label ID="Label34" runat="Server" Text=', User5: '  ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			  <asp:Label ID="Label35" runat="Server" Text='<%#Eval("User5") %>' ForeColor="#275353" 
					  Enabled="False" Font-Bold="True" Font-Size="Large" />
			</td>
		  </tr>
		</ItemTemplate>
					</asp:ListView>--%>
	
		<table class="style1">
			<tr>
				<td class="style14">
					<asp:Label ID="Label42" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="From Date:" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_fromdate" runat="server" Font-Bold="True" 
						ForeColor="#275353" Font-Size="Large"></asp:Label>
					</td>
				<td class="style13">
					<asp:Label ID="Label49" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="No Of Persons:" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_noofpersons" runat="server" Font-Bold="True" 
						ForeColor="#275353" Font-Size="Large"></asp:Label>
					</td>
				<td class="style15">
					<asp:Label ID="Label50" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="Total No Of Days:" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_totaldays" runat="server" Font-Bold="True" 
						ForeColor="#275353" Font-Size="Large"></asp:Label>
					</td>
				<td>
					<asp:Label ID="Label45" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="Total Cost:" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_totalcost" runat="server" Font-Bold="True" 
						ForeColor="#275353" Font-Size="Large"></asp:Label>
					</td>
			</tr>
			<tr>
				<td class="style14">
					<asp:Label ID="Label43" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="To Date:" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label43_todate" runat="server" Font-Bold="True" 
						ForeColor="#275353" Font-Size="Large"></asp:Label>
					</td>
				<td class="style13">
					<asp:Label ID="Label47" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="Status:" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_status" runat="server" Font-Bold="True" 
						ForeColor="#275353" Font-Size="Large"></asp:Label>
					</td>
				<td class="style15">
					<asp:Label ID="Label48" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="Area:" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_area" runat="server" Font-Bold="True" ForeColor="#275353" 
						Font-Size="Large"></asp:Label>
					</td>
				<td>
					&nbsp;</td>
			</tr>
		</table>
		<br />
		<div id="User1div" runat="server">
					<asp:Label ID="Label51" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="User 1" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_usr1" runat="server" Font-Bold="True" 
				ForeColor="#275353" Font-Size="Large"></asp:Label>
		</div>
		<div id="User2div" runat="server">
					<asp:Label ID="Label76" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="User 2" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_usr2" runat="server" Font-Bold="True" 
				ForeColor="#275353" Font-Size="Large"></asp:Label>
		</div>
		<div id="User3div" runat="server">
					<asp:Label ID="Label77" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="User 3" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_usr3" runat="server" Font-Bold="True" 
				ForeColor="#275353" Font-Size="Large"></asp:Label>
		</div>
		<div id="User4div" runat="server">
					<asp:Label ID="Label78" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="User 4" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_usr4" runat="server" Font-Bold="True" 
				ForeColor="#275353" Font-Size="Large"></asp:Label>
		</div>
		<div id="User5div" runat="server">
					<asp:Label ID="Label79" runat="server" Font-Bold="True" ForeColor="#275353" 
						Text="User 5" Font-Size="Large"></asp:Label>
					<asp:Label ID="Label_usr5" runat="server" Font-Bold="True" 
				ForeColor="#275353" Font-Size="Large"></asp:Label>
		</div>
		<br />
		<br />
		&nbsp;<asp:Label ID="Label_Paymenttype" runat="server" 
			Text="Select the payment type : "></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" 
			onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="205px" 
			AutoPostBack="True">
			<asp:ListItem>Select</asp:ListItem>
			<asp:ListItem Value="1">Cash On Delivery</asp:ListItem>
			<asp:ListItem Value="2">Credit Card Payment</asp:ListItem>
		</asp:DropDownList>
		<br />
		<br />
	<div id="CCpaymentDiv" runat="server">
		<table class="style1">
			<tr>
				<td class="style4">
					<asp:Label ID="Label36" runat="server" Text="Card No"></asp:Label>
				</td>
				<td class="style5">
					<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" 
						Height="22px" Width="241px"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="style6">
					<asp:Label ID="Label37" runat="server" Text="Expiry Date"></asp:Label>
				</td>
				<td class="style7">
					<asp:Label ID="Label38" runat="server" Text="Month"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server"  Width="47px">
						<asp:ListItem>1</asp:ListItem>
						 <asp:ListItem>2</asp:ListItem>
							<asp:ListItem>3</asp:ListItem>
							   <asp:ListItem>4</asp:ListItem>
								  <asp:ListItem>5</asp:ListItem>
									 <asp:ListItem>6</asp:ListItem>
										<asp:ListItem>7</asp:ListItem>
										   <asp:ListItem>8</asp:ListItem>
											  <asp:ListItem>9</asp:ListItem>
												 <asp:ListItem>10</asp:ListItem>
						 <asp:ListItem>11</asp:ListItem>
						   <asp:ListItem>12</asp:ListItem>
							<asp:ListItem>13</asp:ListItem>
							   <asp:ListItem>14</asp:ListItem>
								  <asp:ListItem>15</asp:ListItem>
									 <asp:ListItem>16</asp:ListItem>
										<asp:ListItem>17</asp:ListItem>
										   <asp:ListItem>18</asp:ListItem>
											  <asp:ListItem>19</asp:ListItem>
												 <asp:ListItem>20</asp:ListItem>
												 
						   <asp:ListItem>21</asp:ListItem>
							<asp:ListItem>22</asp:ListItem>
							   <asp:ListItem>23</asp:ListItem>
								  <asp:ListItem>24</asp:ListItem>
									 <asp:ListItem>25</asp:ListItem>
										<asp:ListItem>26</asp:ListItem>
										   <asp:ListItem>27</asp:ListItem>
											  <asp:ListItem>28</asp:ListItem>
												 <asp:ListItem>29</asp:ListItem>
												 <asp:ListItem>30</asp:ListItem>
												 <asp:ListItem>31</asp:ListItem>

					</asp:DropDownList>
&nbsp;
					<asp:Label ID="Label39" runat="server" Text="Year"></asp:Label>
					<asp:DropDownList ID="DropDownList3" runat="server"  Width="47px">
					<asp:ListItem>1</asp:ListItem>
						 <asp:ListItem>2</asp:ListItem>
							<asp:ListItem>3</asp:ListItem>
							   <asp:ListItem>4</asp:ListItem>
								  <asp:ListItem>5</asp:ListItem>
									 <asp:ListItem>6</asp:ListItem>
										<asp:ListItem>7</asp:ListItem>
										   <asp:ListItem>8</asp:ListItem>
											  <asp:ListItem>9</asp:ListItem>
												 <asp:ListItem>10</asp:ListItem>
												   <asp:ListItem>11</asp:ListItem>
													 <asp:ListItem>12</asp:ListItem>
					</asp:DropDownList>
				</td>
			</tr>
			<tr>
				<td class="style8">
					<asp:Label ID="Label40" runat="server" Text="CVV"></asp:Label>
				</td>
				<td class="style9">
					<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" 
						Height="22px" TextMode="Password" Width="52px"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="style10">
					<asp:Label ID="Label41" runat="server" Text="Name On Card"></asp:Label>
				</td>
				<td class="style11">
					<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 0px" 
						Height="22px" Width="241px"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="style3">
					&nbsp;</td>
				<td>
					<asp:Label ID="Label_DisplayMsg" runat="server" ForeColor="Red" 
						ViewStateMode="Disabled"></asp:Label>
				</td>
			</tr>
		</table>
		</div>
	
		<asp:Button ID="Button_PlaceOrder" runat="server" Text="Place Order" Width="144px" 
			onclick="Button1_Click" />
	</div>
		
			 </div>
			 </section>
 </asp:Content>