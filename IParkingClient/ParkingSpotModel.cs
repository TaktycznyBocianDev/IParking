using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace IParkingClient
{
    public class ParkingSpotModel
    {

        public int SpotID { get; private set; }
        public int SpotNumber { get; set; }

        public bool IsOccupied { get; set; }

        public int CarID { get; set; }

        public ParkingSpotModel(int spotID, int spotNumber, bool isOccupied, int carID)
        {
            SpotID = spotID;
            SpotNumber = spotNumber;
            IsOccupied = isOccupied;
            CarID = carID;
        }

        public ParkingSpotModel(int spotNumber, bool isOccupied, int carID)
        {
            SpotNumber = spotNumber;
            IsOccupied = isOccupied;
            CarID = carID;
        }

        public ParkingSpotModel() 
        {

            SpotNumber = 1;
            IsOccupied = true;
            CarID = 0;

        }
    }
}
