using System;

namespace Lab01
{
    class Program
    {
        static void Main()
        {
            var a = new Ułamek(5, 4);
            var b = new Ułamek(1, 2);
            Console.WriteLine(-a);   // output: -5 / 4
            Console.WriteLine(a + b);  // output: 14 / 8
            Console.WriteLine(a - b);  // output: 6 / 8
            Console.WriteLine(a * b);  // output: 5 / 8
            Console.WriteLine(a / b);  // output: 10 / 4
        }
    }
}
