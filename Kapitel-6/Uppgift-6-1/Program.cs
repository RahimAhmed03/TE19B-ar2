using System;

namespace Uppgift_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Det här är ett program som skriver tal i kvadrat");

            tal(2);
            tal(6);
            tal(8);
        }

        static void tal (int tal)
        {
            Console.WriteLine($"Talet {tal} i kvadrat blir {tal*tal}");
        }
    }
}
