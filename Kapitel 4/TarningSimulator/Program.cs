using System;

namespace TarningSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga hur många gånger tärningen skall du kasta?
            Console.WriteLine("Hur många gånger vill du kasta tärningen? ");
            int tärning = int.Parse(Console.ReadLine());

            // Fråga hur många sidor har tärningen?
            Console.WriteLine("Hur många sidor har tärningen? ");
            int sidor = int.Parse(Console.ReadLine());

            Random slumptalsgenerator = new Random();
            

            // Kasta tärningen ett antal gånger
            // För varje kast kan man ett slumptal med så många sidor
            for (int i = 0; i < tärning; i++)
            {
                int slumptal2 = slumptalsgenerator.Next(1, sidor + 1);
                Console.WriteLine(slumptal2);
            }
            // Skriv ut varje kast
        }
    }
}
