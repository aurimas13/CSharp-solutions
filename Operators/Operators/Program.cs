using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(a / b); // 0
            Console.WriteLine((float)a / (float)b); // 0.5
            Console.WriteLine(a + b * c); // 7
            Console.WriteLine(a > b); // false
            Console.WriteLine(a == b); // false
            Console.WriteLine(a != b); // true
            Console.WriteLine(!(a != b)); // false
            Console.WriteLine(c > b && c > a); // true
            Console.WriteLine(c > b && c == a); // false
            Console.WriteLine(c > b || c > a); // true
            Console.WriteLine(!(c > b || c > a)); // false
        }
    }
}
