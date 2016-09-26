using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL.Models
{
    public class User
    {

        public int? userID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string streetAdress { get; set; }


        public int? zipcodeID { get; set; }
        public int? cityID { get; set; }
        public int? customergroupID { get; set; }
        public bool admin { get; set; }
         
    }
}