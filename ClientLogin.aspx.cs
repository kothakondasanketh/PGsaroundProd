using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Net;
using System.IO;
//using ASPSnippets.FaceBookAPI;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
public partial class ClientLogin : System.Web.UI.Page
{
    public static string connection = ConfigurationManager.AppSettings["ConnString"];

    SqlConnection sqlcon = new SqlConnection(connection);

   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
          


            string UserId = (string)(Session["UserId"]);
            if (UserId != null)
            {

                MainClass.UserTypeID = 2;
                Response.Redirect("./ClientHome.aspx");
            }
            else
            {
                MainClass.UserTypeID = 2;
            }
        }

    }
    public void loginMethod(string usrname, string passwd)
    {
        MainClass.LoginType = 2;
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
                if (MainClass.UserTypeID == 2)
                {
                    Response.Redirect("./ClientHome.aspx");
                }
               
            }
            else
            {
                Label_Errormsg.Text = "Please Enter the UserName and Password correctly and try";
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
    
}