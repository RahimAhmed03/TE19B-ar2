/* 
Skapa ett program där användaren får skriva in en mening (utan punkt) som består av två ord. Skriv ut orden till användaren i omvänd ordning.
 */

using System;

namespace Uppgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {

            // Läs in texten
            Console.Write("ange en mening med 2 ord: " );
            string mening = Console.ReadLine();

            // Dela upp texten
            int mellanslag = mening.IndexOf(" ");
            string ordFöre = mening.Substring(0, mellanslag);
            string ordEfter = mening.Substring(mellanslag + 1);

            // Skriv ut i omvänd ordning
            Console.WriteLine(ordEfter + " " + ordFöre);

            
        }
    }
}
