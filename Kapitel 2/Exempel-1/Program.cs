using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera en variable för namnet
            string namn = "";
            string hobby = "";
            string meddelande = "";

            // Läs in namnet
            Console.Write("Vad heter du? ");
            namn = Console.ReadLine();

            // Läs in hobby
            Console.Write("Vad gillar du att göra? ");
            hobby = Console.ReadLine();

            // sätter samman ett meddelande
            meddelande = "Hej! " + namn + ", du gillar att " + hobby + ". ";


            // Skriver ut meddelandet
            Console.WriteLine(meddelande);
        }
    }
}
