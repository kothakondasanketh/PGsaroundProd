using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BookPG_Service
{
    [DataContract]
    public class Area
    {
        [DataMember]
        public string AreaName { get; set; }
        [DataMember]
        public int AreaID { get; set; }
        [DataMember]
        public int CityID { get; set; }
    }
}