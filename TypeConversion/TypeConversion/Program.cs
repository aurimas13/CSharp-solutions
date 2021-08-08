using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            int t = 1;
            byte a = (byte)t;
            Console.WriteLine(a);
            int k = 1000;
            byte l = (byte)k;
            Console.WriteLine(l);
            var number = "1234";
            int x = Convert.ToInt32(number);
            try
            {
                var numberTwo = "2345";
                Console.WriteLine(x);
                byte w = Convert.ToByte(numberTwo);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to byte.");
            }
            try
            {
                string str = "true";
                bool d = Convert.ToBoolean(str);
                Console.WriteLine(d);
            }
            catch
            {
                Console.WriteLine("The number could not b e converted to boolean");
            }
        }
    }
}
