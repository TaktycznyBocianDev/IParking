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

        public bool IsOccupied { get; set; }

        public DateTime OccupiedFrom { get; set; }

        public DateTime OccupiedTo { get; set; }

        public int CarID { get; set; }

        public ParkingSpotModel(int spotID, bool isOccupied, DateTime occupiedFrom, DateTime occupiedTo, int carID)
        {
            SpotID = spotID;
            IsOccupied = isOccupied;
            OccupiedFrom = occupiedFrom;
            OccupiedTo = occupiedTo;
            CarID = carID;
        }

        public ParkingSpotModel() 
        {
            IsOccupied = true;
            CarID = 0;

        }

        
    }
}
