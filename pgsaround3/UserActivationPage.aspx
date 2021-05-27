<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserActivationPage.aspx.cs" Inherits="Views_UserActivationPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html>
<head>
<meta charset="utf-8" />
<meta name="format-detection" content="telephone=no" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<title>Activation Page</title>

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
                            <li class="linkedin-color"><a href="http://www.linkedin.com/nhome/?trk="><i class="social-linkedin"></i></a></li>
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
                        <li class="dropdown selected"><a href="signup.html">PG'S Around</a><span class="desc-menu"><a href="signup.html">Feel Like Home</a></span>
                            
                        </li>
                        <li class="dropdown"><a href="contactus.aspx">Contact Us</a><span class="desc-menu"><a href="contactus.aspx">We 'R' Around 'U'</a></span></li>
                        <li class="dropdown"><a href="ourteam.aspx">Our Team</a><span class="desc-menu"><a href="ourteam.aspx">What We 'R'</a></span></li>
						
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
    
	    
		<!-- register starts-->
		
		
	<div id="div1">
    <asp:Label runat="server" ID="Message"></asp:Label>
    </div>
	
                   
    
	
    
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
                	<li class="address"> Plot No-4, H No:1-83-11-2,Mallikarjuna Nagar,Nagaram,Hyderabad,5000883. IND</li>
                    <li class="phone">09533231900</li>
                    <li class="email"><a href="mailto:vellalurukrishna@gmail.com">vellalurukrishna@gmail.com</a></li>
                </ul>
                
                <ul class="footer-link no-bullet">
                	<li><a href="#">Privacy</a></li>
                    
                    <li><a href="#">Terms of Service</a></li>
                    
                </ul>
             
			 
             		 
            </div>
            
            <div class="three column">
            	<a href="index.aspx"><img src="images/icons/logo2.png" alt="PG'SAround" class="footer-logo retina" /></a>
                <p>FIND Fully Furnished, Hygienic, Comfortable & Affordable PG'S HERE.</p>
                <p>&copy; 2014 by Krishna. All Rights Reserved. </p>	
            </div>       
        </div>
    </footer>
    <!-- footer end here -->

</body>


</html>
