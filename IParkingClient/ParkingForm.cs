using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParkingClient
{
    public partial class ParkingForm : Form
    {

        string ImagePath = ".\\ParkingXD.png";
        public UserModel user;
        public CarModel car;

        public ParkingForm(UserModel user, CarModel car)
        {
            InitializeComponent();
            ParkingOutline.Image = Image.FromFile(ImagePath);
            this.user = user;
            this.car = car;
            CustomMessageBox(user.Email, car.Model);
        }

        public void CustomMessageBox(string problemName, string problemDescription)
        {
            MessageBox.Show(problemDescription, problemName, MessageBoxButtons.OK);
        }
    }
}
