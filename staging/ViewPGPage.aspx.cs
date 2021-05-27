using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Services;
using AjaxControlToolkit;
using System.IO;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class Views_ViewPGPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<PGDetails> Display = new List<PGDetails>();
            Display =ImplementationClass.ParticularPgDetailsList(MainClass.SelectedPg);

            foreach (var item in Display)
            {

                Label1.Text = item.PGName;
                Label2.Text = item.PGAddress;
                Label3.Text = item.PGPhno;
                Label4.Text = item.Avialability.ToString();
                Label5.Text = item.CostPerDay.ToString();
                Label6.Text = item.CostPerMonth.ToString();
                Label7.Text = item.Area;
                CheckBox1.Text = "AC";
                CheckBox1.Checked = bool.Parse(item.AC);
                CheckBox2.Text = "3 Food times";
                CheckBox2.Checked = bool.Parse(item.Food3times);
                CheckBox3.Text = "Hotwater";
                CheckBox3.Checked = bool.Parse(item.Hotwater);
                CheckBox4.Text = "Internet";
                CheckBox4.Checked = bool.Parse(item.Internet);
                CheckBox5.Text = "Laundry";
                CheckBox5.Checked = bool.Parse(item.Laundry);
                CheckBox6.Text = "NIFood";
                CheckBox6.Checked = bool.Parse(item.NIFood);
                CheckBox7.Text = "NoFood";
                CheckBox7.Checked = bool.Parse(item.NoFood);
                CheckBox8.Text = "NonAC";
                CheckBox8.Checked = bool.Parse(item.NonAC);
                CheckBox9.Text = "Parkingspace";
                CheckBox9.Checked = bool.Parse(item.Parkingspace);
                CheckBox10.Text = "SIFood";
                CheckBox10.Checked = bool.Parse(item.SIFood);
                CheckBox11.Text = "TV";
                CheckBox11.Checked = bool.Parse(item.TV);

                //Image1.ImageUrl = "./"+MainClass.SelectedPg+"/"+item.Pgimg1+"";
                //Image2.ImageUrl = "./" + MainClass.SelectedPg + "/" + item.Pgimg2 + "";
                //Image3.ImageUrl = "./" + MainClass.SelectedPg + "/" + item.Pgimg3 + "";
                //Image4.ImageUrl = "./" + MainClass.SelectedPg + "/" + item.Pgimg4 + "";
                //Image5.ImageUrl = "./" + MainClass.SelectedPg + "/" + item.Pgimg5 + "";





            }
            DataTable dt = this.GetData("select * from Locations where UserID='" + MainClass.SelectedPg + "'");
            rptMarkers.DataSource = dt;
            rptMarkers.DataBind();
          
          
        }


    }

    
    [WebMethod]
    [ScriptMethod]
    public static Slide[] GetImages()
    {
        List<Slide> slides = new List<Slide>();
        string path = HttpContext.Current.Server.MapPath("~/staging/"+MainClass.SelectedPg);
        if (path.EndsWith("\\"))
        {
            path = path.Remove(path.Length - 1);
        }
        Uri pathUri = new Uri(path, UriKind.Absolute);
        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            Uri filePathUri = new Uri(file, UriKind.Absolute);
            slides.Add(new Slide
            {
             
                ImagePath = pathUri.MakeRelativeUri(filePathUri).ToString()
            });
        }
        return slides.ToArray();
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

   
}