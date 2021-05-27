<%@ Page Language="C#" Async="true"  AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="Views_LoginPage" %>


   
   
                        <!DOCTYPE html>
<head>
<meta charset="utf-8" />
<meta name="format-detection" content="telephone=no" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<title>Sign In</title>

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
                <p class="lead">Welcome to Rama Krishna Clothes... 
				
            	<p>Please Login Here for Sercurity Reasons...</p>
                            
                <div id="signup-form-area">
                    <!-- signin Form Start //-->
                    <form id="signupform" runat="server">
                        <fieldset> 
                        <label>User Name <em>*</em></label>                           
                        <input type="text" name="name" class="textfield" id="name" value="" /> 
                        <!--<label>E-mail ID <em>*</em></label> 
                        <input type="email" name="email" class="textfield" id="email" value="" /> -->
                        <label>Password <em>*</em></label> 
                            <br />
                            <br />
                        <input type="password" name="password" class="textfield" id="passwd" value="" />
						<!--<label>Confirm Password <em>*</em></label> 
                        <input type="password" name="confirm password" class="textfield" id="email" value="" /> -->
                       
                        <!--<a href="pgsaroundpage.html"><button id="ch3" style="width:100px; height:32px; font-size:12px;" type="submit" value="Sign In">Sign In</button></a> --> 
						
	                    
						<asp:Button runat="server" Text="Sign In" id="buttonsend" 
                                onclick="buttonsend_Click" Width="116px"></asp:Button>
                      
                       
                        
						
                        <asp:label id="Label_Errormsg" runat="server" name="Label_Errormsg"></asp:label>   
                        
						 <div class="clear"></div>
                        </fieldset> 
                    </form>
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

</body>


</html>
