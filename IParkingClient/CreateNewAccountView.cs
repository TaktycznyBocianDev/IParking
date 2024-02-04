using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParkingClient
{
    public class CreateNewAccountView
    {
        //Input should not be to long, in order to avoid jokes :)
        private const int MAXINPUTLENGHT = 29;

        private readonly DataMaker _dataMaker;
        private readonly DataReader _dataReader;

        public CreateNewAccountView(DataMaker dataMaker, DataReader dataReader)
        {
            _dataMaker = dataMaker;
            _dataReader = dataReader;   
        }

        public bool NameAndSurnameValidation(string input)
        {
            if (!StringChecker.IsNameCorrect(input) || input.Length > MAXINPUTLENGHT)
            {
                CustomMessageBox("Nieprawidłowe dane",
                    "Akceptowane są jedynie duże i małe litery, oraz znak -. " +
                    "Tekst nie może być dłuższy niż 30 znaków.");
                return false;
            }
            return true;
        }

        public bool EmailValidation(string email)
        {
            if (!StringChecker.IsEmailCorrect(email) || email.Length > MAXINPUTLENGHT)
            {
                CustomMessageBox("Nieprawidłowe dane",
                    "Wprowadź prawidłowy email.");
                return false;
            }
            return true;
        }

        public bool GivenEmailExists(string email)
        {
            if (_dataReader.GetUser(email) != null)
            {
                CustomMessageBox("Podany użytkownik istnieje!",
                    "Skontaktuj się z administratorem celem odzyskania konta.");
                return false;
            }
            return true;
        }

        public bool PasswordValidation(string password)
        {
            if (!StringChecker.IsPasswordSTRONK(password))
            {
                CustomMessageBox(" Silne hasło wymagane! ",
                    "Wprowadź silne hasło: Posiada więcej niż 8 znaków, jedną dużą i jedną małą literę, posiada jedną cyfrę " +
                    "i przynajmniej jeden znak specjalny, jak np. !@#$%^");
                return false;
            }
            return true;
        }

        public bool RepeatPasswordValid(string password, string secondPassword) 
        {

            if (!StringChecker.DoPasswordsMatch(password, secondPassword))
            {
                CustomMessageBox("Podane hasła są różne!", "Wprowadź takie same hasła!");
                return false;
            }
            return true;

        }

        public bool CarPlateNumberValidation(string plateNumber)
        {
            if (!StringChecker.IsCarPlateCorrect(plateNumber))
            {
                CustomMessageBox("Błędna rejestracja",
                    "Wprowadź prawidłową rejestrację pojazdu!");
                return false;
            }
            return true;
        }

        public bool FinalUserCarCreation(UserModel user, CarModel car)
        {
            if (user.Email == null || user.Email == "")
            {
                CustomMessageBox("Błędny lub istniejący emal!",
                    "Wprowadź poprawny email lub skontaktuj się z administratorem celem odzyskania konta.");
            }
            if (!user.AreAtributesCorrect() || !car.AreAtributesCorrect())
            {
                CustomMessageBox("Puste dane!",
                    "Uzupełnij wszystkie pola w sposób prawidłowy i ponów próbę.");
                return false;
            }
            else
            {
                SendUserObjectToDatabase(user);
                SendCarObjectToDatabase(car);
                CustomMessageBox("Utworzono użytkownika!",
                    "Możesz się teraz zalogować!");
                return true;
            }
        }

        public void SendUserObjectToDatabase(UserModel user)
        {
            _dataMaker.Create(user);
        }

        public void SendCarObjectToDatabase(CarModel car)
        {
            if (_dataReader.GetUser(car.UserEmail) != null)
            {
               _dataMaker.Create(car);
            }
            else
            {
                CustomMessageBox("Błąd połączenia",
                    "Próba utworzenia samochodu bez przypisanego użytkownika. Skontaktuj się z prezydentem.");
            }
        }

        public void CustomMessageBox(string problemName, string problemDescription)
        {
            MessageBox.Show(problemDescription, problemName, MessageBoxButtons.OK);
        }

    }

}
