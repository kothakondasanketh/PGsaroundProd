using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;


/// <summary>
/// Summary description for Get_CSCA_Details
/// </summary>

public  class Get_CSCA_Details
{
	public static string connection = ConfigurationManager.AppSettings["ConnString"];

   public static SqlConnection sqlcon = new SqlConnection(connection);
	public Get_CSCA_Details()
	{
		//
		// TODO: Add constructor logic here
		//
	}


	public static List<Country> Country()
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
		cmd.Parameters.AddWithValue("@Tableno", 1);
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


	public static List<State> State(int CountryID)
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
		State state = new State();

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

	public static List<Cities> City(int StateID)
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



	public static List<Area> Area(int CityID)
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
}