using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParkingClient
{
    public class ParkingFormView
    {

        private readonly DataMaker _dataMaker;
        private readonly DataReader _dataReader;

        public ParkingFormView(DataMaker dataMaker, DataReader dataReader)
        {
            _dataMaker = dataMaker;
            _dataReader = dataReader;
        }

        public List<ButtonParkingSpotAssociation> GetAllParkingSpots(List<Button> buttons)
        {
            var associations = new List<ButtonParkingSpotAssociation>();

            if (!TryGetAllParkingSpots())
            {
                CustomMessageBox("Error 404", "Parkingi not find");
                return null;
            }
            else
            {
                associations = CombineButtonAndParkingSpotLists(buttons, _dataReader.GetAllParkingSpots());
            }

            return associations;
        }

        private bool TryGetAllParkingSpots()
        {
            return _dataReader.GetAllParkingSpots().Any<ParkingSpotModel>();

        }

        public List<ButtonParkingSpotAssociation> CombineButtonAndParkingSpotLists(
        List<Button> buttons, List<ParkingSpotModel> parkingSpots)
        {
            var associations = new List<ButtonParkingSpotAssociation>();

            for (int i = 0; i < buttons.Count; i++)
            {
                associations.Add(new ButtonParkingSpotAssociation
                {
                    Button = buttons[i],
                    ParkingSpot = parkingSpots[i]
                });
            }

            return associations;
        }

        //Should be in separate class
        public void CustomMessageBox(string problemName, string problemDescription)
        {
            MessageBox.Show(problemDescription, problemName, MessageBoxButtons.OK);
        }

    }


    public class ButtonParkingSpotAssociation
    {
        public Button Button { get; set; }
        public ParkingSpotModel ParkingSpot { get; set; }
    }

    public class ButtonTable
    {
        public List<Button> Buttons { get; private set; }

        public ButtonTable(Form form)
        {
            Buttons = new List<Button>();
            GetAllButtons(form);
        }

        private void GetAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button button)
                {
                    Buttons.Add(button);
                }
                else if (c.HasChildren)
                {
                    GetAllButtons(c);
                }
            }
        }
    }
}
