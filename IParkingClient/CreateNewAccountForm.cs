using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IParkingClient
{
    public partial class CreateNewAccountForm : Form
    {

        CreateNewAccountView createNewAccountView;
        SQLiteConnection connection;

        DataMaker dataMaker;
        DataReader reader;

        public CreateNewAccountForm()
        {
            InitializeComponent();


            connection = new SQLiteConnection(ConnectionManager.LoadConnectionString());
            dataMaker = new DataMaker(connection);
            reader = new DataReader(connection);
            createNewAccountView = new CreateNewAccountView(dataMaker, reader);

            // Set up event handlers for text changed events
            EmailBox.TextChangedComplete += EmailBox_TextChangedComplete;
            PassBox.TextChangedComplete += PassBox_TextChangedComplete;
            SecPassBox.TextChangedComplete += SecPassBox_TextChangedComplete;
            PlateBox.TextChangedComplete += PlateBox_TextChangedComplete;

            // Set up password character and checkbox initial states
            PassBox.UseSystemPasswordChar = true;
            SecPassBox.UseSystemPasswordChar = true;
            ShowPass.Checked = false;
            ShowSecPass.Checked = false;

        }



        private void CreateNewAccountForm_Load(object sender, EventArgs e)
        {

        }

        // Validate UserName and Surname provided. Adjust their TextBoxes, if neccesary.

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

            if (!createNewAccountView.NameAndSurnameValidation(UserNameBox.Text))
            {
                UserNameBox.Text = UserNameBox.Text.Substring(0, UserNameBox.Text.Length - 1);
                SetCursorAtTheWordEnd(UserNameBox);

            }
        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {
            if (!createNewAccountView.NameAndSurnameValidation(SurnameBox.Text))
            {
                SurnameBox.Text = SurnameBox.Text.Substring(0, SurnameBox.Text.Length - 1);
                SetCursorAtTheWordEnd(SurnameBox);
            }
        }


        //Email, Password and Second password Validation, perform after user stops changing text.

        private void EmailBox_TextChangedComplete(object? sender, EventArgs e)
        {
            if (EmailBox.Text != null || EmailBox.Text == "")
            {                       
                createNewAccountView.EmailValidation(EmailBox.Text);
                if (!createNewAccountView.GivenEmailExists(EmailBox.Text))
                {
                    EmailBox.Text = "";
                }
            }

        }

        private void PassBox_TextChangedComplete(object? sender, EventArgs e)
        {
            if (PassBox.Text != null || PassBox.Text != "")
            {
                createNewAccountView.PasswordValidation(PassBox.Text);
            }
        }

        private void SecPassBox_TextChangedComplete(object? sender, EventArgs e)
        {
            if (SecPassBox.Text != null || SecPassBox.Text != "")
            {
                createNewAccountView.RepeatPasswordValid(PassBox.Text, SecPassBox.Text);
            }
        }

        private void PlateBox_TextChangedComplete(object? sender, EventArgs e)
        {
            if (PlateBox.Text != null || PlateBox.Text != "")
            {
                createNewAccountView.CarPlateNumberValidation(PlateBox.Text);
            }
        }

        private void BrandBox_TextChanged(object sender, EventArgs e)
        {
            if (!createNewAccountView.NameAndSurnameValidation(BrandBox.Text))
            {
                BrandBox.Text = BrandBox.Text.Substring(0, BrandBox.Text.Length - 1);
                SetCursorAtTheWordEnd(BrandBox);
            }
        }

        private void ModelBox_TextChanged(object sender, EventArgs e)
        {
            if (!createNewAccountView.NameAndSurnameValidation(ModelBox.Text))
            {
                ModelBox.Text = ModelBox.Text.Substring(0, ModelBox.Text.Length - 1);
                SetCursorAtTheWordEnd(ModelBox);
            }
        }

        private void CarColorBox_TextChanged(object sender, EventArgs e)
        {
            if (!createNewAccountView.NameAndSurnameValidation(CarColorBox.Text))
            {
                CarColorBox.Text = CarColorBox.Text.Substring(0, CarColorBox.Text.Length - 1);
                SetCursorAtTheWordEnd(CarColorBox);
            }
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = !ShowPass.Checked;
        }

        private void ShowSecPass_CheckedChanged(object sender, EventArgs e)
        {
            SecPassBox.UseSystemPasswordChar = !ShowSecPass.Checked;
        }

        private void SetCursorAtTheWordEnd(TextBox textBox)
        {
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            //email check for more protection
            if (!createNewAccountView.GivenEmailExists(EmailBox.Text))
            {
                createNewAccountView.CustomMessageBox("Błędny email!", "Podany użytkownik istnieje lub podano błędny email.");
                EmailBox.Text = "";
            }
            else
            {
                UserModel user = new UserModel(UserNameBox.Text, SurnameBox.Text, EmailBox.Text, PassBox.Text, UserTypes.user);
                CarModel car = new CarModel(PlateBox.Text, BrandBox.Text, ModelBox.Text, CarColorBox.Text, EmailBox.Text);


                if (createNewAccountView.FinalUserCarCreation(user, car)) this.Close();
            }
          
        }
    }
}