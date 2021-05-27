using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string UserName = TextBox1.Text;
        string password = TextBox2.Text;

        Response.Write("Welcome....."+UserName);

        SqlConnection conn = new SqlConnection();
    
        conn.ConnectionString = ConfigurationManager.AppSettings["ConnString"];
        conn.Open();

        SqlCommand cmd = new SqlCommand("insert into UserDetails(UserName,Password,Typeid) values('" + UserName + "','" + password + "','1')", conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        

    }
   protected void Button2_Click(object sender, EventArgs e)
    {
        string UserName = TextBox1.Text;
        string password = TextBox2.Text;



        SqlConnection conn = new SqlConnection();

        conn.ConnectionString = ConfigurationManager.AppSettings["ConnString"];
        conn.Open();

        SqlCommand cmd = new SqlCommand("select UserName from UserDetails where UserName='" + UserName + "' and Password='" + password + "')", conn);
      SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {

            string un = reader["UserName"].ToString();
            if (un != null)
            {
                Response.Write("Successfully Loged in....." + un);
            }
            else
            {
                Response.Write("Please enter Username and Password correctly and try");
            }
            conn.Close();
        }
    }
}