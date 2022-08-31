using System;
using System.Text.RegularExpressions;

namespace Email_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Email Validation!");
            Console.WriteLine("press 1 for email validation !");
           
            var getValueByUser = Convert.ToInt32(Console.ReadLine());
            switch (getValueByUser)
            {
                case 1:
                    Email_Validation validation = new Email_Validation();
                    Console.WriteLine("Enter you email");
                    string email = Console.ReadLine();
                    bool valid = validation.validateEmail(email);
                    Console.WriteLine(valid);
                    break;

                default:
                    Console.WriteLine("invalid number");
                    return;
            }
        }
    }
}
