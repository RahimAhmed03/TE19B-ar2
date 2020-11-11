using System;

namespace Uppgift_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren om att skriva in ett tal
            Console.WriteLine("Skriv in ett tal");
            string text = Console.ReadLine();

            // Kalkylera summan av talet 
            int summa = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string teckenString = text[i].ToString();
                int tal = int.Parse(teckenString);
                summa += tal;
            }

            // Skriv ut summan
            Console.WriteLine($"Enligt mina beräkningar är summan av talet {text} är {summa}");
        }
    }
}
