using System;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check your password!");

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool verified = PasswordVerifier.VerifyPassword(password);

            Console.WriteLine(verified);
        }
    }
}
