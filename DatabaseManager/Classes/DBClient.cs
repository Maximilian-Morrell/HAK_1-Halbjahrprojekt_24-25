using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.Classes
{
    internal class DBClient
    {
        public SqlConnection ConnectToDB(string Server)
        {
            return new SqlConnection();
        }

        public SqlConnection ConnectToDB(string Server, string Username, string Password)
        {
            return new SqlConnection();
        }
    }
}
