using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class index : System.Web.UI.Page
{
    public string ConString = ConfigurationManager.AppSettings["ConnString"];
    public string IPAddress;
    protected void Page_Load(object sender, EventArgs e)
    {
        IPAddress = IpAddress();
        uploadIpAddress(IPAddress);
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
}