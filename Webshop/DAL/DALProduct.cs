using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            string sql = 
                "SELECT "+
                "prod.ProductName, " + 
                "category.Category, " +
                "size.Size, " + 
                "color.Color, " +
                "brand.Brand, " + 
                "prod.Description, " +
                "prod.PricePerUnit, " +
                "prod.UnitsInStock, " +
                "prod.PictureID " + 
                "from tblProduct AS prod WHERE ";

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

            sql += "INNER JOIN tblCategory AS category ON prod.CategoryID = category.CategoryID " +
                   "INNER JOIN tblColor AS color ON color.ColorID = prod.ColorID " +
                   "INNER JOIN tblSize AS size ON size.SizeID = prod.SizeID " +
                   "INNER JOIN tblBrand AS brand ON brand.BrandID = prod.BrandID";

            List<Product> products = new List<Product>();
            var myCommand = new SqlCommand(sql, connection);

            using (var datareader = myCommand.ExecuteReader())
            {
                while (datareader.Read())
                {
                    Product item = new Product();
                    item.productID = Convert.ToInt32(datareader["ProductID"]);
                    item.name = $"{datareader["ProductName"]}";
                    item.category = $"{datareader["Category"]}";
                    item.size = $"{datareader["Size"]}";
                    item.Color = $"{datareader["Color"]}";
                    item.brand = $"{datareader["Brand"]}";
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
