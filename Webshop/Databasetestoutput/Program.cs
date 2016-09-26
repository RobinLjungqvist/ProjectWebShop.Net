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
            product.ppu = 10;
            List<Product> products = tempbll.SearchProduct(product);

            foreach (var item in products)
            {
                Console.WriteLine(item.ppu);
            }
        }
    }
}
