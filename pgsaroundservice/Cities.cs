using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BookPG_Service
{
    [DataContract(Namespace = "", Name = "Cities")]
    public class Cities
    {
        [DataMember]
        public string CityName { get; set; }
        [DataMember]
        public int CityID { get; set; }
        [DataMember]
        public int StateID { get; set; }
    }
}