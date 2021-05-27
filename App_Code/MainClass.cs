using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections.ObjectModel;

/// <summary>
/// Summary description for MainClass
/// </summary>
public class MainClass
{
    public static string UserName { get; set; }
    public static string Name { get; set; }
    public static int UserTypeID { get; set; }
    public static string ClientID { get; set; }

    public static string OrderNo { get; set; }
    public static string UserEmailID { get; set; }

    public static string gphno { get; set; }
    public static string ggender { get; set; }
    public static string gdob { get; set; }

    public static int LoginType = 0;

    public static int EmailSMSType = 0;

    public static string SelectedPg { get; set; }

    public static int SelectedGender { get; set; }
    public static string SelectedArea { get; set; }

}


public class OrderDisplayClass
{
    public static string User_UserId { get; set; }

    public static string OrderNo { get; set; }
    public static string BookingDate { get; set; }

    public static string Name { get; set; }
    public static string Address { get; set; }
    public static string Phno { get; set; }
    public static string Emailid { get; set; }

    public static string PgAddress { get; set; }
    public static string PgPhno { get; set; }
    public static string PgName { get; set; }

    public static string FromDate { get; set; }
    public static string ToDate { get; set; }
    public static string Noofdays { get; set; }
    public static string TotalCost { get; set; }
    public static string Status { get; set; }

    public static string NoOfPersonsAllowed { get; set; }

    public static string User1 { get; set; }
    public static string User2 { get; set; }
    public static string User3 { get; set; }
    public static string User4 { get; set; }
    public static string User5 { get; set; }

}

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
public static class ImplementationClass
{

     public static bool AllowBooking(string ClientID)
    {
        string connection = ConfigurationManager.AppSettings["ConnString"];

        SqlConnection sqlcon = new SqlConnection(connection);
        bool status;
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("select AllowBooking from PGDetails where UserID='" + ClientID + "'", sqlcon);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable("PGDetails");
        sda.Fill(dt);
        status =bool.Parse(dt.Rows[0]["AllowBooking"].ToString());
       // status = dt.Rows[0][0].ToString().Trim();
     
        sqlcon.Close();
        return status;
    }


    public static int GenerateOrderno()
    {
        string connection = ConfigurationManager.AppSettings["ConnString"];

        SqlConnection sqlcon = new SqlConnection(connection);
        string Orderno;
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("select MAX(Sno) from BookingDetails", sqlcon);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable("BookingDetails");
        sda.Fill(dt);
        // UserName = dt.Rows[0]["UserName"].ToString().Trim();
        Orderno = dt.Rows[0][0].ToString().Trim();
        int Orderno1 = int.Parse(Regex.Match(Orderno, @"\d+").Value);
        sqlcon.Close();
        return Orderno1;

    }


    public static List<UserRegister> GetUserDetails(string Username)
    {
        UserRegister userd = new UserRegister();
        List<UserRegister> lst = new List<UserRegister>();
        try
        {
            string connection = ConfigurationManager.AppSettings["ConnString"];

            SqlConnection sqlcon = new SqlConnection(connection);
            // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5;connection timeout=5";
            // SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("select * from UserDetails where UserName='" + Username + "'", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("UserDetails");
            sda.Fill(dt);

            userd.UserName = dt.Rows[0]["UserName"].ToString().Trim();
            userd.Password = dt.Rows[0]["Password"].ToString().Trim();
            userd.Name = dt.Rows[0]["Name"].ToString().Trim();
            userd.Country = dt.Rows[0]["Country"].ToString().Trim();
            userd.State = dt.Rows[0]["State"].ToString().Trim();
            userd.City = dt.Rows[0]["City"].ToString().Trim();
            userd.Area = dt.Rows[0]["Area"].ToString().Trim();
            userd.Address = dt.Rows[0]["Address"].ToString().Trim();
            userd.PhoneNo = dt.Rows[0]["Phno"].ToString().Trim();
            userd.EmailID = dt.Rows[0]["EmailID"].ToString().Trim();
            userd.Age = int.Parse(dt.Rows[0]["Age"].ToString().Trim());
            userd.Gender = bool.Parse(dt.Rows[0]["Gender"].ToString().Trim());
            userd.DOB = DateTime.Parse(dt.Rows[0]["DOB"].ToString().Trim());


            lst.Add(userd);
            sqlcon.Close();

        }
        catch (Exception ex) { }
        return lst;
    }

