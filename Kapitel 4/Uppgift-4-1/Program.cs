using System;

namespace Uppgift_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ställa en fråga med svar
            Console.WriteLine("Vilket är världens folkrikaste land?");
            string svar = Console.ReadLine();
            while (svar != "kina")
            {
                Console.WriteLine("Det var fel, Försök igen!");
                svar = Console.ReadLine();

            }

            Console.WriteLine("Du Fick Rätt!");
        }
    }
}
