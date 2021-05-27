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
using System.Data;


public partial class Views_UserRegPage : System.Web.UI.Page
{
    public int selectedCountry = 0;
    public int selectedState = 0;
    public int selectedCity = 0;
    public int selectedArea = 0;

    public static string connection = ConfigurationManager.AppSettings["ConnString"];

    SqlConnection sqlcon = new SqlConnection(connection);
    // public List<Country> CountryDetails;
    // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtDate.Text = DateTime.Now.Date.ToString();


            MainClass.UserTypeID = 1;

        }

    }



    protected void Button_Submit_Click(object sender, EventArgs e)
    {
        try
        {

            string Successfull = "";


            MainClass.UserTypeID = 1;
            UserRegister Userdetails = new UserRegister();
            Userdetails.UserTypeID = MainClass.UserTypeID;
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
            Userdetails.DOB = DateTime.Parse(txtDate.Text);
            Userdetails.Country = "India";
            Userdetails.State = "India";
            Userdetails.City = "India";
            Userdetails.Area = "India";

            Guid Activationkey = Guid.NewGuid();
           
            bool stats = ImplementationClass.UserRegister(Userdetails, Activationkey.ToString(), 1);
            if (stats==true)
            {
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


            Successfull = "Welcome...Your Registration is Successfull..Please Login to your Mail and Activate your account to continue.";


            email.Text = "";
            password.Text = "";
            confirmpassword.Text = "";
            name.Text = "";
            txtDate.Text = "";
            age.Text = "";
            phno.Text = "";
            address.Text = "";

            lbl_DisplayMsg.Text = Successfull;

        }
        catch
        {
            email.Text = "";
            password.Text = "";
            confirmpassword.Text = "";
            name.Text = "";
            txtDate.Text = "";
            age.Text = "";
            phno.Text = "";
            address.Text = "";




        }



    }


    protected void Button_Submit0_Click(object sender, EventArgs e)
    {
        Response.Redirect("./LoginPage.aspx");
    }

}