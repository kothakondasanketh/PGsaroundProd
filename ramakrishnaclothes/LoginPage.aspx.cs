using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Net;
using System.IO;

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
        if (!IsPostBack)
        {
            

           
            string UserId = (string)(Session["UserId"]);
            if (UserId != null)
            {

              
                Response.Redirect("./Home.aspx");
            }
          
        }

    }
    public void loginMethod(string usrname,string passwd)
    {
       
      
        //Client.LoginAsync(MainClass.UserName, Password, MainClass.UserTypeID);
        //Client.LoginCompleted += new EventHandler<ServiceReference1.LoginCompletedEventArgs>(Client_LoginCompleted);

        try
        {
           
            string Status = "";
            // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5;connection timeout=5";
            // SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select UserTypeId from LoginTable where Username='" + usrname + "' and Password='" + passwd + "'", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("LoginTable");
            sda.Fill(dt);
            // UserName = dt.Rows[0]["UserName"].ToString().Trim();
           string UserName = dt.Rows[0]["UserTypeId"].ToString().Trim();
           sqlcon.Close();
            if (UserName != null)
            {
                 Session["UserId"] = UserName;
                if (UserName == "1")
                {
                    Response.Redirect("./Home.aspx");
                }
                else if (UserName == "2")
                {
                    Response.Redirect("./AdminPage.aspx");
                }
            }
           
       
            else
            {
                Label_Errormsg.Text = "Please Enter UserName and Password Correctly and Try";
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