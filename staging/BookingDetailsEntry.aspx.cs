using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Views_BookingDetailsEntry : System.Web.UI.Page
{
    public static int Daily_or_Monthly_id = 1;
    public static DateTime FromDate = DateTime.Now.Date;
    public static DateTime ToDate = DateTime.Now.Date;
    public static int NoOfDays;
    public static int NoOfPersons = 1;
    public static int TotalCost;
    public static int NoofMonths = 1;
    public static int CostPerDay = 0;
    List<PGDetails> PGdet;
    public static int GeneratedOrderNo;


    // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            User2div.Visible = false;
            User3div.Visible = false;
            User4div.Visible = false;
            User5div.Visible = false;
            Label_noofmonth.Visible = false;
            DropDownList_noofmonths.Visible = false;
            DatePicker1.SelectedDate = FromDate;
            DatePicker2.SelectedDate = ToDate;
            PGdet = new List<PGDetails>();
            PGdet = ImplementationClass.ParticularPgDetailsList(MainClass.ClientID);
            ListView1.DataSource = PGdet;
            ListView1.DataBind();
            foreach (var item in PGdet)
            {
                CostPerDay = item.CostPerDay;
                BookingEntryDetails.Address = item.PGAddress;
                BookingEntryDetails.Country = item.Country;
                BookingEntryDetails.State = item.State;
                BookingEntryDetails.City = item.City;
                BookingEntryDetails.Area = item.Area;
                BookingEntryDetails.Status = "Cash On Delivery";
                BookingEntryDetails.Costpermonth = item.CostPerMonth;
            }
         
            DropDownList2.Enabled = false;
            DropDownList3.Enabled = false;
            DropDownList4.Enabled = false;
            DropDownList5.Enabled = false;
            DropDownList6.Enabled = false;

          
            DropDownList2.SelectedValue = MainClass.SelectedGender.ToString();
            DropDownList3.SelectedValue = MainClass.SelectedGender.ToString();
            DropDownList4.SelectedValue = MainClass.SelectedGender.ToString();
            DropDownList5.SelectedValue = MainClass.SelectedGender.ToString();
            DropDownList6.SelectedValue = MainClass.SelectedGender.ToString();
            //Client.ParticularPgDetailsListAsync(MainClass.ClientID);

            //Client.ParticularPgDetailsListCompleted += new EventHandler<ServiceReference1.ParticularPgDetailsListCompletedEventArgs>(Client_ParticularPgDetailsListCompleted);


        }
    }



    //void Client_ParticularPgDetailsListCompleted(object sender, ServiceReference1.ParticularPgDetailsListCompletedEventArgs e)

    //{
    //    ListView1.DataSource = e.Result.ToList<ServiceReference1.PGDetails>();
    //    ListView1.DataBind();


    //}
    //public void Client_ParticularPgDetailsListCompleted1()
    // {

    //     PGdet = e.Result.ToList<ServiceReference1.PGDetails>();

    //     foreach (var item in PGdet)
    //     {
    //         CostPerDay = item.CostPerDay;
    //         BookingEntryDetails.Address = item.PGAddress;
    //         BookingEntryDetails.Country = item.Country;
    //         BookingEntryDetails.State = item.State;
    //         BookingEntryDetails.City = item.City;
    //         BookingEntryDetails.Area = item.Area;
    //         BookingEntryDetails.Status = "Cash On Delivery";
    //         BookingEntryDetails.Costpermonth = item.CostPerMonth;
    //     }

    //     BookingEntryDetails.ClientUserID = MainClass.ClientID;
    //     BookingEntryDetails.CustomerUserID = MainClass.UserName;
    //   //  BookingEntryDetails.OrderNo = "ORD" + GeneratedOrderNo;
    //     BookingEntryDetails.FromDate = DatePicker1.SelectedDate;
    //     BookingEntryDetails.ToDate = DatePicker2.SelectedDate;
    //     if (Daily_or_Monthly_id == 1)
    //     {
    //         TimeSpan difference = BookingEntryDetails.ToDate.Subtract(BookingEntryDetails.FromDate);
    //         BookingEntryDetails.TotalNoOfDays = Convert.ToInt32(difference.TotalDays);
    //         BookingEntryDetails.TotalCost = BookingEntryDetails.TotalNoOfDays * BookingEntryDetails.NoOfPersons * CostPerDay;
    //     }
    //     else if (Daily_or_Monthly_id == 2)
    //     {
    //         TimeSpan difference = BookingEntryDetails.ToDate.Subtract(BookingEntryDetails.FromDate);
    //         BookingEntryDetails.TotalNoOfDays = Convert.ToInt32(difference.TotalDays);
    //         BookingEntryDetails.TotalCost = BookingEntryDetails.NoOfPersons * NoofMonths * BookingEntryDetails.Costpermonth;
    //     }
    //     if (BookingEntryDetails.NoOfPersons == 1)
    //     {
    //         BookingEntryDetails.User1 = "Name:" + TextBox1.Text + ","+"Age:"+ TextBox2.Text + "," +"Gender:"+ DropDownList2.SelectedValue + "," +"ID Proof No:"+ TextBox4.Text;
    //         BookingEntryDetails.User2 = "";
    //         BookingEntryDetails.User3 = "";
    //         BookingEntryDetails.User4 = "";
    //         BookingEntryDetails.User5 = "";
    //     }
    //     else if (BookingEntryDetails.NoOfPersons == 2)
    //     {
    //         BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedValue + "," + "ID Proof No:" + TextBox4.Text;
    //         BookingEntryDetails.User2 = "Name:" + TextBox5.Text + "," + "Age:" + TextBox6.Text + "," + "Gender:" + DropDownList3.SelectedValue + "," + "ID Proof No:" + TextBox8.Text;
    //         BookingEntryDetails.User3 = "";
    //         BookingEntryDetails.User4 = "";
    //         BookingEntryDetails.User5 = "";
    //     }
    //     else if (BookingEntryDetails.NoOfPersons == 3)
    //     {
    //         BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedValue + "," + "ID Proof No:" + TextBox4.Text;
    //         BookingEntryDetails.User2 = "Name:" + TextBox5.Text + "," + "Age:" + TextBox6.Text + "," + "Gender:" + DropDownList3.SelectedValue + "," + "ID Proof No:" + TextBox8.Text;
    //         BookingEntryDetails.User3 = "Name:" + TextBox9.Text + "," + "Age:" + TextBox10.Text + "," + "Gender:" + DropDownList4.SelectedValue + "," + "ID Proof No:" + TextBox12.Text;
    //         BookingEntryDetails.User4 = "";
    //         BookingEntryDetails.User5 = "";
    //     }
    //     else if (BookingEntryDetails.NoOfPersons == 4)
    //     {
    //         BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedValue + "," + "ID Proof No:" + TextBox4.Text;
    //         BookingEntryDetails.User2 = "Name:" + TextBox5.Text + "," + "Age:" + TextBox6.Text + "," + "Gender:" + DropDownList3.SelectedValue + "," + "ID Proof No:" + TextBox8.Text;
    //         BookingEntryDetails.User3 = "Name:" + TextBox9.Text + "," + "Age:" + TextBox10.Text + "," + "Gender:" + DropDownList4.SelectedValue + "," + "ID Proof No:" + TextBox12.Text;
    //         BookingEntryDetails.User4 = "Name:" + TextBox13.Text + "," + "Age:" + TextBox14.Text + "," + "Gender:" + DropDownList5.SelectedValue + "," + "ID Proof No:" + TextBox16.Text;
    //         BookingEntryDetails.User5 = "";
    //     }
    //     else if (BookingEntryDetails.NoOfPersons == 5)
    //     {
    //         BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedValue + "," + "ID Proof No:" + TextBox4.Text;
    //         BookingEntryDetails.User2 = "Name:" + TextBox5.Text + "," + "Age:" + TextBox6.Text + "," + "Gender:" + DropDownList3.SelectedValue + "," + "ID Proof No:" + TextBox8.Text;
    //         BookingEntryDetails.User3 = "Name:" + TextBox9.Text + "," + "Age:" + TextBox10.Text + "," + "Gender:" + DropDownList4.SelectedValue + "," + "ID Proof No:" + TextBox12.Text;
    //         BookingEntryDetails.User4 = "Name:" + TextBox13.Text + "," + "Age:" + TextBox14.Text + "," + "Gender:" + DropDownList5.SelectedValue + "," + "ID Proof No:" + TextBox16.Text;
    //         BookingEntryDetails.User5 = "Name:" + TextBox17.Text + "," + "Age:" + TextBox18.Text + "," + "Gender:" + DropDownList6.SelectedValue + "," + "ID Proof No:" + TextBox20.Text;
    //     }




    //     Label_TotalCost.Text = BookingEntryDetails.TotalCost.ToString();



    // }

    public void Total()
    {
        PGdet = new List<PGDetails>();
        PGdet = ImplementationClass.ParticularPgDetailsList(MainClass.ClientID);
        foreach (var item in PGdet)
        {

            CostPerDay = item.CostPerDay;
        }
        BookingEntryDetails.ClientUserID = MainClass.ClientID;
        BookingEntryDetails.CustomerUserID = MainClass.UserName;
        //  BookingEntryDetails.OrderNo = "ORD" + GeneratedOrderNo;
        BookingEntryDetails.FromDate = DatePicker1.SelectedDate;
        BookingEntryDetails.ToDate = DatePicker2.SelectedDate;
        if (Daily_or_Monthly_id == 1)
        {
            TimeSpan difference = BookingEntryDetails.ToDate.Subtract(BookingEntryDetails.FromDate);
            BookingEntryDetails.TotalNoOfDays = Convert.ToInt32(difference.TotalDays);
            BookingEntryDetails.TotalCost = BookingEntryDetails.TotalNoOfDays * BookingEntryDetails.NoOfPersons * CostPerDay;
        }
        else if (Daily_or_Monthly_id == 2)
        {
            TimeSpan difference = BookingEntryDetails.ToDate.Subtract(BookingEntryDetails.FromDate);
            BookingEntryDetails.TotalNoOfDays = Convert.ToInt32(difference.TotalDays);
            BookingEntryDetails.TotalCost = BookingEntryDetails.NoOfPersons * NoofMonths * BookingEntryDetails.Costpermonth;
        }
        if (BookingEntryDetails.NoOfPersons == 1)
        {
            BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedItem + "," + "ID Proof No:" + TextBox4.Text;
            BookingEntryDetails.User2 = "";
            BookingEntryDetails.User3 = "";
            BookingEntryDetails.User4 = "";
            BookingEntryDetails.User5 = "";
        }
        else if (BookingEntryDetails.NoOfPersons == 2)
        {
            BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedItem + "," + "ID Proof No:" + TextBox4.Text;
            BookingEntryDetails.User2 = "Name:" + TextBox5.Text + "," + "Age:" + TextBox6.Text + "," + "Gender:" + DropDownList3.SelectedItem + "," + "ID Proof No:" + TextBox8.Text;
            BookingEntryDetails.User3 = "";
            BookingEntryDetails.User4 = "";
            BookingEntryDetails.User5 = "";
        }
        else if (BookingEntryDetails.NoOfPersons == 3)
        {
            BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedItem + "," + "ID Proof No:" + TextBox4.Text;
            BookingEntryDetails.User2 = "Name:" + TextBox5.Text + "," + "Age:" + TextBox6.Text + "," + "Gender:" + DropDownList3.SelectedItem + "," + "ID Proof No:" + TextBox8.Text;
            BookingEntryDetails.User3 = "Name:" + TextBox9.Text + "," + "Age:" + TextBox10.Text + "," + "Gender:" + DropDownList4.SelectedItem + "," + "ID Proof No:" + TextBox12.Text;
            BookingEntryDetails.User4 = "";
            BookingEntryDetails.User5 = "";
        }
        else if (BookingEntryDetails.NoOfPersons == 4)
        {
            BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedItem + "," + "ID Proof No:" + TextBox4.Text;
            BookingEntryDetails.User2 = "Name:" + TextBox5.Text + "," + "Age:" + TextBox6.Text + "," + "Gender:" + DropDownList3.SelectedItem + "," + "ID Proof No:" + TextBox8.Text;
            BookingEntryDetails.User3 = "Name:" + TextBox9.Text + "," + "Age:" + TextBox10.Text + "," + "Gender:" + DropDownList4.SelectedItem + "," + "ID Proof No:" + TextBox12.Text;
            BookingEntryDetails.User4 = "Name:" + TextBox13.Text + "," + "Age:" + TextBox14.Text + "," + "Gender:" + DropDownList5.SelectedItem + "," + "ID Proof No:" + TextBox16.Text;
            BookingEntryDetails.User5 = "";
        }
        else if (BookingEntryDetails.NoOfPersons == 5)
        {
            BookingEntryDetails.User1 = "Name:" + TextBox1.Text + "," + "Age:" + TextBox2.Text + "," + "Gender:" + DropDownList2.SelectedItem + "," + "ID Proof No:" + TextBox4.Text;
            BookingEntryDetails.User2 = "Name:" + TextBox5.Text + "," + "Age:" + TextBox6.Text + "," + "Gender:" + DropDownList3.SelectedItem + "," + "ID Proof No:" + TextBox8.Text;
            BookingEntryDetails.User3 = "Name:" + TextBox9.Text + "," + "Age:" + TextBox10.Text + "," + "Gender:" + DropDownList4.SelectedItem + "," + "ID Proof No:" + TextBox12.Text;
            BookingEntryDetails.User4 = "Name:" + TextBox13.Text + "," + "Age:" + TextBox14.Text + "," + "Gender:" + DropDownList5.SelectedItem + "," + "ID Proof No:" + TextBox16.Text;
            BookingEntryDetails.User5 = "Name:" + TextBox17.Text + "," + "Age:" + TextBox18.Text + "," + "Gender:" + DropDownList6.SelectedItem + "," + "ID Proof No:" + TextBox20.Text;
        }




        Label_TotalCost.Text = BookingEntryDetails.TotalCost.ToString();
        //Client.ParticularPgDetailsListAsync(MainClass.ClientID);

        //Client.ParticularPgDetailsListCompleted += new EventHandler<ServiceReference1.ParticularPgDetailsListCompletedEventArgs>(Client_ParticularPgDetailsListCompleted1);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Total();
        Response.Redirect("./BookingConfirmationPage.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        BookingEntryDetails.NoOfPersons = Convert.ToInt32(DropDownList1.SelectedValue);
        if (BookingEntryDetails.NoOfPersons == 1)
        {
            User2div.Visible = false;
            User3div.Visible = false;
            User4div.Visible = false;
            User5div.Visible = false;

        }
        else if (BookingEntryDetails.NoOfPersons == 2)
        {
            User2div.Visible = true;
            User3div.Visible = false;
            User4div.Visible = false;
            User5div.Visible = false;
        }
        else if (BookingEntryDetails.NoOfPersons == 3)
        {
            User2div.Visible = true;
            User3div.Visible = true;
            User4div.Visible = false;
            User5div.Visible = false;
        }
        else if (BookingEntryDetails.NoOfPersons == 4)
        {
            User2div.Visible = true;
            User3div.Visible = true;
            User4div.Visible = true;
            User5div.Visible = false;
        }
        else if (BookingEntryDetails.NoOfPersons == 5)
        {
            User2div.Visible = true;
            User3div.Visible = true;
            User4div.Visible = true;
            User5div.Visible = true;
        }

        Total();
    }
    protected void DatePicker1_SelectedDateChanged(object sender, EventArgs e)
    {
        Total();
        DatePicker2.SelectedDate = DatePicker1.SelectedDate.AddDays(30);
    }
    protected void DatePicker2_SelectedDateChanged(object sender, EventArgs e)
    {
        Total();
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        Daily_or_Monthly_id = 1;
        DatePicker2.Enabled = true;
        RadioButton_Monthly.Checked = false;
        DatePicker2.SelectedDate = DateTime.Now.Date;
        Total();
        Label_noofmonth.Visible = false;
        DropDownList_noofmonths.Visible = false;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Daily_or_Monthly_id = 2;
        DatePicker2.Enabled = false;
        RadioButton_Daily.Checked = false;
        DatePicker2.SelectedDate = DatePicker1.SelectedDate.AddDays(30);
        Total();
        Label_noofmonth.Visible = true;
        DropDownList_noofmonths.Visible = true;
    }

    protected void DropDownList_noofmonths_SelectedIndexChanged(object sender, EventArgs e)
    {
        NoofMonths = int.Parse(DropDownList_noofmonths.SelectedValue);
        DatePicker2.SelectedDate = DatePicker1.SelectedDate.AddDays(30 * NoofMonths);
        Total();
    }
   
}