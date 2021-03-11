using System;

namespace Uppgift_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera texterna
            string text = Längst("Hej", "Hejsan");
            Console.WriteLine(text);
        }

        // Metod för att returnera text som är längst
        static string Längst(string text1, string text2)
        {
            // om text1 är kortare än text2 skicka tillbaka text2
            if (text1.Length < text2.Length)
            {
                return text2;
            }
            // annars skicka ut text1
            else
            {
                return text1;
            }
        }
    }
}
