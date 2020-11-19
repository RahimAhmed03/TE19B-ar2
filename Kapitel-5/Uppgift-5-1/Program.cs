using System;

namespace Uppgift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa ett program som innehåller en array som ska innehålla namnen på tre svenska städer. Skriv in två av namnen i programmets kod men låt användaren få skriva in namnet på den tredje staden. Skriv avslutningsvis ut alla stadsnamnen på samma rad.
            */

            // Skapa en array som ska innehålla namnen på tre svenska städer
            string[] städer = { "Stockholm", "Malmö", "Göteborg" };

            // Skriv in två av namnen i programmets kod
            städer[0] = "Stockholm"; // index = 0
            städer[1] = "Malmö";     // index = 1


            // Låt användaren få skriva in namnet på den tredje staden
            Console.WriteLine("Skriv namnet för den tredje staden");
            städer[2] = Console.ReadLine();


            // Skriv avslutningsvis ut alla stadsnamnen på samma rad
            Console.WriteLine($"{städer[0]} + {städer[1]} + {städer[2]}");

        }
    }
}
