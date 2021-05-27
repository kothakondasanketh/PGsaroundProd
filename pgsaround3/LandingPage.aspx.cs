using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Views_LandingPage : System.Web.UI.Page
{

    OleDbConnection oledbConn;
    public int selectedCountry = 0;
    public int selectedState = 0;
    public int selectedCity = 0;
    public int selectedArea = 0;
    public string IPAddress;

    public string ConString = ConfigurationManager.AppSettings["ConnString"];
    public List<Country> CountryDetails;
    //  ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            IPAddress = IpAddress();
            uploadIpAddress(IPAddress);
            GenerateExcelData("Select");
            ComboBox2.Items.Add("Select");
            ComboBox3.Items.Add("Select");
            ComboBox4.Items.Add("Select");

            ComboBox2.DataTextField = "StateName";
            ComboBox2.DataValueField = "StateID";
            ComboBox2.DataSource = Get_CSCA_Details.State(1);
            ComboBox2.DataBind();
            // MainClass.UserTypeID = 1;
            //  Client.CountryAsync();
            // Client.CountryCompleted += new EventHandler<ServiceReference1.CountryCompletedEventArgs>(Client_CountryCompleted);
        }

    }
    public string IpAddress()
    {
        string strIpAddress;
        strIpAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (strIpAddress == null)
        {
            strIpAddress = Request.ServerVariables["REMOTE_ADDR"];
        }
        return strIpAddress;
    }

    public void uploadIpAddress(string IPAdress)
    {
        int NoOfViews;

        SqlConnection con = new SqlConnection(ConString);
        SqlCommand cmd;
        try
        {
            int i = 0;

            cmd = new SqlCommand("Select No_Of_Views from Client_IPAddress_Table where Client_IP_Address='" + IPAdress + "'", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Client_IPAddress_Table");
            sda.Fill(dt);
            // UserName = dt.Rows[0]["UserName"].ToString().Trim();
            NoOfViews = Convert.ToInt32(dt.Rows[0]["No_Of_Views"]);
            NoOfViews = NoOfViews + 1;
            if (NoOfViews != null)
            {
                cmd = new SqlCommand("update Client_IPAddress_Table set No_Of_Views='" + NoOfViews + "' where Client_IP_Address='" + IPAdress + "'", con);

                i = cmd.ExecuteNonQuery();
            }
            else
            {

                cmd = new SqlCommand("Insert into Client_IPAddress_Table (Client_IP_Address,No_Of_Views) values('" + IPAdress + "','1')", con);

                i = cmd.ExecuteNonQuery();
            }

            con.Close();
        }
        catch
        {
            con.Close();

            cmd = new SqlCommand("Insert into Client_IPAddress_Table (Client_IP_Address,No_Of_Views) values('" + IPAdress + "','1')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
    //void Client_CountryCompleted(object sender, ServiceReference1.CountryCompletedEventArgs e)
    //{
    //    try
    //    {
    //        CountryDetails = e.Result.ToList<ServiceReference1.Country>();
    //        ComboBox1.DataTextField = "CountryName";
    //        ComboBox1.DataValueField = "CountryID";
    //        ComboBox1.DataSource = CountryDetails;
    //        ComboBox1.DataBind();


    //    }
    //    catch (Exception ex) { Response.Write("Sorry For The InConvienence....We are facing some technical problems.Please try After Some Time"); }





    //}


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {


        // Label1.Text = ComboBox1.SelectedItem.Text;
        // selectedCountry=Convert.ToInt32(ComboBox1.SelectedValue);

        // Client.StateAsync(selectedCountry);
        //  Client.StateCompleted += new EventHandler<ServiceReference1.StateCompletedEventArgs>(Client_StateCompleted);
    }


    //void Client_StateCompleted(object sender, ServiceReference1.StateCompletedEventArgs e)
    //{
    //    ComboBox2.DataTextField = "StateName";
    //    ComboBox2.DataValueField = "StateID";
    //    ComboBox2.DataSource = e.Result.ToList<ServiceReference1.State>();
    //    ComboBox2.DataBind();


    //}


    protected void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Label2.Text = ComboBox2.SelectedItem.Text;
        selectedState = Convert.ToInt32(ComboBox2.SelectedValue);
        ComboBox3.DataTextField = "CityName";
        ComboBox3.DataValueField = "CityID";
        ComboBox3.DataSource = Get_CSCA_Details.City(selectedState);
        ComboBox3.DataBind();
        //Client.CityAsync(selectedState);
        //Client.CityCompleted += new EventHandler<ServiceReference1.CityCompletedEventArgs>(Client_CityCompleted);
    }

    //void Client_CityCompleted(object sender, ServiceReference1.CityCompletedEventArgs e)
    //{
    //    ComboBox3.DataTextField = "CityName";
    //    ComboBox3.DataValueField = "CityID";
    //    ComboBox3.DataSource = e.Result.ToList<ServiceReference1.Cities>();
    //    ComboBox3.DataBind();


    //}
    protected void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Label3.Text = ComboBox3.SelectedItem.Text;
        selectedCity = Convert.ToInt32(ComboBox3.SelectedValue);
        ComboBox4.DataTextField = "AreaName";
        ComboBox4.DataValueField = "AreaID";
        ComboBox4.DataSource = Get_CSCA_Details.Area(selectedCity);
        ComboBox4.DataBind();
        //Client.AreaAsync(selectedCity);
        //Client.AreaCompleted += new EventHandler<ServiceReference1.AreaCompletedEventArgs>(Client_AreaCompleted);
        //Client.PgDetailsListAsync(null, MainClass.UserTypeID,0);
        //Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);

        //GridView1.DataSource = ImplementationClass.PgDetailsList(null, MainClass.UserTypeID, 0);
        //GridView1.DataBind();
        Label_Errormsg.Text = null;


        if (GridView1.Rows.Count == 0)
        {
            Label_Errormsg.Text = "Sorry we could not find any PG at this place.";
        }

    }


    //void Client_AreaCompleted(object sender, ServiceReference1.AreaCompletedEventArgs e)
    //{
    //    ComboBox4.DataTextField = "AreaName";
    //    ComboBox4.DataValueField = "AreaID";
    //    ComboBox4.DataSource = e.Result.ToList<ServiceReference1.Area>();
    //    ComboBox4.DataBind();



    //}
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Label4.Text = ComboBox4.SelectedItem.Text;
        string selectedarea = ComboBox4.SelectedItem.Text;
        //selectedArea = Convert.ToInt32(ComboBox4.SelectedValue);
        GridView1.DataSource = null;
        GridView1.DataSource = ImplementationClass.PgDetailsList(selectedarea, MainClass.UserTypeID, MainClass.SelectedGender);
        GridView1.DataBind();
        Label_Errormsg.Text = null;


        if (GridView1.Rows.Count == 0)
        {
            Label_Errormsg.Text = "Sorry we could not find any PG at this place.";
        }
        //Client.PgDetailsListAsync(selectedarea, MainClass.UserTypeID,0);
        //Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);
    }

    //void Client_PgDetailsListCompleted(object sender, ServiceReference1.PgDetailsListCompletedEventArgs e)
    //{
    //    if (e.Result != null)
    //    {
    //        GridView1.DataSource = e.Result.ToList<ServiceReference1.PGDetails>();
    //        GridView1.DataBind();
    //        Label_Errormsg.Text = null;
    //    }

    //   if(GridView1.Rows.Count==0)
    //    {
    //        Label_Errormsg.Text = "Sorry we could not find any PG at this place.";
    //    }

    //}




    //void Client_UserRegisterCompleted(object sender, ServiceReference1.UserRegisterCompletedEventArgs e)
    //{
    //   Label_Errormsg.Text=e.Result;
    //    Label8.Visible = true;
    //    Label9.Visible = true;
    //    Label10.Visible = true;
    //    Label11.Visible = true;

    //    ComboBox1.Visible = true;
    //    ComboBox2.Visible = true;
    //    ComboBox3.Visible = true;
    //    ComboBox4.Visible = true;

    //    GridView1.Visible = true;

    //}




    protected void Button2_Click(object sender, EventArgs e)
    {
        if (MainClass.UserTypeID == 1)
        {
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;

            ComboBox1.Visible = false;
            ComboBox2.Visible = false;
            ComboBox3.Visible = false;
            ComboBox4.Visible = false;

            GridView1.Visible = false;

        }
        else if (MainClass.UserTypeID == 2)
        {
            Label8.Visible = false;
            Label9.Visible = false;
            Label10.Visible = false;
            Label11.Visible = false;

            ComboBox1.Visible = false;
            ComboBox2.Visible = false;
            ComboBox3.Visible = false;
            ComboBox4.Visible = false;

            GridView1.Visible = false;

        }
        else if (MainClass.UserTypeID == 3)
        {
            Label8.Visible = true;
            Label9.Visible = true;
            Label10.Visible = true;
            Label11.Visible = true;

            ComboBox1.Visible = true;
            ComboBox2.Visible = true;
            ComboBox3.Visible = true;
            ComboBox4.Visible = true;

            GridView1.Visible = true;

            Label_Errormsg.Text = "Sorry..Please try selecting User or Client";
        }

    }

    //void Client_PGRegisterCompleted(object sender, ServiceReference1.PGRegisterCompletedEventArgs e)
    //{
    //    Label_Errormsg.Text = e.Result;
    //    Label8.Visible = true;
    //    Label9.Visible = true;
    //    Label10.Visible = true;
    //    Label11.Visible = true;

    //    ComboBox1.Visible = true;
    //    ComboBox2.Visible = true;
    //    ComboBox3.Visible = true;
    //    ComboBox4.Visible = true;

    //    GridView1.Visible = true;

    //}
    protected void Button_PGBack_Click(object sender, EventArgs e)
    {
        Label8.Visible = true;
        Label9.Visible = true;
        Label10.Visible = true;
        Label11.Visible = true;

        ComboBox1.Visible = true;
        ComboBox2.Visible = true;
        ComboBox3.Visible = true;
        ComboBox4.Visible = true;

        GridView1.Visible = true;

    }
    protected void Button_back_Click(object sender, EventArgs e)
    {
        Label8.Visible = true;
        Label9.Visible = true;
        Label10.Visible = true;
        Label11.Visible = true;

        ComboBox1.Visible = true;
        ComboBox2.Visible = true;
        ComboBox3.Visible = true;
        ComboBox4.Visible = true;

        GridView1.Visible = true;

    }

    public void getcityarea(string City)
    {
        try
        {
            // need to pass relative path after deploying on server
            string path = Server.MapPath("~/Images/city.xlsx");
            /* connection string  to work with excel file. HDR=Yes - indicates 
               that the first row contains columnnames, not data. HDR=No - indicates 
               the opposite. "IMEX=1;" tells the driver to always read "intermixed" 
               (numbers, dates, strings etc) data columns as text. 
            Note that this option might affect excel sheet write access negative. */

            if (Path.GetExtension(path) == ".xls")
            {
                oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/city.xlsx;Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
            }
            else if (Path.GetExtension(path) == ".xlsx")
            {
                oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/city.xlsx;Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
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
            ComboBox4.DataSource = ds.Tables["cityarea"].DefaultView;
            ComboBox4.DataTextField = "city_area";
            ComboBox4.DataValueField = "city_area";
            ComboBox4.DataBind();
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
            string path = System.IO.Path.GetFullPath(Server.MapPath("~/Images/city.xlsx"));
            /* connection string  to work with excel file. HDR=Yes - indicates 
               that the first row contains columnnames, not data. HDR=No - indicates 
               the opposite. "IMEX=1;" tells the driver to always read "intermixed" 
               (numbers, dates, strings etc) data columns as text. 
            Note that this option might affect excel sheet write access negative. */

            if (Path.GetExtension(path) == ".xls")
            {
                oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/city.xlsx;Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
            }
            else if (Path.GetExtension(path) == ".xlsx")
            {
                oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/city.xlsx;Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
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
            ComboBox2.DataSource = ds.Tables["city_state"].DefaultView;
            if (!IsPostBack)
            {
                ComboBox2.DataTextField = "city_state";
                ComboBox2.DataValueField = "city_state";
                ComboBox2.DataBind();
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

            ComboBox3.DataSource = ds.Tables["srctble"].DefaultView;

            ComboBox3.DataTextField = "city_name";
            ComboBox3.DataValueField = "city_name";
            ComboBox3.DataBind();



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



    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        GenerateExcelData(ComboBox2.SelectedValue);
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        getcityarea(ComboBox3.SelectedValue);
    }

    protected void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {
        MainClass.SelectedGender = Convert.ToInt32(ComboBox5.SelectedValue);
        if (MainClass.SelectedArea != null)
        {
            GridView1.DataSource = null;
            GridView1.DataSource = ImplementationClass.PgDetailsList(MainClass.SelectedArea, MainClass.UserTypeID, MainClass.SelectedGender);
            GridView1.DataBind();
        }
    }
}
