using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Models;

namespace DAL
{
    public class DALCategory: DAL
    {
        public Dictionary<int, string> GetCategories()
        {
            var categories = new Dictionary<int, string>();
            var sql = "SELECT * FROM tblCategory";

            var myCommand = new SqlCommand(sql, connection);

            try
            {
                using (var datareader = myCommand.ExecuteReader())
                {
                    while (datareader.Read())
                    {
                        categories.Add((int)datareader["CategoryID"], (string)datareader["Category"]);
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }

            return categories;
        }
        public void InsertCategory(string category)
        {
            var sql = $"INSERT INTO tblCategory (Category) VALUES ({category})";

            var myCommand = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        public void DeleteCategory(int id)
        {
            var sql = $"DELETE FROM tblCategory WHERE CategoryID = {id}";

            var myCommand = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        public void UpdateCategory(int id, string CategoryUpdate)
        {
            var sql = $"UPDATE tblCategory SET Category={CategoryUpdate} WHERE CategoryID = {id}";

            var myCommand = new SqlCommand(sql, connection);

            try
            {
                connection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
