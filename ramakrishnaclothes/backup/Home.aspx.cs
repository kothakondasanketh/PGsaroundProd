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

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
           string UserId = (string)(Session["UserId"]);
           if (UserId == null)
           {
               Response.Redirect("./LoginPage.aspx");
           }

    }
    [WebMethod]
    [ScriptMethod]
    public static Slide[] GetImages()
    {
        List<Slide> slides = new List<Slide>();
        string path = HttpContext.Current.Server.MapPath("~/ramakrishnaclothes/ramkrishna");
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["UserId"] = null;
        Response.Buffer = true;
        Response.ExpiresAbsolute = DateTime.Now.AddDays(-1d);
        Response.Expires = -1500;
        Response.CacheControl = "no-cache";
        Response.Cache.SetCacheability(HttpCacheability.NoCache);
        Response.Redirect("./LoginPage.aspx");
    }
   
}