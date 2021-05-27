using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Printing;
using System.Net.Mail;
using System.Text;
using System.IO;
using ASPSnippets.SmsAPI;
using System.Net;



public partial class Views_OrderDetailsPage : System.Web.UI.Page
{
    public static string statusord;
    //ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        string UserId = (string)(Session["UserId"]);
        if (UserId != null)
        {
            bookingdetailslist(MainClass.OrderNo);
            // Client.bookingdetailsAsync(MainClass.OrderNo);
            // Client.bookingdetailsCompleted += new EventHandler<ServiceReference1.bookingdetailsCompletedEventArgs>(Client_bookingdetailsCompleted);
        }
        else
        {
            Response.Redirect("./LoginPage.aspx");
        }


    }
    public void bookingdetailslist(string OrderNo)
    {

        List<BookingEntryDetailslocal> bookingdetailsList = new List<BookingEntryDetailslocal>();
        bookingdetailsList = ImplementationClass.bookingdetails(OrderNo);

        GridView_OrderDetails.DataSource = bookingdetailsList;
        GridView_OrderDetails.DataBind();

        foreach (var item in bookingdetailsList)
        {
            Label_BookingDate.Text = item.BookingDate.ToString();
            Label_TodayDate.Text = DateTime.Now.ToString();
            Label_OrderNo0.Text = MainClass.OrderNo;
            Label_TotalCost.Text = item.TotalCost.ToString();
            Label_NoOfPersons.Text = item.NoOfPersons.ToString();
            Label_User1.Text = item.User1;
            Label_User2.Text = item.User2;
            Label_User3.Text = item.User3;
            Label_User4.Text = item.User4;
            Label_User5.Text = item.User5;
            statusord = item.Status;

            OrderDisplayClass.BookingDate = item.BookingDate.ToString();
            OrderDisplayClass.OrderNo = MainClass.OrderNo;
            OrderDisplayClass.TotalCost = item.TotalCost.ToString();
            OrderDisplayClass.NoOfPersonsAllowed = item.NoOfPersons.ToString();
            OrderDisplayClass.User1 = item.User1;
            OrderDisplayClass.User2 = item.User2;
            OrderDisplayClass.User3 = item.User3;
            OrderDisplayClass.User4 = item.User4;
            OrderDisplayClass.User5 = item.User5;
            OrderDisplayClass.Status = item.Status;
            OrderDisplayClass.FromDate = item.FromDate.ToString();
            OrderDisplayClass.ToDate = item.ToDate.ToString();
            OrderDisplayClass.Noofdays = item.TotalNoOfDays.ToString();


            if (item.NoOfPersons == 1)
            {
                Label_User2.Visible = false;
                Label_User3.Visible = false;
                Label_User4.Visible = false;
                Label_User5.Visible = false;

                Label_usr2.Visible = false;
                Label_usr3.Visible = false;
                Label_usr4.Visible = false;
                Label_usr5.Visible = false;
            }
            else if (item.NoOfPersons == 2)
            {
                Label_User2.Visible = true;
                Label_User3.Visible = false;
                Label_User4.Visible = false;
                Label_User5.Visible = false;

                Label_usr2.Visible = true;
                Label_usr3.Visible = false;
                Label_usr4.Visible = false;
                Label_usr5.Visible = false;
            }
            else if (item.NoOfPersons == 3)
            {
                Label_User2.Visible = true;
                Label_User3.Visible = true;
                Label_User4.Visible = false;
                Label_User5.Visible = false;

                Label_usr2.Visible = true;
                Label_usr3.Visible = true;
                Label_usr4.Visible = false;
                Label_usr5.Visible = false;
            }
            else if (item.NoOfPersons == 4)
            {
                Label_User2.Visible = true;
                Label_User3.Visible = true;
                Label_User4.Visible = true;
                Label_User5.Visible = false;

                Label_usr2.Visible = true;
                Label_usr3.Visible = true;
                Label_usr4.Visible = true;
                Label_usr5.Visible = false;
            }
            else if (item.NoOfPersons == 5)
            {
                Label_User2.Visible = true;
                Label_User3.Visible = true;
                Label_User4.Visible = true;
                Label_User5.Visible = true;

                Label_usr2.Visible = true;
                Label_usr3.Visible = true;
                Label_usr4.Visible = true;
                Label_usr5.Visible = true;
            }



            try
            {
                if (MainClass.LoginType == 1)
                {
                    List<UserRegister> userdet = new List<UserRegister>();
                    userdet = ImplementationClass.GetUserDetails(MainClass.UserName);
                    foreach (var item2 in userdet)
                    {
                        Label_UserName.Text = item2.Name;
                        Label_Userphno.Text = item2.PhoneNo;
                        Label_UserAddress.Text = item2.Address;
                        MainClass.UserEmailID = item2.EmailID;


                        OrderDisplayClass.Name = item2.Name;
                        OrderDisplayClass.Phno = item2.PhoneNo;
                        OrderDisplayClass.Address = item2.Address;
                        OrderDisplayClass.Emailid = item2.EmailID;
                    }


                }
                else if (MainClass.LoginType == 2)
                {
                    Label_UserName.Text = MainClass.Name;
                    Label_Userphno.Text = MainClass.gphno;
                    Label_UserAddress.Text = "NA";
                    MainClass.UserEmailID = MainClass.UserEmailID;

                    OrderDisplayClass.Name = MainClass.Name;
                    OrderDisplayClass.Phno = MainClass.gphno;
                    OrderDisplayClass.Address = "NA";
                    OrderDisplayClass.Emailid = MainClass.UserEmailID;


                }
                if (MainClass.EmailSMSType.Equals(1))
                {
                    sendsms(OrderDisplayClass.Phno, MainClass.OrderNo, OrderDisplayClass.Name);

                }
            }
            catch { }

            List<PGDetails> pgdet = new List<PGDetails>();
            pgdet = ImplementationClass.ParticularPgDetailsList(MainClass.ClientID);
            foreach (var item1 in pgdet)
            {
                Label_PGName.Text = item1.PGName;
                Label_PGPHno.Text = item1.PGPhno;
                Label_PGAddress.Text = item1.PGAddress;

                OrderDisplayClass.PgName = item1.PGName;
                OrderDisplayClass.PgPhno = item1.PGPhno;
                OrderDisplayClass.PgAddress = item1.PGAddress;
            }
            if (MainClass.EmailSMSType.Equals(1))
            {
                MailSend(MainClass.UserEmailID);
                MainClass.EmailSMSType = 0;
            }
        }

    }

    //void Client_ParticularPgDetailsListCompleted(object sender, ServiceReference1.ParticularPgDetailsListCompletedEventArgs e)
    //{
    //    List<ServiceReference1.PGDetails> pgdet = new List<ServiceReference1.PGDetails>();
    //    pgdet = e.Result.ToList<ServiceReference1.PGDetails>();
    //    foreach (var item in pgdet)
    //    {
    //        Label_PGName.Text = item.PGName;
    //        Label_PGPHno.Text = item.PGPhno;
    //        Label_PGAddress.Text = item.PGAddress;

    //     OrderDisplayClass.PgName = item.PGName;
    //     OrderDisplayClass.PgPhno = item.PGPhno;
    //     OrderDisplayClass.PgAddress = item.PGAddress;
    //    }
    //    if (MainClass.EmailSMSType.Equals(1))
    //    {
    //        MailSend(MainClass.UserEmailID);
    //        MainClass.EmailSMSType = 0;
    //    }


    //}

    //void Client_GetUserDetailsCompleted(object sender, ServiceReference1.GetUserDetailsCompletedEventArgs e)
    //{
    //    try
    //    {
    //        if (MainClass.LoginType == 1)
    //        {
    //            List<ServiceReference1.UserRegister> userdet = new List<ServiceReference1.UserRegister>();
    //            userdet = e.Result.ToList<ServiceReference1.UserRegister>();
    //            foreach (var item in userdet)
    //            {
    //                Label_UserName.Text = item.Name;
    //                Label_Userphno.Text = item.PhoneNo;
    //                Label_UserAddress.Text = item.Address;
    //                MainClass.UserEmailID = item.EmailID;


    //                OrderDisplayClass.Name = item.Name;
    //                OrderDisplayClass.Phno = item.PhoneNo;
    //                OrderDisplayClass.Address = item.Address;
    //                OrderDisplayClass.Emailid = item.EmailID;
    //            }


    //        }
    //        else if (MainClass.LoginType == 2)
    //        {
    //            Label_UserName.Text = MainClass.Name;
    //            Label_Userphno.Text = MainClass.gphno;
    //            Label_UserAddress.Text = "NA";
    //            MainClass.UserEmailID = MainClass.UserEmailID;

    //            OrderDisplayClass.Name = MainClass.Name;
    //            OrderDisplayClass.Phno = MainClass.gphno;
    //            OrderDisplayClass.Address = "NA";
    //            OrderDisplayClass.Emailid = MainClass.UserEmailID;


    //        }
    //        if (MainClass.EmailSMSType.Equals(1))
    //        {
    //            sendsms(OrderDisplayClass.Phno, MainClass.OrderNo, OrderDisplayClass.Name);

    //        }
    //    }
    //    catch { }



    //}

    public static string GetResponse(string sURL)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL); request.MaximumAutomaticRedirections = 4;
        request.Credentials = CredentialCache.DefaultCredentials;
        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse(); Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8); string sResponse = readStream.ReadToEnd();
            response.Close();
            readStream.Close();
            return sResponse;
        }
        catch
        {
            return "";
        }
    }
    public void sendsms(string userphno, string orderno, string name)
    {
        SMS.APIType = SMSGateway.Site2SMS;
        SMS.MashapeKey = "e7UaclATnsfoj2pbWTa8hgEZs0qEaHWW";
        SMS.Username = "7829880181";
        SMS.Password = "sankethkmr";
        SMS.SendSms(userphno, "Hello " + name + ",Congractulartions..Your Order No- " + orderno + " is successfull.Please login to www.pgsaround.com to view complete order.Thankyou");
        string sUserID = "ksankethkumar";
        string sPwd = "sankethkmr";
        string sNumber = userphno;
        string sSID = "WEBSMS";
        string sMessage = "Hello " + name + ",Congractulartions..Your Order No- " + orderno + " is successfull.Please login to www.pgsaround.com to view complete order.Thankyou";
        string sURL = "http://clients.smshorizon.in/sms_api/sendsms.php?username=" + sUserID + "&password=" + sPwd + "&mobile=" + sNumber + "&sendername=" + sSID + "&message=" + sMessage + "&routetype=0";
        string sResponse = GetResponse(sURL); Response.Write(sResponse);
    }
    public void MailSend(string Tomail)
    {
        try
        {
            StreamReader reader = new StreamReader(Server.MapPath("~/OrderMailhtml6.htm"));
            string readFile = reader.ReadToEnd();
            string myString = "";
            myString = readFile;
            myString = myString.Replace("$$OrderNo$$", OrderDisplayClass.OrderNo);
            myString = myString.Replace("$$Date$$", DateTime.Now.ToString());
            myString = myString.Replace("$$BookingDate$$", OrderDisplayClass.BookingDate);


            myString = myString.Replace("$$Name$$", OrderDisplayClass.Name);
            myString = myString.Replace("$$Address$$", OrderDisplayClass.Address);
            myString = myString.Replace("$$PhoneNo$$", OrderDisplayClass.Phno);
            myString = myString.Replace("$$Email$$", OrderDisplayClass.Emailid);

            myString = myString.Replace("$$PGName$$", OrderDisplayClass.PgName);
            myString = myString.Replace("$$PGAddress$$", OrderDisplayClass.PgAddress);
            myString = myString.Replace("$$PGPhoneNo$$", OrderDisplayClass.PgPhno);

            myString = myString.Replace("$$FromDate$$", OrderDisplayClass.FromDate);
            myString = myString.Replace("$$ToDate$$", OrderDisplayClass.ToDate);
            myString = myString.Replace("$$NoOfDays$$", OrderDisplayClass.Noofdays);
            myString = myString.Replace("$$Status$$", OrderDisplayClass.Status);
            myString = myString.Replace("$$TotalCost$$", OrderDisplayClass.TotalCost);

            myString = myString.Replace("$$NoOfPersonsAllowed$$", OrderDisplayClass.NoOfPersonsAllowed);

            myString = myString.Replace("$$User1$$", OrderDisplayClass.User1);
            myString = myString.Replace("$$User2$$", OrderDisplayClass.User2);
            myString = myString.Replace("$$User3$$", OrderDisplayClass.User3);
            myString = myString.Replace("$$User4$$", OrderDisplayClass.User4);
            myString = myString.Replace("$$User5$$", OrderDisplayClass.User5);

            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();

            MailAddress fromAddress = new MailAddress("orders@pgsaround.com", "PG'sAround");
            smtpClient.Port = 25;
            smtpClient.Host = "webmail.pgsaround.com";

            //From address will be given as a MailAddress Object
            message.From = fromAddress;

            // To address collection of MailAddress
            message.To.Add(Tomail);
            message.Subject = "Your Order No: " + MainClass.OrderNo + " Confirmation"; ;

            // CC and BCC optional
            // MailAddressCollection class is used to send the email to various users
            // You can specify Address as new MailAddress("admin1@yoursite.com")

            //message.CC.Add("customercare@pgsaround.com");

            //Body can be Html or text format
            //Specify true if it  is html message
            message.IsBodyHtml = true;

            // Message body content
            message.Body = myString;



            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("orders@pgsaround.com", "sankethkmr@55");


            // Send SMTP mail
            smtpClient.Send(message);


            //using (MailMessage mailMessage = new MailMessage())
            //{
            //    mailMessage.From = new MailAddress("pgsaround@gmail.com");
            //    mailMessage.Subject = "Your Order " + MainClass.OrderNo + " Confirmation";
            //    mailMessage.Body = myString;
            //    mailMessage.IsBodyHtml = true;
            //    mailMessage.To.Add(new MailAddress(Tomail));


            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.EnableSsl = true;
            //    System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
            //    NetworkCred.UserName = mailMessage.From.Address;
            //    NetworkCred.Password = "pgsaround@123";
            //    smtp.UseDefaultCredentials = true;
            //    smtp.Credentials = NetworkCred;
            //    smtp.Port = 587;
            //    smtp.Send(mailMessage);
            //}
        }
        catch { Exception ex; }


    }

}