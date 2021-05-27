using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Configuration;
using System.Data.SqlClient;

public partial class Views_BookingConfirmationPage : System.Web.UI.Page
{
    public static string connection = ConfigurationManager.AppSettings["ConnString"];

    SqlConnection sqlcon = new SqlConnection(connection);
    public int GeneratedOrderNo;
    //ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CCpaymentDiv.Visible = false;
            Button_PlaceOrder.Visible = false;
            ListView1.DataSource = ImplementationClass.ParticularPgDetailsList(MainClass.ClientID);
            ListView1.DataBind();
            //Client.ParticularPgDetailsListAsync(MainClass.ClientID);
            //Client.ParticularPgDetailsListCompleted += new EventHandler<ServiceReference1.ParticularPgDetailsListCompletedEventArgs>(Client_ParticularPgDetailsListCompleted);

            if (MainClass.LoginType == 1)
            {
                ListView2.DataSource = ImplementationClass.GetUserDetails(MainClass.UserName);
                ListView2.DataBind();
                //Client.GetUserDetailsAsync(MainClass.UserName);
                //Client.GetUserDetailsCompleted += new EventHandler<ServiceReference1.GetUserDetailsCompletedEventArgs>(Client_GetUserDetailsCompleted);
            }
            else if (MainClass.LoginType == 2)
            {
                List<UserRegister> userdet = new List<UserRegister>();
                UserRegister usrd = new UserRegister();
                usrd.Name = MainClass.Name;
                usrd.EmailID = MainClass.UserEmailID;
                usrd.PhoneNo = MainClass.gphno;
                usrd.Address = "NA";
                usrd.Age = 00;

                userdet.Add(usrd);
                ListView2.DataSource = userdet;
                ListView2.DataBind();
            }

            //  Label_OrderNo.Text = BookingEntryDetails.OrderNo;

            //List<BookingEntryDetailslocal> BookDet = new List<BookingEntryDetailslocal>();
            //BookingEntryDetailslocal fff = new BookingEntryDetailslocal();
            ////fff.OrderNo = BookingEntryDetails.OrderNo;
            //fff.FromDate = BookingEntryDetails.FromDate;
            //fff.ToDate = BookingEntryDetails.ToDate;
            //fff.NoOfPersons = BookingEntryDetails.NoOfPersons;
            //fff.TotalNoOfDays = BookingEntryDetails.TotalNoOfDays;
            //fff.TotalCost = BookingEntryDetails.TotalCost;
            //fff.Status = "Pending";
            //fff.Area = BookingEntryDetails.Area;
            //fff.Address = BookingEntryDetails.Address;
            Label_fromdate.Text = BookingEntryDetails.FromDate.ToShortDateString();
            Label43_todate.Text = BookingEntryDetails.ToDate.ToShortDateString();
            Label_noofpersons.Text = BookingEntryDetails.NoOfPersons.ToString();
            Label_totaldays.Text = BookingEntryDetails.TotalNoOfDays.ToString();
            Label_totalcost.Text = BookingEntryDetails.TotalCost.ToString();
            Label_status.Text = "Pending";
            Label_area.Text = BookingEntryDetails.Area;
            Label_usr1.Text = BookingEntryDetails.User1;
            Label_usr2.Text = BookingEntryDetails.User2;
            Label_usr3.Text = BookingEntryDetails.User3;
            Label_usr4.Text = BookingEntryDetails.User4;
            Label_usr5.Text = BookingEntryDetails.User5;
            if (BookingEntryDetails.NoOfPersons == 1)
            {
                //  fff.User1 = BookingEntryDetails.User1;
                User1div.Visible = true;
                User2div.Visible = false;
                User3div.Visible = false;
                User4div.Visible = false;
                User5div.Visible = false;

            }
            else if (BookingEntryDetails.NoOfPersons == 2)
            {
                //    fff.User1 = BookingEntryDetails.User1;
                //    fff.User2 = BookingEntryDetails.User2;
                User1div.Visible = true;
                User2div.Visible = true;
                User3div.Visible = false;
                User4div.Visible = false;
                User5div.Visible = false;

            }
            else if (BookingEntryDetails.NoOfPersons == 3)
            {
                //fff.User1 = BookingEntryDetails.User1;
                //fff.User2 = BookingEntryDetails.User2;
                //fff.User3 = BookingEntryDetails.User3;
                User1div.Visible = true;
                User2div.Visible = true;
                User3div.Visible = true;
                User4div.Visible = false;
                User5div.Visible = false;

            }
            else if (BookingEntryDetails.NoOfPersons == 4)
            {
                //fff.User1 = BookingEntryDetails.User1;
                //fff.User2 = BookingEntryDetails.User2;
                //fff.User3 = BookingEntryDetails.User3;
                //fff.User4 = BookingEntryDetails.User4;
                User1div.Visible = true;
                User2div.Visible = true;
                User3div.Visible = true;
                User4div.Visible = true;
                User5div.Visible = false;
            }
            else if (BookingEntryDetails.NoOfPersons == 5)
            {
                //fff.User1 = BookingEntryDetails.User1;
                //fff.User2 = BookingEntryDetails.User2;
                //fff.User3 = BookingEntryDetails.User3;
                //fff.User4 = BookingEntryDetails.User4;
                //fff.User5 = BookingEntryDetails.User5;
                User1div.Visible = true;
                User2div.Visible = true;
                User3div.Visible = true;
                User4div.Visible = true;
                User5div.Visible = true;
            }




