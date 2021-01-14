using System;
using System.IO;

namespace Filhantering2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Filnamnet
            string filnamn = "./animals.txt";

            // Läs in alla rader
            string[] rader = File.ReadAllLines(filnamn);

            // Läs in sökterm
            Console.Write("Ange sökterm (första bokstaven): ");
            string sökterm = Console.ReadLine();

            // Loopa igenom arrayen
            // Dvs gå igenom rad-för-rad
            int räknare = 1;
            foreach (var rad in rader)
            {
                // Kolla om första bokstaven = sökterm
                if (rad.Substring(0, 1) == sökterm)
                {
                    Console.WriteLine(räknare + " " + rad);
                    räknare++;
                }

                
            }

            // Antal hittade rader
            Console.WriteLine($"Enligt mina beräkningar finns det {räknare - 1} djur");
        }
    }
}
