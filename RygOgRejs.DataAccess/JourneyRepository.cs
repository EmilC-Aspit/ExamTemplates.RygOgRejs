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
            List<Journey> journeyList = new List<Journey>();
            DataSet data = executor.Execute(query);
            DataTableReader reader = data.CreateDataReader();
            while (reader.Read())
            {
                Enum.TryParse(reader["Destination"].ToString(), out Destination destination);
                DateTime depatureTime = Convert.ToDateTime(reader["DepatureTime"]);
                int adults = Convert.ToInt32(reader["Adults"]);
                int children = Convert.ToInt32(reader["Children"]);
                bool isFirstClass = Convert.ToBoolean(reader["IsFirstClass"]);
                int luggaeAmount = Convert.ToInt32(reader["LuggageAmount"]);
                Journey journey = new Journey(destination, depatureTime, isFirstClass, adults, children, luggaeAmount);
                journeyList.Add(journey);
            }
            return journeyList;
        }


        //skulde få den rigtige journey TODO: Test
        public Journey GetJourneyBy(string payerFullName)
        {
            string[] name = payerFullName.Split(' ');
            string firstName = name[0];
            string lastName = name[1];
            string query = $"SELECT Journeyid FROM Payers WHERE FirstName = '{firstName}'";
            DataSet data = executor.Execute(query);
            string temp = data.Tables[0].Rows[0][0].ToString();
            int id = int.Parse(temp);
            data.Clear();
            query = $"SELECT * FROM Journeys WHERE Journeyid = {id}";
            data = executor.Execute(query);
            DataTableReader reader = data.CreateDataReader();


            reader.Read();
            //make better
            Enum.TryParse(reader["Destination"].ToString(), out Destination destination);
            DateTime depatureTime = Convert.ToDateTime(reader["DepatureTime"]);
            int adults = Convert.ToInt32(reader["Adults"]);
            int children = Convert.ToInt32(reader["Children"]);
            bool isFirstClass = Convert.ToBoolean(reader["IsFirstClass"]);
            int luggaeAmount = Convert.ToInt32(reader["LuggageAmount"]);
            Journey journey = new Journey(destination, depatureTime, isFirstClass, adults, children, luggaeAmount);
            reader.Close();
            return journey;
        }
    }
}
