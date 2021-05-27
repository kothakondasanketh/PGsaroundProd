using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class Views_UserActivationPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string activationCode = !string.IsNullOrEmpty(Request.QueryString["ActivationCode"]) ? Request.QueryString["ActivationCode"] : Guid.Empty.ToString();


         int i = 0;
         string ConString = ConfigurationManager.AppSettings["ConnString"];
        SqlConnection con = new SqlConnection(ConString);
        SqlCommand cmd = new SqlCommand("UPDATE UserAuthentication SET Status=1 WHERE AuthenticationKey='" + activationCode + "'", con);
        con.Open();
           i = cmd.ExecuteNonQuery();
           con.Close();
           if (i > 0)
           {
               Message.Text = "Thanks for activation. You can login now!" +" <a href='LoginPage.aspx'>Login</a>";
               
           }
        //string Email, UserID;
        

        //if ((Request.QueryString["UserID"] != null) & (Request.QueryString["Email"] != null))
        //{
        //    UserID = Request.QueryString["UserID"];
        //    Email = Request.QueryString["Email"];
        //    SqlConnection con = new SqlConnection(ConString);
        //    SqlCommand cmd = new SqlCommand("UPDATE aspnet_Membership SET IsApproved=1 WHERE UserID=@UserID AND Email=@Email", con);
        //    cmd.Parameters.AddWithValue("@UserID", UserID);
        //    cmd.Parameters.AddWithValue("@Email", Email);
        //    con.Open();
        //    i = cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        //if (i > 0)
        //{
        //    Response.Write("Thanks for activation. You can login now!");
        //    Response.Write("<a href='Login.aspx'>Login</a>");
        //}

    }
}