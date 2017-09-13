using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


//handle database
namespace RygOgRejs.DataAccess
{
    abstract class DataRepository
    {
        protected QueryExecutor executor;
        public DataRepository()
        {
            executor = new QueryExecutor();
        }
    }
}
