using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParkingClient
{
    public static class ConnectionManager
    {

        public static string LoadConnectionString(string id = "ParkingDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
