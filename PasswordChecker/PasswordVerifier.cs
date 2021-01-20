using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PasswordChecker
{
    public class PasswordVerifier
    {
        public static bool VerifyPassword(string password)
        {
            try
            {
                bool validLength = VerifyLength(password);
                bool isNotNull = VerifyIsNotNull(password);
                bool containsUppercase = VerifyContainsUppercaseLetter(password);
                bool containsLowercase = VerifyContainsLowercaseLetter(password);
                bool containsNumber = VerifyContainsNumber(password);

                if (validLength && isNotNull && containsUppercase && containsLowercase && containsNumber)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        private static bool VerifyLength(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }
            else
            {
                throw new Exception("Password must contain 8 or more characters");
            }
        }

        private static bool VerifyIsNotNull(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Password cannot be empty");
            }
            else
            {
                return true;
            }
        }

        private static bool VerifyContainsUppercaseLetter(string password)
        {
            if (password.Any(char.IsLetter))
            {
                return true;
            }
            else
            {
                throw new Exception("Password must contain at least one uppercase letter");
            }
        }

        private static bool VerifyContainsLowercaseLetter(string password)
        {
            if (password.Any(char.IsLower))
            {
                return true;
            }
            else
            {
                throw new Exception("Password must contain at least one lowercase letter"); 
            }
        }

        private static bool VerifyContainsNumber(string password)
        {
            if (password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                throw new Exception("Password must contain at least one number"); 
            }
        }
    }
}
