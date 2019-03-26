using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public sealed class DBConnection
    {
        private static volatile SqlConnection instance;

        private DBConnection() { }

        public static SqlConnection DB_Connection
        {
            get
            {
                if (instance == null)
                {
                    instance = new SqlConnection(ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString);
                }
                return instance;
            }
        }
    }
}
