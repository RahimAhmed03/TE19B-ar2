using System;

namespace Uppgift_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fråga användaren om att skriva in ett tal
            Console.WriteLine("Skriv in ett tal");
            string text = Console.ReadLine();

            // Deklarera bool
            bool finns3eller7 = false;

            // Loopa igenom siffrorna
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '3' || text[i] == '7')
                {
                finns3eller7 = true;
            }
        }

            // Om 3 eller 7 finns
            if (finns3eller7)
            {
                Console.WriteLine("Talet innehåller minst en 3 eller/och en 7");
            }
            // om det inte finns
            else
            {
                Console.WriteLine("Det finns ingen 3 eller 7 i talet");
            }

        }
    }
}
