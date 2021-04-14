using System;

namespace Uppgift_6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("abul kalam", 1);
        }

        /// <summary>
        /// Skriver ut meddelandet vertikalt
        /// </summary>
        /// <param name="meddelande"> texten som skrivs ut</param>
        /// <param name="antalTommaRader"> Antalet tomma rader som finns mellan varje tecken</param>
        static void SkrivVertikalt(string meddelande, int antalTommaRader = 0)
        {
            // Loopa igenom texten, tecken för tecken
            for (int i = 0; i < meddelande.Length; i++)
            {
                Console.WriteLine(meddelande[i]);
                for (int x = 0; x < antalTommaRader; x++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
