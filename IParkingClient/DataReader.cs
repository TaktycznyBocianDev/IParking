using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParkingClient
{
    public class DataReader
    {
        private readonly IDbConnection _connection;

        public DataReader(IDbConnection connection)
        {
            _connection = connection;
        }

        public UserModel GetUser(string email)
        {
            string query = "SELECT * FROM User WHERE Email = @Email";
            return _connection.QueryFirstOrDefault<UserModel>(query, new { Email = email });
        }
    }
}
