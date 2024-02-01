using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IParkingClient
{

    public class UserTypes
    {
        public static string admin = "Admin";
        public static string user = "User";
    }


    public class UserModel
    {
        public int UserId { get; private set; }
        public string UserName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string UserType { get; set; }



        public UserModel()
        {
            UserName = "Typowy User";
            Surname = "Lololololo";
            Email = "noEmail.nope";
            Password = "123456";
            UserType = UserTypes.user;
        }

        public UserModel(string userName, string surname, string email, string password, string userType)
        {
            UserName = userName;
            Surname = surname;
            Email = email;
            Password = password;
            UserType = userType;
        }

        public UserModel(int userId, string userName, string surname, string email, string password, string userType)
        {
            UserId = userId;
            UserName = userName;
            Surname = surname;
            Email = email;
            Password = password;
            UserType = userType;
        }

        public bool AreAtributesCorrect()
        {
            if (string.IsNullOrEmpty(UserName)) return false;
            if (string.IsNullOrEmpty(Surname)) return false;
            if (string.IsNullOrEmpty(Email)) return false;
            if (string.IsNullOrEmpty(Password)) return false;
            if (string.IsNullOrEmpty(UserType)) return false;
            return true;
        }

    }
}
