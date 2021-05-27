using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Net;
using System.Web.Script.Serialization;

public partial class index : System.Web.UI.Page
{
    public string ConString = ConfigurationManager.AppSettings["ConnString"];
    public string IPAddress;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
           HttpCookie LastVisitCookie=Request.Cookies["pgsaround"];
           if (LastVisitCookie == null)
            {
               HttpCookie aCookie = new HttpCookie("pgsaround");
               aCookie.Value = "pgsaround";
               aCookie.Expires = DateTime.Now.AddDays(365);
               Response.Cookies.Add(aCookie);
               IPAddress = IpAddress();
               uploadIpAddress(IPAddress);
            }
        }
        catch { }
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
        //string APIKey = "77912e692050f9cfab5cf98ce8d7bd307bcfb98ae0b2c528e60689c10dc2ffac";
        //string url = string.Format("http://api.ipinfodb.com/v3/ip-city/?key={0}&ip={1}&format=json", APIKey, IPAdress);
        //List<Location> locations = new List<Location>();
        //WebClient client = new WebClient();
        //string json = client.DownloadString(url);
        //Location location = new JavaScriptSerializer().Deserialize<Location>(json);

        //locations.Add(location);
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
               // cmd = new SqlCommand("update Client_IPAddress_Table set No_Of_Views='" + NoOfViews + "',CountryName='" + location.CountryName + "',CountryCode='" + location.CountryCode + "',CityName='" + location.CityName + "',RegionName='" + location.RegionName + "',ZipCode='" + location.ZipCode + "' where Client_IP_Address='" + IPAdress + "'", con);
                cmd = new SqlCommand("update Client_IPAddress_Table set No_Of_Views='" + NoOfViews + "' where Client_IP_Address='" + IPAdress + "'", con);
                i = cmd.ExecuteNonQuery();
            }
            else
            {

                //cmd = new SqlCommand("Insert into Client_IPAddress_Table (Client_IP_Address,No_Of_Views,CountryName,CountryCode,CityName,RegionName,ZipCode) values('" + IPAdress + "','1','" + location.CountryName + "','" + location.CountryCode + "','" + location.CityName + "','" + location.RegionName + "','" + location.ZipCode + "')", con);
                cmd = new SqlCommand("Insert into Client_IPAddress_Table (Client_IP_Address,No_Of_Views) values('" + IPAdress + "','1')", con);
                i = cmd.ExecuteNonQuery();
            }

            con.Close();
        }
        catch
        {
            con.Close();

           // cmd = new SqlCommand("Insert into Client_IPAddress_Table (Client_IP_Address,No_Of_Views,CountryName,CountryCode,CityName,RegionName,ZipCode) values('" + IPAdress + "','1','" + location.CountryName + "','" + location.CountryCode + "','" + location.CityName + "','" + location.RegionName + "','" + location.ZipCode + "')", con);
            cmd = new SqlCommand("Insert into Client_IPAddress_Table (Client_IP_Address,No_Of_Views) values('" + IPAdress + "','1')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
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
}