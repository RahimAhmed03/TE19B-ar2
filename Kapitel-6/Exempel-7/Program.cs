using System;

namespace Exempel_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en text att kryptera:");
            string meddelande = Console.ReadLine();

            Console.WriteLine($"Krypterat med 1 steg:{CeasarKryptera(meddelande)}");
            Console.WriteLine($"Krypterat med 3 steg:{CeasarKryptera(meddelande, 3)}");
        }

        static string CeasarKryptera(string text, int nyckel = 1)
        {
            // Loopa igenom texten, tecken för tecken
            for (int i = 0; i < text.Length; i++)
            {
                // Plocka ut ett tecken
                char tecken = text[i];

                // Ta reda teckenkoden
                int teckenKod = (int)tecken;

                // Räkna ut nu krypterar tecken
                int teckenKodKrypterat = teckenKod + nyckel;

                char teckenKrypterat = (char)teckenKodKrypterat;
            }

            return..;
        }
    }
}
