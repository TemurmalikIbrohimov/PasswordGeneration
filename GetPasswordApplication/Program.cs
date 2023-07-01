using System;
using System.Text;

namespace GetPasswordApplication
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter password length: ");
            int passwordLength = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine(GetPassword(passwordLength));
            Main(args);
        }

        static string GetPassword(int n)
        {
            if (n < 8)
            {
                return "Password length cannot be less than 8";
            }
            
            const string upperLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            const string lowerLetters = "qwertyuiopasdfghjklzxcvbnm";
            const string character = "@#$&_";
            const string numbers = "1234567890";

            var random = new Random();
            var password = new StringBuilder();
            password.Append(upperLetters[random.Next(1, 26) - 1]);
            password.Append(character[random.Next(1, 5) - 1]);

            for (int i = 0; i < 2 * (n - 2) / 3; i++)
            {
                password.Append(lowerLetters[random.Next(1, 26) - 1]);
            }
            
            for (int i = 0; i < n - (2 * (n - 2) / 3); i++)
            {
                password.Append(numbers[random.Next(1, 10) - 1]);
            }

            return password.ToString();
        }
        
    }
}