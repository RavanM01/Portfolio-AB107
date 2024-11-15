using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOClassTask.Context
{
    internal class AppDBContext
    {
        string conn = "server=MSI\\SQLEXPRESS;database=Student_Ab107;Integrated security=true";
        SqlConnection connection;

        public AppDBContext()
        {
            connection = new SqlConnection(conn);
        }

        public int NonQueryExecute(string command)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(command,connection);
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        public DataTable QueryExecute(string query)
        {
            connection.Open();
            SqlDataAdapter adapter=new SqlDataAdapter(query,connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }
    }
}
