using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAdress { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalPrice { get; set; }
        public Dictionary<int,int> ProductIDAndQuantity { get; set; }

    }
}
