<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<html>
<head runat="server">
<meta charset="utf-8" />
<meta name="format-detection" content="telephone=no" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<title>Home</title>

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
<form id="signupform" runat="server">
	<!-- header start here -->
	<header>
    
    	<!-- top info start here -->
    	<div id="top-info">
		    <div class="row">
		        <div class="twelve column">
                    <!-- logo start here -->
                    <div id="logo">
                        &nbsp;</div>           
                    <!-- logo end here -->
                    
                    <div id="top-socials">
                     <div class="my-sign">
                      
           <asp:LinkButton ID="Button1" runat="server"  Text="Logout" 
                        BorderColor="White" Font-Bold="false" Font-Italic="False" 
                        Font-Underline="True" ForeColor="#7E8892" 
                  style="margin-left: 43px" onclick="Button1_Click"  /></div>
		 
		
		  </div>
                    </div>
                </div>
            </div>
			
        </div>
		
        <!-- top info end here -->        
        
       
                    
                <!-- navigation start here -->
                
    </header>
    <!-- header end here -->
    
	    <section class="content-wrapper">
				
		
		
    	<div class="row">
		
        	
            <div class="eight column">
                <p class="lead">Welcome User<div id="signup-form-area">
                    <!-- signin Form Start //-->
                    
                        <fieldset> 
                        <table class="style3">
                         <tr>
                             <td class="style14">
                                 <asp:ImageButton ID="ImageButton_Left" runat="server" Height="66px" 
                                     ImageUrl="~/Images/LeftArrow.jpg" Width="65px" />
                             </td>
                             <td class="style15">
                                <asp:Image ID="Image6" runat="server" Height="310px" Width="611px" />
       
      
             <asp:SlideShowExtender ID="SlideShowExtender" runat="server" TargetControlID="Image6"
                SlideShowServiceMethod="GetImages"  
                AutoPlay="true" PlayInterval="1000" Loop="true" PlayButtonID="Button_Play" StopButtonText="Stop" 
                PlayButtonText="Play" NextButtonID="ImageButton_Right" PreviousButtonID="ImageButton_Left"></asp:SlideShowExtender>
                             </td>
                             <td class="style16">
                                 <asp:ImageButton ID="ImageButton_Right" runat="server" Height="66px" 
                                     ImageUrl="~/Images/RightArrow.jpg" Width="65px" style="margin-left: 0px" />
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
                    <br />
                    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
</asp:ToolkitScriptManager>
       
      
                  <%--  <a href="javascript: history.go(-1)">Go Back</a>--%>
                    <br />
                    <br />
   
   

<!-- ModalPopupExtender -->
                        </fieldset> 
                    
                    <!-- Contact Form End //-->
                </div>	
            </div>     
        </div>  
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
                	<li class="address"> C/O-RamaKrishna,Sarjapur Road,Near Wipro,Bangalore,karnataka</li>
                    <li class="phone">Phno:9742965613</li>
                </ul>
                
             
             
			 
             		 
            </div>
            
        </div>
    </footer>
    <!-- footer end here -->
    </form>
</body>


</html>