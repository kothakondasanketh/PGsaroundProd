using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.IO;
using System.Data;
using System.Drawing;

public partial class Views_BookingSearchPage : System.Web.UI.Page
{
    OleDbConnection oledbConn;
    public int selectedCountry = 0;
    public int selectedState = 0;
    public int selectedCity = 0;
    public int selectedArea = 0;
    public string Area = "Marathalli";
    public int UsertypeID;
    public int SelectedGender = 0;
    public string selectedarea = null;
    
    public List<Country> CountryDetails;
    // ServiceReference1.Service1Client Client = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Visible = false;
        if (!Page.IsPostBack)
        {
            MainClass.SelectedGender = 1;
            MainClass.UserTypeID = 1;
            CountryDetails = Get_CSCA_Details.Country();
            DropDownList1.DataTextField = "CountryName";
            DropDownList1.DataValueField = "CountryID";
            DropDownList1.DataSource = CountryDetails;
            DropDownList1.DataBind();
            //  Client.CountryAsync();
            //  Client.CountryCompleted += new EventHandler<ServiceReference1.CountryCompletedEventArgs>(Client_CountryCompleted);

            // GenerateExcelData("Select");
            //  DropDownList2.Items.Add("Select");
            //  DropDownList3.Items.Add("Select");
            //  DropDownList4.Items.Add("Select");

        }

    }
    //void Client_CountryCompleted(object sender, ServiceReference1.CountryCompletedEventArgs e)
    //{
    //    try
    //    {
    //        CountryDetails = e.Result.ToList<ServiceReference1.Country>();
    //        DropDownList1.DataTextField = "CountryName";
    //        DropDownList1.DataValueField = "CountryID";
    //        DropDownList1.DataSource = CountryDetails;
    //        DropDownList1.DataBind();
    //    }
    //    catch (Exception ex) { Response.Write("Sorry For The InConvienence....Please try After Some Time"); }





    //}


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        DropDownList2.Items.Add("Select");
        Label1.Text = DropDownList1.SelectedItem.Text;
        selectedCountry = Convert.ToInt32(DropDownList1.SelectedValue);
        DropDownList2.DataTextField = "StateName";
        DropDownList2.DataValueField = "StateID";
        DropDownList2.DataSource = Get_CSCA_Details.State(selectedCountry);
        DropDownList2.DataBind();
        // Client.StateAsync(selectedCountry);
        // Client.StateCompleted += new EventHandler<ServiceReference1.StateCompletedEventArgs>(Client_StateCompleted);
    }

    //void Client_StateCompleted(object sender, ServiceReference1.StateCompletedEventArgs e)
    //{
    //    DropDownList2.DataTextField = "StateName";
    //    DropDownList2.DataValueField = "StateID";
    //    DropDownList2.DataSource = e.Result.ToList<ServiceReference1.State>();
    //    DropDownList2.DataBind();
    //}


    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
       DropDownList3.Items.Add("Select");
        Label2.Text = DropDownList2.SelectedItem.Text;
        selectedState = Convert.ToInt32(DropDownList2.SelectedValue);
        DropDownList3.DataTextField = "CityName";
        DropDownList3.DataValueField = "CityID";
        DropDownList3.DataSource = Get_CSCA_Details.City(selectedState);
        DropDownList3.DataBind();
        // Client.CityAsync(selectedState);
        // Client.CityCompleted += new EventHandler<ServiceReference1.CityCompletedEventArgs>(Client_CityCompleted);
    }

    //void Client_CityCompleted(object sender, ServiceReference1.CityCompletedEventArgs e)
    //{
    //    DropDownList3.DataTextField = "CityName";
    //    DropDownList3.DataValueField = "CityID";
    //    DropDownList3.DataSource = e.Result.ToList<ServiceReference1.Cities>();
    //    DropDownList3.DataBind();
    //}
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList4.Items.Add("Select");
        Label3.Text = DropDownList3.SelectedItem.Text;
        selectedCity = Convert.ToInt32(DropDownList3.SelectedValue);
        DropDownList4.DataTextField = "AreaName";
        DropDownList4.DataValueField = "AreaID";
        DropDownList4.DataSource = Get_CSCA_Details.Area(selectedCity);
        DropDownList4.DataBind();
        // Client.AreaAsync(selectedCity);
        //  Client.AreaCompleted += new EventHandler<ServiceReference1.AreaCompletedEventArgs>(Client_AreaCompleted);
        //  Client.PgDetailsListAsync(null, UsertypeID, SelectedGender);
        //  Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);
       // GridView1.DataSource = ImplementationClass.PgDetailsList(null, UsertypeID, SelectedGender);
       // GridView1.DataBind();
    }

    //void Client_AreaCompleted(object sender, ServiceReference1.AreaCompletedEventArgs e)
    //{
    //    DropDownList4.DataTextField = "AreaName";
    //    DropDownList4.DataValueField = "AreaID";
    //    DropDownList4.DataSource = e.Result.ToList<ServiceReference1.Area>();
    //    DropDownList4.DataBind();

    //}
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label4.Text = DropDownList4.SelectedItem.Text;
        MainClass.SelectedArea = DropDownList4.SelectedItem.Text;
        //selectedArea = Convert.ToInt32(DropDownList3.SelectedValue);
        if (MainClass.SelectedGender != 0)
        {
            GridView1.DataSource = null;
            GridView1.DataSource = ImplementationClass.PgDetailsList(MainClass.SelectedArea, MainClass.UserTypeID, MainClass.SelectedGender);
            GridView1.DataBind();
        }
    }
    //void Client_PgDetailsListCompleted(object sender, ServiceReference1.PgDetailsListCompletedEventArgs e)
    //{
    //    GridView1.DataSource = e.Result.ToList<ServiceReference1.PGDetails>();
    //    GridView1.DataBind();
    //}
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MainClass.ClientID = GridView1.SelectedRow.Cells[2].Text;
        ListView1.DataSource = ImplementationClass.ParticularPgDetailsList(MainClass.ClientID);
        ListView1.DataBind();
        //Client.ParticularPgDetailsListAsync(MainClass.ClientID);

        //Client.ParticularPgDetailsListCompleted += new EventHandler<ServiceReference1.ParticularPgDetailsListCompletedEventArgs>(Client_ParticularPgDetailsListCompleted);
        Button1.Visible = true;


    }

    //void Client_ParticularPgDetailsListCompleted(object sender, ServiceReference1.ParticularPgDetailsListCompletedEventArgs e)
    //{
    //    ListView1.DataSource = e.Result.ToList<ServiceReference1.PGDetails>();
    //    ListView1.DataBind();
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("./BookingDetailsEntry.aspx");
    }

    public void getcityarea(string City)
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
            cmd.CommandText = "SELECT [city_area]" +
                     "  FROM [city$] where [city_name1]= @City_Abbreviation";
            cmd.Parameters.AddWithValue("@City_Abbreviation", City);
            oleda = new OleDbDataAdapter(cmd);
            oleda.Fill(ds, "cityarea");
            DropDownList4.DataSource = ds.Tables["cityarea"].DefaultView;
            DropDownList4.DataTextField = "city_area";
            DropDownList4.DataValueField = "city_area";
            DropDownList4.DataBind();
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
            DropDownList2.DataSource = ds.Tables["city_state"].DefaultView;
            if (!IsPostBack)
            {
                DropDownList2.DataTextField = "city_state";
                DropDownList2.DataValueField = "city_state";
                DropDownList2.DataBind();
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

            DropDownList3.DataSource = ds.Tables["srctble"].DefaultView;

            DropDownList3.DataTextField = "city_name";
            DropDownList3.DataValueField = "city_name";
            DropDownList3.DataBind();



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


    //protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    GenerateExcelData(DropDownList2.SelectedValue);
    //}
    //protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    getcityarea(DropDownList3.SelectedValue);
    //}


    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ViewDetails")
        {
            // Convert the row index stored in the CommandArgument
            // property to an Integer.
            int index = Convert.ToInt32(e.CommandArgument);

            // Get the last name of the selected author from the appropriate
            // cell in the GridView control.
            GridViewRow selectedRow = GridView1.Rows[index];
            MainClass.SelectedPg = selectedRow.Cells[2].Text;
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    row.BackColor = ColorTranslator.FromHtml("#CFEAFA");
                    row.ForeColor = ColorTranslator.FromHtml("#006666");
                }
                else
                {
                    row.BackColor = ColorTranslator.FromHtml("#CFEAFA");
                    row.ForeColor = ColorTranslator.FromHtml("#006666");
                }
            }

            Response.Redirect("~/staging/ViewPGPage.aspx");
        }
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            MainClass.SelectedGender = Convert.ToInt32(DropDownList5.SelectedValue);
            if (MainClass.SelectedArea != null)
            {
                GridView1.DataSource = null;
                GridView1.DataSource = ImplementationClass.PgDetailsList(MainClass.SelectedArea,MainClass.UserTypeID, MainClass.SelectedGender);
                GridView1.DataBind();
            }
        }
        catch { }
    }
}