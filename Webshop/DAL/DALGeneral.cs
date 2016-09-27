using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALGeneral
    {
        public SqlConnection connection = new SqlConnection();

        public DataTable GetData(string sql)
        {
            connection.ConnectionString = @"Data source=217.210.151.153,1433; Network Library=DBMSSOCN; Initial Catalog=Webbshop; User ID = guest; Password=temppass22;";
            using (connection)
            {
                connection.Open();
                using (var sda = new SqlDataAdapter(sql, connection))
                {
                    var dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                } 
            }

        }
        public int CrudData(string sql)
        {
            int affectedRows = -1;
            connection.ConnectionString = @"Data source=217.210.151.153,1433; Network Library=DBMSSOCN; Initial Catalog=Webbshop; User ID = guest; Password=temppass22;";
            using (connection)
            {
                connection.Open();
                using (var command = new SqlCommand(sql, connection))
                {
                    affectedRows = command.ExecuteNonQuery();
                }
            }
            return affectedRows;
        }
        public int CrudData(SqlCommand comm)
        {
            int affectedRows = -1;
            connection.ConnectionString = @"Data source=217.210.151.153,1433; Network Library=DBMSSOCN; Initial Catalog=Webbshop; User ID = guest; Password=temppass22;";
            using (connection)
            {
                connection.Open();
                using (comm.Connection = connection)
                {
                    affectedRows = comm.ExecuteNonQuery();
                }
            }
            return affectedRows;
        }
    }
}
