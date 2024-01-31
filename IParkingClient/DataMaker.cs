using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IParkingClient
{
    public class DataMaker
    {


        private readonly IDbConnection _connection;

        public DataMaker(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Create(UserModel user)
        {
            try
            {
                _connection.Open();

                using (var transaction = _connection.BeginTransaction())
                {
                    string query = "INSERT INTO User (UserName, Email, Password, UserType) VALUES (@UserName, @Email, @Password, @UserType);";
                    _connection.Execute(query, new
                    {
                        UserName = user.UserName,
                        Email = user.Email,
                        Password = user.Password,
                        UserType = user.UserType

                    }, transaction: transaction);
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Create(CarModel carModel, UserModel carOwner)
        {
            try
            {
                _connection.Open();

                using (var transaction = _connection.BeginTransaction())
                {
                    string query = "INSERT INTO Car (PlateNumber, Brand, Model, Color, UserID) VALUES (@PlateNumber, @Brand, @Model, @Color, @UserID);";
                    _connection.Execute(query, new
                    {
                        PlateNumber = carModel.PlateNumber,
                        Brand = carModel.Brand,
                        Model = carModel.Model,
                        Color = carModel.Color,
                        UserID = carOwner.UserId

                    }, transaction: transaction);
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

    }
}
