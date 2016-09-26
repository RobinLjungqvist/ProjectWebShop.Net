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
            var dt = new DataTable();
            var sda = new SqlDataAdapter(sql, connection);
            connection.Open();
            sda.Fill(dt);
            connection.Close();
            connection.Dispose();

            return dt;
        }

    }
}
