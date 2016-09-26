using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DALUser : DALGeneral
    {
        List<string> count = new List<string>();

        //public List<User> GetAllUserBySearch(User user)
        //{
        //    string sql =
        //        "SELECT " +
        //        "user.UserID" +
        //        "user.Firstname" +
        //        "user.Lastname" +
        //        "user.Username" +
        //        "user.Password" +
        //        "user.StreetAdress" +
        //        "zipcode.ZipcodeID" +
        //        "city.CityID" +
        //        "customergroup.CustomergroupID" +
        //        "user.Admin" +
        //        "FROM tblUser AS user WHERE ";

        //    if (user.userID != null)
        //    {
        //        if (count.Count > 0)
        //            sql += "AND";
        //        sql += $"UserID = {user.userID}";
        //    } 
        //    if (user.firstname != null)
        //    {
        //         if(count.Count > 0 )
        //            sql += "AND";
        //            sql += $"FirstName = {user.firstname}";
             
        //    }
        //    if (user.lastname != null)
        //    {
        //        if (count.Count > 0)
        //            sql += "AND";
        //        sql += $"LastName = {user.lastname}";
        //    }
        //    if (user.username != null)
        //    {
        //        if (count.Count > 0)
        //            sql += "AND";
        //        sql += $"Username = {user.username}";
        //    }
        //    if (user.streetAdress != null)
        //    {
        //        if (count.Count > 0)
        //            sql += "AND";
        //        sql += $"StreetAdress = {user.streetAdress}";
        //    }
        //    if (user.zipcodeID != null)
        //    {
        //        if (count.Count > 0)
        //            sql += "AND";
        //        sql += $"ZipcodeID = {user.zipcodeID}";
        //    }
        //    if (user.cityID != null)
        //    {
        //        if (count.Count > 0)
        //            sql += "AND";
        //        sql += $"CityID = {user.cityID}";
        //    }
        //    if (user.customergroupID != null)
        //    {
        //        if (count.Count > 0)
        //            sql += "AND";
        //        sql += $"CustomergroupID = {user.customergroupID}";
        //    }

        //    sql += "INNER JOIN tblZipcode AS zipcode ON user.ZipcodeID = zipcode.ZipcodeID"
        //        + "INNER JOIN tblCity AS city ON user.CityID = city.CityID"
        //        + "INNER JOIN tblCustomerGroup AS customergroup ON user.CustomergroupID = customergroup.CustomergroupID";

        //    List<User> users = new List<User>();
        //    var myCommand = new SqlCommand(sql, connection);

        //    using (var datareader = myCommand.ExecuteReader())
        //    {
        //        while (datareader.Read())
        //        {
        //            User item = new User();
        //            user.userID = Convert.ToInt32(datareader["UserID"]);
        //            user.firstname = $"{datareader["FirstName"]}";
        //            user.lastname = $"{datareader["LastName"]}";
        //            user.username = $"{datareader["Username"]}";
        //            user.streetAdress = $"{datareader["StreetAdress"]}";
        //            user.zipcodeID = Convert.ToInt32(datareader["ZipcodeID"]);
        //            user.cityID = Convert.ToInt32(datareader["CityID"]);
        //            user.customergroupID = Convert.ToInt32(datareader["CustomergroupID"]);
        //            user.admin = Convert.ToBoolean(datareader["Admin"]);
        //            users.Add(item);
        //        }
        //    }
        //    return users;
        //}

        //public void UpdateUser (int user)
        //{
        //    SqlCommand cmdUpdate = new SqlCommand("UPDATE tblUser SET FirstName = @newFirstName, LastName = @newLastName, Username = @newUsername, Password = @newPsw, StreetAdress = @newStreetAddress WHERE UserID = @UserID", connection);

        //    cmdUpdate.Parameters.AddWithValue("@UserID", user);
            

        //}

        //public void InsertUser(User user)
        //{ 
        //        connection.Open();
        //        SqlCommand insertUser = new SqlCommand("INSERT INTO tblUser (FirstName, LastName, Username, Password, StreetAdress, ZipcodeID, CityID, CustomergroupID) VALUES(@newFirstName, @newLastName, @newUsername, @newPsw, @newStreetAddress, @newZipcodeID, @newCityID, @newCustomergroupID");
        //        insertUser.Parameters.AddWithValue("@newFirstName", user.firstname);
        //        insertUser.Parameters.AddWithValue("@newLastName", user.lastname);
        //        insertUser.Parameters.AddWithValue("@newUsername", user.username);
        //        insertUser.Parameters.AddWithValue("@newPsw", user.password);
        //        insertUser.Parameters.AddWithValue("@newStreetAddress", user.streetAdress);
        //        insertUser.Parameters.AddWithValue("@newZipcodeID", user.zipcodeID);
        //        insertUser.Parameters.AddWithValue("@newCityID", user.cityID);
        //        insertUser.Parameters.AddWithValue("@newCustomergroupID", user.customergroupID);
        //        insertUser.ExecuteNonQuery();
        //    connection.Close();
           

        //}

        //public void DeleteUser(User user)
        //{
        //    connection.Open();
        //    SqlCommand deleteUser = new SqlCommand("DELETE FROM tblUser WHERE UserID = @UserID", connection);
        //    deleteUser.Parameters.AddWithValue("@UserID", user);
        //    deleteUser.ExecuteNonQuery();
        //}

    }
}

