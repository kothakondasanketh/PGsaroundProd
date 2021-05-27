using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Configuration;


namespace BookPG_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {

        public static string connection = ConfigurationManager.AppSettings["ConnString"];
         
            SqlConnection sqlcon = new SqlConnection(connection);


            public int GenerateOrderno()
            {
                string Orderno;
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select MAX(Sno) from BookingDetails", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("BookingDetails");
                sda.Fill(dt);
                // UserName = dt.Rows[0]["UserName"].ToString().Trim();
                Orderno =dt.Rows[0][0].ToString().Trim();
               int Orderno1 =int.Parse(Regex.Match(Orderno, @"\d+").Value);
                sqlcon.Close();
                return Orderno1;

            }
       public string Login(string Username,string Password,int UserTypeID)
        {
            try
            {
                string UserName =null;
                string Status = "";
               // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5;connection timeout=5";
               // SqlConnection sqlcon = new SqlConnection(connection);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select Name from UserDetails where UserName='" + Username + "' and PassWord='" + Password + "' and UserTypeID='" + UserTypeID + "'", sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("UserDetails");
                sda.Fill(dt);
                // UserName = dt.Rows[0]["UserName"].ToString().Trim();
                UserName = dt.Rows[0]["Name"].ToString().Trim();

                if (UserName != null)
                {
                    cmd = new SqlCommand("select Status from UserAuthentication where Username='" + Username + "'", sqlcon);
                    sda = new SqlDataAdapter(cmd);
                    dt = new DataTable("UserAuthentication");
                    sda.Fill(dt);
                    // UserName = dt.Rows[0]["UserName"].ToString().Trim();
                    Status = dt.Rows[0]["Status"].ToString().Trim();
                }
                sqlcon.Close();
                if (Status != "0")
                {

                    return UserName;
                }
                else 
                {
                    return "False";
                }
               
               
            }
            catch (Exception ex) { throw new FaultException(ex.Message); }
        }

       public List<UserRegister> GetUserDetails(string Username)
       {
           try
           {

              // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5;connection timeout=5";
              // SqlConnection sqlcon = new SqlConnection(connection);
               sqlcon.Open();
               SqlCommand cmd = new SqlCommand("select * from UserDetails where UserName='" + Username + "'", sqlcon);
               SqlDataAdapter sda = new SqlDataAdapter(cmd);
               DataTable dt = new DataTable("UserDetails");
               sda.Fill(dt);
               UserRegister userd = new BookPG_Service.UserRegister();
               List<UserRegister> lst = new List<BookPG_Service.UserRegister>();
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
               userd.Age =int.Parse( dt.Rows[0]["Age"].ToString().Trim());
               userd.Gender =bool.Parse(dt.Rows[0]["Gender"].ToString().Trim());
               userd.DOB = DateTime.Parse(dt.Rows[0]["DOB"].ToString().Trim());
               

               lst.Add(userd);
               sqlcon.Close();
               return lst;
           }
           catch (Exception ex) { throw new FaultException(ex.Message); }
       }

      public string UserRegister(UserRegister Userdetails,int update )
       {
           string Successfull=null;
           try
           {
               // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
               //    SqlConnection sqlcon = new SqlConnection(connection);
                   sqlcon.Open();
                   SqlCommand cmd;

               if (update == 1)
               {
                   cmd = new SqlCommand("insert into UserDetails(UserName,Password,EmailID,Name,Age,Gender,Phno,Address,Area,City,State,Country,DOB,UserTypeID)values('" + Userdetails.UserName + "','" + Userdetails.Password + "','" + Userdetails.EmailID + "','" + Userdetails.Name + "','" + Userdetails.Age + "','" + Userdetails.Gender + "','" + Userdetails.PhoneNo + "','" + Userdetails.Address + "','" + Userdetails.Area + "','" + Userdetails.City + "','" + Userdetails.State + "','" + Userdetails.Country + "','" + Userdetails.DOB.Date + "','" + Userdetails.UserTypeID + "')", sqlcon);
                   //SqlDataReader SDR = cmd.ExecuteReader();
                   int i = cmd.ExecuteNonQuery();
                   sqlcon.Close();
                   if (i > 0)
                   {
                       Successfull = "Successfull";
                   }
                   else
                   {
                       Successfull = "Not Successfull..Please Enter the Fields Correctly and TRY";
                   }
               }
               else if (update == 2)
               {
                   cmd = new SqlCommand("update UserDetails set Password='" + Userdetails.Password + "',EmailID='" + Userdetails.EmailID + "',Name='" + Userdetails.Name + "',Age='" + Userdetails.Age + "',Gender='" + Userdetails.Gender + "',Phno='" + Userdetails.PhoneNo + "',Address='" + Userdetails.Address + "',Area='" + Userdetails.Area + "',City='" + Userdetails.City + "',State='" + Userdetails.State + "',Country='" + Userdetails.State + "',DOB='" + Userdetails.DOB + "' where UserName='" + Userdetails.UserName + "'" , sqlcon);
                   //SqlDataReader SDR = cmd.ExecuteReader();
                   int i = cmd.ExecuteNonQuery();
                   sqlcon.Close();
                   if (i > 0)
                   {
                       Successfull = "Successfully Updated";
                   }
                   else
                   {
                       Successfull = "Not Successfull..Please Enter the Fields Correctly and TRY";
                   }

               }
               sqlcon.Close();
              
           }
           catch (Exception ex) { throw new FaultException(ex.Message); }


           return Successfull;
         


       }

