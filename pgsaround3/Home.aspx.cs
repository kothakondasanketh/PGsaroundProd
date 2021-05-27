using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string UserId = (string)(Session["UserId"]);
            if (UserId != null)
            {
                //if (MainClass.UserTypeID == 1)
                //{

                  Frame1.Attributes.Add("src", "./BookingSearchPage.aspx");
                //}
                //else if (MainClass.UserTypeID == 2)
                //{
                //    Menu1.Items.RemoveAt(0);
                //    Frame1.Attributes.Add("src", "./BookingsPage.aspx");
                //}

                UserAccountName.Text ="Welcome "+ MainClass.Name;
            }
            else
            {
                Response.Redirect("./LoginPage.aspx");
            }

        }


    }
    //protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    //{

    //    if (Menu1.SelectedItem.Text == "Home")
    //    {
    //        if (MainClass.UserTypeID == 1)
    //        {
    //            Frame1.Attributes.Add("src", "./BookingSearchPage.aspx");
    //        }
    //        else if (MainClass.UserTypeID == 2)
    //        {
    //            Frame1.Attributes.Add("src", "./BookingsPage.aspx");
    //        }

    //    }
    //    else if (Menu1.SelectedItem.Text == "Bookings")
    //    {
    //        Frame1.Attributes.Add("src", "./BookingsPage.aspx");
    //    }
    //    else if (Menu1.SelectedItem.Text == "Account")
    //    {
    //        if (MainClass.UserTypeID == 1)
    //        {
    //            Frame1.Attributes.Add("src", "./UserUpdateDetailsPage.aspx");
    //        }
    //        else if (MainClass.UserTypeID == 2)
    //        {
    //            Frame1.Attributes.Add("src", "./ClientUpdateDetailsPage.aspx");
    //        }


    //    }
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["UserId"] = null;
        Response.Buffer = true;
        Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
        Response.Expires = -1500;
        Response.CacheControl = "no-cache";
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Redirect("./index.aspx");

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Frame1.Attributes.Add("src", "./UserUpdateDetailsPage.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Frame1.Attributes.Add("src", "./BookingsPage.aspx");
    }
}