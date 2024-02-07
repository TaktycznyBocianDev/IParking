using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public CarModel GetCar(string email)
        {
            string query = "SELECT * FROM Car WHERE UserEmail = @UserEmail";
            return _connection.QueryFirstOrDefault<CarModel>(query, new { UserEmail = email });
        }

        public List<ParkingSpotModel> GetAllParkingSpots()
        {
            string query = "SELECT * FROM ParkingSpot";
            return _connection.Query<ParkingSpotModel>(query).AsList();
        }
    }
}