      public string PGRegister(PGDetails pgdetails, int update)
      {
          string Successfull = null;
          try
          {
             // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
              //    SqlConnection sqlcon = new SqlConnection(connection);
                  sqlcon.Open();
                  SqlCommand cmd ;
              if (update == 1)
              {
                  cmd = new SqlCommand("insert into PGDetails(UserID,PGAddress,PGName,PGPhno,Availability,CostPerDay,CostPerMonth,Area,City,State,Country,ConfirmationStatus,AC,NonAC,NIFood,SIFood,Internet,TV,Hotwater,Food3times,NoFood,Parkingspace,Laundry,Pgprofilepic,Pgimg1,Pgimg2,Pgimg3,Pgimg4,Pgimg5)values('" + pgdetails.UserID + "','" + pgdetails.PGAddress + "','" + pgdetails.PGName + "','" + pgdetails.PGPhno + "','" + pgdetails.Avialability + "','" + pgdetails.CostPerDay + "','" + pgdetails.CostPerMonth + "','" + pgdetails.Area + "','" + pgdetails.City + "','" + pgdetails.State + "','" + pgdetails.Country + "','" + pgdetails.ConfirmationStas + "','" + pgdetails.AC + "','" + pgdetails.NonAC + "','" + pgdetails.NIFood + "','" + pgdetails.SIFood + "','" + pgdetails.Internet + "','" + pgdetails.TV + "','" + pgdetails.Hotwater + "','" + pgdetails.Food3times + "','" + pgdetails.NoFood + "','" + pgdetails.Parkingspace + "','" + pgdetails.Laundry + "','" + pgdetails.Pgprofilepic + "','" + pgdetails.Pgimg1 + "','" + pgdetails.Pgimg2 + "','" + pgdetails.Pgimg3 + "','" + pgdetails.Pgimg4 + "','" + pgdetails.Pgimg5 + "')", sqlcon);
                  //SqlDataReader SDR = cmd.ExecuteReader();
                  int i = cmd.ExecuteNonQuery();
                  sqlcon.Close();
                  if (i > 0)
                  {
                      Successfull = "Successfull";
                  }
                  else
                  {
                      Successfull = "Not Successfull..Please Enter the Fields Correctly and TRY";
                  }
              }
              else if (update == 2)
              {
                  cmd = new SqlCommand("update PGDetails set PGAddress='" + pgdetails.PGAddress + "',PGName='" + pgdetails.PGName + "',PGPhno='" + pgdetails.PGPhno + "',Availability='" + pgdetails.Avialability + "',CostPerDay='" + pgdetails.CostPerDay + "',CostPerMonth='" + pgdetails.CostPerMonth + "',Area='" + pgdetails.Area + "',City='" + pgdetails.City + "',State='" + pgdetails.State + "',Country='" + pgdetails.Country + "',AC='" + pgdetails.AC + "',NonAC='" + pgdetails.NonAC + "',NIFood='" + pgdetails.NIFood + "',SIFood='" + pgdetails.SIFood + "',Internet='" + pgdetails.Internet + "',TV='" + pgdetails.TV + "',Hotwater='" + pgdetails.Hotwater + "',Food3times='" + pgdetails.Food3times + "',NoFood='" + pgdetails.NoFood + "',Parkingspace='" + pgdetails.Parkingspace + "',Laundry='" + pgdetails.Laundry + "',Pgprofilepic='" + pgdetails.Pgprofilepic + "',Pgimg1='" + pgdetails.Pgimg1 + "',Pgimg2='" + pgdetails.Pgimg2 + "',Pgimg3='" + pgdetails.Pgimg3 + "',Pgimg4='" + pgdetails.Pgimg4 + "',Pgimg5='" + pgdetails.Pgimg5 + "' where UserID='" + pgdetails.UserID + "'", sqlcon);
                  //SqlDataReader SDR = cmd.ExecuteReader();
                  int i = cmd.ExecuteNonQuery();
                  sqlcon.Close();
                  if (i > 0)
                  {
                      Successfull = "SuccessfullY Updated";
                  }
                  else
                  {
                      Successfull = "Not Successfull..Please Enter the Fields Correctly and TRY";
                  }

              }
              else if (update == 3)
              {
                  cmd = new SqlCommand("update PGDetails set ConfirmationStatus='" + pgdetails.ConfirmationStas + "' where UserID='" + pgdetails.UserID + "'", sqlcon);
                  //SqlDataReader SDR = cmd.ExecuteReader();
                  int i = cmd.ExecuteNonQuery();
                  sqlcon.Close();
                  if (i > 0)
                  {
                      Successfull = "SuccessfullY Updated";
                  }
                  else
                  {
                      Successfull = "Not Successfull..Please Enter the Fields Correctly and TRY";
                  }

              }
              sqlcon.Close();

          }
          catch (Exception ex) { throw new FaultException(ex.Message); }


          return Successfull;



      }
       

        
        public List<Country> Country()
        {
        //    string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
        //    SqlConnection sqlcon = new SqlConnection(connection);
        //    sqlcon.Open();
        //    SqlCommand cmd = new SqlCommand("select * from CountryTable", sqlcon);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable("CountryTable");
        //    sda.Fill(dt);


            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("sp_get_list_CSCA", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tableno",1);
            cmd.Parameters.AddWithValue("@Id", "");

            
            
            SqlDataReader rdr1 = cmd.ExecuteReader();
            List<Country> listCountry = new List<Country>();
            Country country = new Country();

            country = new Country();

            Country obj = default(Country);
            while (rdr1.Read())
            {
                obj = Activator.CreateInstance<Country>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(rdr1[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, rdr1[prop.Name], null);
                    }
                }
                listCountry.Add(obj);
            }
            sqlcon.Close();

            return listCountry;




        }

       
        public List<State> State(int CountryID)
        {
           // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
           // SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            //SqlCommand cmd = new SqlCommand("select * from StateTable where CountryID='"+CountryID+"'", sqlcon);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("StateTable");
            //sda.Fill(dt);
            SqlCommand cmd = new SqlCommand("sp_get_list_CSCA", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tableno", 2);
            cmd.Parameters.AddWithValue("@Id", CountryID);

            SqlDataReader rdr1 = cmd.ExecuteReader();
            List<State> liststate = new List<State>();
            State state= new State();

            state = new State();

            State obj = default(State);
            while (rdr1.Read())
            {
                obj = Activator.CreateInstance<State>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(rdr1[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, rdr1[prop.Name], null);
                    }
                }
                liststate.Add(obj);
            }

            sqlcon.Close();
            return liststate;




        }

