using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.ObjectModel;


public partial class Views_BookingsPage : System.Web.UI.Page
{
    // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = ImplementationClass.UserBookingDetailsList(MainClass.UserName, MainClass.UserTypeID);
        GridView1.DataBind();
        //Client.UserBookingDetailsListAsync(MainClass.UserName, MainClass.UserTypeID);
        //Client.UserBookingDetailsListCompleted += new EventHandler<ServiceReference1.UserBookingDetailsListCompletedEventArgs>(Client_UserBookingDetailsListCompleted);
    }

    //void Client_UserBookingDetailsListCompleted(object sender, ServiceReference1.UserBookingDetailsListCompletedEventArgs e)
    //{
    //    GridView1.DataSource = e.Result;
    //    GridView1.DataBind();
    //}
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MainClass.OrderNo = GridView1.SelectedRow.Cells[1].Text;

        Response.Redirect("./OrderDetailsPage.aspx");
    }





}