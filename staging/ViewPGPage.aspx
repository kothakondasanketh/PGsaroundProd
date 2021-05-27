<%@ Page Language="C#"  Async="true" AutoEventWireup="true" CodeFile="ViewPGPage.aspx.cs" Inherits="Views_ViewPGPage" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .modalBackground
        {
             background-color: #Green;
        }
        .ModalPopupBG
{
    background-color: #666699;
    filter: alpha(opacity=50);
    opacity: 0.7;
}

.HellowWorldPopup
{
    min-width:200px;
    min-height:150px;
    background:white;
}
        .style1
        {
            width: 65%;
            margin-right: 0px;
        }
        .style2
        {
            width: 106px;
        }
        .style3
        {
            width: 51%;
        }
        .style9
        {
            width: 70px;
        }
        .style10
        {
            width: 499px;
        }
    </style>
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
     <script type="text/javascript">
    var markers = [
    <asp:Repeater ID="rptMarkers" runat="server">
    <ItemTemplate>
             {
                "title": '<%# Eval("PGName") %>',
                "lat": '<%# Eval("Latitude") %>',
                "lng": '<%# Eval("Longitude") %>',
                "description": '<%# Eval("PGAddress") %>'
            }
    </ItemTemplate>
    <SeparatorTemplate>
        ,
    </SeparatorTemplate>
    </asp:Repeater>
    ];
    </script>
    <script type="text/javascript">

        window.onload = function () {
            var mapOptions = {
                center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var infoWindow = new google.maps.InfoWindow();
            var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);
            for (i = 0; i < markers.length; i++) {
                var data = markers[i]
                var myLatlng = new google.maps.LatLng(data.lat, data.lng);
                var marker = new google.maps.Marker({
                    position: myLatlng,
                    map: map,
                    title: data.title
                });
                (function (marker, data) {
                    google.maps.event.addListener(marker, "click", function (e) {
                        infoWindow.setContent(data.description);
                        infoWindow.open(map, marker);
                    });
                })(marker, data);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                    <table class="style1">
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label8" runat="server" Text="P G Name :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label9" runat="server" Text="Address :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label10" runat="server" Text="Phone No :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label11" runat="server" Text="Availability :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label12" runat="server" Text="Cost Per Day :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label13" runat="server" Text="Cost Per Month :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                <asp:Label ID="Label14" runat="server" Text="Area :"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                <asp:CheckBox ID="CheckBox1" runat="server" />
                                <asp:CheckBox ID="CheckBox2" runat="server" />
                                <asp:CheckBox ID="CheckBox3" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                <asp:CheckBox ID="CheckBox4" runat="server" />
                                <asp:CheckBox ID="CheckBox5" runat="server" />
                                <asp:CheckBox ID="CheckBox6" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                <asp:CheckBox ID="CheckBox7" runat="server" />
                                <asp:CheckBox ID="CheckBox8" runat="server" />
                                <asp:CheckBox ID="CheckBox9" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                <asp:CheckBox ID="CheckBox10" runat="server" />
                                <asp:CheckBox ID="CheckBox11" runat="server" />
                            </td>
                        </tr>
                    </table>
    
                   <%-- <table class="style3">
                        <tr>
                            <td class="style5">
                                <asp:Image ID="Image1" runat="server" Height="190px" Width="269px" />
                            </td>
                            <td class="style6">
                                <asp:Image ID="Image2" runat="server" Height="182px" Width="252px" />
                            </td>
                            <td class="style7">
                                <asp:Image ID="Image3" runat="server" Height="178px" Width="240px" />
                            </td>
                            <td class="style8">
                                <asp:Image ID="Image4" runat="server" Height="171px" Width="234px" />
                            </td>
                            <td class="style4">
                                <asp:Image ID="Image5" runat="server" Height="173px" Width="230px" />
                            </td>
                        </tr>
                    </table>--%>
                     <table class="style3">
                         <tr>
                             <td class="style9">
                                 <asp:ImageButton ID="ImageButton_Left" runat="server" Height="66px" 
                                     ImageUrl="~/Images/LeftArrow.jpg" Width="65px" />
                             </td>
                             <td class="style10">
                                <asp:Image ID="Image6" runat="server" Height="281px" Width="498px" />
                             </td>
                             <td>
                                 <asp:ImageButton ID="ImageButton_Right" runat="server" Height="66px" 
                                     ImageUrl="~/Images/RightArrow.jpg" Width="65px" />
                             </td>
                         </tr>
                         <tr>
                             <td class="style9">
                                 &nbsp;</td>
                             <td class="style10">
                                 <asp:Button ID="Button_Play" runat="server" Text="Play" />
                             </td>
                             <td>
                                 &nbsp;</td>
                         </tr>
                    </table>
                    <br />
                    <asp:ToolkitScriptManager ID="SCMGR" runat="server"></asp:ToolkitScriptManager>
                    <div id="dvMap" style="height: 350px; width: 650px">
                    </div>
                    <br />
                    <br />
       
      
             <asp:SlideShowExtender ID="SlideShowExtender" runat="server" TargetControlID="Image6"
                SlideShowServiceMethod="GetImages"  
                AutoPlay="true" PlayInterval="1000" Loop="true" PlayButtonID="Button_Play" StopButtonText="Stop" SlideShowAnimationType="FadeInOut"
                PlayButtonText="Play" NextButtonID="ImageButton_Right" PreviousButtonID="ImageButton_Left"></asp:SlideShowExtender>
                    <a href="javascript: history.go(-1)">Go Back</a>
                    <br />
                    <br />
   
        
    </div>
    </form>
</body>
</html>
