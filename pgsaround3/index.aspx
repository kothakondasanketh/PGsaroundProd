<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<!DOCTYPE html>
<head>
<meta charset="utf-8" />
<meta name="format-detection" content="telephone=no" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<title>PG'S Around</title>

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
<script src="ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
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
                            <!--<li class="linkedin-color"><a href="http://www.linkedin.com/nhome/?trk="><i class="social-linkedin"></i></a></li>-->
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
                        <li class="dropdown selected"><a href="index.aspx">Home</a><span class="desc-menu"><a href="index.aspx">It's our home</a></span>
                         </li>   
                                                                           
                        	
                        
                        <li class="dropdown"><a href="services.aspx">Our Services</a><span class="desc-menu"><a href="services.aspx">At Your Request</span></a>
                        	 
                                
                                
                            
                        </li> 
                        <li class="dropdown"><a href="signup.html">PG'S Around</a><span class="desc-menu"><a href="signup.html">Feel Like Home</a></span>
                            
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
     <!-- slideshow start here -->
    <section id="slideshow-container">
    	<div class="banner">            
        	
            <ul>      
                
                <li data-transition="fade">
                	<img src="images/slideshow/transparent.png" alt="" style="background:#2c81b5">
                    <div class="caption general_caption lfb" data-x="-432" data-y="190" data-speed="2000" data-endspeed="1000" data-start="300" data-end="7700" data-easing="easeOutExpo" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_bg1.png" alt=""></div>
                    <div class="caption general_caption lfb" data-x="-432" data-y="284" data-speed="2300" data-endspeed="1000" data-start="600" data-end="7800" data-easing="easeOutExpo" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_bg2.png" alt=""></div>
                    <div class="caption general_caption lfb" data-x="-432" data-y="294" data-speed="2600" data-endspeed="1000" data-start="900" data-end="7900" data-easing="easeOutExpo" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_bg3.png" alt=""></div>
                    <div class="caption general_caption pst_media12 lft"  data-x="58" data-y="119" data-speed="2200" data-endspeed="900" data-start="800" data-end="7900" data-easing="easeOutExpo" data-endeasing="easeInBack"><h1 class="bold">PG'SAround</h1></div> 
                    <div class="caption general_caption pst_media lft"  data-x="58" data-y="175" data-speed="2200" data-endspeed="900" data-start="600" data-end="8100" data-easing="easeOutExpo" data-endeasing="easeInBack"><h2>A Home Away From Home</h2></div>
                    <div class="caption randomrotate" data-x="58" data-y="242" data-speed="1200" data-start="700" data-end="8000" data-easing="easeOutExpo"></div>
                    
                    <div class="caption general_caption lfb" data-x="593" data-y="5" data-speed="4000" data-endspeed="1000" data-start="100" data-end="8200" data-easing="easeOutElastic" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_icon1.png" title="Search UR Stay" alt=""></div>
                    <div class="caption general_caption lfb" data-x="779" data-y="13" data-speed="4000" data-endspeed="1000" data-start="200" data-end="8100" data-easing="easeOutElastic" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_icon2.png" title="Exciting Offers Offered Here" alt=""></div>
                    <div class="caption general_caption lfb" data-x="887" data-y="158" data-speed="4000" data-endspeed="1000" data-start="300" data-end="7900" data-easing="easeOutElastic" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_icon3.png" title="Plan UR Stay" alt=""></div>
                    <div class="caption general_caption lfb" data-x="795" data-y="293" data-speed="4000" data-endspeed="1000" data-start="600" data-end="7900" data-easing="easeOutElastic" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_icon4.png" title="Use UR Card" alt=""></div>
                    <div class="caption general_caption lfb" data-x="585" data-y="300" data-speed="4000" data-endspeed="1000" data-start="700" data-end="8000" data-easing="easeOutElastic" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_icon5.png" title="Save TIME With US" alt=""></div>
                    <div class="caption general_caption lfb" data-x="492" data-y="165" data-speed="4000" data-endspeed="1000" data-start="400" data-end="7800" data-easing="easeOutElastic" data-endeasing="easeInExpo"><img src="images/slideshow/icon-wallet_2x.png" title="Wallet UR STAY" alt=""></div>
                    <div class="caption general_caption lfb" data-x="683" data-y="167" data-speed="4000" data-endspeed="1000" data-start="500" data-end="7700" data-easing="easeOutElastic" data-endeasing="easeInExpo"><img src="images/slideshow/sld1_icon7.png" title="Find US on any Device" alt=""></div>
    			</li>
                
               
                <li data-transition="fade">
                	<img src="images/slideshow/transparent.png" alt="" style="background:#f29d17">
                    <div class="caption general_caption fade" data-x="-432" data-y="0" data-speed="2000" data-endspeed="1000" data-start="100" data-end="8700" data-easing="easeOutExpo" data-endeasing="easeInExpo"><img src="images/slideshow/sld2_bg1.png" alt=""></div>
                    <div class="caption randomrotate" data-x="-43" data-y="0" data-speed="1200" data-start="200" data-end="7500" data-easing="easeOutExpo"><img src="images/slideshow/sld2_ornament1.png" alt=""></div>
                    <div class="caption randomrotate" data-x="244" data-y="0" data-speed="1200" data-start="400" data-end="7800" data-easing="easeOutExpo"><img src="images/slideshow/sld2_ornament2.png" alt=""></div>
                    <div class="caption randomrotate" data-x="580" data-y="0" data-speed="1200" data-start="400" data-end="7800" data-easing="easeOutExpo"><img src="images/slideshow/sld2_ornament3.png" alt=""></div>
                    <div class="caption randomrotate" data-x="915" data-y="0" data-speed="1200" data-start="200" data-end="7500" data-easing="easeOutExpo"><img src="images/slideshow/sld2_ornament4.png" alt=""></div>
                    
                    <div class="caption general_caption pst_media2 lft"  data-x="228" data-y="124" data-speed="2200" data-endspeed="900" data-start="600" data-end="7900" data-easing="easeOutExpo" data-endeasing="easeInBack"><h1 class="bold btm-line">It's EASY To FIND With Us</h1></div>
                    <div class="caption general_caption lfb"  data-x="227" data-y="214" data-speed="2200" data-endspeed="900" data-start="800" data-end="7900" data-easing="easeOutExpo" data-endeasing="easeInBack"><p class="lead text-center"> FIND Fully Furnished, Hygienic, Comfortable & Affordable PG'S HERE   </p></div>
                </li> -->
                
                
                
                <!-- slide 4 -->
                <li data-transition="fade">
                	<img src="images/slideshow/transparent.png" alt="" style="background:#e7e9e9">
                    <div class="caption general_caption lfb" data-x="-432" data-y="0" data-speed="2000" data-endspeed="1000" data-start="100" data-end="7700" data-easing="easeOutExpo" data-endeasing="easeInExpo"><img src="images/slideshow/sld4_bg1.png" alt=""></div>
                    <div class="caption general_caption lfb" data-x="520" data-y="28" data-speed="3000" data-endspeed="1000" data-start="700" data-end="8000" data-easing="easeOutExpo" data-endeasing="easeInExpo"><img src="images/slideshow/sld_people3.png" alt=""></div>
                    <div class="caption general_caption pst_media14 lfl ltl"  data-x="56" data-y="83" data-speed="900" data-endspeed="900" data-start="100" data-end="5700" data-easing="easeOutBack" data-endeasing="easeInBack"><h1 class="bold blue-text">THREE STEPS TO STAY</h1></div>
                    <div class="caption general_caption lfl ltl "  data-x="56" data-y="162" data-speed="900" data-endspeed="900" data-start="800" data-end="6200" data-easing="easeOutBack" data-endeasing="easeInBack">
                    	<p class="lead-alt"><i class="icon-ok-sign"></i>SIGN UP As A USER</p>
                    </div>
                    <div class="caption general_caption pst_media4 lfl ltl"  data-x="56" data-y="210" data-speed="900" data-endspeed="900" data-start="1300" data-end="6700" data-easing="easeOutBack" data-endeasing="easeInBack">
                    	<p class="lead-alt"><i class="icon-ok-sign"></i>CHOOSE UR PREFERENCES</p>
                    </div>
                    <div class="caption general_caption pst_media5 lfl ltl"  data-x="56" data-y="258" data-speed="900" data-endspeed="900" data-start="1800" data-end="7200" data-easing="easeOutBack" data-endeasing="easeInBack"> 
                    	<p class="lead-alt"><i class="icon-ok-sign"></i>BOOK With UR Credentials</p>
                    </div>
                </li>   
            </ul>
            <div class="tp-bannertimer tp-top"></div>
                
        </div>        
    </section>
    <!-- slideshow end here -->
    
    
    <section id="slide-box">
    	<div class="row">
        	<div class="twelve column">                    	
                <div class="promo-box">
                    <div class="promo-text">
                    	<div class="flatborder left">                           
                            <i class="flat-file small"></i>
                        </div>
                        <h3>FIND Fully Furnished, Hygienic, Comfortable &amp; Affordable PG's Here.</h3>
                        <p>A Home Away From Home</p>
                    </div>
                    <div class="promo-button green">
                        <a href="#"><h3>Book Now</h3><i class="icon-chevron-right"></i></a>
                    </div>
                </div>                                   
            </div>
        </div>    
    </section>
	
	
 
      
	
	
	<section id="bottom-content">
    
    	<div class="row">
        	<div class="twelve column text-center">
            	<h2>What Is Going On Your Mind!!!</h2>
                
                <ul class="block-grid-nomargin four-up">
                	<li class="bottom-fact with-border">
					
					
                    	
                        <h6>How to find PG</h6>
						<img src="images/icons/slide05.png" />
                    	<h5>Knock Every Door??</h5>
                    </li>
                    
                    <li class="bottom-fact with-border">
                    	
                        <h6>Where to find PG</h6>
						<img src="images/icons/slide04.png" />
                    	<h5>Roam Every Street??</h5>
                    </li>
                    
                    <li class="bottom-fact with-border">
                    	
                        <h6>What will be the Budget</h6>
						<img src="images/icons/slide02.png" />
                    	<h5>Worried About Wallet??</h5>
                    </li>
                    
                    <li class="bottom-fact">
                    	
                        <h6>We will find you everything</h6>
						<img src="images/icons/slide03.png" />
                    	<h5>In PG'S Around</h5>
                    </li>
                </ul>
                
                <h6>We provide you the selective PG's Around - <a href="#" class="raquo">Learn more about our team <i class="icon-chevron-right"></i></a></h6>
            </div>         
        </div>
        
	
	
	
	
	
	
	
	
	
	
	
	
	<!-- content section start here -->
	
	
	
    <a name="sig"><section class="content-wrapper"></a>
    	<div class="row">
        	<div class="twelve column smallmargin-top2">
            	<ul class="block-grid-nomargin three-up mobile-style">
                    <li>
                    	<div class="animated-column text-center btmar">
                            <div class="flatborder">                           
                                <i class="flat-check medium"></i>
                            </div>    
                            <h3>USER</h3> 
                            <p>User Will Login First So That He Can Choose His Preference TO Book The PG. </p>
							<a class="button small white" href="signup.html">Sign In</a> <a class="button small white" href="register.html">New User</a>
							
							
							
                        </div>	
                    </li>
                    <li>
                    	<div class="animated-column text-center">
                            <div class="flatborder">                           
                                <i class="flat-ui medium"></i>
                            </div>    
                            <h3>CLIENT</h3> 
                            <p>Client Will Login first so that he can check his PG Updates, Bookings, etc.</p>
							 <a class="button small white" href="signup.html">Sign In</a><a class="button small white" href="register.html">New User</a>
                        </div>	
                    </li>
                    <li>
                    	<div class="animated-column text-center">
                            <div class="flatborder">                           
                                <i class="flat-statistic medium"></i>
                            </div>    
                            <h3>ADMIN</h3> 
                            <p>Admin Will Look After The Transaction, Updates Done By The Users And Clients.  </p>
							<a class="button small white" href="#">Login Here</a>
                        </div>	
                    </li>                            
                </ul>
            </div>
        </div>        
        
        
     <!-- content section end here -->
	
	
	
 <section class="content-wrapper">       
        <div class="row">
            <div class="twelve column"> 
            </div>
            <div class="twelve column">
                <hr/>
            </div>
            
            <div class="twelve column"> 
            	<h4 class="smallmargin-bottom">DISCOUNT COUPONS</h4>                   	
                <div class="promo-box">
                    <div class="promo-text">
                    	<div class="flatborder left">                           
                            <i class="flat-love small"></i>
							
                        </div>
                        <h3>We Have Very Good OFFERS in the Bag</h3>
                        <p>Find Them Once You Login And Get Better Deals With Us</p>
                    </div>
                    <div class="promo-button green">
                        <a href="#"><h3>Check Out</h3><i class="icon-chevron-right"></i></a>
                    </div>
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