        public List<Cities> City(int StateID)
        {
           // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
           // SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            //SqlCommand cmd = new SqlCommand("select * from CityTable where StateID='"+StateID+"'", sqlcon);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("CityTable");
            //sda.Fill(dt);
            SqlCommand cmd = new SqlCommand("sp_get_list_CSCA", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tableno", 3);
            cmd.Parameters.AddWithValue("@Id", StateID);
            SqlDataReader rdr1 = cmd.ExecuteReader();
            List<Cities> listcities = new List<Cities>();
            Cities cities = new Cities();

            cities = new Cities();

            Cities obj = default(Cities);
            while (rdr1.Read())
            {
                obj = Activator.CreateInstance<Cities>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(rdr1[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, rdr1[prop.Name], null);
                    }
                }
                listcities.Add(obj);
            }
            sqlcon.Close();

            return listcities;




        }

       
        //public List<Area> Area(int CityID)
        //{
        //   // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
        //   // SqlConnection sqlcon = new SqlConnection(connection);
        //    sqlcon.Open();
        //    //SqlCommand cmd = new SqlCommand("select * from AreaTable where CityID='" + CityID + "'", sqlcon);
        //    //SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    //DataTable dt = new DataTable("AreaTable");
        //    //sda.Fill(dt);
        //    SqlCommand cmd = new SqlCommand("sp_get_list_CSCA", sqlcon);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@Tableno", 4);
        //    cmd.Parameters.AddWithValue("@Id", CityID);

