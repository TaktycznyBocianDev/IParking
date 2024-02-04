using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
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
                    string query = "INSERT INTO User (UserName, Surname, Email, Password, UserType) VALUES (@UserName, @Surname, @Email, @Password, @UserType);";
                    _connection.Execute(query, new
                    {
                        UserName = user.UserName,
                        Surname = user.Surname,
                        Email = user.Email,
                        Password = user.Password,
                        UserType = user.UserType

                    }, transaction: transaction);
                    transaction.Commit();
                }
            }
            catch (SQLiteException ex)
            {
                if (ex.ResultCode == SQLiteErrorCode.Constraint_Unique)
                {
                    Debug.Write("SQLiteError: " + ex.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        public void Create(CarModel car)
        {
            try
            {
                _connection.Open();

                using (var transaction = _connection.BeginTransaction())
                {
                    string query = "INSERT INTO Car (PlateNumber, Brand, Model, Color, UserEmail) VALUES (@PlateNumber, @Brand, @Model, @Color, @UserEmail);";
                    _connection.Execute(query, new
                    {
                        PlateNumber = car.PlateNumber,
                        Brand = car.Brand,
                        Model = car.Model,
                        Color = car.Color,
                        UserEmail = car.UserEmail

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
