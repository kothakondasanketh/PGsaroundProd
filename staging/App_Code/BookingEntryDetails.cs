using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BookingEntryDetails
/// </summary>
public class BookingEntryDetails
{

    // public static string OrderNo { get; set; }

    public static string ClientUserID { get; set; }
    public static string CustomerUserID { get; set; }

    public static DateTime FromDate { get; set; }
    public static DateTime ToDate { get; set; }

    public static int Costpermonth { get; set; }
    public static int NoOfPersons { get; set; }
    public static int TotalNoOfDays { get; set; }
    public static int TotalCost { get; set; }
    public static string Status { get; set; }
    public static string Address { get; set; }
    public static string Area { get; set; }
    public static string City { get; set; }
    public static string State { get; set; }
    public static string Country { get; set; }

    public static string User1 { get; set; }
    public static string User2 { get; set; }
    public static string User3 { get; set; }
    public static string User4 { get; set; }
    public static string User5 { get; set; }


}

public class BookingEntryDetailslocal
{

    public string OrderNo { get; set; }

    public string ClientUserID { get; set; }
    public string CustomerUserID { get; set; }

    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public DateTime BookingDate { get; set; }

    public int NoOfPersons { get; set; }
    public int TotalNoOfDays { get; set; }
    public int TotalCost { get; set; }
    public string Status { get; set; }
    public string Address { get; set; }
    public string Area { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public string User1 { get; set; }
    public string User2 { get; set; }
    public string User3 { get; set; }
    public string User4 { get; set; }
    public string User5 { get; set; }


}