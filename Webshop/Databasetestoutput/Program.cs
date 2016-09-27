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
            var tempbll = new BLLProduct();
            var product = new Product();
            product.category = "KEPS";
            List<Product> products = tempbll.SearchProduct(product);
            var prod2 = new Product();
            prod2.name = "Trucker Keps";
            prod2.category = "KEPS";
            prod2.Color = "Röd";
            prod2.brand = "HM";
            prod2.description = "En rätt nice Keps";
            prod2.ppu = 100;
            prod2.size = "XS";
            prod2.unitsInStock = 5;
            prod2.picture = null;

            foreach (var item in products)
            {
                Console.WriteLine($"{item.productID}, {item.name}, {item.category}, {item.size}, {item.brand}, {item.Color}, {item.description}, {(int)item.ppu} Kronor, {item.unitsInStock}, {item.picture}");
            }
            //Console.WriteLine(tempbll.AddProduct(prod2));
            Console.ReadKey();
        }
    }
}
