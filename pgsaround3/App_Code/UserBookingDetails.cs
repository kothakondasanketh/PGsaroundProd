using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace pgsaround
{
    public class UserBookingDetails
    {

        public string CustomerUserID { get; set; }

        public string ClientUserID { get; set; }

        public string OrderNo { get; set; }

        public string Status { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int TotalCost { get; set; }

        public string Address { get; set; }

        public string Area { get; set; }


    }
    //public class BookingEntryDetails
    //{
    //    public string OrderNo { get; set; }

    //    public string ClientUserID { get; set; }
    //    public string CustomerUserID { get; set; }

    //    public DateTime FromDate { get; set; }
    //    public DateTime ToDate { get; set; }
    //    public DateTime BookingDate { get; set; }
    //    public int NoOfPersons { get; set; }
    //    public string TotalNoOfDays { get; set; }
    //    public int TotalCost { get; set; }
    //    public string Status { get; set; }
    //    public string Address { get; set; }
    //    public string Area { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string Country { get; set; }

    //    public string User1 { get; set; }
    //    public string User2 { get; set; }
    //    public string User3 { get; set; }
    //    public string User4 { get; set; }
    //    public string User5 { get; set; }


    //}
}
