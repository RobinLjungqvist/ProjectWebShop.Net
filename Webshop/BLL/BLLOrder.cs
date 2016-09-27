using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL
{
    class BLLOrder
    {
        public List<Order> SearchProduct(Order product)
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
    }
}
