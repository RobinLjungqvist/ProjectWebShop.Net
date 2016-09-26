using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop;
using DAL;
using BLL;
using System.Data.SqlClient;

namespace Databasetestoutput
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection();
            connection.ConnectionString = @"Data source=217.210.151.153,1433; Network Library=DBMSSOCN; Initial Catalog=Webbshop; User ID = guest; Password=temppass22;";
            connection.Open();
            string sql =
               "SELECT " +
               "prod.ProductName, " +
               "category.Category, " +
               "size.Size, " +
               "color.Color, " +
               "brand.Brand, " +
               "prod.Description, " +
               "prod.PricePerUnit, " +
               "prod.UnitsInStock, " +
               "prod.PictureID " +
               "from tblProduct AS prod ";

            sql += "INNER JOIN tblCategory AS category ON prod.CategoryID = category.CategoryID " +
                   "INNER JOIN tblColor AS color ON color.ColorID = prod.ColorID " +
                   "INNER JOIN tblSize AS size ON size.SizeID = prod.SizeID " +
                   "INNER JOIN tblBrand AS brand ON brand.BrandID = prod.BrandID";

            List<string> tempname = new List<string>();
            var myCommand = new SqlCommand(sql, connection);
            using (var datareader = myCommand.ExecuteReader())
            {
                while (datareader.Read())
                {
                    tempname.Add($"{datareader["ProductName"]}, {datareader["Category"]},{datareader["Size"]},{datareader["Color"]},{datareader["Brand"]},{ datareader["Description"]},{datareader["PricePerUnit"]}{datareader["UnitsInStock"]},{datareader["PictureID"]}");
                }
            }

            foreach (var item in tempname)
            {
                Console.WriteLine(item);
            }
            connection.Close();
            Console.ReadKey();
        }
    }
}
