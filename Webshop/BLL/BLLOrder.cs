using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;
using DAL;
using System.Data;

namespace BLL
{
    class BLLOrder
    {
        public List<Order> SearchOrder(Order order)
        {
            List<string> count = new List<string>();
            string sql =
                "SELECT " +
                "ord.OrderID, " +
                "ord.Orderdate, " +
                "ord.DeliveryAdress, " +
                "city.City, " +
                "zip.Zipcode, " +
                "ord.CustomerID, " +
                "ord.TotalPrice, " +
                "from tblOrderHead AS ord ";

            sql += "INNER JOIN tblCity AS c ON ord.CityID = c.CityID " +
                "INNER JOIN tblZipcode AS zip ON zip.ZipcodeID = ord.ZipID WHERE ";

            if (order.OrderID != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"OrderID = {order.OrderID} ";
                count.Add(sql);
            }

            if (order.CustomerID != null)
            {
                if (count.Count > 0)
                    sql += "AND ";
                sql += $"CustomerID = {order.CustomerID} ";
            }



            List<Order> orderList = new List<Order>();
            var dal = new DALGeneral();
            var dataTable = dal.GetData(sql);


            foreach (DataRow row in dataTable.Rows)
            {
                Order item = new Order();
                item.OrderID = Convert.ToInt32(row["OrderID"]);
                item.Orderdate = Convert.ToDateTime(row["Orderdate"]);
                item.DeliveryAdress = $"{row["DeliveryAdress"]}";
                item.City = $"{row["City"]}";
                item.Zipcode = Convert.ToInt32($"{row["Zipcode"]}");
                item.CustomerID = Convert.ToInt32(row["Brand"]);
                item.TotalPrice = Convert.ToDecimal(row["Description"]);
                item.Products = GetOrderProducts(Convert.ToInt32(row["OrderID"]));
                orderList.Add(item);
            }

            return orderList;
        }
        public string UpdateOrder(Order order)
        {
            return "";
        }
        public string AddOrder(Order Order)
        {
            Order.Products.ForEach(x => AddOrderProduct(Order));


            return "";
        }
        public string DeleteOrder(int OrderID)
        {
            return "";
        }

        private List<OrderProduct> GetOrderProducts(int OrderID)
        {
            string sql =
                "SELECT " +
                "od.OrderID, " +
                "od.ProductID, " +
                "p.ProductName, " +
                "od.Quantity, " +
                "od.Price " +
                "from tblOrderDetails AS od ";

            sql += $"INNER JOIN tblProduct AS p ON p.ProductID = od.ProductID WHERE od.OrderID = {OrderID}";

            List<OrderProduct> orderProductList = new List<OrderProduct>();
            var dal = new DALGeneral();
            var dataTable = dal.GetData(sql);


            foreach (DataRow row in dataTable.Rows)
            {
                OrderProduct item = new OrderProduct();
                item.OrderID = Convert.ToInt32(row["OrderID"]);
                item.ProductID = Convert.ToInt32(row["Orderdate"]);
                item.ProductName = $"{row["DeliveryAdress"]}";
                item.Quantity = Convert.ToInt32(row["City"]);
                item.Price = Convert.ToInt32($"{row["Zipcode"]}");

                orderProductList.Add(item);
            }

            return orderProductList;

        }

        private void AddOrderProduct(Order order)
        {

            if (order.Products.Count > 0)
            {
                foreach(var product in order.Products)
                {
                    var sql = "INSERT INTO tblOrderDetails (OrderID, ProductID, Quantity, Price) " + 
                             $"VALUES ({product.OrderID}{product.ProductID}{product.Quantity}{product.Price})";
                    var dal = new DALGeneral();
                    dal.CrudData(sql);
                } 
            }
        }
    }

}
