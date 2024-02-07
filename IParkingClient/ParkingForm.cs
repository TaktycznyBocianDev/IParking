using IParkingClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace IParkingClient
{
    public partial class ParkingForm : Form
    {

        string ImagePath = ".\\ParkingXD.png";
        private ParkingFormView _view;
        public UserModel user;
        public CarModel car;
        private ButtonTable buttonTable;
        private ParkingSpotModel[] parkingSpots;
        List<ButtonParkingSpotAssociation> buttonParkings;


        public ParkingForm(UserModel user, CarModel car, DataMaker dataMaker, DataReader dataReader)
        {
            InitializeComponent();
            ParkingOutline.Image = Image.FromFile(ImagePath);
            this.user = user;
            this.car = car;
            buttonTable = new ButtonTable(this);
            _view = new ParkingFormView(dataMaker, dataReader);
            buttonParkings = _view.GetAllParkingSpots(buttonTable.Buttons);
            //todo - use those element to set parking spot
            //Add user data in parkingspot fomr
        }

        
    }
}