        //    SqlDataReader rdr1 = cmd.ExecuteReader();
        //    List<Area> listarea = new List<Area>();
        //    Area area = new Area();

        //    area = new Area();

        //    Area obj = default(Area);
        //    while (rdr1.Read())
        //    {
        //        obj = Activator.CreateInstance<Area>();
        //        foreach (PropertyInfo prop in obj.GetType().GetProperties())
        //        {
        //            if (!object.Equals(rdr1[prop.Name], DBNull.Value))
        //            {
        //                prop.SetValue(obj, rdr1[prop.Name], null);
        //            }
        //        }
        //        listarea.Add(obj);
        //    }

        //    sqlcon.Close();
        //    return listarea;
        //}
        public List<Area> Area(int CityID)
        {
            // string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
            // SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            //SqlCommand cmd = new SqlCommand("select * from AreaTable where CityID='" + CityID + "'", sqlcon);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("AreaTable");
            //sda.Fill(dt);
            SqlCommand cmd = new SqlCommand("sp_get_list_CSCA", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tableno", 4);
            cmd.Parameters.AddWithValue("@Id", CityID);

            SqlDataReader rdr1 = cmd.ExecuteReader();
            List<Area> listarea = new List<Area>();
            Area area = new Area();

            area = new Area();

            Area obj = default(Area);
            while (rdr1.Read())
            {
                obj = Activator.CreateInstance<Area>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!object.Equals(rdr1[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, rdr1[prop.Name], null);
                    }
                }
                listarea.Add(obj);
            }

            sqlcon.Close();
            return listarea;
        }

        public List<PGDetails> ParticularPgDetailsList(string ClientID)
        {

           
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

        public List<PGDetails> PgDetailsList(string Area,int UserTyperID,int Gender)
        {
            List<PGDetails> List_PgDetails = new List<PGDetails>();
            PGDetails pgdetails = new PGDetails();
          //  string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
          //  SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
             SqlCommand cmd;
            if (Area != null)
            {

                cmd = new SqlCommand("select * from PGDetails where Area='" + Area + "' and ConfirmationStatus='Approved' and Pgservetype='"+Gender+"'", sqlcon);
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
            }
            else if(Area!=null && UserTyperID!=3)
            {
                List<Confirmation> Conflist = new List<Confirmation>() { new Confirmation() { CornformationStatus = "Pending", CornformationStatusID = 1 }, new Confirmation() { CornformationStatus = "Hold", CornformationStatusID = 2 }, new Confirmation() { CornformationStatus = "Approved", CornformationStatusID = 3 }, new Confirmation() { CornformationStatus = "NotApproved", CornformationStatusID = 4 } };
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
                    if(UserTyperID==2)
                    {
                    pgdetails.ConfirmationStas = dt.Rows[i]["ConfirmationStatus"].ToString().Trim();
                    }
                    pgdetails.ConfirmationLst = Conflist;
                    List_PgDetails.Add(pgdetails);

                }

            }
            else if (Area == null && UserTyperID == 3)
            {
                List<Confirmation> Conflist = new List<Confirmation>() { new Confirmation() { CornformationStatus = "Pending", CornformationStatusID = 1 }, new Confirmation() { CornformationStatus = "Hold", CornformationStatusID = 2 }, new Confirmation() { CornformationStatus = "Approved", CornformationStatusID = 3 }, new Confirmation() { CornformationStatus = "NotApproved", CornformationStatusID = 4 } };
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

            }
            sqlcon.Close();
            return List_PgDetails;

        }

