<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pgsaround.aspx.cs" Inherits="pgsaround" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<head>
<meta charset="utf-8" />
<meta name="format-detection" content="telephone=no" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<title>PG's Around</title>

<!-- ////////////////////////////////// -->
<!-- //     Retina Bookmark Icon     // -->
<!-- ////////////////////////////////// -->
<link rel="apple-touch-icon-precomposed" href="apple-icon.png"/>

<!-- ////////////////////////////////// -->
<!-- //     Retina Bookmark Icon     // -->
<!-- ////////////////////////////////// -->
<link rel="apple-touch-icon-precomposed" href="apple-icon.png"/>

<!-- ////////////////////////////////// -->
<!-- //      Stylesheets Files       // -->
<!-- ////////////////////////////////// -->
<link rel="stylesheet" href="css/style.css"/>
<link rel="stylesheet" href="css/media.css"/>
<link rel="stylesheet" href="css/revolution.css" media="screen"/>
<link rel="stylesheet" href="css/media-slideshow.css" media="screen"/>
<link rel="stylesheet" href="css/noscript.css" media="screen,all" id="noscript"/>

<!-- ////////////////////////////////// -->
<!-- //     Google Webfont Files     // -->
<!-- ////////////////////////////////// -->
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto:400,300,700,500,900"/>
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Open+Sans"/>
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Pacifico"/>

<!-- ////////////////////////////////// -->
<!-- //        Favicon Files         // -->
<!-- ////////////////////////////////// -->
<link rel="shortcut icon" href="images/favicon.ico"/>

<!-- ////////////////////////////////// -->
<!-- //      Javascript Files        // -->
<!-- ////////////////////////////////// -->
 <script type="text/javascript" language="javascript">     window.history.forward(1)</script>
<script src="../../ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
<script src="js/jquery.easing-1.3.min.js"></script>
<script src="js/modernizr.js"></script>
<script src="js/superfish.js"></script>
<script src="js/jquery.carouFredSel-6.2.1-packed.js"></script>
<script src="js/jquery.themepunch.plugins.min.js"></script>
<script src="js/jquery.themepunch.revolution.min.js"></script>
<script src="js/mediaelement-and-player.min.js"></script>
<script src="js/jquery.fancyboxe45f.js?v=2.0.6"></script>
<script src="js/jquery.fancybox-media2c70.js?v=1.0.3"></script>
<script src="js/jquery.donutchart.js"></script>
<script src="js/jflickrfeed.min.js"></script>
<script src="js/jquery.twitter.js"></script>
<script src="js/accordion-functions.js" ></script>
<script src="js/theme-functions.js"></script>
<script src="js/jquery.retina.js"></script>
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
      if (navigator.geolocation) {
          navigator.geolocation.getCurrentPosition(success);
      } else {
          alert("Geo Location is not supported on your current browser!");
      }
      function success(position) {
          var lat = position.coords.latitude;
          var long = position.coords.longitude;
          var city = position.coords.locality;

          var myLatlng = new google.maps.LatLng(lat, long);
          var myOptions = {
              center: myLatlng,
              zoom: 12,
              mapTypeId: google.maps.MapTypeId.ROADMAP
          };
          var map = new google.maps.Map(document.getElementById("Panel_Map"), myOptions);
          var marker = new google.maps.Marker({
              position: myLatlng,
              title: "lat: " + lat + " long: " + long
          });

          marker.setMap(map);
          var hdnfldVariable = document.getElementById('hdnfldVariablelat');
          hdnfldVariable.value = lat;
          var hdnfldVariable = document.getElementById('hdnfldVariablelong');
          hdnfldVariable.value = long;
          var infowindow = new google.maps.InfoWindow({ content: "<b>User Address</b><br/> Latitude:" + lat + "<br /> Longitude:" + long + "" });
          infowindow.open(map, marker);
      }
