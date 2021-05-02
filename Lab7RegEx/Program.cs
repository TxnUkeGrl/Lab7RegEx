using System;
using System.Text.RegularExpressions;

namespace Lab7RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name?");
            string nameInput = Console.ReadLine();
            NameValidate(nameInput);

            Console.WriteLine("Email?");
            string emailInput = Console.ReadLine();
            EmailValidate(emailInput);

            Console.WriteLine("Phone Number?");
            string phoneInput = Console.ReadLine();
            PhoneNumberValidate(phoneInput);

            Console.WriteLine("Date?");
            string dateInput = Console.ReadLine();
            DateValidate(dateInput);
        }

        public static void NameValidate(string nameInput)
        {
            Regex nameValid = new Regex(@"^([A-Z]{1}[a-z]{1,29})$");

            if (nameValid.IsMatch(nameInput))
            {
                Console.WriteLine($"Thank you, {nameInput} is Valid");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameInput} is not a valid name");
            }
        }

        public static void EmailValidate(string emailInput)
        {
            Regex emailValid = new Regex(@"(\w{5,30}@\w{5,10}.\w\D{2,3})");

            if (emailValid.IsMatch(emailInput))
            {
                Console.WriteLine($"Thank you, {emailInput} is Valid");
            }
            else
            {
                Console.WriteLine($"Sorry, {emailInput} is not a valid email");
            }
        }

        public static void PhoneNumberValidate(string phoneInput)
        {
            Regex phoneValid = new Regex(@"([0-9]{3}-[0-9]{3}-[0-9]{4})");

            if (phoneValid.IsMatch(phoneInput))
            {
                Console.WriteLine($"Thank you, {phoneInput} is Valid");
            }
            else
            {
                Console.WriteLine($"Sorry, {phoneInput} is not a valid phone number");
            }
        }

        public static void DateValidate(string dateInput)
        {
            Regex dateValid = new Regex(@"[0-9]{2}/[0-9]{2}/[0-9]{4}");

            if (dateValid.IsMatch(dateInput))
            {
                Console.WriteLine($"Thank you, {dateInput} is Valid");
            }
            else
            {
                Console.WriteLine($"Sorry, {dateInput} is not a valid date");
            }
        }

        //public static string HTMLValidate()
        //{

        //}
    }
}
