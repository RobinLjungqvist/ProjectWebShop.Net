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
            var dt = new DataTable();
            var sda = new SqlDataAdapter(sql, connection);
            connection.Open();
            sda.Fill(dt);
            connection.Close();
            connection.Dispose();

            return dt;
        }
        public void blablabla()
        {
            
        }
    }
}