    public static bool UserRegister(UserRegister Userdetails,string Activationkey, int update)
    {
        bool Successfull = false;
        try
        {
            string connection = ConfigurationManager.AppSettings["ConnString"];

            SqlConnection sqlcon = new SqlConnection(connection);
            // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
            //    SqlConnection sqlcon = new SqlConnection(connection);
            //sqlcon.Open();
            SqlCommand cmd;

            if (update == 1)
            {
                sqlcon.Open();
                cmd = new SqlCommand("Insert_Update_UserDetails", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Userdetails.UserName);
                cmd.Parameters.AddWithValue("@Password", Userdetails.Password);
                cmd.Parameters.AddWithValue("@EmailID", Userdetails.EmailID);
                cmd.Parameters.AddWithValue("@Name", Userdetails.Name);
                cmd.Parameters.AddWithValue("@Age", Userdetails.Age);
                cmd.Parameters.AddWithValue("@Gender", Userdetails.Gender);
                cmd.Parameters.AddWithValue("@Phno", Userdetails.PhoneNo);
                cmd.Parameters.AddWithValue("@Address", Userdetails.Address);
                cmd.Parameters.AddWithValue("@DOB", Userdetails.DOB);
                cmd.Parameters.AddWithValue("@UserTypeID", Userdetails.UserTypeID);
                cmd.Parameters.AddWithValue("@TypeId", "1");
                cmd.Parameters.AddWithValue("@AuthenticationKey", Activationkey);
                int i = cmd.ExecuteNonQuery();
                sqlcon.Close();
               // cmd = new SqlCommand("insert into UserDetails(UserName,Password,EmailID,Name,Age,Gender,Phno,Address,Area,City,State,Country,DOB,UserTypeID)values('" + Userdetails.UserName + "','" + Userdetails.Password + "','" + Userdetails.EmailID + "','" + Userdetails.Name + "','" + Userdetails.Age + "','" + Userdetails.Gender + "','" + Userdetails.PhoneNo + "','" + Userdetails.Address + "','" + Userdetails.Area + "','" + Userdetails.City + "','" + Userdetails.State + "','" + Userdetails.Country + "','" + Userdetails.DOB.Date + "','" + Userdetails.UserTypeID + "')", sqlcon);
                //SqlDataReader SDR = cmd.ExecuteReader();
                //int i = cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (i > 0)
                {
                    Successfull = true;
                }
                else
                {
                    Successfull = false;
                }
            }
            else if (update == 2)
            {
                //cmd = new SqlCommand("update UserDetails set Password='" + Userdetails.Password + "',EmailID='" + Userdetails.EmailID + "',Name='" + Userdetails.Name + "',Age='" + Userdetails.Age + "',Gender='" + Userdetails.Gender + "',Phno='" + Userdetails.PhoneNo + "',Address='" + Userdetails.Address + "',Area='" + Userdetails.Area + "',City='" + Userdetails.City + "',State='" + Userdetails.State + "',Country='" + Userdetails.State + "',DOB='" + Userdetails.DOB + "' where UserName='" + Userdetails.UserName + "'", sqlcon);
                //SqlDataReader SDR = cmd.ExecuteReader();
                sqlcon.Open();
                cmd = new SqlCommand("Insert_Update_UserDetails", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", Userdetails.UserName);
                cmd.Parameters.AddWithValue("@Password", Userdetails.Password);
                cmd.Parameters.AddWithValue("@EmailID", Userdetails.EmailID);
                cmd.Parameters.AddWithValue("@Name", Userdetails.Name);
                cmd.Parameters.AddWithValue("@Age", Userdetails.Age);
                cmd.Parameters.AddWithValue("@Gender", Userdetails.Gender);
                cmd.Parameters.AddWithValue("@Phno", Userdetails.PhoneNo);
                cmd.Parameters.AddWithValue("@Address", Userdetails.Address);
                cmd.Parameters.AddWithValue("@DOB", Userdetails.DOB);
                cmd.Parameters.AddWithValue("@UserTypeID", Userdetails.UserTypeID);
                cmd.Parameters.AddWithValue("@TypeId", "2");
                cmd.Parameters.AddWithValue("@AuthenticationKey", Activationkey);
                int i = cmd.ExecuteNonQuery();
                sqlcon.Close();
              
                if (i > 0)
                {
                    Successfull = true;
                }
                else
                {
                    Successfull = false;
                }

            }
            //sqlcon.Close();

        }
        catch (Exception ex) { }


        return Successfull;



    }

    public static bool PGRegister(PGDetails pgdetails, int update)
    {
        bool Successfull = false;
        try
        {
            string connection = ConfigurationManager.AppSettings["ConnString"];

            SqlConnection sqlcon = new SqlConnection(connection);
           
            SqlCommand cmd;
            if (update == 1)
            {
                sqlcon.Open();
                cmd = new SqlCommand("insert into Locations(UserID,Latitude,Longitude,PGName,PGAddress,Area)values('" + pgdetails.UserID + "','" + pgdetails.Latitude + "','" + pgdetails.Longitude + "','" + pgdetails.PGName + "','" + pgdetails.PGAddress + "','" + pgdetails.Area + "')", sqlcon);
                int i1 = cmd.ExecuteNonQuery();
                sqlcon.Close();
                sqlcon.Open();
                cmd = new SqlCommand("insert into PGDetails(UserID,PGAddress,PGName,PGPhno,Availability,CostPerDay,CostPerMonth,Area,City,State,Country,ConfirmationStatus,AC,NonAC,NIFood,SIFood,Internet,TV,Hotwater,Food3times,NoFood,Parkingspace,Laundry,Pgprofilepic,Pgimg1,Pgimg2,Pgimg3,Pgimg4,Pgimg5,Pgservetype)values('" + pgdetails.UserID + "','" + pgdetails.PGAddress + "','" + pgdetails.PGName + "','" + pgdetails.PGPhno + "','" + pgdetails.Avialability + "','" + pgdetails.CostPerDay + "','" + pgdetails.CostPerMonth + "','" + pgdetails.Area + "','" + pgdetails.City + "','" + pgdetails.State + "','" + pgdetails.Country + "','" + pgdetails.ConfirmationStas + "','" + pgdetails.AC + "','" + pgdetails.NonAC + "','" + pgdetails.NIFood + "','" + pgdetails.SIFood + "','" + pgdetails.Internet + "','" + pgdetails.TV + "','" + pgdetails.Hotwater + "','" + pgdetails.Food3times + "','" + pgdetails.NoFood + "','" + pgdetails.Parkingspace + "','" + pgdetails.Laundry + "','" + pgdetails.Pgprofilepic + "','" + pgdetails.Pgimg1 + "','" + pgdetails.Pgimg2 + "','" + pgdetails.Pgimg3 + "','" + pgdetails.Pgimg4 + "','" + pgdetails.Pgimg5 + "','" + pgdetails.Pgservetype + "')", sqlcon);
                //SqlDataReader SDR = cmd.ExecuteReader();
                int i = cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (i > 0)
                {
                    Successfull = true;
                }
                else
                {
                    Successfull = false;
                }
            }
            else if (update == 2)
            {
                sqlcon.Open();
                cmd = new SqlCommand("update PGDetails set PGAddress='" + pgdetails.PGAddress + "',PGName='" + pgdetails.PGName + "',PGPhno='" + pgdetails.PGPhno + "',Availability='" + pgdetails.Avialability + "',CostPerDay='" + pgdetails.CostPerDay + "',CostPerMonth='" + pgdetails.CostPerMonth + "',Area='" + pgdetails.Area + "',City='" + pgdetails.City + "',State='" + pgdetails.State + "',Country='" + pgdetails.Country + "',AC='" + pgdetails.AC + "',NonAC='" + pgdetails.NonAC + "',NIFood='" + pgdetails.NIFood + "',SIFood='" + pgdetails.SIFood + "',Internet='" + pgdetails.Internet + "',TV='" + pgdetails.TV + "',Hotwater='" + pgdetails.Hotwater + "',Food3times='" + pgdetails.Food3times + "',NoFood='" + pgdetails.NoFood + "',Parkingspace='" + pgdetails.Parkingspace + "',Laundry='" + pgdetails.Laundry + "',Pgprofilepic='" + pgdetails.Pgprofilepic + "',Pgimg1='" + pgdetails.Pgimg1 + "',Pgimg2='" + pgdetails.Pgimg2 + "',Pgimg3='" + pgdetails.Pgimg3 + "',Pgimg4='" + pgdetails.Pgimg4 + "',Pgimg5='" + pgdetails.Pgimg5 + "' where UserID='" + pgdetails.UserID + "'", sqlcon);
                //SqlDataReader SDR = cmd.ExecuteReader();
                int i = cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (i > 0)
                {
                    Successfull = true;
                }
                else
                {
                    Successfull =false;
                }

            }
            else if (update == 3)
            {
                sqlcon.Open();
                cmd = new SqlCommand("update PGDetails set ConfirmationStatus='" + pgdetails.ConfirmationStas + "' where UserID='" + pgdetails.UserID + "'", sqlcon);
                //SqlDataReader SDR = cmd.ExecuteReader();
                int i = cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (i > 0)
                {
                    Successfull = true;
                }
                else
                {
                    Successfull =false;
                }

            }
            
        }
        catch (Exception ex) { }


        return Successfull;



    }





    public static List<PGDetails> ParticularPgDetailsList(string ClientID)
    {

        string connection = ConfigurationManager.AppSettings["ConnString"];

        SqlConnection sqlcon = new SqlConnection(connection);
        List<PGDetails> List_PgDetails = new List<PGDetails>();
        PGDetails pgdetails = new PGDetails();
        //  string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
        //  SqlConnection sqlcon = new SqlConnection(connection);
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand("select * from PGDetails where UserID='" + ClientID + "'", sqlcon);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable("PGDetails");
        sda.Fill(dt);

        SqlDataReader rdr1 = cmd.ExecuteReader();

        pgdetails = new PGDetails();
        pgdetails.UserID = dt.Rows[0]["UserID"].ToString().Trim();
        pgdetails.PGName = dt.Rows[0]["PGName"].ToString().Trim();
        pgdetails.PGAddress = dt.Rows[0]["PGAddress"].ToString().Trim();
        pgdetails.PGPhno = dt.Rows[0]["PGPhno"].ToString().Trim();
        pgdetails.Avialability = int.Parse(dt.Rows[0]["Availability"].ToString().Trim());
        pgdetails.CostPerDay = int.Parse(dt.Rows[0]["CostPerDay"].ToString().Trim());
        pgdetails.CostPerMonth = int.Parse(dt.Rows[0]["CostPerMonth"].ToString().Trim());
        pgdetails.Area = dt.Rows[0]["Area"].ToString().Trim();
        pgdetails.City = dt.Rows[0]["City"].ToString().Trim();
        pgdetails.State = dt.Rows[0]["State"].ToString().Trim();
        pgdetails.Country = dt.Rows[0]["Country"].ToString().Trim();
        pgdetails.ConfirmationStas = dt.Rows[0]["ConfirmationStatus"].ToString().Trim();
        pgdetails.AC = dt.Rows[0]["AC"].ToString().Trim();
        pgdetails.NonAC = dt.Rows[0]["NonAC"].ToString().Trim();
        pgdetails.NIFood = dt.Rows[0]["NIFood"].ToString().Trim();
        pgdetails.SIFood = dt.Rows[0]["SIFood"].ToString().Trim();
        pgdetails.Internet = dt.Rows[0]["Internet"].ToString().Trim();
        pgdetails.TV = dt.Rows[0]["TV"].ToString().Trim();
        pgdetails.Hotwater = dt.Rows[0]["Hotwater"].ToString().Trim();
        pgdetails.Food3times = dt.Rows[0]["Food3times"].ToString().Trim();
        pgdetails.NoFood = dt.Rows[0]["NoFood"].ToString().Trim();
        pgdetails.Parkingspace = dt.Rows[0]["Parkingspace"].ToString().Trim();
        pgdetails.Laundry = dt.Rows[0]["Laundry"].ToString().Trim();
        pgdetails.Pgprofilepic = dt.Rows[0]["Pgprofilepic"].ToString().Trim();
        pgdetails.Pgimg1 = dt.Rows[0]["Pgimg1"].ToString().Trim();
        pgdetails.Pgimg2 = dt.Rows[0]["Pgimg2"].ToString().Trim();
        pgdetails.Pgimg3 = dt.Rows[0]["Pgimg3"].ToString().Trim();
        pgdetails.Pgimg4 = dt.Rows[0]["Pgimg4"].ToString().Trim();
        pgdetails.Pgimg5 = dt.Rows[0]["Pgimg5"].ToString().Trim();
        List_PgDetails.Add(pgdetails);

        sqlcon.Close();

        return List_PgDetails;

    }

    public static List<PGDetails> PgDetailsList(string Area, int UserTyperID, int Gender)
    {
        string connection = ConfigurationManager.AppSettings["ConnString"];

        SqlConnection sqlcon = new SqlConnection(connection);
        List<PGDetails> List_PgDetails = new List<PGDetails>();
        PGDetails pgdetails = new PGDetails();
        //  string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
        //  SqlConnection sqlcon = new SqlConnection(connection);
       
        SqlCommand cmd;
        if (Area != null)
        {
            sqlcon.Open();
            cmd = new SqlCommand("select * from PGDetails where Area='" + Area + "' and ConfirmationStatus='Approved' and Pgservetype='" + Gender + "'", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("PGDetails");
            sda.Fill(dt);

            SqlDataReader rdr1 = cmd.ExecuteReader();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                pgdetails = new PGDetails();
                pgdetails.UserID = dt.Rows[i]["UserID"].ToString().Trim();
                pgdetails.PGName = dt.Rows[i]["PGName"].ToString().Trim();
                pgdetails.PGAddress = dt.Rows[i]["PGAddress"].ToString().Trim();
                pgdetails.PGPhno = dt.Rows[i]["PGPhno"].ToString().Trim();
                pgdetails.Avialability = int.Parse(dt.Rows[i]["Availability"].ToString().Trim());
                pgdetails.CostPerDay = int.Parse(dt.Rows[i]["CostPerDay"].ToString().Trim());
                pgdetails.CostPerMonth = int.Parse(dt.Rows[i]["CostPerMonth"].ToString().Trim());
                pgdetails.Area = dt.Rows[i]["Area"].ToString().Trim();
                pgdetails.City = dt.Rows[i]["City"].ToString().Trim();
                pgdetails.State = dt.Rows[i]["State"].ToString().Trim();
                pgdetails.Country = dt.Rows[i]["Country"].ToString().Trim();

                List_PgDetails.Add(pgdetails);

            }
            sqlcon.Close();
        }
        else if (Area != null && UserTyperID != 3)
        {
            List<Confirmation> Conflist = new List<Confirmation>() { new Confirmation() { CornformationStatus = "Pending", CornformationStatusID = 1 }, new Confirmation() { CornformationStatus = "Hold", CornformationStatusID = 2 }, new Confirmation() { CornformationStatus = "Approved", CornformationStatusID = 3 }, new Confirmation() { CornformationStatus = "NotApproved", CornformationStatusID = 4 } };
            sqlcon.Open();
            cmd = new SqlCommand("select * from PGDetails where ConfirmationStatus='Approved' and Pgservetype='" + Gender + "'", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("PGDetails");
            sda.Fill(dt);

            SqlDataReader rdr1 = cmd.ExecuteReader();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                pgdetails = new PGDetails();
                pgdetails.UserID = dt.Rows[i]["UserID"].ToString().Trim();
                pgdetails.PGName = dt.Rows[i]["PGName"].ToString().Trim();
                pgdetails.PGAddress = dt.Rows[i]["PGAddress"].ToString().Trim();
                pgdetails.PGPhno = dt.Rows[i]["PGPhno"].ToString().Trim();
                pgdetails.Avialability = int.Parse(dt.Rows[i]["Availability"].ToString().Trim());
                pgdetails.CostPerDay = int.Parse(dt.Rows[i]["CostPerDay"].ToString().Trim());
                pgdetails.CostPerMonth = int.Parse(dt.Rows[i]["CostPerMonth"].ToString().Trim());
                pgdetails.Area = dt.Rows[i]["Area"].ToString().Trim();
                pgdetails.City = dt.Rows[i]["City"].ToString().Trim();
                pgdetails.State = dt.Rows[i]["State"].ToString().Trim();
                pgdetails.Country = dt.Rows[i]["Country"].ToString().Trim();
                if (UserTyperID == 2)
                {
                    pgdetails.ConfirmationStas = dt.Rows[i]["ConfirmationStatus"].ToString().Trim();
                }
                pgdetails.ConfirmationLst = Conflist;
                List_PgDetails.Add(pgdetails);

            }
            sqlcon.Close();
        }
        else if (Area == null && UserTyperID == 3)
        {
            List<Confirmation> Conflist = new List<Confirmation>() { new Confirmation() { CornformationStatus = "Pending", CornformationStatusID = 1 }, new Confirmation() { CornformationStatus = "Hold", CornformationStatusID = 2 }, new Confirmation() { CornformationStatus = "Approved", CornformationStatusID = 3 }, new Confirmation() { CornformationStatus = "NotApproved", CornformationStatusID = 4 } };
            sqlcon.Open();
            cmd = new SqlCommand("select * from PGDetails", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("PGDetails");
            sda.Fill(dt);

            SqlDataReader rdr1 = cmd.ExecuteReader();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                pgdetails = new PGDetails();
                pgdetails.UserID = dt.Rows[i]["UserID"].ToString().Trim();
                pgdetails.PGName = dt.Rows[i]["PGName"].ToString().Trim();
                pgdetails.PGAddress = dt.Rows[i]["PGAddress"].ToString().Trim();
                pgdetails.PGPhno = dt.Rows[i]["PGPhno"].ToString().Trim();
                pgdetails.Avialability = int.Parse(dt.Rows[i]["Availability"].ToString().Trim());
                pgdetails.CostPerDay = int.Parse(dt.Rows[i]["CostPerDay"].ToString().Trim());
                pgdetails.CostPerMonth = int.Parse(dt.Rows[i]["CostPerMonth"].ToString().Trim());
                pgdetails.Area = dt.Rows[i]["Area"].ToString().Trim();
                pgdetails.City = dt.Rows[i]["City"].ToString().Trim();
                pgdetails.State = dt.Rows[i]["State"].ToString().Trim();
                pgdetails.Country = dt.Rows[i]["Country"].ToString().Trim();
                pgdetails.ConfirmationStas = dt.Rows[i]["ConfirmationStatus"].ToString().Trim();
                pgdetails.ConfirmationLst = Conflist;
                List_PgDetails.Add(pgdetails);

            }
            sqlcon.Close();
        }
       
        return List_PgDetails;

    }

    public static List<UserBookingDetails> UserBookingDetailsList(string Username, int UserID)
    {
        string connection = ConfigurationManager.AppSettings["ConnString"];

        SqlConnection sqlcon = new SqlConnection(connection);
        string ClientUserID = null;
        List<UserBookingDetails> UserBookingDetailslist = new List<UserBookingDetails>();
        UserBookingDetails userBookingDetails = new UserBookingDetails();
        //   string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
        //   SqlConnection sqlcon = new SqlConnection(connection);
        sqlcon.Open();
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        if (UserID == 1)
        {
            //cmd = new SqlCommand("select * from BookingDetails where CustomerUserID='" + Username + "'", sqlcon);
            cmd = new SqlCommand("sp_UserBookingDetails", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Id", UserID);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable("BookingDetails");
            sda.Fill(dt);

            SqlDataReader rdr1 = cmd.ExecuteReader();
            for (int i = 0; i < dt.Rows.Count; i++)
            {




                userBookingDetails = new UserBookingDetails();
                userBookingDetails.OrderNo = dt.Rows[i]["OrderNo"].ToString().Trim();

                userBookingDetails.Status = dt.Rows[i]["Status"].ToString().Trim();
                userBookingDetails.FromDate = DateTime.Parse(dt.Rows[i]["FromDate"].ToString().Trim());
                userBookingDetails.ToDate = DateTime.Parse(dt.Rows[i]["ToDate"].ToString().Trim());
                userBookingDetails.TotalCost = int.Parse(dt.Rows[i]["TotalCost"].ToString().Trim());
                userBookingDetails.Area = dt.Rows[i]["Area"].ToString().Trim();

                ClientUserID = dt.Rows[i]["ClientUserID"].ToString().Trim();
                //string connection1 = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
                sqlcon.Close();
                sqlcon.Open();
                SqlCommand cmd1 = new SqlCommand("select PGName,PGAddress from PGDetails where UserID='" + ClientUserID + "'", sqlcon);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable("BookingDetails");
                sda1.Fill(dt1);

                SqlDataReader rdr2 = cmd1.ExecuteReader();
                PGDetails pgDetails = new PGDetails();
                pgDetails.PGAddress = dt1.Rows[0]["PGAddress"].ToString().Trim();
                pgDetails.PGName = dt1.Rows[0]["PGName"].ToString().Trim();


                userBookingDetails.Address = pgDetails.PGName + "," + pgDetails.PGAddress;


                UserBookingDetailslist.Add(userBookingDetails);
                sqlcon.Close();
            }
        }
        else if (UserID == 2)
        {
            //cmd = new SqlCommand("select * from BookingDetails where ClientUserID='" + Username + "'", sqlcon);
            cmd = new SqlCommand("sp_UserBookingDetails", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Id", UserID);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable("BookingDetails");
            sda.Fill(dt);

            SqlDataReader rdr1 = cmd.ExecuteReader();
            for (int i = 0; i < dt.Rows.Count; i++)
            {




                userBookingDetails = new UserBookingDetails();
                userBookingDetails.OrderNo = dt.Rows[i]["OrderNo"].ToString().Trim();

                userBookingDetails.Status = dt.Rows[i]["Status"].ToString().Trim();
                userBookingDetails.FromDate = DateTime.Parse(dt.Rows[i]["FromDate"].ToString().Trim());
                userBookingDetails.ToDate = DateTime.Parse(dt.Rows[i]["ToDate"].ToString().Trim());
                userBookingDetails.TotalCost = int.Parse(dt.Rows[i]["TotalCost"].ToString().Trim());
                userBookingDetails.Area = dt.Rows[i]["Area"].ToString().Trim();

                ClientUserID = dt.Rows[i]["ClientUserID"].ToString().Trim();
                //string connection1 = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
                sqlcon.Close();
                sqlcon.Open();
                SqlCommand cmd1 = new SqlCommand("select PGName,PGAddress from PGDetails where UserID='" + ClientUserID + "'", sqlcon);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable("BookingDetails");
                sda1.Fill(dt1);

                SqlDataReader rdr2 = cmd1.ExecuteReader();
                PGDetails pgDetails = new PGDetails();
                pgDetails.PGAddress = dt1.Rows[0]["PGAddress"].ToString().Trim();
                pgDetails.PGName = dt1.Rows[0]["PGName"].ToString().Trim();


                userBookingDetails.Address = pgDetails.PGName + "," + pgDetails.PGAddress;


                UserBookingDetailslist.Add(userBookingDetails);
                sqlcon.Close();
            }
        }





        return UserBookingDetailslist;

    }

    public static List<BookingEntryDetailslocal> bookingdetails(string OrderNo)
    {
        string connection = ConfigurationManager.AppSettings["ConnString"];

        SqlConnection sqlcon = new SqlConnection(connection);
        List<BookingEntryDetailslocal> UserBookingDetails = new List<BookingEntryDetailslocal>();
        BookingEntryDetailslocal userBookingDetails = new BookingEntryDetailslocal();
        //   string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
        //   SqlConnection sqlcon = new SqlConnection(connection);
        
        SqlCommand cmd = null;
        SqlDataAdapter sda;
        DataTable dt;
        SqlDataReader rdr1;

        if (OrderNo == null)
        {
            sqlcon.Open();
            cmd = new SqlCommand("select OrderNo,Address,Status,FromDate,ToDate,TotalNoOfDays,TotalNoOfPersons,TotalCost,Bookingdate,Area,User1,User2,User3,User4,User5,ClientUserID,CustomerUserID from BookingDetails", sqlcon);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable("BookingDetails");
            sda.Fill(dt);

            rdr1 = cmd.ExecuteReader();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                userBookingDetails = new BookingEntryDetailslocal();

                userBookingDetails.ClientUserID = dt.Rows[i]["ClientUserID"].ToString().Trim();
                userBookingDetails.CustomerUserID = dt.Rows[i]["CustomerUserID"].ToString().Trim();

                userBookingDetails.OrderNo = dt.Rows[i]["OrderNo"].ToString().Trim();
                userBookingDetails.Address = dt.Rows[i]["Address"].ToString().Trim();
                userBookingDetails.Status = dt.Rows[i]["Status"].ToString().Trim();
                userBookingDetails.FromDate = DateTime.Parse(dt.Rows[i]["FromDate"].ToString().Trim());
                userBookingDetails.ToDate = DateTime.Parse(dt.Rows[i]["ToDate"].ToString().Trim());
                userBookingDetails.TotalNoOfDays = int.Parse(dt.Rows[i]["TotalNoOfDays"].ToString().Trim());
                userBookingDetails.NoOfPersons = int.Parse(dt.Rows[i]["TotalNoOfPersons"].ToString().Trim());
                userBookingDetails.TotalCost = int.Parse(dt.Rows[i]["TotalCost"].ToString().Trim());
                userBookingDetails.BookingDate = DateTime.Parse(dt.Rows[i]["Bookingdate"].ToString().Trim());
                userBookingDetails.Area = dt.Rows[i]["Area"].ToString().Trim();
                userBookingDetails.User1 = dt.Rows[i]["User1"].ToString().Trim();
                userBookingDetails.User2 = dt.Rows[i]["User2"].ToString().Trim();
                userBookingDetails.User3 = dt.Rows[i]["User3"].ToString().Trim();
                userBookingDetails.User4 = dt.Rows[i]["User4"].ToString().Trim();
                userBookingDetails.User5 = dt.Rows[i]["User5"].ToString().Trim();


                UserBookingDetails.Add(userBookingDetails);

            }
            sqlcon.Close();
        }
        else
        {
            sqlcon.Open();
            cmd = new SqlCommand("select * from BookingDetails where OrderNo='" + OrderNo + "'", sqlcon);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable("BookingDetails");
            sda.Fill(dt);

            rdr1 = cmd.ExecuteReader();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                userBookingDetails = new BookingEntryDetailslocal();

                userBookingDetails.ClientUserID = dt.Rows[i]["ClientUserID"].ToString().Trim();
                userBookingDetails.CustomerUserID = dt.Rows[i]["CustomerUserID"].ToString().Trim();

                userBookingDetails.OrderNo = dt.Rows[i]["OrderNo"].ToString().Trim();
                userBookingDetails.Address = dt.Rows[i]["Address"].ToString().Trim();
                userBookingDetails.Status = dt.Rows[i]["Status"].ToString().Trim();
                userBookingDetails.FromDate = DateTime.Parse(dt.Rows[i]["FromDate"].ToString().Trim());
                userBookingDetails.ToDate = DateTime.Parse(dt.Rows[i]["ToDate"].ToString().Trim());
                userBookingDetails.TotalNoOfDays = int.Parse(dt.Rows[i]["TotalNoOfDays"].ToString().Trim());
                userBookingDetails.NoOfPersons = int.Parse(dt.Rows[i]["TotalNoOfPersons"].ToString().Trim());
                userBookingDetails.TotalCost = int.Parse(dt.Rows[i]["TotalCost"].ToString().Trim());
                userBookingDetails.BookingDate = DateTime.Parse(dt.Rows[i]["Bookingdate"].ToString().Trim());
                userBookingDetails.Area = dt.Rows[i]["Area"].ToString().Trim();
                userBookingDetails.User1 = dt.Rows[i]["User1"].ToString().Trim();
                userBookingDetails.User2 = dt.Rows[i]["User2"].ToString().Trim();
                userBookingDetails.User3 = dt.Rows[i]["User3"].ToString().Trim();
                userBookingDetails.User4 = dt.Rows[i]["User4"].ToString().Trim();
                userBookingDetails.User5 = dt.Rows[i]["User5"].ToString().Trim();




                string connection1 = ConfigurationManager.AppSettings["ConnString"];
                SqlConnection sqlcon1 = new SqlConnection(connection1);
                sqlcon1.Open();
                SqlCommand cmd1 = new SqlCommand("select * from PGDetails where UserID='" + userBookingDetails.ClientUserID + "'", sqlcon1);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable("BookingDetails");
                sda1.Fill(dt1);

                SqlDataReader rdr2 = cmd1.ExecuteReader();
                PGDetails pgDetails = new PGDetails();
                pgDetails.PGAddress = dt1.Rows[0]["PGAddress"].ToString().Trim();
                pgDetails.PGName = dt1.Rows[0]["PGName"].ToString().Trim();
                sqlcon1.Close();

                userBookingDetails.Address = pgDetails.PGName + "," + pgDetails.PGAddress;

                UserBookingDetails.Add(userBookingDetails);

            }
            sqlcon.Close();
        }


       
        return UserBookingDetails;



    }


  



}
