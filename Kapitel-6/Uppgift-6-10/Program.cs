using System;

namespace Uppgift_6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren att skriva in något
            Console.WriteLine("Programmet ska förstå ifall det du skrev är ett heltal eller inte. Var vänligen skriv något");
            TestInt();
        }

        /// <summary>
        /// Metod för att programmet ska förså ifall det är ett tal eller inte
        /// </summary>
        static void TestInt()
        {
            int tal = 0;
            if (int.TryParse(Console.ReadLine(), out tal))
            {
                // Ifall det är ett tal skriv "det är ett tal"
                Console.WriteLine("Det var ett tal. Tack för det");
            }
            else
            {
                // Ifall det inte är ett tal skriv "det är inte ett tal
                Console.WriteLine("Ditt svar var inte ett tal.");
            }
        }
    }
}
