using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop;
using DAL;
using BLL;
using BLL.Models;
using System.Data.SqlClient;

namespace Databasetestoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempbll = new test();
            var i = new Order();
            List<Order> items = tempbll.GetAllOrders();
            //var prod2 = new Product();
            //prod2.name = "Trucker Keps";
            //prod2.category = "KEPS";
            //prod2.Color = "Röd";
            //prod2.brand = "HM";
            //prod2.description = "En rätt nice Keps";
            //prod2.ppu = 100;
            //prod2.size = "XS";
            //prod2.unitsInStock = 5;
            //prod2.picture = null;

            foreach (var item in items)
            {
                Console.WriteLine($"{item.OrderID}, {item.Orderdate}, {item.TotalPrice}, {item.Zipcode}, {item.DeliveryAdress}, {item.Zipcode}, {item.City}");
            }
            //Console.WriteLine(tempbll.AddProduct(prod2));
            Console.ReadKey();
        }
    }
}
