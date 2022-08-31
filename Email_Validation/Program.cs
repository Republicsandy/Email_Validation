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
            Console.WriteLine("press 2 for second check email validation !");
            Console.WriteLine("press 3 for third check email validation !");
            Console.WriteLine("press 4 for fourth check email validation !");

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
                case 2:
                    Email_Validation1 validation1 = new Email_Validation1();
                    Console.WriteLine("Enter you email");
                    string email1 = Console.ReadLine();
                    bool valid1 = validation1.validateEmail1(email1);
                    Console.WriteLine(valid1);
                    break;
                case 3:
                    Email_Validation2 validation2 = new Email_Validation2();
                    Console.WriteLine("Enter you email");
                    string email2 = Console.ReadLine();
                    bool valid2 = validation2.validateEmail2(email2);
                    Console.WriteLine(valid2);
                    break;
                case 4:
                    Email_Validation3 validation3 = new Email_Validation3();
                    Console.WriteLine("Enter you email");
                    string email3 = Console.ReadLine();
                    bool valid3 = validation3.validateEmail3(email3);
                    Console.WriteLine(valid3);
                    break;

                default:
                    Console.WriteLine("invalid number");
                    return;
            }
        }
    }
}
