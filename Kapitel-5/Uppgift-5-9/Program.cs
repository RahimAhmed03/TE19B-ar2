using System;

namespace Uppgift_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren om tal for att addera
            Console.WriteLine("Skriv in tal sedan + och ett till tal");

            // Läs in talen
            string beräkning = Console.ReadLine();

            // Splita talen från + 
            string[] termerOrd = beräkning.Split('+');

            // Kalkylera summan av talet
            int summa = 0;

            foreach (string termOrd in termerOrd)
            {
                int term = int.Parse(termOrd);
                summa += term;
            }
            // Skriv ut summan
            Console.WriteLine($"Summan är {summa}");
        }
    }
}
