using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RygOgRejs.Entities;
using System.Data;
using System.Data.SqlClient;
namespace RygOgRejs.DataAccess
{
   public class TransactionRepository : DataRepository
    {
        //Never got this to work
        
        public decimal GetTotalsFor(DateTime date)
        {
            
            string query = $"SELECT * FROM Transactions WHERE TransactionDate = {date.Date}";
            DataSet data = executor.Execute(query);
            DataTableReader reader = data.CreateDataReader();
            decimal ammountFromDb = 0;
            while (reader.Read())
            {
                ammountFromDb = ammountFromDb + Convert.ToDecimal(reader["Ammount"]);
            }

            return ammountFromDb;
        }
    }
}
