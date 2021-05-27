using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Data;

public partial class Views_ClientRegPage : System.Web.UI.Page
{


    OleDbConnection oledbConn;
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
   // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!Page.IsPostBack)
        {
            DatePicker1.SelectedDate = DateTime.Now.Date;

            MainClass.UserTypeID = 1;
            GenerateExcelData("Select");

            DropDownList_Country.Items.Add("India");
            DropDownList_Country0.Items.Add("India");

            DropDownList_Area.Items.Add("Select");
            DropDownList_City.Items.Add("Select");
            DropDownList_State.Items.Add("Select");

            DropDownList_Area0.Items.Add("Select");
            DropDownList_City0.Items.Add("Select");
            DropDownList_State0.Items.Add("Select");

            CountryDetails = Get_CSCA_Details.Country();
            DropDownList_Country.DataTextField = "CountryName";
            DropDownList_Country.DataValueField = "CountryID";
            DropDownList_Country.DataSource = CountryDetails;
            DropDownList_Country.DataBind();
           // Client.CountryAsync();
           // Client.CountryCompleted += new EventHandler<ServiceReference1.CountryCompletedEventArgs>(Client_CountryCompleted);
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



    protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    {


        // Label1.Text = DropDownList1.SelectedItem.Text;
        selectedCountry = Convert.ToInt32(DropDownList_Country.SelectedValue);
        DropDownList_State.DataTextField = "StateName";
        DropDownList_State.DataValueField = "StateID";
        DropDownList_State.DataSource = Get_CSCA_Details.State(selectedCountry);
        DropDownList_State.DataBind();
        //Client.StateAsync(selectedCountry);
        //Client.StateCompleted += new EventHandler<ServiceReference1.StateCompletedEventArgs>(Client_StateCompleted);
    }

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
    //    Client.CityAsync(selectedState);
    //    Client.CityCompleted += new EventHandler<ServiceReference1.CityCompletedEventArgs>(Client_CityCompleted);
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
    //    Client.AreaAsync(selectedCity);
    //    Client.AreaCompleted += new EventHandler<ServiceReference1.AreaCompletedEventArgs>(Client_AreaCompleted);
    //    //Client.PgDetailsListAsync(null, MainClass.UserTypeID);
    //    //Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);

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
    //    //Client.PgDetailsListAsync(selectedarea, 2);
    //    //Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);
    //}

    //void Client_PgDetailsListCompleted(object sender, ServiceReference1.PgDetailsListCompletedEventArgs e)
    //{
    //    throw new NotImplementedException();
    //}

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

    protected void Button_Submit_Click(object sender, EventArgs e)
    {
        try
        {



            UserRegister UserReg = new UserRegister();
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

            //Client.UserRegisterAsync(UserReg, 1);
            //Client.UserRegisterCompleted += new EventHandler<ServiceReference1.UserRegisterCompletedEventArgs>(Client_UserRegisterCompleted);

            bool result = ImplementationClass.UserRegister(UserReg,"sdfgsg", 1);

        }
        catch { }



    }






    protected void Button_SubmitPG_Click(object sender, EventArgs e)
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
        UserReg.State = DropDownList_State.SelectedItem.ToString();
        UserReg.City = DropDownList_City.SelectedItem.ToString();
        UserReg.Area = DropDownList_Area.SelectedItem.ToString();

        PGDetails PGReg = new PGDetails();
        PGReg.PGName = TextBox_PGName.Text;
        PGReg.UserID = TextBox_Username.Text;
        PGReg.PGAddress = TextBox_PGAddress.Text;
        PGReg.PGPhno = TextBox_PGPhno.Text;
        PGReg.Avialability = int.Parse(TextBox_PGAvailability.Text);
        PGReg.CostPerDay = int.Parse(TextBox_PGCostPerDay.Text);
        PGReg.CostPerMonth = int.Parse(TextBox_PGCostPerMonth.Text);
        PGReg.Country = "India";//DropDownList_Country.SelectedItem.ToString();
        PGReg.State = DropDownList_State.SelectedItem.ToString();
        PGReg.City = DropDownList_City.SelectedItem.ToString();
        PGReg.Area = DropDownList_Area.SelectedItem.ToString();
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
        PGReg.Pgprofilepic = Fileuploaderprofilepic.FileName;
        PGReg.Pgimg1 = Fileuploaderimg1.FileName;
        PGReg.Pgimg2 = Fileuploaderimg2.FileName;
        PGReg.Pgimg3 = Fileuploaderimg3.FileName;
        PGReg.Pgimg4 = Fileuploaderimg4.FileName;
        PGReg.Pgimg5 = Fileuploaderimg5.FileName;

        var folder = Server.MapPath("~/" + TextBox_Username.Text);
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        Fileuploaderprofilepic.SaveAs(Server.MapPath("~/" + TextBox_Username.Text + "/" + Fileuploaderprofilepic.FileName));
        Fileuploaderimg1.SaveAs(Server.MapPath("~/" + TextBox_Username.Text + "/" + Fileuploaderimg1.FileName));
        Fileuploaderimg2.SaveAs(Server.MapPath("~/" + TextBox_Username.Text + "/" + Fileuploaderimg2.FileName));
        Fileuploaderimg3.SaveAs(Server.MapPath("~/" + TextBox_Username.Text + "/" + Fileuploaderimg3.FileName));
        Fileuploaderimg4.SaveAs(Server.MapPath("~/" + TextBox_Username.Text + "/" + Fileuploaderimg4.FileName));
        Fileuploaderimg5.SaveAs(Server.MapPath("~/" + TextBox_Username.Text + "/" + Fileuploaderimg5.FileName));


        PGReg.ConfirmationStas = "Pending";


        string res = ImplementationClass.UserRegister(UserReg,"", 1).ToString();
        string re = ImplementationClass.PGRegister(PGReg, 1).ToString();
        //Client.UserRegisterAsync(UserReg, 1);
        //Client.UserRegisterCompleted += new EventHandler<ServiceReference1.UserRegisterCompletedEventArgs>(Client_UserRegisterCompleted);

        //Client.PGRegisterAsync(PGReg, 1);
        //Client.PGRegisterCompleted += new EventHandler<ServiceReference1.PGRegisterCompletedEventArgs>(Client_PGRegisterCompleted);
    }

