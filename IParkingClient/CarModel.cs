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

        public int UserId { get; set; }

        public CarModel(int carId, string plateNumber, string brand, string model, string color, int userId)
        {
            CarId = carId;
            PlateNumber = plateNumber;
            Brand = brand;
            Model = model;
            Color = color;
            UserId = userId;
        }

        public CarModel(string plateNumber, string brand, string model, string color, int userId)
        {
            PlateNumber = plateNumber;
            Brand = brand;
            Model = model;
            Color = color;
            UserId = userId;
        }

        public CarModel()
        {
            PlateNumber = "XXX XXXX";
            Brand = "Skodunia";
            Model = "Feliczita";
            Color = "Zielony";
            UserId = 0;
        }
    }
}
