using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace IParkingClient
{
    public class CarModel
    {

        public int CarId { get; private set; }
        public string PlateNumber { get; set; }

        public string Brand { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }

        public string UserEmail { get; set; }

        public CarModel(int carId, string plateNumber, string brand, string model, string color, string userEmail)
        {
            CarId = carId;
            PlateNumber = plateNumber;
            Brand = brand;
            Model = model;
            Color = color;
            UserEmail = userEmail;
        }

        public CarModel(string plateNumber, string brand, string model, string color, string userEmail)
        {
            PlateNumber = plateNumber;
            Brand = brand;
            Model = model;
            Color = color;
            UserEmail = userEmail;
        }

        public CarModel()
        {
            PlateNumber = "XXX XXXX";
            Brand = "Skodunia";
            Model = "Feliczita";
            Color = "Zielony";
            UserEmail = "TotalnyFake@gmmailo.com";
        }

        public bool AreAtributesCorrect()
        {
            if (string.IsNullOrEmpty(PlateNumber)) return false;
            if (string.IsNullOrEmpty(Brand)) return false;
            if (string.IsNullOrEmpty(Model)) return false;
            if (string.IsNullOrEmpty(Color)) return false;
            if (string.IsNullOrEmpty(UserEmail)) return false;
            return true;
        }
    }
}
