using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

public partial class contactus : System.Web.UI.Page
{
    public string ConString = ConfigurationManager.AppSettings["ConnString"];
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConString);
        SqlCommand cmd;
        try
        {
            int i=0;
            con.Open();
            cmd = new SqlCommand("insert into Contactus_Table (Name,Email,Subject,Message)values('" + TextBox_Name.Text + "','" + TextBox_Email.Text + "','" + TextBox_Subject.Text + "','" + TextBox_Message.Text + "')", con);
            i = cmd.ExecuteNonQuery();
            con.Close();

            TextBox_Name.Text = "";
            TextBox_Email.Text = "";
            TextBox_Subject.Text = "";
            TextBox_Message.Text = "";
            lbl_Display.Text = "Thank you for your interest...Our Representatative will back to you soon.";
        }
        catch { lbl_Display.Text = "Enter the Fields Correctly and TRY"; }

    }
}