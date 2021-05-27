<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeFile="BookingSearchPage.aspx.cs" MasterPageFile="~/HomeMaster.master" Inherits="Views_BookingSearchPage" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1"  runat="server" ID="C1">

<asp:UpdatePanel runat="server">
    <ContentTemplate>
    <section class="content-wrapper">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
 
    
   
				
		
		
    	<div class="content-wrapper" >
		
        	 <div>
                           <table>
                           <tr>
                           <td>
                           
                                 <table style="width: 104%">
                                 
                                   
                                 
                                   
                                <tr>
                                <td style="width: 100px"> Gender:</td>
                                    <td>
                                       <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                                            Font-Bold="True" onselectedindexchanged="DropDownList5_SelectedIndexChanged" 
                                            Width="180px">
                                            <asp:ListItem Value="1">Men</asp:ListItem>
                                            <asp:ListItem Value="2">Women</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                 <td style="width: 100px">Select State:</td>
    
                                        
                                    <td style="width: 184px">
    
                                       <asp:DropDownList ID="DropDownList2" runat="server" 
                                            AutoPostBack="True" Font-Bold="True" 
                                            onselectedindexchanged="DropDownList2_SelectedIndexChanged" Width="180px">
                                            <asp:ListItem Selected="True">Select</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                <td style="width: 100px"> Select City:</td>
                                    <td style="width: 184px">
                                       <asp:DropDownList ID="DropDownList3" runat="server" 
                                            AutoPostBack="True" Font-Bold="True" 
                                            onselectedindexchanged="DropDownList3_SelectedIndexChanged" Width="180px">
                                            <asp:ListItem Selected="True">Select</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                <td style="width: 100px"> Select Area:</td>
                                    <td style="width: 184px">
                                       <asp:DropDownList ID="DropDownList4" runat="server" 
                                            AutoPostBack="True" Font-Bold="True" 
                                            onselectedindexchanged="DropDownList4_SelectedIndexChanged" Width="180px">
                                            <asp:ListItem Selected="True">Select</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                              
                    </table>
                           </td>
                            <td>
                           <table class="style1">
                        <tr>
                            <td>
                            <p><asp:Label ID="lbl_Status" runat="server" Font-Bold="True" Font-Overline="False" 
                                    Font-Strikeout="False" Font-Underline="False" ForeColor="#394653"></asp:Label></p>
                   <asp:GridView  ID="GridView1" runat="server"  
                                    onselectedindexchanged="GridView1_SelectedIndexChanged"  PageSize="10" 
                                    AutoGenerateColumns="false" AllowSorting="True" 
                                    onrowcommand="GridView1_RowCommand" Width="150px">
                       <%--  BackColor="Teal" 
                        BorderWidth="3px" CaptionAlign="Top" CellPadding="4" 
                        Font-Bold="True" Font-Italic="False" Font-Size="Medium" GridLines="Horizontal" 
                        Height="174px" HorizontalAlign="Justify" style="margin-top: 0px" 
                        Width="800px"  --%>
                       
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
                   <asp:TemplateField>

  <ItemTemplate>
    <asp:LinkButton ID="ViewDetailsButton" runat="server"  
      CommandName="ViewDetails" Font-Bold="True"
      CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
      Text="ViewDetails" ForeColor="#006666"  Font-Underline="True"   />
  </ItemTemplate> 
  </asp:TemplateField>
    <asp:TemplateField>
      <ItemTemplate>
       <asp:LinkButton ID="ViewDetailsButtonbook" runat="server"  
      CommandName="BookDetails" 
      CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
      Text="Book" ForeColor="#006666" Font-Bold="True"   Font-Underline="True"  />

      </ItemTemplate> 
      </asp:TemplateField>
                           <asp:BoundField DataField="UserID" HeaderText="PG ID" />
                        <asp:BoundField DataField="PGName" HeaderText="PGName" />
                        <asp:BoundField DataField="PGAddress" HeaderText="PGAddress"/>
                         <asp:BoundField DataField="PGPhno" HeaderText="PGPhno"/>
                         <asp:BoundField DataField="Avialability" HeaderText="Avialability"/>
                        <%-- <asp:BoundField DataField="CostPerDay" HeaderText="CostPerDay"/>
                         <asp:BoundField DataField="CostPerMonth" HeaderText="CostPerMonth"/>
                        <asp:BoundField DataField="Area" HeaderText="Area"/>--%>
                        </Columns>
                    </asp:GridView>
    
                            </td>
                        </tr>
                    </table>
                           </td>
                           </tr>
                            </table>
                          

                    
    
                    <br />
                    <asp:ListView ID="ListView1" runat="server"   >
                    
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
                  <asp:Button ID="Button1" runat="server" Text="Proceed" 
                     ToolTip="Press here to Continue" Width="174px" 
                        onclick="Button1_Click" />
                 
                    

  
				
		
		
    	</div>
		
        	 </div>
            
    
    
             </section>
             </ContentTemplate>
    
    </asp:UpdatePanel>
             
</asp:Content>
