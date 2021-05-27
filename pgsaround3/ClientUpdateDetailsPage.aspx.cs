using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_ClientUpdateDetailsPage : System.Web.UI.Page
{
    public int selectedCountry = 0;
    public int selectedState = 0;
    public int selectedCity = 0;
    public int selectedArea = 0;


    public List<Country> CountryDetails;
   // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DatePicker1.SelectedDate = DateTime.Now.Date;


            
            //Client.CountryAsync();
            //Client.CountryCompleted += new EventHandler<ServiceReference1.CountryCompletedEventArgs>(Client_CountryCompleted);

            //Client.GetUserDetailsAsync(MainClass.UserName);
            //Client.GetUserDetailsCompleted += new EventHandler<ServiceReference1.GetUserDetailsCompletedEventArgs>(Client_GetUserDetailsCompleted);

            //Client.ParticularPgDetailsListAsync(MainClass.UserName);
            //Client.ParticularPgDetailsListCompleted += new EventHandler<ServiceReference1.ParticularPgDetailsListCompletedEventArgs>(Client_ParticularPgDetailsListCompleted);
        }

    }

    //void Client_ParticularPgDetailsListCompleted(object sender, ServiceReference1.ParticularPgDetailsListCompletedEventArgs e)
    //{
    //    List<ServiceReference1.PGDetails> PGdetLst = new List<ServiceReference1.PGDetails>();
    //    PGdetLst = e.Result.ToList<ServiceReference1.PGDetails>();
    //    foreach (var PGdet in PGdetLst)
    //    {
           
    //        TextBox_PGName.Text = PGdet.PGName;
    //        TextBox_PGAddress.Text = PGdet.PGAddress;
    //        TextBox_PGPhno.Text = PGdet.PGPhno;
    //        TextBox_PGAvailability.Text = PGdet.Avialability.ToString();
    //        TextBox_PGCostPerDay.Text = PGdet.CostPerDay.ToString();
    //        TextBox_PGCostPerMonth.Text = PGdet.CostPerMonth.ToString();
    //        Label_Status.Text = PGdet.ConfirmationStas;
         

    //    }
    //}

    //void Client_GetUserDetailsCompleted(object sender, ServiceReference1.GetUserDetailsCompletedEventArgs e)
    //{
    //    List<ServiceReference1.UserRegister> UserRegDet = new List<ServiceReference1.UserRegister>();
       

    //    UserRegDet = e.Result.ToList<ServiceReference1.UserRegister>();
    //    foreach (var UserReg in UserRegDet)
    //    {
    //        // UserReg.UserTypeID = MainClass.UserTypeID;
    //        TextBox_Passwd.Text = UserReg.Password;
    //        TextBox_Passwdcnfm.Text = UserReg.Password;
    //        TextBox_Username.Text = UserReg.UserName;
    //        TextBox_Passwdcnfm.Text = UserReg.Password;
    //        TextBox_Name.Text = UserReg.Name;
    //        TextBox_Age.Text = UserReg.Age.ToString();
    //        TextBox_Emailid.Text = UserReg.EmailID;
    //        TextBox_Phno.Text = UserReg.PhoneNo;
    //        if (UserReg.Gender == true)
    //        {
    //            DropDownList_Gender.SelectedValue = "Male";
    //        }
    //        else
    //        {
    //            DropDownList_Gender.SelectedValue = "Female";
    //        }

    //        TextBox_Address.Text = UserReg.Address;
    //        DatePicker1.SelectedDate = UserReg.DOB;

    //        //DropDownList_Country.Items.FindByText(UserReg.Country).Selected =true;
    //        DropDownList_Country.DataTextField = UserReg.Country;
    //        DropDownList_State.DataTextField = UserReg.State;
    //        DropDownList_City.DataTextField = UserReg.City;
    //        DropDownList_Area.DataTextField = UserReg.Area;



    //    }

    //}
    //void Client_CountryCompleted(object sender, ServiceReference1.CountryCompletedEventArgs e)
    //{
    //    try
    //    {
    //        CountryDetails = e.Result.ToList<ServiceReference1.Country>();
    //        //DropDownList1.DataTextField = "CountryName";
    //        //DropDownList1.DataValueField = "CountryID";
    //        //DropDownList1.DataSource = CountryDetails;
    //        //DropDownList1.DataBind();

    //        DropDownList_Country.DataTextField = "CountryName";
    //        DropDownList_Country.DataValueField = "CountryID";
    //        DropDownList_Country.DataSource = CountryDetails;
    //        DropDownList_Country.DataBind();
    //    }
    //    catch (Exception ex) { Response.Write("Sorry For The InConvienence....We are facing some technical problems.Please try After Some Time"); }





    //}


    //void Client_StateCompleted(object sender, ServiceReference1.StateCompletedEventArgs e)
    //{
    //    //DropDownList2.DataTextField = "StateName";
    //    //DropDownList2.DataValueField = "StateID";
    //    //DropDownList2.DataSource = e.Result.ToList<ServiceReference1.State>();
    //    //DropDownList2.DataBind();

    //    DropDownList_State.DataTextField = "StateName";
    //    DropDownList_State.DataValueField = "StateID";
    //    DropDownList_State.DataSource = e.Result.ToList<ServiceReference1.State>();
    //    DropDownList_State.DataBind();

    //}




    //void Client_CityCompleted(object sender, ServiceReference1.CityCompletedEventArgs e)
    //{
    //    //DropDownList3.DataTextField = "CityName";
    //    //DropDownList3.DataValueField = "CityID";
    //    //DropDownList3.DataSource = e.Result.ToList<ServiceReference1.Cities>();
    //    //DropDownList3.DataBind();

    //    DropDownList_City.DataTextField = "CityName";
    //    DropDownList_City.DataValueField = "CityID";
    //    DropDownList_City.DataSource = e.Result.ToList<ServiceReference1.Cities>();
    //    DropDownList_City.DataBind();
    //}



    //void Client_AreaCompleted(object sender, ServiceReference1.AreaCompletedEventArgs e)
    //{
    //    //DropDownList4.DataTextField = "AreaName";
    //    //DropDownList4.DataValueField = "AreaID";
    //    //DropDownList4.DataSource = e.Result.ToList<ServiceReference1.Area>();
    //    //DropDownList4.DataBind();

    //    DropDownList_Area.DataTextField = "AreaName";
    //    DropDownList_Area.DataValueField = "AreaID";
    //    DropDownList_Area.DataSource = e.Result.ToList<ServiceReference1.Area>();
    //    DropDownList_Area.DataBind();

    //}


    //void Client_PgDetailsListCompleted(object sender, ServiceReference1.PgDetailsListCompletedEventArgs e)
    //{
    //    //if (e.Result != null)
    //    //{
    //    //    GridView1.DataSource = e.Result.ToList<ServiceReference1.PGDetails>();
    //    //    GridView1.DataBind();
    //    //    Label_Errormsg.Text = null;
    //    //}

    //    //if (GridView1.Rows.Count == 0)
    //    //{
    //    //    Label_Errormsg.Text = "Sorry we could not find any PG at this place.";
    //    //}

    //}
    protected void DropDownList_Country_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Label1.Text = DropDownList_Country.SelectedItem.Text;
        selectedCountry = Convert.ToInt32(DropDownList_Country.SelectedValue);

       // Client.StateAsync(selectedCountry);
      //  Client.StateCompleted += new EventHandler<ServiceReference1.StateCompletedEventArgs>(Client_StateCompleted);

    }
    protected void DropDownList_State_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Label2.Text = DropDownList_State.SelectedItem.Text;
        selectedState = Convert.ToInt32(DropDownList_State.SelectedValue);
       //
        
        //Client.CityAsync(selectedState);
        //Client.CityCompleted += new EventHandler<ServiceReference1.CityCompletedEventArgs>(Client_CityCompleted);
    }
    protected void DropDownList_City_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedCity = Convert.ToInt32(DropDownList_City.SelectedValue);
        //Client.AreaAsync(selectedCity);
        //Client.AreaCompleted += new EventHandler<ServiceReference1.AreaCompletedEventArgs>(Client_AreaCompleted);
    }
    protected void DropDownList_Area_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedarea = DropDownList_Area.SelectedItem.Text;
        selectedArea = Convert.ToInt32(DropDownList_Area.SelectedValue);
        //Client.PgDetailsListAsync(selectedarea, MainClass.UserTypeID,0);
        //Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);
    }
   

    //void Client_PGRegisterCompleted(object sender, ServiceReference1.PGRegisterCompletedEventArgs e)
    //{
    //    Response.Write(e.Result);
    //}

    //void Client_UserRegisterCompleted(object sender, ServiceReference1.UserRegisterCompletedEventArgs e)
    //{
    //    Response.Write(e.Result);
    //}

    protected void Button_SubmitPG_Click(object sender, EventArgs e)
    {
        UserRegister UserReg = new UserRegister();
        PGDetails PGDet = new PGDetails();
        UserReg.UserTypeID = MainClass.UserTypeID;
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
        UserReg.Country = DropDownList_Country.SelectedItem.ToString();
        UserReg.State = DropDownList_State.SelectedItem.ToString();
        UserReg.City = DropDownList_City.SelectedItem.ToString();
        UserReg.Area = DropDownList_Area.SelectedItem.ToString();

        PGDet.PGName = TextBox_PGName.Text;
        PGDet.PGAddress = TextBox_PGAddress.Text;
        PGDet.PGPhno = TextBox_PGPhno.Text;
        PGDet.Avialability = int.Parse(TextBox_PGAvailability.Text);
        PGDet.CostPerDay = int.Parse(TextBox_PGCostPerDay.Text);
        PGDet.CostPerMonth = int.Parse(TextBox_PGCostPerMonth.Text);
        

        PGDet.Country = DropDownList_Country.SelectedItem.ToString();
        PGDet.State = DropDownList_State.SelectedItem.ToString();
        PGDet.City = DropDownList_City.SelectedItem.ToString();
        PGDet.Area = DropDownList_Area.SelectedItem.ToString();

        //Client.UserRegisterAsync(UserReg, 2);
        //Client.UserRegisterCompleted += new EventHandler<ServiceReference1.UserRegisterCompletedEventArgs>(Client_UserRegisterCompleted);

        //Client.PGRegisterAsync(PGDet, 2);
        //Client.PGRegisterCompleted += new EventHandler<ServiceReference1.PGRegisterCompletedEventArgs>(Client_PGRegisterCompleted);
    }
}