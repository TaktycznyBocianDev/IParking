using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IParkingClient
{
    public class LoginScreenView
    {

        private readonly DataMaker _dataMaker;
        private readonly DataReader _dataReader;

        public LoginScreenView(DataMaker dataMaker, DataReader dataReader)
        {
            _dataMaker = dataMaker;
            _dataReader = dataReader;
        }

        public UserModel GetUserByEmail(string email)
        {
            if (!StringChecker.IsEmailCorrect(email))
            {
                CustomMessageBox("Zły email", "Podaj prawidłowy email.");
                return null;
            }

            UserModel user = _dataReader.GetUser(email);
            if (user == null)
            {
                CustomMessageBox("", "Podany użytkownik nie istnieje!");
                return null;
            }

            return user;
        }

        public bool IsPasswordCorrect(UserModel user, string password)
        {
            if (user == null || string.IsNullOrEmpty(password))
            {
                CustomMessageBox("Źle podane hasło", "Wpisz hasło ponownie");
                return false;
            }

            if (!(user.Password == password))
            {
                CustomMessageBox("Błędne hasło", "Wpisz poprawne hasło lub skontaktuj się z adminem celem odzyskania hasła");
                return false;
            }

            return user.Password == password;

        }

        public CarModel GetCar(string email)
        {
            if (!StringChecker.IsEmailCorrect(email))
            {
                CustomMessageBox("Brak samnochodu dla podanego email", "Brak samnochodu dla podanego email");
                return null;
            }

            CarModel car = _dataReader.GetCar(email);
            if (car == null)
            {
                CustomMessageBox("Brak samnochodu dla podanego email", "Brak samnochodu dla podanego email");
                return null;
            }

            return car;
        }

        //Should be in separate class
        public void CustomMessageBox(string problemName, string problemDescription)
        {
            MessageBox.Show(problemDescription, problemName, MessageBoxButtons.OK);
        }
    }
}
