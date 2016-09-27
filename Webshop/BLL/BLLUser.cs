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
                "user.UserID" +
                "user.Firstname" +
                "user.Lastname" +
                "user.Username" +
                "user.Password" +
                "user.StreetAdress" +
                "zipcode.ZipcodeID" +
                "city.CityID" +
                "customergroup.CustomergroupID" +
                "user.Admin" +
                "FROM tblUser AS user ";

            sql += "INNER JOIN tblZipcode AS zipcode ON user.ZipcodeID = zipcode.ZipcodeID"+ 
              "INNER JOIN tblCity AS city ON user.CityID = city.CityID"+ "INNER JOIN tblCustomerGroup AS customergroup ON user.CustomergroupID = customergroup.CustomergroupID WHERE ";

            if (user.userID != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"UserID = {user.userID}";
            }
            if (user.firstname != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"FirstName = {user.firstname}";

            }
            if (user.lastname != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"LastName = {user.lastname}";
            }
            if (user.username != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"Username = {user.username}";
            }
            if (user.streetAdress != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"StreetAdress = {user.streetAdress}";
            }
            if (user.zipcodeID != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"ZipcodeID = {user.zipcodeID}";
            }
            if (user.cityID != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"CityID = {user.cityID}";
            }
            if (user.customergroupID != null)
            {
                if (count.Count > 0)
                    sql += "AND";
                sql += $"CustomergroupID = {user.customergroupID}";
            } 

            List<User> users = new List<User>();
            var dal = new DALGeneral();
            var dataTable = dal.GetData(sql);

            foreach(DataRow row in dataTable.Rows)
                {
                    User item = new User();
                    item.userID = Convert.ToInt32(row["UserID"]);
                    item.firstname = $"{row["FirstName"]}";
                    item.lastname = $"{row["LastName"]}";
                    item.username = $"{row["Username"]}";
                    item.streetAdress = $"{row["StreetAdress"]}";
                    item.zipcodeID = Convert.ToInt32(row["ZipcodeID"]);
                    item.cityID = Convert.ToInt32(row["CityID"]);
                    item.customergroupID = Convert.ToInt32(row["CustomergroupID"]);
                    item.admin = Convert.ToBoolean(row["Admin"]);
                    users.Add(item);
                } 
            return users;
        }

        public string UpdateUser(User user)
        {
            string updateUserQuery = $"DECLARE @zipID int, @cityID int, @userGroupID int;" +
                      $"SELECT @zipID = ZipcodeID FROM tblZipcode AS z WHERE z.Zipcode = '{user.zipcodeID}';" +
                      $"SELECT @cityID = CityID FROM tblCity AS c WHERE c.City = '{user.cityID}';" +
                      $"SELECT @userGroupID = CustomerGroupID FROM tblCustomerGroup AS cg WHERE cg.CustomerGroup = '{user.customergroupID}';" + 
                      $"UPDATE tblUser SET FirstName = '{user.firstname}', LastName = '{user.lastname}', Username = '{user.username}', Password = '{user.password}', StreetAdress = '{user.streetAdress}', ZipcodeID = @zipID, @cityID = CityID, CustomergroupID = @userGroupID WHERE UserID = @userID";
            var dal = new DALGeneral();
            dal.CrudData(updateUserQuery);
            string success = CreateUpdateString(dal.CrudData(updateUserQuery));
            return success;
        }

        public string DeleteUser(User user)
        {
            string deleteUserQuery = $"DELETE FROM tblUser WHERE UserID = {user.userID}";
            var dal = new DALGeneral();
            dal.CrudData(deleteUserQuery);
            string success = CreateDeleteString(dal.CrudData(deleteUserQuery));
            return success;
        }
         
        public string AddUser(User user)
        {
            string addUser = $"DECLARE @zipID int, @cityID int, @userGroupID int;" + 
                     $"SELECT @zipID = ZipcodeID FROM tblZipcode AS z WHERE z.Zipcode = '{user.zipcodeID}';" +
                     $"SELECT @cityID = CityID FROM tblCity AS c WHERE c.City = '{user.cityID}';" +
                        $"SELECT @userGroupID = CustomerGroupID FROM tblCustomerGroup AS cg WHERE cg.CustomerGroup = '{user.customergroupID}';" +
                         $"INSERT INTO tblUser (FirstName, LastName, Username, Password, StreetAdress, ZipcodeID, CityID, CustomergroupID) VALUES('{user.firstname}', '{user.lastname}', '{user.password}', '{user.streetAdress}', '{user.streetAdress}', '{user.zipcodeID}', '{user.cityID}', '{user.customergroupID}')";

            var dal = new DALGeneral();
            dal.CrudData(addUser);
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
