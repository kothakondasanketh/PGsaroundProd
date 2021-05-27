using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net;

public partial class Views_ClientRegPage : System.Web.UI.Page
{


    public int selectedCountry = 0;
    public int selectedState = 0;
    public int selectedCity = 0;
    public int selectedArea = 0;
    public bool AC = false;
    public bool NonAC = false; 
    public bool NIFood = false;
    public bool SIFood = false; public bool Internet = false;
    public bool TV = false;
    public bool Hotwater = false;
    public bool Food3times = false;
    public bool NoFood = false;
    public bool Parkingspace = false;
    public bool Laundry = false;
    public bool Pgprofilepic = false;
    public bool Pgimg1 = false;
    public bool Pgimg2 = false;
    public bool Pgimg3 = false;
    public bool Pgimg4 = false;
    public bool Pgimg5 = false;

    public List<Country> CountryDetails;
    public static string connection = ConfigurationManager.AppSettings["ConnString"];

    SqlConnection sqlcon = new SqlConnection(connection);
    List<Lati_Long_Class> List_Lati_Long = new List<Lati_Long_Class>();
    Lati_Long_Class lst_lat_long = new Lati_Long_Class();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!Page.IsPostBack)
        {
            DatePicker1.SelectedDate = DateTime.Now.Date;

            MainClass.UserTypeID = 2;
            

            //DropDownList_Country.Items.Add("India")
            DropDownList_Country0.Items.Add("India");

            //DropDownList_Area.Items.Add("Select");
            //DropDownList_City.Items.Add("Select");
            //DropDownList_State.Items.Add("Select");

            DropDownList_Area0.Items.Add("Select");
            DropDownList_City0.Items.Add("Select");
            DropDownList_State0.Items.Add("Select");

            CountryDetails = Get_CSCA_Details.Country();
            DropDownList_Country0.DataTextField = "CountryName";
            DropDownList_Country0.DataValueField = "CountryID";
            DropDownList_Country0.DataSource = CountryDetails;
            DropDownList_Country0.DataBind();
           // Client.CountryAsync();
           // Client.CountryCompleted += new EventHandler<ServiceReference1.CountryCompletedEventArgs>(Client_CountryCompleted);
        }

    }

    protected void CheckBox_AC_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_AC.Checked)
        {
            AC = true;
        }
        else if(!CheckBox_AC.Checked)
        {
            AC = false;
        }
    }
    protected void CheckBox_NonAc_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_NonAc.Checked)
        {
            NonAC = true;
        }
        else
        {
            NonAC = false;
        }
    }
    protected void CheckBox_NIFood_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_NIFood.Checked)
        {
            NIFood = true;
        }
        else
        {
            NIFood = false;
        }
    }
    protected void CheckBox_SIFood_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_SIFood.Checked)
        {
            SIFood = true;
        }
        else
        {
            SIFood = false;
        }
    }
    protected void CheckBox_Internet_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_Internet.Checked)
        {
            Internet = true;
        }
        else
        {
            Internet = false;
        }
    }
    protected void CheckBox_Hotwater_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_Hotwater.Checked)
        {
            Hotwater = true;
        }
        else
        {
            Hotwater = false;
        }
    }
    protected void CheckBox_TV_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_TV.Checked)
        {
            TV = true;
        }
        else
        {
            TV = false;
        }
    }
    protected void CheckBox_Food3times_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_Food3times.Checked)
        {
            Food3times = true;
        }
        else
        {
            Food3times = false;
        }
    }
    protected void CheckBox_NoFood_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_NoFood.Checked)
        {
            NoFood = true;
        }
        else
        {
            NoFood = false;
        }
    }
    protected void CheckBox_Parkingspace_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_Parkingspace.Checked)
        {
            Parkingspace = true;
        }
        else
        {
            Parkingspace = false;
        }
    }
    protected void CheckBox_Laundry_CheckedChanged(object sender, EventArgs e)
    {
        if (CheckBox_Laundry.Checked)
        {
            Laundry = true;
        }
        else
        {
            Laundry = false;
        }
    }

   





    protected void Button_SubmitPG_Click(object sender, EventArgs e)
    {
        try
        {

            if (CheckBox_AC.Checked)
            {
                AC = true;
            }
            else if (!CheckBox_AC.Checked)
            {
                AC = false;
            }
            if (CheckBox_NonAc.Checked)
            {
                NonAC = true;
            }
            else
            {
                NonAC = false;
            }
            if (CheckBox_NIFood.Checked)
            {
                NIFood = true;
            }
            else
            {
                NIFood = false;
            }

            if (CheckBox_SIFood.Checked)
            {
                SIFood = true;
            }
            else
            {
                SIFood = false;
            }

            if (CheckBox_Internet.Checked)
            {
                Internet = true;
            }
            else
            {
                Internet = false;
            }

            if (CheckBox_Hotwater.Checked)
            {
                Hotwater = true;
            }
            else
            {
                Hotwater = false;
            }

            if (CheckBox_TV.Checked)
            {
                TV = true;
            }
            else
            {
                TV = false;
            }

            if (CheckBox_Food3times.Checked)
            {
                Food3times = true;
            }
            else
            {
                Food3times = false;
            }

            if (CheckBox_NoFood.Checked)
            {
                NoFood = true;
            }
            else
            {
                NoFood = false;
            }

            if (CheckBox_Parkingspace.Checked)
            {
                Parkingspace = true;
            }
            else
            {
                Parkingspace = false;
            }

            if (CheckBox_Laundry.Checked)
            {
                Laundry = true;
            }
            else
            {
                Laundry = false;
            }

            UserRegister UserReg = new UserRegister();
            UserReg.UserTypeID = 2;
            UserReg.UserName = TextBox_Username.Text;
            UserReg.Password = TextBox_Passwdcnfm.Text;
            UserReg.Name = TextBox_Name.Text;
            UserReg.Age = Convert.ToInt32(TextBox_Age.Text);
            UserReg.EmailID = TextBox_Emailid.Text;
            UserReg.PhoneNo = TextBox_Phno.Text;
            if (DropDownList_Gender.SelectedValue.ToString() == "Male")
            {
                UserReg.Gender = true;
            }
            else
            {
                UserReg.Gender = false;
            }
            UserReg.Address = TextBox_Address.Text;
            UserReg.DOB = DatePicker1.SelectedDate;
            UserReg.Country = "India";//DropDownList_Country.SelectedItem.ToString();
            UserReg.State = "India";
            UserReg.City = "India";
            UserReg.Area = "India";

            Guid Activationkey = Guid.NewGuid();
            //sqlcon.Open();
            //SqlCommand cmd;
            //cmd = new SqlCommand("Insert_Update_UserDetails", sqlcon);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Username", UserReg.UserName);
            //cmd.Parameters.AddWithValue("@Password", UserReg.Password);
            //cmd.Parameters.AddWithValue("@EmailID", UserReg.EmailID);
            //cmd.Parameters.AddWithValue("@Name", UserReg.Name);
            //cmd.Parameters.AddWithValue("@Age", UserReg.Age);
            //cmd.Parameters.AddWithValue("@Gender", UserReg.Gender);
            //cmd.Parameters.AddWithValue("@Phno", UserReg.PhoneNo);
            //cmd.Parameters.AddWithValue("@Address", UserReg.Address);
            //cmd.Parameters.AddWithValue("@DOB", UserReg.DOB);
            //cmd.Parameters.AddWithValue("@UserTypeID", UserReg.UserTypeID);
            //cmd.Parameters.AddWithValue("@TypeId", "2");
            //cmd.Parameters.AddWithValue("@AuthenticationKey", Activationkey);
            //int i = cmd.ExecuteNonQuery();
            //sqlcon.Close();


            PGDetails PGReg = new PGDetails();
            PGReg.PGName = TextBox_PGName.Text;
            PGReg.UserID = TextBox_Username.Text;
            PGReg.PGAddress = TextBox_PGAddress.Text;
            PGReg.PGPhno = TextBox_PGPhno.Text;
            PGReg.Avialability = int.Parse(TextBox_PGAvailability.Text);
            PGReg.CostPerDay = int.Parse(TextBox_PGCostPerDay.Text);
            PGReg.CostPerMonth = int.Parse(TextBox_PGCostPerMonth.Text);
            PGReg.Country = DropDownList_Country0.SelectedItem.ToString();
            PGReg.State = DropDownList_State0.SelectedItem.ToString();
            PGReg.City = DropDownList_City0.SelectedItem.ToString();
            PGReg.Area = DropDownList_Area0.SelectedItem.ToString();
            PGReg.AC = AC.ToString();
            PGReg.NonAC = NonAC.ToString();
            PGReg.NIFood = NIFood.ToString();
            PGReg.SIFood = SIFood.ToString();
            PGReg.TV = TV.ToString();
            PGReg.Internet = Internet.ToString();
            PGReg.Food3times = Food3times.ToString();
            PGReg.NoFood = NoFood.ToString();
            PGReg.Parkingspace = Parkingspace.ToString();
            PGReg.Laundry = Laundry.ToString();
            PGReg.Hotwater = Hotwater.ToString();
            PGReg.Pgservetype = DropDownList_Gender0.SelectedValue;

            PGReg.Pgprofilepic = Fileuploaderprofilepic.FileName;
            PGReg.Pgimg1 = Fileuploaderimg1.FileName;
            PGReg.Pgimg2 = Fileuploaderimg2.FileName;
            PGReg.Pgimg3 = Fileuploaderimg3.FileName;
            PGReg.Pgimg4 = Fileuploaderimg4.FileName;
            PGReg.Pgimg5 = Fileuploaderimg5.FileName;
            PGReg.ConfirmationStas = "Pending";
            PGReg.Latitude = TextBox_Lati.Text;
            PGReg.Longitude = TextBox_Long.Text;

            var folder = Server.MapPath("~/staging/" + TextBox_Username.Text);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            try
            {
                Fileuploaderprofilepic.SaveAs(Server.MapPath("~/staging/" + TextBox_Username.Text + "/" + Fileuploaderprofilepic.FileName));
            }
            catch { }
            try
            {
                Fileuploaderimg1.SaveAs(Server.MapPath("~/staging/" + TextBox_Username.Text + "/" + Fileuploaderimg1.FileName));
            }
            catch { }
            try
            {
                Fileuploaderimg2.SaveAs(Server.MapPath("~/staging/" + TextBox_Username.Text + "/" + Fileuploaderimg2.FileName));
            }
            catch { }
            try
            {
                Fileuploaderimg3.SaveAs(Server.MapPath("~/staging/" + TextBox_Username.Text + "/" + Fileuploaderimg3.FileName));
            }
            catch { }
            try
            {
                Fileuploaderimg4.SaveAs(Server.MapPath("~/staging/" + TextBox_Username.Text + "/" + Fileuploaderimg4.FileName));
            }
            catch { }
            try
            {
                Fileuploaderimg5.SaveAs(Server.MapPath("~/staging/" + TextBox_Username.Text + "/" + Fileuploaderimg5.FileName));
            }
            catch { }







            bool stats = ImplementationClass.UserRegister(UserReg, Activationkey.ToString(), 1);
            bool re = ImplementationClass.PGRegister(PGReg, 1);
            if (stats == true)
            {

                SmtpClient smtpClient = new SmtpClient();
                MailMessage message = new MailMessage();

                MailAddress fromAddress = new MailAddress("noreply@pgsaround.com", "PG'sAround");
                smtpClient.Port = 25;
                smtpClient.Host = "webmail.pgsaround.com";

                message.From = fromAddress;

                message.To.Add(UserReg.EmailID);
                message.Subject = "Account Activation ";

                // Message body content

                string body = "Hello " + UserReg.Name + ",";
                body += "<br /><br />Please click the following link to activate your account";
                body += "<br /><a href = '" + Request.Url.AbsoluteUri.Replace("ClientRegPage.aspx", "UserActivationPage.aspx?ActivationCode=" + Activationkey) + "'>Click here to activate your account.</a>";
                body += "<br /><br />Thanks";
                message.Body = body;
                message.IsBodyHtml = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("noreply@pgsaround.com", "pgsaround123");

                // Send SMTP mail
                smtpClient.Send(message);
            }
        }
        catch { }
       
    }

 
    protected void Button_SubmitPG0_Click(object sender, EventArgs e)
    {
        Response.Redirect("./LoginPage.aspx");
    }
  
   
    protected void DropDownList_State0_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList_City0.Items.Add("Select");
     //   Label_pwd.Text = DropDownList_State0.SelectedItem.Text;
        selectedState = Convert.ToInt32(DropDownList_State0.SelectedValue);
        DropDownList_City0.DataTextField = "CityName";
        DropDownList_City0.DataValueField = "CityID";
        DropDownList_City0.DataSource = Get_CSCA_Details.City(selectedState);
        DropDownList_City0.DataBind();
    }
    protected void DropDownList_City0_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList_Area0.Items.Add("Select");
      //  Label_pwdcnf.Text = DropDownList_City0.SelectedItem.Text;
        selectedCity = Convert.ToInt32(DropDownList_City0.SelectedValue);
        DropDownList_Area0.DataTextField = "AreaName";
        DropDownList_Area0.DataValueField = "AreaID";
        DropDownList_Area0.DataSource = Get_CSCA_Details.Area(selectedCity);
        DropDownList_Area0.DataBind();
    }
    protected void DropDownList_Area0_SelectedIndexChanged(object sender, EventArgs e)
    {
        //DropDownList_City0.Items.Add("Select");
        //Label3.Text = DropDownList_City0.SelectedItem.Text;
        //selectedCity = Convert.ToInt32(DropDownList_City0.SelectedValue);
        //DropDownList_City0.DataTextField = "AreaName";
        //DropDownList_City0.DataValueField = "AreaID";
        //DropDownList_City0.DataSource = Get_CSCA_Details.Area(selectedCity);
        //DropDownList_City0.DataBind();
    }
    protected void Fileuploaderprofilepic_Load(object sender, EventArgs e)
    {
       // Image_Pgprofilepic.ImageUrl = Fileuploaderprofilepic.FileName;
    }

   
    protected void DropDownList_Country0_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList_State0.Items.Add("Select");
       // Label1.Text = DropDownList_Country0.SelectedItem.Text;
        selectedCountry = Convert.ToInt32(DropDownList_Country0.SelectedValue);
        DropDownList_State0.DataTextField = "StateName";
        DropDownList_State0.DataValueField = "StateID";
        DropDownList_State0.DataSource = Get_CSCA_Details.State(selectedCountry);
        DropDownList_State0.DataBind();
    }
   
    protected void Button_Lat_Long_Click(object sender, EventArgs e)
    {
       
        lst_lat_long.Latitude=TextBox_Lati.Text;
        lst_lat_long.Longitude=TextBox_Long.Text;
        List_Lati_Long.Add(lst_lat_long);
        Grid_Lat_Long.DataSource = List_Lati_Long;
        Grid_Lat_Long.DataBind();
    }

    public class Lati_Long_Class
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    
}