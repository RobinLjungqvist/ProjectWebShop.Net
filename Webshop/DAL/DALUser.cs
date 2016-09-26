using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Models;

namespace DAL
{
    class DALUser : DALGeneral
    {
        List<string> count = new List<string>();

        public List<User> GetAllUserBySearch(User user)
        {
            string sql =
                "SELECT " + 
                "user.Firstname"+
                "user.Lastname"+
                "user.Username"+
                "user.Password"+
                "user.StreetAdress"+
                "zipcode.ZipcodeID"+
                "city.CityID"+
                "customergroup.CustomergroupID"+
                "user.Admin"+
                "FROM tblUser AS user WHERE ";
             
            if (user.firstname != null)
            {
                 if(count.Count > 0 )
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

            sql += "INNER JOIN tblZipcode AS zipcode ON user.ZipcodeID = zipcode.ZipcodeID"
                + "INNER JOIN tblCity AS city ON user.CityID = city.CityID"
                + "INNER JOIN tblCustomerGroup AS customergroup ON user.CustomergroupID = customergroup.CustomergroupID";

            List<User> users = new List<User>();
            var myCommand = new SqlCommand(sql, connection);

            using (var datareader = myCommand.ExecuteReader())
            {
                while (datareader.Read())
                {
                    User item = new User();
                    user.userID = Convert.ToInt32(datareader["UserID"]);
                    user.firstname = $"{datareader["FirstName"]}";
                    user.lastname = $"{datareader["LastName"]}";
                    user.username = $"{datareader["Username"]}";
                    user.streetAdress = $"{datareader["StreetAdress"]}";
                    user.zipcodeID = Convert.ToInt32(datareader["ZipcodeID"]);
                    user.cityID = Convert.ToInt32(datareader["CityID"]);
                    user.customergroupID = Convert.ToInt32(datareader["CustomergroupID"]);
                    user.admin = Convert.ToBoolean(datareader["Admin"]);
                    users.Add(item);
                }
            }
            return users;
        }

        public void UpdateUser (int user)
        {
            SqlCommand cmdUpdate = new SqlCommand("UPDATE tblUser SET FirstName = @newFirstName, LastName = @newLastName, Username = @newUsername, Password = @newPsw, StreetAdress = @newStreetAddress WHERE UserID = @UserID", connection);

            cmdUpdate.Parameters.AddWithValue("@UserID", user);


        }

        public void InsertUser(User user)
        {
            SqlCommand insertUser = new SqlCommand("INSERT INTO tblUser (FirstName, LastName, Username, Password, StreetAdress) VALUES(@newFirstName, @newLastName, @newUsername, @newPsw, @newStreetAddress");
            insertUser.Parameters.AddWithValue("@newFirstName", user.firstname);
            insertUser.Parameters.AddWithValue("@newLastName", user.lastname);
            insertUser.Parameters.AddWithValue("@newUsername", user.username);
            insertUser.Parameters.AddWithValue("@newPsw", user.password);
            insertUser.Parameters.AddWithValue("@newStreetAddress", user.streetAdress);
            insertUser.ExecuteNonQuery();

        }

    }
}

