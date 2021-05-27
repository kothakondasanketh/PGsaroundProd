using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace pgsaround
{
    public class UserRegister
    {


        public string UserName { get; set; }

        public string Password { get; set; }

        public string EmailID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


        public string PhoneNo { get; set; }

        public DateTime DOB { get; set; }

        public bool Gender { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Area { get; set; }

        public string Address { get; set; }

        public int UserTypeID { get; set; }


    }
}
