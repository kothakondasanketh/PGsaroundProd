using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace BookPG_Service
{
    [DataContract(Namespace = "UserRegister")]
    public class UserRegister
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string EmailID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]

        public string PhoneNo { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }
        [DataMember]
        public bool Gender { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Area { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int UserTypeID { get; set; }
        

    }
}