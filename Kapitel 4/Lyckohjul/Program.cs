using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Läs in en gissning
            Console.Write("Gissa ett tal (1-10)? ");
            int gissning = int.Parse(Console.ReadLine());

            Random slumptalsgenerator = new Random();
            int slumptal2 = slumptalsgenerator.Next(1, 11);

            // vad slumptalet blir
            Console.WriteLine("slumptalet är " + slumptal2);

            // Kolla om gissningen är korrekt
            if (gissning == slumptal2)
            {
                Console.WriteLine("Rätt svar!");
            }
            else
            {
                Console.WriteLine("Fel svar!");
            }




        }
    }
}
