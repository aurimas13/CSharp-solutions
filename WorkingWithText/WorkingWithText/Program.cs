using System;
using System.Collections.Generic;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Aurimas Nausedas ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // Trim: 'Aurimas Nausedas'
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper()); // ToUpper: 'AURIMAS NAUSEDAS'
            // Strings are immutable

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName); // First Name: Aurimas
            Console.WriteLine("Last Name: " + lastName); // Last Name: Nausedas 

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]); // First Name: Aurimas
            Console.WriteLine("First Name: " + names[1]); // First Name: Nausedas

            Console.WriteLine(fullName.Replace("Aurimas", "Auris")); // Auris Nausedas 

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid"); // Invalid

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age); // 25

            float price = 29.95f;
            Console.WriteLine(price.ToString("C")); // $29.95
            Console.WriteLine(price.ToString("C0")); // $30

            var sentence = "This is a sentence of something new and old.";
            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary, 25);
        }
    }
}
