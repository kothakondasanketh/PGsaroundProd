using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetOpenAuth.OpenId;
using DotNetOpenAuth.OpenId.RelyingParty;
using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
using System.Web.Security;
using System.Net;
using System.IO;
//using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Views_LoginPage : System.Web.UI.Page
{
    public static string connection = ConfigurationManager.AppSettings["ConnString"];

    SqlConnection sqlcon = new SqlConnection(connection);
   
   
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(Request.Params["accessToken"]))
            {

                //let's send an http-request to Google+ API using the token  

                string json = GetGoogleUserJSON(Request.Params["accessToken"]);

                //and Deserialize the JSON response
                JavaScriptSerializer js = new JavaScriptSerializer();
                var oUser = js.Deserialize<Data>(json);
                     MainClass.UserName = oUser.email;
                    MainClass.Name = oUser.name;
                    Session["UserId"] = MainClass.UserName;
                    MainClass.UserTypeID = 1;
                    MainClass.LoginType = 1;
                   
                   Response.Redirect("./Home.aspx");
                  
               

            }
         
        if (!IsPostBack)
        {
             string UserId = (string)(Session["UserId"]);
            if (UserId != null)
            {

                MainClass.UserTypeID = 1;
                Response.Redirect("./Home.aspx");
            }
            else
            {
                MainClass.UserTypeID = 1;
            }

           
           
           
        }

    }
    public void loginMethod(string usrname,string passwd)
    {
        MainClass.LoginType = 1;
        MainClass.UserName = usrname;
        string Password = passwd;
        //Client.LoginAsync(MainClass.UserName, Password, MainClass.UserTypeID);
        //Client.LoginCompleted += new EventHandler<ServiceReference1.LoginCompletedEventArgs>(Client_LoginCompleted);

        try
        {
            string UserName = null;
            string Status = "";
            // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5;connection timeout=5";
            // SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select Name from UserDetails where UserName='" + MainClass.UserName + "' and PassWord='" + Password + "' and UserTypeID='" + MainClass.UserTypeID + "'", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("UserDetails");
            sda.Fill(dt);
            // UserName = dt.Rows[0]["UserName"].ToString().Trim();
            UserName = dt.Rows[0]["Name"].ToString().Trim();

            if (UserName != null)
            {
                cmd = new SqlCommand("select Status from UserAuthentication where Username='" + MainClass.UserName + "'", sqlcon);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable("UserAuthentication");
                sda.Fill(dt);
                // UserName = dt.Rows[0]["UserName"].ToString().Trim();
                Status = dt.Rows[0]["Status"].ToString().Trim();
            }
            sqlcon.Close();
            if (Status != "0")
            {

                MainClass.Name = UserName;
                Session["UserId"] = MainClass.UserName;
                if (MainClass.UserTypeID == 3)
                {
                    Response.Redirect("./AdminPage.aspx");
                }
                else
                {
                    Response.Redirect("./Home.aspx");
                }
            }
            else
            {
                Label_Errormsg.Text = "Please Activate your Account";
            }


        }
        catch (Exception ex) { Label_Errormsg.Text = "Please Enter the UserName and Password correctly and try"; }

    }
 


    protected void buttonsend_Click(object sender, EventArgs e)
    {
        string usrname = Request.Params["name"];
        string passwd = Request.Params["password"];
        if (usrname != null && passwd != null)
        {
            loginMethod(usrname, passwd);
        }
    }
    protected void ImageButton2_Click(object sender, CommandEventArgs e)
    {
      
        MainClass.UserTypeID = 1;
        MainClass.LoginType = 2;
    }

    private string GetGoogleUserJSON(string access_token)
    {
        string url = "https://www.googleapis.com/oauth2/v1/userinfo?alt=json";

        WebClient wc = new WebClient();
        wc.Headers.Add("Authorization", "OAuth " + Request.Params["accessToken"]);
        Stream data = wc.OpenRead(url);
        StreamReader reader = new StreamReader(data);
        string retirnedJson = reader.ReadToEnd();
        data.Close();
        reader.Close();

        return retirnedJson;
    }
    public class Data
    {
        public string email { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string picture { get; set; }

    }
}