    //void Client_UserRegisterCompleted(object sender, ServiceReference1.UserRegisterCompletedEventArgs e)
    //{
    //    Response.Write("Successfull");
    //}

    //void Client_PGRegisterCompleted(object sender, ServiceReference1.PGRegisterCompletedEventArgs e)
    //{
    //    Response.Write("Successfull");
    //}
    protected void Button_SubmitPG0_Click(object sender, EventArgs e)
    {
        Response.Redirect("./LoginPage.aspx");
    }
    public void getcityarea(string City)
    {
        try
        {
            // need to pass relative path after deploying on server
            string path = System.IO.Path.GetFullPath(Server.MapPath("~/city.xlsx"));
            /* connection string  to work with excel file. HDR=Yes - indicates 
               that the first row contains columnnames, not data. HDR=No - indicates 
               the opposite. "IMEX=1;" tells the driver to always read "intermixed" 
               (numbers, dates, strings etc) data columns as text. 
            Note that this option might affect excel sheet write access negative. */

            if (Path.GetExtension(path) == ".xls")
            {
                oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
            }
            else if (Path.GetExtension(path) == ".xlsx")
            {
                oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
            }
            oledbConn.Open();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            // passing list to drop-down list

            // selecting distict list of Slno 
            cmd.Connection = oledbConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT [city_area]" +
                     "  FROM [city$] where [city_name1]= @City_Abbreviation";
            cmd.Parameters.AddWithValue("@City_Abbreviation", City);
            oleda = new OleDbDataAdapter(cmd);
            oleda.Fill(ds, "cityarea");
            DropDownList_Area.DataSource = ds.Tables["cityarea"].DefaultView;
            DropDownList_Area.DataTextField = "city_area";
            DropDownList_Area.DataValueField = "city_area";
            DropDownList_Area.DataBind();

            DropDownList_Area0.DataSource = ds.Tables["cityarea"].DefaultView;
            DropDownList_Area0.DataTextField = "city_area";
            DropDownList_Area0.DataValueField = "city_area";
            DropDownList_Area0.DataBind();
            // GridView1.DataSource = ds;
            //GridView1.DataBind();
            oledbConn.Close();
        }
        catch { }
    }

