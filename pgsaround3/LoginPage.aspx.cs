using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using DotNetOpenAuth.OpenId;
//using DotNetOpenAuth.OpenId.RelyingParty;
//using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
//using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
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
   
   // OpenIdRelyingParty openid = new OpenIdRelyingParty();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           /// HandleOpenIDProviderResponse();

           
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
    //void Client_LoginCompleted(object sender, ServiceReference1.LoginCompletedEventArgs e)
    //{
    //    try
    //    {
    //        if (e.Result != null)
    //        {
    //            if (e.Result == "False")
    //            {
    //                Label_Errormsg.Text = "Please Activate your Account";
    //            }
    //            else
    //            {
    //                MainClass.Name = e.Result;
    //                Session["UserId"] = MainClass.UserName;
    //                if (MainClass.UserTypeID == 3)
    //                {
    //                    Response.Redirect("./AdminPage.aspx");
    //                }
    //                else
    //                {
    //                    Response.Redirect("./HomePage.aspx");
    //                }
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Label_Errormsg.Text = "Please Enter UserName and Password Correctly and TRY!!";
    //        // Response.Write(ex.ma);
    //    }
    //}
    //protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    //{
    //    MainClass.UserTypeID = 1;
    //    if (RadioButton1.Checked == true)
    //    {
    //        RadioButton2.Checked = false;
    //        RadioButton3.Checked = false;

    //    }
    //}
    //protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    //{
    //    MainClass.UserTypeID = 2;
    //    if (RadioButton2.Checked == true)
    //    {
    //        RadioButton1.Checked = false;

    //        RadioButton3.Checked = false;

    //    }
    //}
    //protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    //{
    //    MainClass.UserTypeID = 3;
    //    if (RadioButton3.Checked == true)
    //    {
    //        RadioButton1.Checked = false;
    //        RadioButton2.Checked = false;

    //    }
    //}
    //protected void HandleOpenIDProviderResponse()
    //{
    //    var response = openid.GetResponse();

    //    if (response != null)
    //    {
    //        switch (response.Status)
    //        {
    //            case AuthenticationStatus.Authenticated:
    //                // NotLoggedIn.Visible = false;
    //                // btngmaillogout.Visible = true;

    //                var fetchResponse = response.GetExtension<FetchResponse>();
    //                Session["FetchResponse"] = fetchResponse;
    //                var response2 = Session["FetchResponse"] as FetchResponse;

    //                string mailid = response2.GetAttributeValue(WellKnownAttributes.Contact.Email);
    //                string fullname = GetFullname(response2.GetAttributeValue(WellKnownAttributes.Name.First), response2.GetAttributeValue(WellKnownAttributes.Name.Last));
    //                string dob = response2.GetAttributeValue(WellKnownAttributes.BirthDate.WholeBirthDate);
    //                string mobileno = response2.GetAttributeValue(WellKnownAttributes.Contact.Phone.Mobile);
    //                string gender = response2.GetAttributeValue(WellKnownAttributes.Person.Gender);
    //                MainClass.LoginType = 2;
    //                MainClass.UserName = mailid;
    //                MainClass.UserEmailID = MainClass.UserName;
    //                MainClass.Name = fullname;
    //                MainClass.gdob = dob;
    //                MainClass.gphno = mobileno;
    //                MainClass.ggender = gender;
    //                Session["UserId"] = MainClass.UserName;
    //                Response.Redirect("./HomePage.aspx");
    //                break;
    //            case AuthenticationStatus.Canceled:
    //                Response.Redirect("./LoginPage.aspx");
    //                break;
    //            case AuthenticationStatus.Failed:
    //                Response.Redirect("./LoginPage.aspx");
    //                break;
    //        }
    //    }
    //    else
    //    {
    //        return;

    //    }

    //}


    //private static string GetFullname(string first, string last)
    //{
    //    var _first = first ?? "";
    //    var _last = last ?? "";

    //    if (string.IsNullOrEmpty(_first) || string.IsNullOrEmpty(_last))
    //        return "";

    //    return _first + " " + _last;
    //}


    //protected void Login(object sender, EventArgs e)
    //{
    //    FaceBookConnect.Authorize("user_photos,email,user_location,user_birthday", Request.Url.AbsoluteUri.Split('?')[0]);
    //}


    //public class FaceBookUser
    //{
    //    public string Id { get; set; }
    //    public string Name { get; set; }
    //    public string UserName { get; set; }
    //    public string PictureUrl { get; set; }
    //    public string Email { get; set; }
    //    public string Birthday { get; set; }
    //    public string Gender { get; set; }
    //    public FaceBookEntity Location { get; set; }
    //}

    //public class FaceBookEntity
    //{
    //    public string Id { get; set; }
    //    public string Name { get; set; }
    //}

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
        //string discoveryUri = e.CommandArgument.ToString();
        //var b = new UriBuilder(Request.Url) { Query = "" };
        //var req = openid.CreateRequest(discoveryUri, b.Uri, b.Uri);
        //var fetchRequest = new FetchRequest();
        //fetchRequest.Attributes.AddRequired(WellKnownAttributes.Contact.Email);
        //fetchRequest.Attributes.AddRequired(WellKnownAttributes.Name.First);
        //fetchRequest.Attributes.AddRequired(WellKnownAttributes.Name.Last);
        //fetchRequest.Attributes.AddRequired(WellKnownAttributes.Person.Gender);
        //fetchRequest.Attributes.AddRequired(WellKnownAttributes.Contact.Phone.Mobile);
        //fetchRequest.Attributes.AddRequired(WellKnownAttributes.BirthDate.WholeBirthDate);
        //req.AddExtension(fetchRequest);
        //req.RedirectToProvider();
        //MainClass.UserTypeID = 1;
        //MainClass.LoginType = 2;
    }
}