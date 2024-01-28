using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IParkingClient
{
    public static class StringChecker
    {
        public static bool IsNameCorrect(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                return true;
            }

            Regex regex = new Regex("^[a-zA-Z-]+$");
            return regex.IsMatch(input);
        }

        public static bool IsEmailCorrect(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsPasswordSTRONK(string password)
        {
            if (password.Length < 8) return false;

            if (!password.Any(char.IsUpper)) return false;

            if (!password.Any(char.IsLower)) return false;

            if (!password.Any(char.IsDigit)) return false;

            if (!password.Any(IsSpecialCharacter)) return false;

            return true;

        }

        public static bool DoPasswordsMatch(string password, string secPassword)
        {
            return password == secPassword;
        }

        private static bool IsSpecialCharacter(char c)
        {
           
            string specialCharacters = "!@#$%^&*()-_=+[]{}|;:'\",.<>/?";

            return specialCharacters.Contains(c);
        }



        public static bool IsCarPlateCorrect(string plateNumber)
        {
            string regex = @"^[A-Z0-9]{2,3}\s?[A-Z0-9]{4,5}$";

            return Regex.IsMatch(plateNumber, regex, RegexOptions.IgnoreCase);
        }
   
    }
}
