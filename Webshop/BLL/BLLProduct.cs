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
    public class BLLProduct
    {
        
        public List<Product> SearchProduct(Product product)
        {
            List<string> count = new List<string>();
            string sql =
                "SELECT " +
                "prod.ProductID, " +
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
                "INNER JOIN tblBrand AS brand ON brand.BrandID = prod.BrandID WHERE ";

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
                sql += $"ProductName = '{product.name}' ";
                count.Add(sql);
            }
            if (product.category != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"Category = '{product.category}' ";
                count.Add(sql);
            }
            if (product.size != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"Size = '{product.size}' ";
                count.Add(sql);
            }
            if (product.Color != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"Color = '{product.Color}' ";
                count.Add(sql);
            }
            if (product.brand != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"Brand = '{product.brand}' ";
                count.Add(sql);
            }
            if (product.description != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"Description = '{product.description}' ";
                count.Add(sql);
            }
            if (product.ppu != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"PricePerUnit = '{product.ppu}' ";
                count.Add(sql);
            }
            if (product.unitsInStock != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"UnitsInStock = '{product.unitsInStock}' ";
                count.Add(sql);
            }
            if (product.picture != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"PictureID = {product.picture} ";
            }



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

        public string UpdateProduct(Product product)
        {
            string updatestring = $"UPDATE tblProduct SET ProductName = @{product.name}, Category = @{product.category}, Size = @{product.size} " +
                                  $"Color = @{product.Color}, Brand = @{product.brand} Description = @{ product.description}, PricePerUnit = @{ product.ppu} " +
                                  $"UnitsInStock = @{product.unitsInStock} " +
                                  $"WHERE ProductID = @ProductID";
            var dal = new DALGeneral();
            string success = CreateUpdateString(dal.CrudData(updatestring));
            return success;
        }
        public string DeleteProduct(Product product)
        {
            string deletestring = $"DELETE FROM tblProduct WHERE ProductID = {product.productID}";
            var dal = new DALGeneral();
           string success = CreateDeleteString(dal.CrudData(deletestring));
            return success;

        }


        public string AddProduct(Product product)
        {
            string addstring = "DECLARE @cid int, @sid int, @colid int, @bid int;" +
                        $"SELECT @cid = CategoryID FROM tblCategory AS c WHERE c.Category = '{product.category}'; " +
                        $"SELECT @sid = SizeID FROM tblSize AS s WHERE s.Size = '{product.size}'; " +
                        $"SELECT @colid = ColorID FROM tblColor AS color WHERE color.Color = '{product.Color}'; " +
                        $"SELECT @bid = BrandID FROM tblBrand AS b WHERE b.Brand = '{product.brand}'; " +
                        "INSERT INTO tblProduct (ProductName, CategoryID, SizeID, ColorID, BrandID, Description, PricePerUnit, UnitsInStock) " +
                        $"VALUES ('{product.name}', @cid, @sid, @colid, @bid, '{product.description}', {product.ppu}, {product.unitsInStock})" ;
            var dal = new DALGeneral();
            string success = CreateAddString(dal.CrudData(addstring));
            return success;
        }
        private string CreateDeleteString(int affectedrows)
        {
            if (affectedrows > 0)
                return "The product was successfully deleted";
            return "The product was not deleted";
                
        }
        private string CreateUpdateString(int affectedrows)
        {
            if (affectedrows > 0)
                return "The product was successfully updated";
            return "The product was not updated";
        }
        private string CreateAddString(int affectedrows)
        {
            if (affectedrows > 0)
                return "The product was successfully added";
            return "The product was not added";
        }
    }
}
