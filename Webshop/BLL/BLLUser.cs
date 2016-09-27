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
                "FROM tblUser AS user WHERE ";

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

            sql += "INNER JOIN tblZipcode AS zipcode ON user.ZipcodeID = zipcode.ZipcodeID"
                + "INNER JOIN tblCity AS city ON user.CityID = city.CityID"
                + "INNER JOIN tblCustomerGroup AS customergroup ON user.CustomergroupID = customergroup.CustomergroupID";

            List<User> users = new List<User>();
            var dal = new DALGeneral();
            var dataTable = dal.GetData(sql);

            foreach(DataRow row in dataTable.Rows)
                {
                    User item = new User();
                    user.userID = Convert.ToInt32(row["UserID"]);
                    user.firstname = $"{row["FirstName"]}";
                    user.lastname = $"{row["LastName"]}";
                    user.username = $"{row["Username"]}";
                    user.streetAdress = $"{row["StreetAdress"]}";
                    user.zipcodeID = Convert.ToInt32(row["ZipcodeID"]);
                    user.cityID = Convert.ToInt32(row["CityID"]);
                    user.customergroupID = Convert.ToInt32(row["CustomergroupID"]);
                    user.admin = Convert.ToBoolean(row["Admin"]);
                    users.Add(item);
                } 
            return users;
        }

        public void UpdateUser(User user)
        {
            string updateUserQuery = $"UPDATE tblUser SET FirstName = @{user.firstname}, LastName = @{user.lastname}, Username = @{user.username}, Password = @{user.password}, StreetAdress = @{user.streetAdress}, CustomergroupID = @{user.customergroupID} WHERE UserID = @{user.userID}";
            var dal = new DALGeneral();
            dal.CrudData(updateUserQuery); 
        }

        public void DeleteUser(User user)
        {
            string deleteUserQuery = $"DELETE FROM tblUser WHERE UserID = {user.userID}";
            var dal = new DALGeneral();
            dal.CrudData(deleteUserQuery);
        }

        // Tog bort CustomerGroupID eftersom en user ska ju inte bestämma åt sig själv vilken customergroup den ska vara i utan det är Admins jobb att skriva det.
        public void InsertUser(User user)
        {
            string insertUser = $"INSERT INTO tblUser (FirstName, LastName, Username, Password, StreetAdress, ZipcodeID, CityID) VALUES('{user.firstname}', '{user.lastname}', '{user.password}', '{user.streetAdress}', '{user.streetAdress}', '{user.zipcodeID}', '{user.cityID}')";

            var dal = new DALGeneral();
            dal.CrudData(insertUser);
        }
    }
} 
