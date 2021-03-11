using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string svar = "";
            while (svar != "3")
            {
                visaMeny();
                svar = Console.ReadLine();

                switch (svar)
                {
                    case "1":
                    SkrivUtVertikalt(Console.ReadLine());
                    break;

                    case "2":
                    SkrivUtOmvänt(Console.ReadLine());
                    break;

                    case "3":
                    //
                    break;
                    default:
                }
            }
        }

        static void visaMeny() {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Skriv ut texten vertikalt");
            Console.WriteLine("2. Skriv ut texten omvänt");
            Console.WriteLine("3. Avsluta");
        }

        static void SkrivUtVertikalt(string text1) {
            for (int i = 0; i < text1.Length; i++)
            {
                Console.WriteLine(text1[i]);
            }

        }

        static void SkrivUtOmvänt(string meddelande) {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