            // BookDet.Add(fff);
            // ListView3.DataSource = BookDet;
            // ListView3.DataBind();





        }

    }

    //void Client_GetUserDetailsCompleted(object sender, ServiceReference1.GetUserDetailsCompletedEventArgs e)
    //{
    //    try
    //    {
    //        ListView2.DataSource = e.Result.ToList<ServiceReference1.UserRegister>();
    //        ListView2.DataBind();
    //    }
    //    catch { }
    //}
    //void Client_ParticularPgDetailsListCompleted(object sender, ServiceReference1.ParticularPgDetailsListCompletedEventArgs e)
    //{
    //    ListView1.DataSource = e.Result.ToList<ServiceReference1.PGDetails>();
    //    ListView1.DataBind();


    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label_DisplayMsg.Text = "Please wait while we proceed to the transaction";

        GeneratedOrderNo = ImplementationClass.GenerateOrderno();
        GeneratedOrderNo = GeneratedOrderNo + 1;
        BookingEntryDetailslocal BEntry = new BookingEntryDetailslocal();
        BEntry.ClientUserID = BookingEntryDetails.ClientUserID;
        BEntry.CustomerUserID = BookingEntryDetails.CustomerUserID;
        BEntry.OrderNo = "PGSORD" + GeneratedOrderNo;
        BEntry.FromDate = BookingEntryDetails.FromDate;
        BEntry.ToDate = BookingEntryDetails.ToDate;
        BEntry.NoOfPersons = BookingEntryDetails.NoOfPersons;
        BEntry.TotalNoOfDays = BookingEntryDetails.TotalNoOfDays;
        BEntry.TotalCost = BookingEntryDetails.TotalCost;
        BEntry.Status = DropDownList1.SelectedItem.ToString();
        BEntry.User1 = BookingEntryDetails.User1;
        BEntry.User2 = BookingEntryDetails.User2;
        BEntry.User3 = BookingEntryDetails.User3;
        BEntry.User4 = BookingEntryDetails.User4;
        BEntry.User5 = BookingEntryDetails.User5;
        BEntry.Area = BookingEntryDetails.Area;
        BEntry.City = BookingEntryDetails.City;
        BEntry.State = BookingEntryDetails.State;
        BEntry.Country = BookingEntryDetails.Country;
        BEntry.Address = BookingEntryDetails.Address;
        BEntry.BookingDate = DateTime.Now;
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("insert into BookingDetails(OrderNo,ClientUserID,CustomerUserID,FromDate,ToDate,TotalNoOfPersons,TotalNoOfDays,TotalCost,Status,Address,Area,City,State,User1,User2,User3,User4,User5,Bookingdate)values('" + BEntry.OrderNo + "','" + BEntry.ClientUserID + "','" + BEntry.CustomerUserID + "','" + BEntry.FromDate + "','" + BEntry.ToDate + "','" + BEntry.NoOfPersons + "','" + BEntry.TotalNoOfDays + "','" + BEntry.TotalCost + "','" + BEntry.Status + "','" + BEntry.Address + "','" + BEntry.Area + "','" + BEntry.City + "','" + BEntry.State + "','" + BEntry.User1 + "','" + BEntry.User2 + "','" + BEntry.User3 + "','" + BEntry.User4 + "','" + BEntry.User5 + "','" + BEntry.BookingDate + "')", sqlcon);
        //SqlDataReader SDR = cmd.ExecuteReader();
        int i = cmd.ExecuteNonQuery();
        sqlcon.Close();
        if (i > 0)
        {
            Label_OrderSubmit.Text = "Congractulations your Order is Succesfull..... Your Order No is : PGSORD" + GeneratedOrderNo + "";
            Button_PlaceOrder.Visible = false;
            CCpaymentDiv.Visible = false;
            Label_Paymenttype.Visible = false;
            DropDownList1.Visible = false;
            // Thread.Sleep(2000);
            MainClass.EmailSMSType = 1;
            MainClass.OrderNo = "PGSORD" + GeneratedOrderNo;
            Response.Redirect("./OrderDetailsPage.aspx");
        }
        else
        {
            Label_OrderSubmit.Text = "Not Successfull..Please Enter the Fields Correctly and TRY";
        }
        sqlcon.Close();


        //Client.GenerateOrdernoAsync();
        //Client.GenerateOrdernoCompleted += new EventHandler<ServiceReference1.GenerateOrdernoCompletedEventArgs>(Client_GenerateOrdernoCompleted);



    }
    //void Client_GenerateOrdernoCompleted(object sender, ServiceReference1.GenerateOrdernoCompletedEventArgs e)
    //{

    //    GeneratedOrderNo = e.Result;
    //    GeneratedOrderNo = GeneratedOrderNo + 1;
    //    ServiceReference1.BookingEntryDetails fff = new ServiceReference1.BookingEntryDetails();
    //    fff.ClientUserID = BookingEntryDetails.ClientUserID;
    //    fff.CustomerUserID = BookingEntryDetails.CustomerUserID;
    //    fff.OrderNo = "PGS"+ GeneratedOrderNo;
    //    fff.FromDate = BookingEntryDetails.FromDate;
    //    fff.ToDate = BookingEntryDetails.ToDate;
    //    fff.NoOfPersons = BookingEntryDetails.NoOfPersons;
    //    fff.TotalNoOfDays = BookingEntryDetails.TotalNoOfDays.ToString();
    //    fff.TotalCost = BookingEntryDetails.TotalCost;
    //    fff.Status = DropDownList1.SelectedItem.ToString();
    //    fff.User1 = BookingEntryDetails.User1;
    //    fff.User2 = BookingEntryDetails.User2;
    //    fff.User3 = BookingEntryDetails.User3;
    //    fff.User4 = BookingEntryDetails.User4;
    //    fff.User5 = BookingEntryDetails.User5;
    //    fff.Area = BookingEntryDetails.Area;
    //    fff.City = BookingEntryDetails.City;
    //    fff.State = BookingEntryDetails.State;
    //    fff.Country = BookingEntryDetails.Country;
    //    fff.Address = BookingEntryDetails.Address;
    //    fff.BookingDate = DateTime.Now;



    //    //Client.BookPGAsync(fff);
    //    //Client.BookPGCompleted += new EventHandler<ServiceReference1.BookPGCompletedEventArgs>(Client_BookPGCompleted);
    //}

    //void Client_BookPGCompleted(object sender, ServiceReference1.BookPGCompletedEventArgs e)
    //{
    //    //Response.Write(e.Result);
    //    Label_OrderSubmit.Text="Congractulations your Order is Succesfull..... Your Order No is : PGSORD"+ GeneratedOrderNo+"";
    //    Button_PlaceOrder.Visible = false;
    //    CCpaymentDiv.Visible = false;
    //    Label_Paymenttype.Visible = false;
    //    DropDownList1.Visible = false;
    //   // Thread.Sleep(2000);
    //    MainClass.EmailSMSType = 1;
    //    MainClass.OrderNo="PGSORD"+GeneratedOrderNo;
    //    Response.Redirect("./OrderDetailsPage.aspx");
    //}
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "1")
        {
            Button_PlaceOrder.Visible = true;
            CCpaymentDiv.Visible = false;
        }
        else if (DropDownList1.SelectedValue == "2")
        {
            Button_PlaceOrder.Visible = true;
            CCpaymentDiv.Visible = true;
        }
    }

}