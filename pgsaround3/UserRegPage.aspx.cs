using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Configuration;


public partial class Views_UserRegPage : System.Web.UI.Page
{
    public int selectedCountry = 0;
    public int selectedState = 0;
    public int selectedCity = 0;
    public int selectedArea = 0;

    public static string connection = ConfigurationManager.AppSettings["ConnString"];

    SqlConnection sqlcon = new SqlConnection(connection);
    public List<Country> CountryDetails;
    // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DatePicker1.SelectedDate = DateTime.Now.Date;


            MainClass.UserTypeID = 1;
            CountryDetails = Get_CSCA_Details.Country();
            //DropDownList_Country.DataTextField = "CountryName";
            //DropDownList_Country.DataValueField = "CountryID";
            //DropDownList_Country.DataSource = CountryDetails;
            //DropDownList_Country.DataBind();


            //  Client.CountryAsync();
            //  Client.CountryCompleted += new EventHandler<ServiceReference1.CountryCompletedEventArgs>(Client_CountryCompleted);
        }

    }
    //void Client_CountryCompleted(object sender, ServiceReference1.CountryCompletedEventArgs e)
    //{
    //    try
    //    {
    //        CountryDetails = e.Result.ToList<ServiceReference1.Country>();


    //        DropDownList_Country.DataTextField = "CountryName";
    //        DropDownList_Country.DataValueField = "CountryID";
    //        DropDownList_Country.DataSource = CountryDetails;
    //        DropDownList_Country.DataBind();
    //    }
    //    catch (Exception ex) { Response.Write("Sorry For The InConvienence....We are facing some technical problems.Please try After Some Time"); }





    //}



    //protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    //{


    //    // Label1.Text = DropDownList1.SelectedItem.Text;
    //    selectedCountry = Convert.ToInt32(DropDownList_Country.SelectedValue);

    //    DropDownList_State.DataTextField = "StateName";
    //    DropDownList_State.DataValueField = "StateID";
    //    DropDownList_State.DataSource = Get_CSCA_Details.State(selectedCountry);
    //    DropDownList_State.DataBind();

    //    //Client.StateAsync(selectedCountry);
    //    //Client.StateCompleted += new EventHandler<ServiceReference1.StateCompletedEventArgs>(Client_StateCompleted);
    //}

    //void Client_StateCompleted(object sender, ServiceReference1.StateCompletedEventArgs e)
    //{


    //    DropDownList_State.DataTextField = "StateName";
    //    DropDownList_State.DataValueField = "StateID";
    //    DropDownList_State.DataSource = e.Result.ToList<ServiceReference1.State>();
    //    DropDownList_State.DataBind();

    //}



    //protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    //Label2.Text = DropDownList2.SelectedItem.Text;
    //    selectedState = Convert.ToInt32(DropDownList_State.SelectedValue);
    //    DropDownList_City.DataTextField = "CityName";
    //    DropDownList_City.DataValueField = "CityID";
    //    DropDownList_City.DataSource = Get_CSCA_Details.City(selectedState);
    //    DropDownList_City.DataBind();
    //    // Client.CityAsync(selectedState);
    //    //Client.CityCompleted += new EventHandler<ServiceReference1.CityCompletedEventArgs>(Client_CityCompleted);
    //}
    //void Client_CityCompleted(object sender, ServiceReference1.CityCompletedEventArgs e)
    //{

    //    DropDownList_City.DataTextField = "CityName";
    //    DropDownList_City.DataValueField = "CityID";
    //    DropDownList_City.DataSource = e.Result.ToList<ServiceReference1.Cities>();
    //    DropDownList_City.DataBind();
    //}

    //protected void DropDownList9_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    // Label3.Text = DropDownList3.SelectedItem.Text;
    //    selectedCity = Convert.ToInt32(DropDownList_City.SelectedValue);
    //    DropDownList_Area.DataTextField = "AreaName";
    //    DropDownList_Area.DataValueField = "AreaID";
    //    DropDownList_Area.DataSource = Get_CSCA_Details.Area(selectedCity);
    //    DropDownList_Area.DataBind();
    //    // Client.AreaAsync(selectedCity);
    //    //  Client.AreaCompleted += new EventHandler<ServiceReference1.AreaCompletedEventArgs>(Client_AreaCompleted);

    //}

    //void Client_AreaCompleted(object sender, ServiceReference1.AreaCompletedEventArgs e)
    //{


    //    DropDownList_Area.DataTextField = "AreaName";
    //    DropDownList_Area.DataValueField = "AreaID";
    //    DropDownList_Area.DataSource = e.Result.ToList<ServiceReference1.Area>();
    //    DropDownList_Area.DataBind();

    //}

    //protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    //Label4.Text = DropDownList4.SelectedItem.Text;
    //    string selectedarea = DropDownList_Area.SelectedItem.Text;
    //    selectedArea = Convert.ToInt32(DropDownList_Area.SelectedValue);

    //}



    protected void Button_Submit_Click(object sender, EventArgs e)
    {
        try
        {


            MainClass.UserTypeID=1;
            UserRegister Userdetails = new UserRegister();
            Userdetails.UserTypeID =MainClass.UserTypeID ;
            Userdetails.UserName = email.Text;
            Userdetails.Password = password.Text;
            Userdetails.Name = name.Text;
            Userdetails.Age = Convert.ToInt32(age.Text);
            Userdetails.EmailID = email.Text;
            MainClass.UserEmailID = email.Text;
            Userdetails.PhoneNo = phno.Text;
            if (DropDownList_Gender.SelectedValue.ToString() == "Male")
            {
                Userdetails.Gender = true;
            }
            else
            {
                Userdetails.Gender = false;
            }
            Userdetails.Address = address.Text;
            Userdetails.DOB = DatePicker1.SelectedDate;
            Userdetails.Country = "NA";
            Userdetails.State = "NA";
            Userdetails.City = "NA";
            Userdetails.Area = "NA";


            sqlcon.Open();
            SqlCommand cmd;


            cmd = new SqlCommand("insert into UserDetails(UserName,Password,EmailID,Name,Age,Gender,Phno,Address,Area,City,State,Country,DOB,UserTypeID)values('" + Userdetails.UserName + "','" + Userdetails.Password + "','" + Userdetails.EmailID + "','" + Userdetails.Name + "','" + Userdetails.Age + "','" + Userdetails.Gender + "','" + Userdetails.PhoneNo + "','" + Userdetails.Address + "','" + Userdetails.Area + "','" + Userdetails.City + "','" + Userdetails.State + "','" + Userdetails.Country + "','" + Userdetails.DOB.Date + "','" + Userdetails.UserTypeID + "')", sqlcon);
            //SqlDataReader SDR = cmd.ExecuteReader();
            int i = cmd.ExecuteNonQuery();
            sqlcon.Close();
            if (i > 0)
            {
                Guid Activationkey = Guid.NewGuid();

                string ConString = ConfigurationManager.AppSettings["ConnString"];
                sqlcon = new SqlConnection(ConString);
                cmd = new SqlCommand("insert into UserAuthentication(Username,Status,AuthenticationKey)values('" + email.Text + "','0','" + Activationkey + "')", sqlcon);
                //SqlDataReader SDR = cmd.ExecuteReader();
                sqlcon.Open();
                int i1 = cmd.ExecuteNonQuery();
                sqlcon.Close();

                SmtpClient smtpClient = new SmtpClient();
                MailMessage message = new MailMessage();

                MailAddress fromAddress = new MailAddress("noreply@pgsaround.com", "PG'sAround");
                smtpClient.Port = 25;
                smtpClient.Host = "webmail.pgsaround.com";

                message.From = fromAddress;

                message.To.Add(MainClass.UserEmailID);
                message.Subject = "Account Activation ";

                // Message body content

                string body = "Hello " + name.Text.Trim() + ",";
                body += "<br /><br />Please click the following link to activate your account";
                body += "<br /><a href = '" + Request.Url.AbsoluteUri.Replace("UserRegPage.aspx", "UserActivationPage.aspx?ActivationCode=" + Activationkey) + "'>Click here to activate your account.</a>";
                body += "<br /><br />Thanks";
                message.Body = body;
                message.IsBodyHtml = true;
                // message.Body = "Dear Customer.Please click on below url to activate your account. http://localhost:2540/BookPG_Website_Version5/Views/UserActivationPage.aspx?ActivationCode=" +Activationkey;



                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("noreply@pgsaround.com", "pgsaround123");


                // Send SMTP mail
                smtpClient.Send(message);
            }
            else
            {
                string Successfull = "Not Successfull..Please Enter the Fields Correctly and TRY";
            }

            sqlcon.Close();
            // Client.UserRegisterAsync(UserReg, 1);
            // Client.UserRegisterCompleted += new EventHandler<ServiceReference1.UserRegisterCompletedEventArgs>(Client_UserRegisterCompleted);



        }
        catch { }



    }

    
    protected void Button_Submit0_Click(object sender, EventArgs e)
    {
        Response.Redirect("./LoginPage.aspx");
    }
  
}