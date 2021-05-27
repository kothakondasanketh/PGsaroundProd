using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_AdminPage : System.Web.UI.Page
{
    // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string UserId = (string)(Session["UserId"]);
            if (UserId != null)
            {
                Label1.Text = "Welcome " + MainClass.Name;

                GridView3.DataSource = ImplementationClass.bookingdetails(null);
                GridView3.DataBind();

                GridView1.DataSource = ImplementationClass.PgDetailsList(null, MainClass.UserTypeID, 0);
                GridView1.DataBind();

                //Client.PgDetailsListAsync(null, MainClass.UserTypeID,0);
                //Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);

                //Client.bookingdetailsAsync(null);
                //Client.bookingdetailsCompleted += new EventHandler<ServiceReference1.bookingdetailsCompletedEventArgs>(Client_bookingdetailsCompleted);
            }
            else
            {
                Response.Redirect("./AdminLogin.aspx");
            }


        }

    }

    //void Client_bookingdetailsCompleted(object sender, ServiceReference1.bookingdetailsCompletedEventArgs e)
    //{
    //    try
    //    {
    //        GridView3.DataSource = e.Result;
    //        GridView3.DataBind();
    //    }
    //    catch (Exception ex) { }
    //}

    //void Client_PgDetailsListCompleted(object sender, ServiceReference1.PgDetailsListCompletedEventArgs e)
    //{
    //    GridView1.DataSource = e.Result;
    //    GridView1.DataBind();
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["UserId"] = null;
        Response.Redirect("./AdminLogin.aspx");
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.DataSource = ImplementationClass.PgDetailsList(null, MainClass.UserTypeID, 0);
        GridView1.DataBind();
    }
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        GridView1.EditIndex = -1;
        GridView1.DataBind();
        GridView1.DataSource = ImplementationClass.PgDetailsList(null, MainClass.UserTypeID, 0);
        GridView1.DataBind();


    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //  GridView gg = new GridView();


        //string ssd = GridView1.DataKeys[e.RowIndex].Value.ToString();
        DropDownList ddlNew = (DropDownList)GridView1.Rows[e.RowIndex].FindControl("DrpDwn1");

        Label ID = (Label)GridView1.Rows[e.RowIndex].FindControl("LabelUserID");
        string id = ID.Text;


        string selectedvalue = ddlNew.SelectedValue;

        PGDetails pgd = new PGDetails();
        pgd.UserID = id;
        pgd.ConfirmationStas = selectedvalue;

        bool status = ImplementationClass.PGRegister(pgd, 3);
        if (status == true)
            Label2.Text = "Successfull";
        else
            Label2.Text = "Not Successfull";

        GridView1.EditIndex = -1;
        GridView1.DataBind();
        GridView1.DataSource = ImplementationClass.PgDetailsList(null, MainClass.UserTypeID, 0);
        GridView1.DataBind();
        //Client.PgDetailsListAsync(null, MainClass.UserTypeID,0);
        //Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);
    }

    //void Client_PGRegisterCompleted(object sender, ServiceReference1.PGRegisterCompletedEventArgs e)
    //{
    //    Label2.Text = e.Result;

    //}

    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        MainClass.OrderNo = GridView3.SelectedRow.Cells[1].Text;

        Response.Redirect("./OrderDetailsPage.aspx");
    }
}