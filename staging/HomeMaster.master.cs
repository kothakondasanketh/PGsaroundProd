using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Views_HomeMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
      //  Frame1.Attributes.Add("src", "./LoginPage.aspx");
    }
   
    public void lnkUpdate_Click(object sender, EventArgs e)
    {

        if (MainClass.UserTypeID == 1)
        {
      //      Frame1.Attributes.Add("src", "./UserRegistrationPage.aspx");
        }
        else if (MainClass.UserTypeID == 2)
        {
       //     Frame1.Attributes.Add("src", "./ClientRegistrationPage.aspx");
        }
    }
    public void lnkUpdate0_Click(object sender, EventArgs e)
    {
      //  Frame1.Attributes.Add("src", "./LoginPage.aspx");
    }
}