        public List<UserBookingDetails> UserBookingDetailsList(string Username,int UserID)
        {
         
            string ClientUserID=null;
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

        public ObservableCollection<BookingEntryDetails> bookingdetails(string OrderNo)
        {

            ObservableCollection<BookingEntryDetails> UserBookingDetails = new ObservableCollection<BookingEntryDetails>();
            BookingEntryDetails userBookingDetails = new BookingEntryDetails();
         //   string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
         //   SqlConnection sqlcon = new SqlConnection(connection);
            sqlcon.Open();
            SqlCommand cmd = null;
            SqlDataAdapter sda;
            DataTable dt;
            SqlDataReader rdr1;

            if (OrderNo == null)
            {
                cmd = new SqlCommand("select OrderNo,Address,Status,FromDate,ToDate,TotalNoOfDays,TotalNoOfPersons,TotalCost,Bookingdate,Area,User1,User2,User3,User4,User5,ClientUserID,CustomerUserID from BookingDetails", sqlcon);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable("BookingDetails");
                sda.Fill(dt);

                rdr1 = cmd.ExecuteReader();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    userBookingDetails = new BookingEntryDetails();

                    userBookingDetails.ClientUserID = dt.Rows[i]["ClientUserID"].ToString().Trim();
                    userBookingDetails.CustomerUserID = dt.Rows[i]["CustomerUserID"].ToString().Trim();

                    userBookingDetails.OrderNo = dt.Rows[i]["OrderNo"].ToString().Trim();
                    userBookingDetails.Address = dt.Rows[i]["Address"].ToString().Trim();
                    userBookingDetails.Status = dt.Rows[i]["Status"].ToString().Trim();
                    userBookingDetails.FromDate = DateTime.Parse(dt.Rows[i]["FromDate"].ToString().Trim());
                    userBookingDetails.ToDate = DateTime.Parse(dt.Rows[i]["ToDate"].ToString().Trim());
                    userBookingDetails.TotalNoOfDays = dt.Rows[i]["TotalNoOfDays"].ToString().Trim();
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
            }
            else
            {
                cmd = new SqlCommand("select * from BookingDetails where OrderNo='" + OrderNo + "'", sqlcon);
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable("BookingDetails");
                sda.Fill(dt);

                rdr1 = cmd.ExecuteReader();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    userBookingDetails = new BookingEntryDetails();

                    userBookingDetails.ClientUserID = dt.Rows[i]["ClientUserID"].ToString().Trim();
                    userBookingDetails.CustomerUserID = dt.Rows[i]["CustomerUserID"].ToString().Trim();

                    userBookingDetails.OrderNo = dt.Rows[i]["OrderNo"].ToString().Trim();
                    userBookingDetails.Address = dt.Rows[i]["Address"].ToString().Trim();
                    userBookingDetails.Status = dt.Rows[i]["Status"].ToString().Trim();
                    userBookingDetails.FromDate = DateTime.Parse(dt.Rows[i]["FromDate"].ToString().Trim());
                    userBookingDetails.ToDate = DateTime.Parse(dt.Rows[i]["ToDate"].ToString().Trim());
                    userBookingDetails.TotalNoOfDays = dt.Rows[i]["TotalNoOfDays"].ToString().Trim();
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


                    userBookingDetails.Address = pgDetails.PGName + "," + pgDetails.PGAddress;

                    UserBookingDetails.Add(userBookingDetails);

                }
            }

           
            sqlcon.Close();
            return UserBookingDetails;



        }


        public string BookPG(BookingEntryDetails BEntry)
        {
            try
            {
                string status = null;
             //   string connection = "server=(local);database=BookPG_Database;Integrated security=true;connection timeout=5";
             //   SqlConnection sqlcon = new SqlConnection(connection);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("insert into BookingDetails(OrderNo,ClientUserID,CustomerUserID,FromDate,ToDate,TotalNoOfPersons,TotalNoOfDays,TotalCost,Status,Address,Area,City,State,User1,User2,User3,User4,User5,Bookingdate)values('" + BEntry.OrderNo + "','" + BEntry.ClientUserID + "','" + BEntry.CustomerUserID + "','" + BEntry.FromDate + "','" + BEntry.ToDate + "','" + BEntry.NoOfPersons + "','" + BEntry.TotalNoOfDays + "','" + BEntry.TotalCost + "','" + BEntry.Status + "','" + BEntry.Address + "','" + BEntry.Area + "','" + BEntry.City + "','" + BEntry.State + "','" + BEntry.User1 + "','" + BEntry.User2 + "','" + BEntry.User3 + "','" + BEntry.User4 + "','" + BEntry.User5 + "','" + BEntry.BookingDate + "')", sqlcon);
                //SqlDataReader SDR = cmd.ExecuteReader();
                int i = cmd.ExecuteNonQuery();
                sqlcon.Close();
                if (i > 0)
                {
                    status = "Congractulations your Order has placed Successfully \n Your Order Number is- " + BEntry.OrderNo + "";
                }
                else
                {
                    status = "Not Successfull..Please Enter the Fields Correctly and TRY";
                }
                sqlcon.Close();
                return status;
            }
            catch (Exception ex) { throw new FaultException(ex.Message); }
         }

        

    } 
}
