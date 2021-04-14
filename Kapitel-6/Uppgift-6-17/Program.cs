using System;

namespace Uppgift_6_17
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("abul kalam", 1, 6);
        }

        static void SkrivVertikalt(string meddelande, int antalTommaRader = 0, int stegÅtHöger = 0)
        {
            // Loopa igenom texten, tecken för tecken
            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int y = 0; y < antalTommaRader; y++)
                {
                    Console.WriteLine();
                }
                for (int x = 0; x < stegÅtHöger; x++)
                {
                    Console.Write();
                }
                Console.WriteLine(meddelande[i]);
            }

        }

    }
}
