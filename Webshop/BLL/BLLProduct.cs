using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    class BLLProduct
    {
        List<string> count = new List<string>();
        public List<Product> SearchProduct(Product product)
        {
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
                "from tblProduct AS prod WHERE ";

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

            sql += "INNER JOIN tblCategory AS category ON prod.CategoryID = category.CategoryID " +
                   "INNER JOIN tblColor AS color ON color.ColorID = prod.ColorID " +
                   "INNER JOIN tblSize AS size ON size.SizeID = prod.SizeID " +
                   "INNER JOIN tblBrand AS brand ON brand.BrandID = prod.BrandID";

            List<Product> products = new List<Product>();
            var dal = new DALGeneral();
            var dataTable = dal.GetData(sql);

          
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Product item = new Product();
                        item.productID = Convert.ToInt32(row["ProductID"]);
                        item.name = $"{row["ProductName"]}";
                        item.category = $"{row["Category"]}";
                        item.size = $"{row["Size"]}";
                        item.Color = $"{row["Color"]}";
                        item.brand = $"{row["Brand"]}";
                        item.description = $"{row["Description"]}";
                        item.ppu = Convert.ToDecimal(row["PricePerUnit"]);
                        item.unitsInStock = Convert.ToInt32(row["UnitsInStock"]);
                        item.picture = $"{row["PictureID"]}";
                        products.Add(item); 
                    }
               
            return products;
        }

        public void UpdateProduct(Product product)
        {

        }
        //public void DeleteProduct(Product product)
        //{
        //    string sql = "DELETE FROM " + "tblProduct" + " WHERE " + "ProductID" + " = '" + product.productID + "'";
        //    using (connection)
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            command.ExecuteNonQuery();
        //        }
        //        connection.Close();
        //    }
        //}
        //public void AddProduct(Product product)
        //{
        //    string sql = "INSERT into tblProduct (ProductID,ProductName,Category,Size,Color,Brand,Description,PricePerUnit,UnitsInStock,PictureID) " +
        //           " VALUES ('" + product.productID + "', '" + product.name + "', '" + product.category + "', '" + product.size + "', '" + product.brand + "', '" + product.description + "', '" + product.ppu
        //            + "', '" + product.unitsInStock + "', '" + product.picture + "');";

        //    using (connection)
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(sql, connection))
        //        {
        //            command.ExecuteNonQuery();
        //        }
        //        connection.Close();
        //    }
        //}
    }
}
