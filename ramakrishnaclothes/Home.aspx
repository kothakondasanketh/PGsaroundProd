<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<html>
<head id="Head1" runat="server">
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
		
        	
            <div >
                <p>Welcome User</p><div>
                    <!-- signin Form Start //-->
                    
                        <fieldset> 
                        <div><p>Latest Photos</p>

</div>


<div><p>Last Updated Photos</p>
   <asp:DataList ID="DataList1"  DataSourceID="SqlDataSource1" runat="server" RepeatColumns="4" onitemcommand="dList_ItemCommand">
<ItemTemplate>
<table style="width:100%">
    <tr>
        <td style="width: 100%;">
            <asp:Image ID="ImgUri" ImageUrl="<%#Bind('BrandImage') %>" Width="200px" BorderStyle="Double" BorderColor="Gray" Height="250px"
                runat="server"></asp:Image>
        </td>
    </tr>
    <tr>
        <td style="width: 100%;border:10px">
            <asp:Label runat="server" ID="BrandName" Text="<%#Bind('BrandName') %>"></asp:Label>
            <asp:LinkButton runat="server" ID="BrandTxtbx" Text="Download"  CommandName="imgClick" Font-Underline="True" Font-Bold="true" />
        </td>
    </tr>
    
</table>
</ItemTemplate>

</asp:DataList>

</div>

<div><p>Past Photos</p>
   <asp:DataList ID="DataList2"  DataSourceID="SqlDataSource2" runat="server" RepeatColumns="4" onitemcommand="dList_ItemCommand">
<ItemTemplate>
<table style="width:100%">
    <tr>
        <td style="width: 100%;">
            <asp:Image ID="ImgUri" ImageUrl="<%#Bind('BrandImage') %>" Width="200px" BorderStyle="Double" BorderColor="Gray" Height="250px"
                runat="server"></asp:Image>
        </td>
    </tr>
    <tr>
        <td style="width: 100%;border:10px">
            <asp:Label runat="server" ID="BrandName" Text="<%#Bind('BrandName') %>"></asp:Label>
            <asp:LinkButton runat="server" ID="BrandTxtbx" Text="Download"   CommandName="imgClick" Font-Underline="True" Font-Bold="true" />
        </td>
    </tr>
    
</table>
</ItemTemplate>

</asp:DataList>
</div>
<asp:SqlDataSource ID="sqldataImages" runat="server"  ConnectionString="<%$appSettings:ConnString %>"
SelectCommand="select * from Image_Table where Date=(select MAX(Date) from Image_Table ) ORDER BY BrandName ASC" >
</asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource1" runat="server"  ConnectionString="<%$appSettings:ConnString %>"
SelectCommand="SELECT * FROM Image_Table WHERE Date = ( SELECT MAX(Date)  FROM Image_Table  WHERE Date < ( SELECT MAX(Date) FROM Image_Table) ) ORDER BY BrandName ASC" >
</asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource2" runat="server"  ConnectionString="<%$appSettings:ConnString %>"
SelectCommand="SELECT * FROM Image_Table WHERE Date <= ( SELECT MAX(Date)  FROM Image_Table  WHERE Date < ( SELECT MAX(Date) FROM Image_Table WHERE Date <( SELECT MAX(Date) FROM Image_Table)) ) ORDER BY BrandName ASC " >
</asp:SqlDataSource>
                        </fieldset> 
                    
                    <!-- Contact Form End //-->
                </div>	
            </div>     
        </div>  
	 </section>
	
	            
    
	
    
    <!-- bottom content end here -->
	
    
    <!-- footer start here -->
   <%-- <footer>   
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
    </footer>--%>
    <!-- footer end here -->
    </form>
</body>


</html>