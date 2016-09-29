using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL.Models
{
    public class User
    {

        public int? UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string StreetAdress { get; set; }


        public int? ZipCode { get; set; }
        public string City { get; set; }
        public string CustomerGroup { get; set; }
        public bool IsAdmin { get; set; }
         
    }
}