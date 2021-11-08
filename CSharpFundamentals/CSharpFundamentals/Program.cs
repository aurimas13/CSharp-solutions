// Created by Aurimas A. Nausedas on 08/08/21.
// Updated by Aurimas A. Nausedas on 11/08/21.

using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce(); // My name is John Smith

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result); // 3

            var numbers = new int[3]; // var in this case is int[]
            numbers[0] = 1;

            Console.WriteLine(numbers[0]); // 1
            Console.WriteLine(numbers[1]); // 0
            Console.WriteLine(numbers[2]); // 0

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]); // True
            Console.WriteLine(flags[1]); // False
            Console.WriteLine(flags[2]); // False

            var names = new string[3] { "Jack", "John", "Paul" };
            Console.WriteLine(names[0]); // Jack
            Console.WriteLine(names[1]); // John
            Console.WriteLine(names[2]); // Paul

            var firstName = "Aurimas";
            var lastName = "Nausedas";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var namesTwo = new string[3] { "Joe", "Al", "Tim" };
            var formattedNames = string.Join(", ", namesTwo);
            Console.WriteLine(formattedNames); // Joe, Al, Tim

            var text = @"Hi John
            Look into the following paths
            c:\folder1
            c:\folder2";
            Console.WriteLine(text); // Hi John
                                                // Look into the following paths
                                                // c:\folder1
                                                // c:\folder2

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // 3

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); // Express

            Console.WriteLine(method.ToString()); // Express | convert to string

            Console.WriteLine(method); // Express | convert to string

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod); // Express

            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); // a: 10, b: 1

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0])); // array1: 0, array2: 0

            int number = 1;
            Increment(number);
            Console.WriteLine(number); // 1 | value type

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); // 30 | reference type
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
