using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RygOgRejs.DataAccess
{
    public class QueryExecutor
    {
        private string connectionString;
        public DataSet Execute(string sqlQuery)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataSet set = new DataSet();
                adapter.Fill(set);
                connection.Close();
                return set;
            }

        }

        //something will be added
        public DataSet Execute(SqlCommand command)
        {
            return null;
        }

        public QueryExecutor()
        {
            connectionString = GetConnectionString();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                connection.Close();
            }
            catch (SqlException) { throw; }
   

        }

        private static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RygOgRejsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
