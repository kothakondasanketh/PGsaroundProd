using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_HomeMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //  Frame1.Attributes.Add("src", "./LoginPage.aspx");
        string UserId = (string)(Session["UserId"]);
        if (UserId != null)
        {
            lbl_Name.Text = "Welcome "+MainClass.Name;
            btn_Account.Visible = true;
            btn_Login_SignOut.Text = "Signout";
            LinkButton_Register.Visible = false;
            btn_bookings.Visible = true;
        }
        else
        {
            LinkButton_Register.Visible = true;
            btn_Login_SignOut.Text = "Login";
            btn_Account.Visible = false;
            btn_bookings.Visible = false;
            lbl_Name.Text = "Welcome Guest!!";
        }
    }
   
    public void lnkUpdate_Click(object sender, EventArgs e)
    {

        if (MainClass.UserTypeID == 1)
        {
      //      Frame1.Attributes.Add("src", "./UserRegistrationPage.aspx");
        }
        else if (MainClass.UserTypeID == 2)
        {
       //     Frame1.Attributes.Add("src", "./ClientRegistrationPage.aspx");
        }
    }
    public void lnkUpdate0_Click(object sender, EventArgs e)
    {
      //  Frame1.Attributes.Add("src", "./LoginPage.aspx");
    }
    protected void btn_Account_Click(object sender, EventArgs e)
    {
        string UserId = (string)(Session["UserId"]);
        if (UserId != null)
        {
            btn_Account.Visible = true;
            btn_Login_SignOut.Text = "Signout";
            LinkButton_Register.Visible = false;
            btn_bookings.Visible = true;
            Response.Redirect("./UserUpdateDetailsPage.aspx");
        }
        else
        {
            LinkButton_Register.Visible = true;
            btn_Login_SignOut.Text = "Login";
            btn_Account.Visible = false;
            btn_bookings.Visible = false;
            lbl_Name.Text = "Welcome Guest!!";
        }
    }
    protected void btn_Login_SignOut_Click(object sender, EventArgs e)
    {
        string UserId = (string)(Session["UserId"]);
        if (UserId != null)
        {
            LinkButton_Register.Visible = true;
            btn_Login_SignOut.Text = "Login";
            btn_Account.Visible = false;
            btn_bookings.Visible = false;
            lbl_Name.Text = "Welcome Guest!!";
            Session["UserId"] = null;
            Response.Buffer = true;
            Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
            Response.Expires = -1500;
            Response.CacheControl = "no-cache";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Redirect("./index.aspx");
        }
        else
        {
            LinkButton_Register.Visible = true;
            btn_Login_SignOut.Text = "Login";
            btn_Account.Visible = false;
            btn_bookings.Visible = false;
            lbl_Name.Text = "Welcome Guest!!";
            Response.Redirect("./LoginPage.aspx");
        }
    }
    protected void LinkButton_Register_Click(object sender, EventArgs e)
    {

        Response.Redirect("./UserRegPage.aspx");
    }
    protected void btn_bookings_Click(object sender, EventArgs e)
    {
        string UserId = (string)(Session["UserId"]);
        if (UserId != null)
        {
            btn_Account.Visible = true;
            btn_bookings.Visible = true;
            btn_Login_SignOut.Text = "Signout";
            LinkButton_Register.Visible = false;
            Response.Redirect("./BookingsPage.aspx");
        }
        else
        {
            LinkButton_Register.Visible = true;
            btn_Login_SignOut.Text = "Login";
            btn_Account.Visible = false;
            btn_bookings.Visible = false;
            lbl_Name.Text = "Welcome Guest!!";
        }
    }
}
