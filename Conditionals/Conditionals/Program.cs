using System;
using static Conditionals.Season;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning"); // It's morning
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.05f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price); // 19.95

            var season = Season.Autumn; // It's autumn and a beautiful season.

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season."); // It's autumn and a beautiful season.
                    break;

                case Season.Summer:
                    Console.WriteLine("Beach time.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }

            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); // 2, 4, 6, 8, 10
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); // 10, 8, 6, 4, 2
                }
            }

            var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            foreach (var character in name)
            {
                Console.WriteLine(character); // J o h n S m i t h
            }

            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number); // 1, 2, 3, 4
            }

            var n = 0;
            while (n <= 10)
            {
                if (n % 2 == 0)
                    Console.WriteLine(n); // 0, 2, 4, 6, 8, 10

                n++;
            }

            while (true)
            {
                Console.Write("Type your name: "); // Type your name
                var input = Console.ReadLine(); // Aurimas (or whichever you choose)

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;

            }

            var random = new Random();
            for (var x = 0; x < 10; x++)
            Console.Write((char)('a' + random.Next(0, 26))); // cast as character
            Console.WriteLine();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var x = 0; x < passwordLength; x++)
                buffer[x] = (char)('a' + random.Next(0, 26)); // cast as character

            var password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
