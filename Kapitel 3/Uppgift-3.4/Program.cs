using System;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läs in poäng
            Console.WriteLine("Hur många poäng fick du under NP i matte? ");
            int poäng = int.Parse(Console.ReadLine());

            // Skriv ut betyg
            if (poäng >= 55 )
            {
                Console.WriteLine("Du fick betyget A");
            }
            else if (poäng >= 46)
            {
                Console.WriteLine("Du fick betyget B");
            }
            else if (poäng >= 35)
            {
                Console.WriteLine("Du fick betyget C");
            }
            else if (poäng >= 27)
            {
                Console.WriteLine("Du fick betyget D");
            }
            else if (poäng >= 18)
            {
                Console.WriteLine("Du fick betyget E");
            }
            else
            {
                Console.WriteLine("Du fick betyget F");
            }
        }
    }
}
