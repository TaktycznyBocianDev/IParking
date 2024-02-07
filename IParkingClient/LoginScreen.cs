using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace IParkingClient
{
    public partial class LoginScreen : Form
    {

        LoginScreenView _view;
        DataMaker _dataMaker;
        DataReader _reader;

        public LoginScreen()
        {
            InitializeComponent();
            SQLiteConnection connection = new SQLiteConnection(ConnectionManager.LoadConnectionString());
            DataMaker _dataMaker = new DataMaker(connection);
            DataReader _reader = new DataReader(connection);
            _view = new LoginScreenView(_dataMaker, _reader);

            PassTxtBox.UseSystemPasswordChar = true;
            ShowPassChck.Checked = false;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            CreateNewAccountForm createNewAccountForm = new CreateNewAccountForm();
            createNewAccountForm.ShowDialog();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            UserModel userModel = _view.GetUserByEmail(LoginTxtBox.Text);

            if (_view.IsPasswordCorrect(userModel, PassTxtBox.Text))
            {
                CarModel car = _view.GetCar(LoginTxtBox.Text);

                if (car != null)
                {
                    ParkingForm parkingForm = new ParkingForm(userModel, car, _dataMaker, _reader);
                    parkingForm.ShowDialog();

                }

            }
        }

        private void ShowPassChck_CheckedChanged(object sender, EventArgs e)
        {
            PassTxtBox.UseSystemPasswordChar = !ShowPassChck.Checked;
        }
    }
}
