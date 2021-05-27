using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Data;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using System.Drawing;

public partial class pgsaround : System.Web.UI.Page
{

    public int selectedCountry = 0;
    public int selectedState = 0;
    public int selectedCity = 0;
    public int selectedArea = 0;
    public string Area = "Marathalli";
    public int UsertypeID;
    public int SelectedGender = 0;
    public string selectedarea = null;


    string connection = ConfigurationManager.AppSettings["ConnString"];

    public class pgsaroundAreaClass
    {
        public string Area { get; set; }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_Status.Text = "";
        if (!IsPostBack)
        {
            MainClass.SelectedGender = 1;
            MainClass.UserTypeID = 1;
            DropDownList2.Items.Add("Select");
            // Label1.Text = DropDownList1.SelectedItem.Text;

            //DropDownList2.DataTextField = "StateName";
//DropDownList2.DataValueField = "StateID";
           // DropDownList2.DataSource = Get_CSCA_Details.State(1);
           // DropDownList2.DataBind();
            //Panel_Map.Visible = false;
           // Panel_Map_lookaround.Visible = true;
            //SqlConnection sqlcon = new SqlConnection(connection);

            //SqlCommand cmd;
            //sqlcon.Open();
            //cmd = new SqlCommand("select distinct Area from Locations", sqlcon);
            //SqlDataReader rdr1 = cmd.ExecuteReader();
            //List<pgsaroundAreaClass> listarea = new List<pgsaroundAreaClass>();
            //pgsaroundAreaClass areals = new pgsaroundAreaClass();

            //areals = new pgsaroundAreaClass();

            //pgsaroundAreaClass obj = default(pgsaroundAreaClass);
            //while (rdr1.Read())
            //{
            //    obj = Activator.CreateInstance<pgsaroundAreaClass>();
            //    foreach (PropertyInfo prop in obj.GetType().GetProperties())
            //    {
            //        if (!object.Equals(rdr1[prop.Name], DBNull.Value))
            //        {
            //            prop.SetValue(obj, rdr1[prop.Name], null);
            //        }
            //    }
            //    listarea.Add(obj);
            //}
            //sqlcon.Close();

            //DropDownList_Area.DataTextField = "Area";
            //DropDownList_Area.DataValueField = "Area";
            //DropDownList_Area.DataSource = listarea;
            //DropDownList_Area.Items.Add("Select");
            //DropDownList_Area.DataBind();
        }

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Items.Add("Select");
        // Label2.Text = DropDownList2.SelectedItem.Text;
        selectedState = Convert.ToInt32(DropDownList2.SelectedValue);
        DropDownList3.DataTextField = "CityName";
        DropDownList3.DataValueField = "CityID";
        DropDownList3.DataSource = Get_CSCA_Details.City(selectedState);
        DropDownList3.DataBind();
        // Client.CityAsync(selectedState);
        // Client.CityCompleted += new EventHandler<ServiceReference1.CityCompletedEventArgs>(Client_CityCompleted);
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList_Area.Items.Add("Select");
        // Label3.Text = DropDownList3.SelectedItem.Text;
        selectedCity = Convert.ToInt32(DropDownList3.SelectedValue);
        DropDownList_Area.DataTextField = "AreaName";
        DropDownList_Area.DataValueField = "AreaID";
        DropDownList_Area.DataSource = Get_CSCA_Details.Area(selectedCity);
        DropDownList_Area.DataBind();
        // Client.AreaAsync(selectedCity);
        //  Client.AreaCompleted += new EventHandler<ServiceReference1.AreaCompletedEventArgs>(Client_AreaCompleted);
        //  Client.PgDetailsListAsync(null, UsertypeID, SelectedGender);
        //  Client.PgDetailsListCompleted += new EventHandler<ServiceReference1.PgDetailsListCompletedEventArgs>(Client_PgDetailsListCompleted);
        // GridView1.DataSource = ImplementationClass.PgDetailsList(null, UsertypeID, SelectedGender);
        // GridView1.DataBind();
    }
    protected void DropDownList_Area_SelectedIndexChanged(object sender, EventArgs e)
    {
        //  Label4.Text = DropDownList4.SelectedItem.Text;
        MainClass.SelectedArea = DropDownList_Area.SelectedItem.Text;
        //selectedArea = Convert.ToInt32(DropDownList3.SelectedValue);
        if (MainClass.SelectedGender != 0)
        {
            Grid_List_Of_Pgs.DataSource = null;
            Grid_List_Of_Pgs.DataSource = ImplementationClass.PgDetailsList(MainClass.SelectedArea, MainClass.UserTypeID, MainClass.SelectedGender);
            Grid_List_Of_Pgs.DataBind();
        }

        DataTable dt = this.GetData("select * from Locations where Area='" + DropDownList_Area.SelectedItem + "'");
        rptMarkers.DataSource = dt;
        rptMarkers.DataBind();
        //Grid_List_Of_Pgs.DataSource = dt;
        //Grid_List_Of_Pgs.DataBind();
          

    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            MainClass.SelectedGender = Convert.ToInt32(DropDownList5.SelectedValue);
            if (MainClass.SelectedArea != null)
            {
                Grid_List_Of_Pgs.DataSource = null;
                Grid_List_Of_Pgs.DataSource = ImplementationClass.PgDetailsList(MainClass.SelectedArea, MainClass.UserTypeID, MainClass.SelectedGender);
                Grid_List_Of_Pgs.DataBind();
            }
        }
        catch { }
    }
    protected void Grid_List_Of_Pgs_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "ViewDetails")
        {
            // Convert the row index stored in the CommandArgument
            // property to an Integer.
            int index = Convert.ToInt32(e.CommandArgument);

            // Get the last name of the selected author from the appropriate
            // cell in the GridView control.
            GridViewRow selectedRow = Grid_List_Of_Pgs.Rows[index];
            MainClass.SelectedPg = selectedRow.Cells[2].Text;
            foreach (GridViewRow row in Grid_List_Of_Pgs.Rows)
            {
                if (row.RowIndex == Grid_List_Of_Pgs.SelectedIndex)
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

            Response.Redirect("~/ViewPGPage.aspx");
        }
        else if (e.CommandName == "BookDetails")
        {
            int index = Convert.ToInt32(e.CommandArgument);

            // Get the last name of the selected author from the appropriate
            // cell in the GridView control.
            GridViewRow selectedRow = Grid_List_Of_Pgs.Rows[index];
            MainClass.ClientID = selectedRow.Cells[2].Text;
            bool status = ImplementationClass.AllowBooking(MainClass.ClientID);
            if (status.Equals(true))
            {
                Response.Redirect("./BookingDetailsEntry.aspx");
                lbl_Status.Text = "";
            }
            else if (status.Equals(false))
            {
               
                lbl_Status.Text = "Sorry we dont provide Booking for this PG";
            }
            foreach (GridViewRow row in Grid_List_Of_Pgs.Rows)
            {
                if (row.RowIndex == Grid_List_Of_Pgs.SelectedIndex)
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
            Response.Redirect("./BookingDetailsEntry.aspx");
        }
    }
    private DataTable GetData(string query)
    {
        string conString = ConfigurationManager.AppSettings["ConnString"];
        SqlCommand cmd = new SqlCommand(query);
        using (SqlConnection con = new SqlConnection(conString))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter())
            {
                cmd.Connection = con;

                sda.SelectCommand = cmd;
                using (DataTable dt = new DataTable())
                {
                    sda.Fill(dt);
                    return dt;
                }
            }
        }
    }


  
    protected void LinkButton_lookaroundme_Click(object sender, EventArgs e)
    {
        //IpAddress();
        LookAround();
    }
    //public string IpAddress()
    //{
    //    string strIpAddress;
    //    strIpAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
    //    if (strIpAddress == null)
    //    {
    //        strIpAddress = Request.ServerVariables["REMOTE_ADDR"];
    //    }
    //    string APIKey = "77912e692050f9cfab5cf98ce8d7bd307bcfb98ae0b2c528e60689c10dc2ffac";
    //    string url = string.Format("http://api.ipinfodb.com/v3/ip-city/?key={0}&ip={1}&format=json", APIKey, strIpAddress);
       
    //    WebClient client = new WebClient();
    //    string json = client.DownloadString(url);
    //    Location location = new JavaScriptSerializer().Deserialize<Location>(json);
    //    List<Location> Listofloc = new List<Location>();
    //    if (location.CityName != "")
    //    {
    //        DataTable dt = this.GetData("select * from Locations where Area='" + location.CityName + "'");
            
    //        rptMarkers.DataSource = dt;
    //        rptMarkers.DataBind();
    //    }

    //    return strIpAddress;
    //}
    public class Location
    {
        public string IPAddress { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public string ZipCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string TimeZone { get; set; }
    }
    public void LookAround()
    {
        try
        {
            string ConnectionString = ConfigurationManager.AppSettings["ConnString"];
            SqlConnection Conn = new SqlConnection(ConnectionString);
            SqlDataReader myReader;
            bool status = false;
            string lat = hdnfldVariablelat.Value;
            string longit = hdnfldVariablelong.Value;
            WebRequest req = WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/xml?latlng=" + lat + "," + longit + "&sensor=false");
            WebResponse resp = req.GetResponse();
            Stream streamresp = resp.GetResponseStream();
            StreamReader reader = new StreamReader(streamresp, Encoding.UTF8);

            string xml1 = reader.ReadToEnd();
            //  MessageBox.Show(reader.ReadToEnd());
            WebClient client = new WebClient();
            StringReader sr = new StringReader(xml1);
            DataSet ds = new DataSet();
            ds.ReadXml(sr);
            DataTable fdgdfg = ds.Tables["address_component"];
            List<string> longnamelst = fdgdfg.AsEnumerable().Select(dr => dr.Field<string>("long_name")).ToList();



            SqlCommand cmd;
            int i = -1;
            //bool AreaSerachStatus = false;

            foreach (var item in longnamelst)
            {
                try
                {
                    Conn.Open();
                    cmd = new SqlCommand("select * from Locations where Area='" + item + "'", Conn);
                    myReader = cmd.ExecuteReader();
                    if (myReader == null || !myReader.HasRows)
                    {

                        //  Response.Write(myReader["Description"].ToString() + "--" + myReader["Area"].ToString() + "--" + myReader["Name"].ToString());
                        //  GridView1.DataSource = myReader;
                        // GridView1.DataBind();

                        //System.Web.UI.ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "Script", "Functionload();", true);
                        //DataTable dt = this.GetData("select * from Locations");
                        //rptMarkers.DataSource = dt;
                        //rptMarkers.DataBind();


                    }
                    else
                    {
                        var dt = new DataTable();
                        dt.Load(myReader);
                        var categoryList = new List<Category>(dt.Rows.Count);
                        foreach (DataRow row in dt.Rows)
                        {
                            var values = row.ItemArray;
                            var category = new Category()
                            {
                                UserID = values[0].ToString(),
                                PGName = values[3].ToString(),
                                Latitude = values[1].ToString(),
                                Longitude = values[2].ToString(),
                                PGAddress = values[4].ToString()
                            };
                            categoryList.Add(category);
                        }
                     

                        categoryList.Add(new Category() { PGName = "You Are Here", PGAddress = "You Are Here", Latitude = lat, Longitude = longit });

                        rptMarkers.DataSource = categoryList;
                        rptMarkers.DataBind();


                        Grid_List_Of_Pgs.DataSource = ImplementationClass.PgDetailsList(item, 1,Convert.ToInt32( DropDownList5.SelectedValue));
                        Grid_List_Of_Pgs.DataBind();
                      
                        status = true;
                    }

                    Conn.Close();

                }
                catch { }
                if (status == true)
                {
                    break;
                }
                if (++i == longnamelst.Count - 1)
                {
                    // this is the last item
                    foreach (var item2 in longnamelst)
                    {
                        try
                        {
                            Conn.Open();
                            cmd = new SqlCommand("select * from Locations where City='" + item2 + "'", Conn);
                            myReader = cmd.ExecuteReader();
                            if (myReader == null || !myReader.HasRows)
                            {

                                //  Response.Write(myReader["Description"].ToString() + "--" + myReader["Area"].ToString() + "--" + myReader["Name"].ToString());
                                //  GridView1.DataSource = myReader;
                                // GridView1.DataBind();

                                //System.Web.UI.ScriptManager.RegisterClientScriptBlock(Page, this.GetType(), "Script", "Functionload();", true);
                                //DataTable dt = this.GetData("select * from Locations");
                                //rptMarkers.DataSource = dt;
                                //rptMarkers.DataBind();


                            }
                            else
                            {
                                var dt = new DataTable();
                                dt.Load(myReader);
                                var categoryList = new List<Category>(dt.Rows.Count);
                                foreach (DataRow row in dt.Rows)
                                {
                                    var values = row.ItemArray;
                                    var category = new Category()
                                    {
                                        UserID=values[0].ToString(),
                                        PGName = values[3].ToString(),
                                        Latitude = values[1].ToString(),
                                        Longitude = values[2].ToString(),
                                        PGAddress = values[4].ToString()
                                    };
                                    categoryList.Add(category);
                                }

                             

                                categoryList.Add(new Category() { PGName = "You Are Here", PGAddress = "You Are Here", Latitude = lat, Longitude = longit });
                                rptMarkers.DataSource = categoryList;
                                rptMarkers.DataBind();
                                //Conn.Close();
                               // Conn.Open();
                                cmd = new SqlCommand("select * from PGDetails where City='" + item2 + "' and ConfirmationStatus='Approved' and Pgservetype='" + Convert.ToInt32(DropDownList5.SelectedValue) + "'", Conn);
                                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                                DataTable dt5 = new DataTable("PGDetails");
                                sda.Fill(dt5);
                                List<PGDetails> List_PgDetails = new List<PGDetails>();
                                PGDetails pgdetails = new PGDetails();
                                SqlDataReader rdr1 = cmd.ExecuteReader();
                                for (int i1 = 0; i1 < dt5.Rows.Count; i1++)
                                {

                                    pgdetails = new PGDetails();
                                    pgdetails.UserID = dt5.Rows[i1]["UserID"].ToString().Trim();
                                    pgdetails.PGName = dt5.Rows[i1]["PGName"].ToString().Trim();
                                    pgdetails.PGAddress = dt5.Rows[i1]["PGAddress"].ToString().Trim();
                                    pgdetails.PGPhno = dt5.Rows[i1]["PGPhno"].ToString().Trim();
                                    pgdetails.Avialability = int.Parse(dt5.Rows[i1]["Availability"].ToString().Trim());
                                    pgdetails.CostPerDay = int.Parse(dt5.Rows[i1]["CostPerDay"].ToString().Trim());
                                    pgdetails.CostPerMonth = int.Parse(dt5.Rows[i1]["CostPerMonth"].ToString().Trim());
                                    pgdetails.Area = dt5.Rows[i1]["Area"].ToString().Trim();
                                    pgdetails.City = dt5.Rows[i1]["City"].ToString().Trim();
                                    pgdetails.State = dt5.Rows[i1]["State"].ToString().Trim();
                                    pgdetails.Country = dt5.Rows[i1]["Country"].ToString().Trim();

                                    List_PgDetails.Add(pgdetails);

                                }

                                Grid_List_Of_Pgs.DataSource = List_PgDetails;
                                Grid_List_Of_Pgs.DataBind();
                             
                                
                                status = true;
                            }

                            Conn.Close();
                        }
                        catch { }
                        if (status == true)
                        {
                            break;
                        }
                    }
                }
            }
        }
        catch { }
    }
    public class Category
    {
        public string UserID { get; set; }
        public string PGName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PGAddress { get; set; }
    }
   
}