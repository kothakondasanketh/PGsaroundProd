using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Reflection;
using System.Net;
using System.Net.Mail;
using ASPSnippets.SmsAPI;

public partial class Views_AdminPage : System.Web.UI.Page
{
    // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    string connection = ConfigurationManager.AppSettings["ConnString"];
    List<Phn_Email_List> listphnEmail = new List<Phn_Email_List>();
    
    protected void Page_Load(object sender, EventArgs e)
    {
      
        try
        {
           
            string UserId = (string)(Session["UserId"]);
            if (UserId == null)
            {
                Response.Redirect("./LoginPage.aspx");
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(connection);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select Name,PhoneNo,EmailId from RK_Phn_Email", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("RK_Phn_Email");
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                SqlDataReader rdr1 = cmd.ExecuteReader();

                Phn_Email_List PhnEmail = new Phn_Email_List();

                PhnEmail = new Phn_Email_List();

                Phn_Email_List obj = default(Phn_Email_List);
                while (rdr1.Read())
                {
                    obj = Activator.CreateInstance<Phn_Email_List>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        if (!object.Equals(rdr1[prop.Name], DBNull.Value))
                        {
                            prop.SetValue(obj, rdr1[prop.Name], null);
                        }
                    }
                    listphnEmail.Add(obj);
                }

                sqlcon.Close();
            }
           
        }
        catch { }
       
    }

    public class Phn_Email_List
    {
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        try
        {
            string path = Server.MapPath("~/ramakrishnaclothes/ramkrishna");
            foreach (var file in Directory.GetFiles(path))
            {
                File.Delete(file);
            }

            try
            {
                Fileupload1.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload1.FileName));
            }
            catch { }
            try{
                Fileupload2.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload2.FileName));
            }
            catch { }
            try
            {
                Fileupload3.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload3.FileName));
            }
            catch { }
            try
            {

                Fileupload4.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload4.FileName));
            }
            catch {  }
            try{
                Fileupload5.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload5.FileName));
                }
            catch {  }
            try{
                Fileupload6.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload6.FileName));
            }
            catch { }
            try
            {
                Fileupload7.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload7.FileName));
            }
            catch { }
            try{
                Fileupload8.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload8.FileName));
            }
            catch { }
            try{
                Fileupload9.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload9.FileName));
            }
            catch { }
            try{
                Fileupload10.SaveAs(Server.MapPath("~/ramakrishnaclothes/ramkrishna/" + Fileupload10.FileName));
            }
            catch { }
            

            sendsms();
            MailSend();

            Lbl_Status_msg.Text = "Successfully Submitted";
        }
        catch
        {
            Lbl_Status_msg.Text = "Some thing Went wrong Please Try Again.";
        }
        

    }
    public void sendsms()
    {
        List<string> numbers = new List<string>();
        foreach (var item in listphnEmail)
        {
            numbers.Add(item.PhoneNo);
        }

        SMS.APIType = SMSGateway.Site2SMS;
        SMS.MashapeKey = "e7UaclATnsfoj2pbWTa8hgEZs0qEaHWW";
        SMS.Username = "7829880181";
        SMS.Password = "sankethkmr";

        SMS.SendSms(numbers, "Hello Everybody..New stock has been appeared so be the first to grab it..You can also view the images at www.pgsaround.com/ramakrishnaclothes");
       
    }
    public void MailSend()
    {
        try
        {
            List<string> numbers = new List<string>();
            foreach (var item in listphnEmail)
            {
                numbers.Add(item.EmailId);
            }

            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();

            MailAddress fromAddress = new MailAddress("noreply@pgsaround.com", "Rama krishna Clothes");
            smtpClient.Port = 25;
            smtpClient.Host = "webmail.pgsaround.com";

            //From address will be given as a MailAddress Object
            message.From = fromAddress;

            //string[] multi = Tomail.Split(',');
            foreach (var multiemail in numbers)
            {
                message.To.Add(new MailAddress(multiemail));
            }
            // To address collection of MailAddress
           // message.To.Add(Tomail);
            message.Subject = "New Arrivals Appreared...grab it sooon..be the first"; ;

            // CC and BCC optional
            // MailAddressCollection class is used to send the email to various users
            // You can specify Address as new MailAddress("admin1@yoursite.com")

            //message.CC.Add("customercare@pgsaround.com");

            //Body can be Html or text format
            //Specify true if it  is html message
            message.IsBodyHtml = false;

            // Message body content
            message.Body = "Hello Everybody..New stock has been appeared so be the first to grab it....You can also view the images at www.pgsaround.com/ramakrishnaclothes using Username: User and Password: ramakrishna1234. Thank you.";



            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("noreply@pgsaround.com", "pgsaround123");


            // Send SMTP mail
            smtpClient.Send(message);


       
        }
        catch { Exception ex; }


    }
    protected void Button_phnupload_Click(object sender, EventArgs e)
    {
       
        try
        {
            SqlConnection sqlcon = new SqlConnection(connection);

            SqlCommand cmd;
            SqlDataAdapter sda;
            DataTable dt;
            SqlDataReader rdr1;

            sqlcon.Open();
            cmd = new SqlCommand("INSERT INTO RK_Phn_Email (Name,PhoneNo,EmailId)VALUES('" + TextBox_name.Text + "','" + TextBox_Phoneno.Text + "','" + TextBox_Email.Text + "')", sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();




            sqlcon.Open();
            cmd = new SqlCommand("select Name,PhoneNo,EmailId from RK_Phn_Email", sqlcon);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable("RK_Phn_Email");
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            sqlcon.Close();


            lbl_msg.Text = "Successfully Uploaded";
            TextBox_Email.Text = "";
            TextBox_name.Text = "";
            TextBox_Phoneno.Text = "";
        }
        catch { Lbl_Status_msg.Text = "Enter the Values Correctly and try"; }
       
    }
    
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["UserId"] = null;
        Response.Buffer = true;
        Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
        Response.Expires = -1500;
        Response.CacheControl = "no-cache";
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Redirect("./LoginPage.aspx");
    }
}