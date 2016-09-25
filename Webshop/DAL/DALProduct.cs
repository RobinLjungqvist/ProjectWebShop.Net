using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Models;
using System.Data.SqlClient;




namespace DAL
{
    class DALProduct : DAL
    {

        List<string> count = new List<string>();
        public List<Product> SearchProduct(Product product)
        {
            string sql = "Get * from tblProduct WHERE ";

            if (product.productID != null)
            {
                if (count.Count > 0)
                    sql += "'AND ";
                sql += $"ProductID = {product.productID} ";
                count.Add(sql);
            }
            if (product.name != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"ProductName = {product.name} ";
                count.Add(sql);
            }
            if (product.category != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"CategoryID = {product.category} ";
                count.Add(sql);
            }
            if (product.size != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"SizeID = {product.size} ";
                count.Add(sql);
            }
            if (product.Color != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"ColorID = {product.Color} ";
                count.Add(sql);
            }
            if (product.brand != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"BrandID = {product.brand} ";
                count.Add(sql);
            }
            if (product.description != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"Description = {product.description} ";
                count.Add(sql);
            }
            if (product.ppu != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"PricePerUnit = {product.ppu} ";
                count.Add(sql);
            }
            if (product.unitsInStock != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"UnitsInStock = {product.unitsInStock} ";
                count.Add(sql);
            }
            if (product.picture != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"PictureID = {product.picture} ";
            }
            List<Product> products = new List<Product>();
            var myCommand = new SqlCommand(sql, connection);

            using (var datareader = myCommand.ExecuteReader())
            {
                while (datareader.Read())
                {
                    Product item = new Product();
                    item.productID = Convert.ToInt32(datareader["ProductID"]);
                    item.name = $"{datareader["ProductName"]}";
                    item.category = $"{datareader["CategoryID"]}";
                    item.size = $"{datareader["SizeID"]}";
                    item.Color = $"{datareader["ColorID"]}";
                    item.brand = $"{datareader["BrandID"]}";
                    item.description = $"{datareader["Description"]}";
                    item.ppu = Convert.ToDecimal(datareader["PricePerUnit"]);
                    item.unitsInStock = Convert.ToInt32(datareader["UnitsInStock"]);
                    item.picture = $"{datareader["PictureID"]}";
                    products.Add(item);
                }
            }
            return products;
        }
    }
}
