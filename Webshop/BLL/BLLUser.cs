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
    public class BLLUser
    {
        List<string> count = new List<string>();
        public List<User> SearchUser(User user)
        {

            string sql =
                "SELECT " +
                "u.UserID, " +
                "u.FirstName, " +
                "u.LastName, " +
                "u.Username, " +
                "u.Password, " +
                "u.StreetAdress, " +
                "zipcode.Zipcode, " +
                "city.City, " +
                "customergroup.CustomerGroup, " +
                "u.Admin " +
                "FROM tblUser AS u ";

            sql += "INNER JOIN tblZipcode AS zipcode ON u.ZipcodeID = zipcode.ZipcodeID "+ 
              "INNER JOIN tblCity AS city ON u.CityID = city.CityID "+ "INNER JOIN tblCustomerGroup AS customergroup ON u.CustomergroupID = customergroup.CustomergroupID WHERE ";

            if (user.UserID != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"UserID = {user.UserID}";
            }
            if (user.FirstName != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"FirstName = '{user.FirstName}'";

            }
            if (user.LastName != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"LastName = '{user.LastName}'";
            }
            if (user.UserName != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"Username = '{user.UserName}'";
            }
            if (user.StreetAdress != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"StreetAdress = '{user.StreetAdress}'";
            }
            if (user.ZipCode != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"ZipcodeID = {user.ZipCode}";
            }
            if (user.City != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"CityID = {user.City}";
            }
            if (user.CustomerGroup != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"CustomergroupID = {user.CustomerGroup}";
            } 

            List<User> users = new List<User>();
            var dal = new DALGeneral();
            var dataTable = dal.GetData(sql);

            foreach(DataRow row in dataTable.Rows)
                {
                    User item = new User();
                    item.UserID = Convert.ToInt32(row["UserID"]);
                    item.FirstName = $"{row["FirstName"]}";
                    item.LastName = $"{row["LastName"]}";
                    item.UserName = $"{row["Username"]}";
                    item.StreetAdress = $"{row["StreetAdress"]}";
                    item.ZipCode = Convert.ToInt32(row["Zipcode"]);
                    item.City = $"{row["City"]}";
                    item.CustomerGroup = $"{row["CustomerGroup"]}";
                    item.IsAdmin = Convert.ToBoolean(row["Admin"]);
                    users.Add(item);
                } 
            return users;
        }

        public string UpdateUser(User user)
        {
            string updateUserQuery = $"DECLARE @zipID int, @cityID int, @userGroupID int;" +
                      $"SELECT @zipID = ZipcodeID FROM tblZipcode AS z WHERE z.Zipcode = '{user.ZipCode}';" +
                      $"SELECT @cityID = CityID FROM tblCity AS c WHERE c.City = '{user.City}';" +
                      $"SELECT @userGroupID = CustomerGroupID FROM tblCustomerGroup AS cg WHERE cg.CustomerGroup = '{user.CustomerGroup}';" + 
                      $"UPDATE tblUser SET FirstName = '{user.FirstName}', LastName = '{user.LastName}', Username = '{user.UserName}', Password = '{user.Password}', StreetAdress = '{user.StreetAdress}', ZipcodeID = @zipID, @cityID = CityID, CustomergroupID = @userGroupID WHERE UserID = {user.UserID}";
            var dal = new DALGeneral();
            string success = CreateUpdateString(dal.CrudData(updateUserQuery));
            return success;
        }

        public string DeleteUser(User user)
        {
            string deleteUserQuery = $"DELETE FROM tblUser WHERE UserID = {user.UserID}";
            var dal = new DALGeneral();
            string success = CreateDeleteString(dal.CrudData(deleteUserQuery));
            return success;
        }
         
        public string AddUser(User user)
        {
            int admin = user.IsAdmin ? 1 : 0;
            string addUser = $"DECLARE @zipID int, @cityID int, @userGroupID int;" + 
                     $"SELECT @zipID = ZipcodeID FROM tblZipcode AS z WHERE z.Zipcode = '{user.ZipCode}';" +
                     $"SELECT @cityID = CityID FROM tblCity AS c WHERE c.City = '{user.City}';" +
                        $"SELECT @userGroupID = CustomerGroupID FROM tblCustomerGroup AS cg WHERE cg.CustomerGroup = '{user.CustomerGroup}';" +
                         $"INSERT INTO tblUser (FirstName, LastName, Username, Password, StreetAdress, ZipcodeID, CityID, CustomergroupID, Admin) VALUES('{user.FirstName}', '{user.LastName}', '{user.Password}', '{user.StreetAdress}', '{user.StreetAdress}', @zipID , @cityID, @userGroupID, {admin})";

            var dal = new DALGeneral();
            string success = CreateAddString(dal.CrudData(addUser));
            return success;
        }

        private string CreateDeleteString(int affectedrows)
        {
            if (affectedrows > 0)
                return "The user was successfully deleted";
            return "The user was not deleted";

        }
        private string CreateUpdateString(int affectedrows)
        {
            if (affectedrows > 0)
                return "The user was successfully updated";
            return "The user was not updated";
        }
        private string CreateAddString(int affectedrows)
        {
            if (affectedrows > 0)
                return "The user was successfully added";
            return "The user was not added";
        }
    }
} 
