using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BookPG_Service
{
    [DataContract]
    public class Country
    {
        [DataMember]
        public string CountryName { get; set; }
        [DataMember]
        public int CountryID { get; set; }
    }
}