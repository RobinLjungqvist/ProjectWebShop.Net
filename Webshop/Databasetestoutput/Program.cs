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
using System.Data;

namespace Databasetestoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //var temp = new DALGeneral();
            //var i = new Order();
            //List<Order> items = tempbll.GetAllOrders();
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
            //var sql = "SELECT * FROM tblUser";

            //List<User> users = new List<User>();
            //var dal = new DALGeneral();
            //var dataTable = dal.GetData(sql);

            var bll = new BLLUser();

            var jag = new User();
            jag.UserID = 11;
            jag.FirstName = "Kalle";
            jag.LastName = "Fuling";
            jag.UserName = "Pelikan";
            jag.Password = "fågel";
            jag.StreetAdress = "Himlen";
            jag.ZipCode = 30651;
            jag.IsAdmin = true;
            jag.City = "Helsingborg";
            jag.CustomerGroup = "VIP";

            bll.UpdateUser(jag);
           

            //var user1 = new User();
            //user1.FirstName = "Robin";
            //var users2 = bll.SearchUser(norris);
            //foreach (var item in users2)
            //{
            //    Console.WriteLine($"{item.UserName}");
            //}
            //Console.WriteLine(tempbll.AddProduct(prod2));
            Console.ReadKey();
        }
    }
}
