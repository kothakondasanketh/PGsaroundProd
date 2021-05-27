<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GooglePlusLogin.aspx.cs" Inherits="GooglePlusLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        (function () {
            var po = document.createElement('script');
            po.type = 'text/javascript'; po.async = true;
            po.src = 'https://plus.google.com/js/client:plusone.js';
            var s = document.getElementsByTagName('script')[0];
            s.parentNode.insertBefore(po, s);
        })();
    </script>
    <script type="text/javascript">
        /**
        * Calls the helper method that handles the authentication flow.
        *
        * @param {Object} authResult An Object which contains the access token and
        *   other authentication information.
        */
        function onSignInCallback(authResult) {
            if (authResult['access_token']) {
                // The user is signed in
                var loc = '/staging/GooglePlusLogin.aspx?accessToken=' + authResult['access_token'];
                window.location.href = loc;
            } else if (authResult['error']) {
                // There was an error, which means the user is not signed in.
                // As an example, you can troubleshoot by writing to the console:
                alert('There was an error: ' + authResult['error']);
            }
            //console.log('authResult', authResult);
        }
    </script>
    <style type="text/css">
        .g-signin
        {
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <button class="g-signin"
            data-scope="https://www.googleapis.com/auth/plus.login  https://www.googleapis.com/auth/userinfo.email "
            data-requestvisibleactions="http://schemas.google.com/AddActivity"
            data-clientid="120880486856-puo0rm3it9l71a8pd4cdtcgqbrt1o1ej.apps.googleusercontent.com"
            data-accesstype="offline"
            data-callback="onSignInCallback"
            data-theme="dark"
            data-cookiepolicy="single_host_origin">
        </button>
    </div>
    </form>
</body>
</html>
