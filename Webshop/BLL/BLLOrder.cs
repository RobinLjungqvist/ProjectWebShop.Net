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
        public int UpdateOrder(Order order)
        {
            var affectedRows = -1;
            var sql = "DECLARE @cid INT; DECLARE @zid; " +
                      $"SELECT @cid = c.CityID FROM tblCity AS c WHERE c.City = '{order.City}' " +
                      $"SELECT @zid = z.ZipcodeID FROM tblZipcode WHERE z.Zipcode = {order.Zipcode} " +
                      "UPDATE tblOrderHEAD AS oh " +
                     $"SET oh.Orderdate={order.Orderdate}, " +
                     $"oh.DeliveryAdress={order.DeliveryAdress} " +
                     $"oh.City = @cid " +
                     $"oh.Zipcode = @Zipcode " +
                     $"oh.CustomerID = {order.CustomerID} " +
                     $"oh.TotalPrice = {order.TotalPrice}" +
                     $"WHERE oh.OrderID ={order.OrderID} ";
            var dal = new DALGeneral();
            affectedRows = dal.CrudData(sql);

            UpdateOrderProduct(order);

            return affectedRows;
        }
        public int AddOrder(Order order)
        {
            var affectedRows = -1;

            string sql = "DECLARE @zid int, @cid int; " +
                        $"SELECT @zid = ZipcodeID FROM tblZipcode AS z WHERE z.Zipcode = {order.Zipcode}; " +
                        $"SELECT @cid = CityID FROM tblCity AS c WHERE c.City = '{order.City}'; " +
                        "INSERT INTO tblOrderHead (Orderdate, DeliveryAdress, CityID, ZipcodeID, CustomerID, TotalPrice) " +
                        $"VALUES ({order.Orderdate}, '{order.DeliveryAdress}', @cid, @zid, '{order.CustomerID}', {order.TotalPrice})";
            var dal = new DALGeneral();
            affectedRows = dal.CrudData(sql);


            order.Products.ForEach(x => AddOrderProduct(order));
            return affectedRows;
        }
        public int DeleteOrder(Order order)
        {
            var affectedRows = -1;
            DeleteOrderProducts(order);

            var sql = $"DELETE FROM tblOrderHead AS oh WHERE oh.OrderID = {order.OrderID}";
            var dal = new DALGeneral();
            affectedRows = dal.CrudData(sql);
            return affectedRows;
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
        private void DeleteOrderProducts(Order order)
        {
            var sql = $"DELETE FROM tblOrderDetails AS od WHERE od.OrderID = {order.OrderID}";
            var dal = new DALGeneral();
            dal.CrudData(sql);
        }
        private void UpdateOrderProduct(Order order)
        {
            var dal = new DALGeneral();
            foreach (var product in order.Products)
            {
                var sql = "UPDATE tblOrderDetails AS od " +
                         $"SET Quantity={product.Quantity}, Price = {product.Price} " +
                         $"WHERE od.OrderID ={product.OrderID} AND od.ProductID = {product.ProductID}";
                dal.CrudData(sql);
            }
        }
    }

}