    public class Employee { public string city_name { get; set; } public string city_state { get; set; } }

    private void GenerateExcelData(string SlnoAbbreviation)
    {
        try
        {
            // need to pass relative path after deploying on server
            string path = System.IO.Path.GetFullPath(Server.MapPath("~/city.xlsx"));
            /* connection string  to work with excel file. HDR=Yes - indicates 
               that the first row contains columnnames, not data. HDR=No - indicates 
               the opposite. "IMEX=1;" tells the driver to always read "intermixed" 
               (numbers, dates, strings etc) data columns as text. 
            Note that this option might affect excel sheet write access negative. */

            if (Path.GetExtension(path) == ".xls")
            {
                oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
            }
            else if (Path.GetExtension(path) == ".xlsx")
            {
                oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
            }
            oledbConn.Open();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter oleda = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            // passing list to drop-down list

            // selecting distict list of Slno 
            cmd.Connection = oledbConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT distinct([city_state]) FROM [city$]";
            oleda = new OleDbDataAdapter(cmd);
            oleda.Fill(ds, "city_state");
            DropDownList_State.DataSource = ds.Tables["city_state"].DefaultView;
            DropDownList_State0.DataSource = ds.Tables["city_state"].DefaultView;
            if (!IsPostBack)
            {
                DropDownList_State.DataTextField = "city_state";
                DropDownList_State.DataValueField = "city_state";
                DropDownList_State.DataBind();
                DropDownList_State0.DataTextField = "city_state";
                DropDownList_State0.DataValueField = "city_state";
                DropDownList_State0.DataBind();
            }
            // by default we will show form data for all states but if any state is selected then show data accordingly
            if (!String.IsNullOrEmpty(SlnoAbbreviation) && SlnoAbbreviation != "Select")
            {
                cmd.CommandText = "SELECT [city_name]" +
                    "  FROM [city$] where [city_state]= @Slno_Abbreviation";
                cmd.Parameters.AddWithValue("@Slno_Abbreviation", SlnoAbbreviation);
            }
            else
            {
                // cmd.CommandText = "SELECT [city_id], [city_name], [city_state] FROM [city$]";
            }
            oleda = new OleDbDataAdapter(cmd);
            //oleda.Fill(ds);
            oleda.Fill(ds, "srctble");

            // var empList = ds.Tables["srctble"].AsEnumerable().Select(dataRow => new Employee { city_name = dataRow.Field<string>("city_name") });

            DropDownList_City.DataSource = ds.Tables["srctble"].DefaultView;

            DropDownList_City.DataTextField = "city_name";
            DropDownList_City.DataValueField = "city_name";
            DropDownList_City.DataBind();

            DropDownList_City0.DataSource = ds.Tables["srctble"].DefaultView;

            DropDownList_City0.DataTextField = "city_name";
            DropDownList_City0.DataValueField = "city_name";
            DropDownList_City0.DataBind();

            // binding form data with grid view
            // GridView1.DataSource = ds.Tables[1].DefaultView;
            // GridView1.DataBind();
        }
        // need to catch possible exceptions
        catch (Exception ex)
        {
            //lblError.Text = ex.ToString();
        }
        finally
        {
            oledbConn.Close();
        }
    }
    protected void DropDownList_State_SelectedIndexChanged(object sender, EventArgs e)
    {
        GenerateExcelData(DropDownList_State.SelectedValue);
    }
    protected void DropDownList_City_SelectedIndexChanged(object sender, EventArgs e)
    {
        getcityarea(DropDownList_City.SelectedValue);
    }
    protected void DropDownList_Area_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList_State0_SelectedIndexChanged(object sender, EventArgs e)
    {
        GenerateExcelData(DropDownList_State0.SelectedValue);
    }
    protected void DropDownList_City0_SelectedIndexChanged(object sender, EventArgs e)
    {
        getcityarea(DropDownList_City0.SelectedValue);
    }
    protected void DropDownList_Area0_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Fileuploaderprofilepic_Load(object sender, EventArgs e)
    {
       // Image_Pgprofilepic.ImageUrl = Fileuploaderprofilepic.FileName;
    }
   
}