using System;

namespace Projekt_Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "";
            Console.WriteLine("Välkommen till Rahims frågesport. Skriv in ditt namn");

            namn = Console.ReadLine();

            Console.WriteLine("Första frågan! Vilket år var det då USA landade i Månen? ");
            Console.WriteLine("1. 1970");
            Console.WriteLine("2. 1969");
            Console.WriteLine("3. 1960");

            int val1 = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (int.TryParse(input, out val1))
            {
                if (int.TryParse(input, out val1))
                {
                    Console.WriteLine("Tack för svaret med ett heltal!");                   
                }

                if (val1 != "2")
                {
                    Console.WriteLine("Tyvärr det var fel svar!");
                }
                else
                {
                    Console.WriteLine("Du fick rätt bra jobbat!");
                }

                Console.WriteLine("Andra frågan! När började Andra Världskriget?");
                Console.WriteLine("1. 1939");
                Console.WriteLine("2. 1945");
                Console.WriteLine("3. 1916");

            }




        }
    }
}