</script>
    <script type="text/javascript">

        window.onload = function () {
            var mapOptions = {
                center: new google.maps.LatLng(markers[0].lat, markers[0].lng),
                zoom: 8,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var infoWindow = new google.maps.InfoWindow();
            var map = new google.maps.Map(document.getElementById("Panel_Map_lookaround"), mapOptions);
            for (i = 0; i < markers.length; i++) {
                var data = markers[i]
                var myLatlng = new google.maps.LatLng(data.lat, data.lng);
                var marker = new google.maps.Marker({
                    position: myLatlng,
                    map: map,
                    title: data.title,
                    icon: 'http://www.pgsaround.com/images/Map_Pointer.gif'
                });
                infoWindow.setContent(data.description);
                infoWindow.open(map, marker);
                (function (marker, data) {
                    google.maps.event.addListener(marker, "click", function (e) {
                        infoWindow.setContent(data.description);
                        infoWindow.open(map, marker);
                    });
                })(marker, data);
            }
        }
    </script>
<script>
    $(document).ready(function () {
        //Retina Image
        $('img.retina').retina('@2x');

        //Slideshow
        $('.banner').revolution({
            delay: 9000,
            startwidth: 1040,
            startheight: 463,
            onHoverStop: "off", 					// Stop Banner Timet at Hover on Slide on/off

            thumbWidth: 100, 						// Thumb With and Height and Amount (only if navigation Tyope set to thumb !)
            thumbHeight: 50,
            thumbAmount: 3,

            hideThumbs: 0,
            navigationType: "bullet", 			// bullet, thumb, none
            navigationArrows: "none", 			// nexttobullets, solo (old name verticalcentered), none

            navigationStyle: "round-old", 		// round,square,navbar,round-old,square-old,navbar-old, or any from the list in the docu (choose between 50+ different item), custom


            navigationHAlign: "center", 			// Vertical Align top,center,bottom
            navigationVAlign: "bottom", 			// Horizontal Align left,center,right
            navigationHOffset: -419,
            navigationVOffset: 72,

            touchenabled: "on", 					// Enable Swipe Function : on/off

            stopAtSlide: -1, 						// Stop Timer if Slide "x" has been Reached. If stopAfterLoops set to 0, then it stops already in the first Loop at slide X which defined. -1 means do not stop at any slide. stopAfterLoops has no sinn in this case.
            stopAfterLoops: -1, 					// Stop Timer if All slides has been played "x" times. IT will stop at THe slide which is defined via stopAtSlide:x, if set to -1 slide never stop automatic

            hideCaptionAtLimit: 0, 				// It Defines if a caption should be shown under a Screen Resolution ( Basod on The Width of Browser)
            hideAllCaptionAtLilmit: 0, 			// Hide all The Captions if Width of Browser is less then this value
            hideSliderAtLimit: 0, 				// Hide the whole slider, and stop also functions if Width of Browser is less than this value


            fullWidth: "on",

            shadow: 0								//0 = no Shadow, 1,2,3 = 3 Different Art of Shadows -  (No Shadow in Fullwidth Version !)
        })

    });
</script>

<!-- IE Fix for HTML5 Tags -->
<!--[if lt IE 9]><script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script><![endif]-->

</head>
<body>
	<!-- header start here -->
	<header>
    
    	<!-- top info start here -->
    	<div id="top-info">
		    <div class="row">
		        <div class="twelve column">
                    <!-- logo start here -->
                    <div id="logo">
                        <a href="index.aspx"><img src="images/icons/logo2.png" alt="PG'S Around" class="retina"/></a>
						
                    </div>           
                    <!-- logo end here -->
                    
                    <div id="top-socials">
                        <ul>                                
                            <li class="facebook-color"><a href="https://www.facebook.com/pgsaroundwebsite"><i class="social-facebook"></i></a></li>
                            <li class="googleplus-color"><a href="https://plus.google.com/107582638782706612398"><i class="social-googleplus"></i></a></li>
                          <!--  <li class="linkedin-color"><a href="http://www.linkedin.com/nhome/?trk="><i class="social-linkedin"></i></a></li> -->
                        </ul>
                    </div>
                </div>
            </div>
			
        </div>
		
		  <div class="myfo">
		  
		  <div class="my-sign"><a href="LoginPage.aspx"> Sign In </a></div>
		  <div class="my-register"><a href="UserRegPage.aspx"> Register </a></div>
		  
		  </div>
		
        <!-- top info end here -->        
        
       
                    
                <!-- navigation start here -->
                <div id="mainmenu-wrapper">
            <div class="left-menu">
                    
                
                <nav id="mainmenu">
                    <ul id="menu">
                        <li class="dropdown"><a href="index.aspx">Home</a><span class="desc-menu"><a href="index.aspx">It's our home</a></span>
                         </li>   
                                                                           
                        	
                        
                        <li class="dropdown"><a href="services.aspx">Our Services</a><span class="desc-menu"><a href="services.aspx">At Your Request</span></a>
                        	 
                                
                                
                            
                        </li> 
                        <li class="dropdown"><a href="pgsaround.aspx">PG'S Around</a><span class="desc-menu"><a href="pgsaround.aspx">Feel Like Home</a></span>
                            
                        </li>
                        <li><a href="contactus.aspx">Contact Us</a><span class="desc-menu"><a href="contactus.aspx">We 'R' Around 'U'</a></span></li>
                        <li><a href="ourteam.aspx">Our Team</a><span class="desc-menu"><a href="ourteam.aspx">What We 'R'</a></span></li>
						
                    </ul>
                </nav>
                <!-- navigation end here --> 
                    
            </div>
            
            <div class="right-menu" id="top-search">
                <a class="trigger" href="#"><i class="icon-search"></i></a>
                <div class="search-panel">
                    <ul>
                        <li>
                        <form id="search" action="#" method="get">
                            <fieldset class="search-fieldset">
                                <input type="text" id="search-form" value="Order Number" />
                            </fieldset>      						
                        </form>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
                
    </header>
    <!-- header end here -->
    
	    <section class="content-wrapper">
				
		
		
    	<div class="row">
		<form runat="server">
        	
        <asp:HiddenField ID="hdnfldVariablelat" runat="server" />
        <asp:HiddenField ID="hdnfldVariablelong" runat="server" />
        <table class="style1">
        <tr>
        <td>
        <asp:Label ID="Label4" runat="server" Text="Select Gender:"></asp:Label>
        </td>
          <td>
        
                    <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                        Font-Bold="True"  
                        
            Width="131px" onselectedindexchanged="DropDownList5_SelectedIndexChanged">
                        <asp:ListItem Value="1">Men</asp:ListItem>
                        <asp:ListItem Value="2">Women</asp:ListItem>
                    </asp:DropDownList>
        
        </td>
        </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="Label2" runat="server" Text="Select State:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                        Font-Bold="True" 
                        onselectedindexchanged="DropDownList2_SelectedIndexChanged" 
            Width="144px">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                  <asp:Label ID="Label1" runat="server" Text="Select City:"></asp:Label>
                </td> 
                <td>
                
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                       Font-Bold="True" 
                        onselectedindexchanged="DropDownList3_SelectedIndexChanged" 
            Width="137px">
                        <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>
                
                </td>
                    <td>
                  <asp:Label ID="Label3" runat="server" Text="Select Area:"></asp:Label>
                </td> 
                <td>
                
                    <asp:DropDownList ID="DropDownList_Area" runat="server" Height="33px" 
                        onselectedindexchanged="DropDownList_Area_SelectedIndexChanged"  Font-Bold="True" 
                        style="margin-left: 0px" Width="180px" AutoPostBack="True">  <asp:ListItem Selected="True">Select</asp:ListItem>
                    </asp:DropDownList>
                
                </td>
                <td>
                    <asp:LinkButton ID="LinkButton_lookaroundme" runat="server" Font-Bold="True" 
                        Font-Underline="True" onclick="LinkButton_lookaroundme_Click">Look Around</asp:LinkButton>
                </td>
            </tr>
        </table>
         <div id="dvMap" style="height: 399px; width: 987px">
         <asp:Panel runat="server" ID="Panel_Map" style="height: 1px; width:1px"></asp:Panel>
         <asp:Panel runat="server" ID="Panel_Map_lookaround" style="height: 399px; width: 987px"></asp:Panel>
          </div>
          <br />
   </div>
   <div class="content-wrapper">
   <p><asp:Label ID="lbl_Status" runat="server" Font-Bold="True" Font-Overline="False" 
                                    Font-Strikeout="False" Font-Underline="False" ForeColor="#394653"></asp:Label></p>
    <asp:GridView ID="Grid_List_Of_Pgs" runat="server"  
            onrowcommand="Grid_List_Of_Pgs_RowCommand" AutoGenerateColumns="false" 
             >
     <HeaderStyle BackColor="#31475D" Font-Bold="True" ForeColor="Teal" />
     <Columns>
      <asp:TemplateField>
      <ItemTemplate>
       <asp:LinkButton ID="ViewDetailsButtonview" runat="server"  
      CommandName="ViewDetails" 
      CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
      Text="ViewDetails" ForeColor="#006666" Font-Bold="True"   Font-Underline="True" />
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
                        <asp:BoundField DataField="PGAddress" HeaderText="PGAddress" HeaderStyle-Width="100px"/>
                         <asp:BoundField DataField="PGPhno" HeaderText="PGPhno"/>
                         <asp:BoundField DataField="Avialability" HeaderText="Avialability"/>
                         <asp:BoundField DataField="CostPerDay" HeaderText="CostPerDay"/>
                         <asp:BoundField DataField="CostPerMonth" HeaderText="CostPerMonth"/>
                        <asp:BoundField DataField="Area" HeaderText="Area"/>
     </Columns>

    </asp:GridView>
    </div>
    
             </form>
        
	 </section>
	
	            
    
	
    
    <!-- bottom content end here -->
	
    
    <!-- footer start here -->
    <footer>   
        <div class="row">
        	<div class="nine column">
            	<h4>Contact Information</h4>
                <div class="say-hello">
                	<h4><a href="contactus.aspx">Hello!</a></h4>
					
                </div>
                <ul class="footer-address no-bullet">
                	<li class="address"> Hyderabad,AndraPradesh,500045. IND</li>
                    <li class="phone">09533231900 , 918892512513</li>
                    <li class="email"><a href="mailto:customercare@pgsaround.com">customercare@pgsaround.com</a></li>
                </ul>
                
                <ul class="footer-link no-bullet">
                	<li><a href="#">Privacy</a></li>
                    
                    <li><a href="#">Terms of Service</a></li>
                    
                </ul>
             
			 
             		 
            </div>
            
            <div class="three column">
            	<a href="index.aspx"><img src="images/icons/logo2.png" alt="PG'SAround" class="footer-logo retina" /></a>
                <p>FIND Fully Furnished, Hygienic, Comfortable & Affordable PG'S HERE.</p>
                <p>@ 2014-2015. All Rights Reserved. </p>	
            </div>       
        </div>
    </footer>
    <!-- footer end here -->

</body>


</html>
