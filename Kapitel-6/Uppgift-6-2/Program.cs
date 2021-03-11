using System;

namespace Uppgift_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges("Hej jag heter Rahim");
            SkrivBaklänges("Jag är 17 år");
            SkrivBaklänges("Jag bor i Stockholm");
        }

        static void SkrivBaklänges (string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }

        }
    }
}
