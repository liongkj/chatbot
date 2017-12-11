using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HRMain
{
    public class DataContext
    {
        private static DataContext contextInstance;
        private SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=DATABASE_NAME;Integrated Security=True;");

        private DataContext() { }

        public static DataContext getDatabaseInstance()
        {
            if (contextInstance == null)
                contextInstance = new DataContext();
            return contextInstance;
        }

        public string RunQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            return command.ExecuteScalar().ToString();
        }
    }
}