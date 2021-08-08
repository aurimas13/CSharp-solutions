using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2; // C# compiler by var detects byte
            var count = 10; // C# compiler by var detects int
            var totalPrice = 20.95f; // C# compiler by var detects float
            var character = 'A'; // C# compiler by var detects char
            var firstName = "Aurimas"; // C# compiler by var detects string
            var isWorking = false; // C# compiler by var detects bool

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            const float Pi = 3.14f;
        }
    }
}
