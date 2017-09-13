using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RygOgRejs.DataAccess
{
    class QueryExecutor
    {
        private string connectionString;
        public DataSet Execute(string sqlQuery)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataSet set = new DataSet();
                adapter.Fill(set);
                return set;
            }
        }
        public DataSet Execute(SqlCommand command)
        {
            return null;
        }

        public QueryExecutor()
        {
            connectionString = GetConnectionString();
        }

        private static string GetConnectionString()
        {
            return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RygOgRejsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
