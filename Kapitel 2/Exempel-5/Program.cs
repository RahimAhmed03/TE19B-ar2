using System;

namespace Exempel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = "Rahim";
            Console.WriteLine("Mitt namn är " + namn);

            // med hjälp av variabelsustitution'
            Console.WriteLine($"Mitt namn är {namn}. ");

            string svar = $"Mitt förnamn är {namn}.";
            Console.WriteLine(svar);

            Console.WriteLine();
        }
    }
}
