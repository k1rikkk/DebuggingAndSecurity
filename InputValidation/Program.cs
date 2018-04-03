using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    internal class Program
    {
        private static IValidator validator = new UrlValidator();

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter \"Change\" to change validator");
                Console.Write(validator.Info);
                string line = Console.ReadLine();
                if (line.ToLower() == "change")
                    ChangeValidator();
                else
                {
                    Console.WriteLine(validator.IsValid(line) ? "Valid" : "Invalid");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
        }

        private static void ChangeValidator()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to validate urls");
            Console.WriteLine("Press 2 to validate file path");
            Console.WriteLine("Press 3 to validate emails");
            char key = Console.ReadKey().KeyChar;
            if (key == '1')
                validator = new UrlValidator();
            else if (key == '2')
                validator = new FilePathValidator();
            else if (key == '3')
                validator = new EmailValidator();
        }
    }
}
