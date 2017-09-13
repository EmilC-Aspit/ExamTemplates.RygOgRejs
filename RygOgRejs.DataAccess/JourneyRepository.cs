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
    public class JourneyRepository : DataRepository
    {
        public List<Journey> GetAll()
        {
            string query = "SELECT * FROM Journeys";
            List<Journey> Kappa = new List<Journey>();
            DataTable dt = new DataTable();
            DataSet data = executor.Execute(query);
            DataTableReader reader = data.CreateDataReader();
            Journey.Destiantion destination;
            while (reader.Read())
            {
                Enum.TryParse(reader["Destination"].ToString(), out destination);
                DateTime depatureTime = Convert.ToDateTime(reader["DepatureTime"]);
                int adults = Convert.ToInt32(reader["Adults"]);
                int children = Convert.ToInt32(reader["Children"]);
                bool isFirstClass = Convert.ToBoolean(reader["IsFirstClass"]);
                int luggaeAmount = Convert.ToInt32(reader["LuggageAmount"]);
                Journey journey = new Journey(destination, depatureTime, isFirstClass, adults, children, luggaeAmount);
                Kappa.Add(journey);
            }
            return Kappa;
        }
    }
}
