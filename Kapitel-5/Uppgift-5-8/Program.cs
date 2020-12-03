using System;

namespace Uppgift_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skriv in en mening
            Console.WriteLine("Skriv in en mening");

            // Läs in meningen
            string mening = Console.ReadLine();

            // Dela texten i seperata ord
            string [] orden = mening.Split(' ');

            // Skriv ut varje ord i meningen på en egen rad
            foreach (string ord in orden)
            {
                Console.WriteLine(ord);
            }
        }
    }
}
