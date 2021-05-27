using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BookPG_Service
{
    [DataContract]
    public class State
    {
        [DataMember]
        public string StateName { get; set; }
        [DataMember]
        public int StateID { get; set; }
        [DataMember]
        public int CountryID { get; set; }
    }
}