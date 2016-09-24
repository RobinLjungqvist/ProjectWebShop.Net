using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Models;




namespace DAL
{
    class DALProduct : DAL
    {

        public List<Product> GetAllProductsBySearch(Product product)
        {
            string sql = "Get * from tblProduct WHERE ";

            if (product.productID != null)
            {
                if (count.Count > 0)
                    sql += "'AND ";
                sql += $"ProductID = {product.productID} ";
            }
            if (product.name != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"ProductName = {product.name} ";
            }
            if (product.category != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"CategoryID = {product.category} ";
            }
            if (product.size != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"SizeID = {product.size} ";
            }
            if (product.Color != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"ColorID = {product.Color} ";
            }
            if (product.brand != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"BrandID = {product.brand} ";
            }
            if (product.description != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"Description = {product.description} ";
            }
            if (product.ppu != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"PricePerUnit = {product.ppu} ";
            }
            if (product.unitsInStock != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"UnitsInStock = {product.unitsInStock} ";
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
