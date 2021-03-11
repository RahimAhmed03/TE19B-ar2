using System;

namespace Uppgift_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // int tal1 = 5;
            // int tal2 = 6;

            double Multiplikation = Multiplicera (7, 14);
            double Division = Dividera (14, 7);

            Console.WriteLine(Multiplikation);
            Console.WriteLine(Division);
        }

        // Metod för produkt av två tal
        // Returnerar ett tal
        static double Multiplicera (double tal1, double tal2)
        {
            // int tal3 = tal1 * tal2; Fel
            return tal1 * tal2;
        }

        // Metod för kvot av två tal
        // Returnerar ett tal
        static double Dividera (double tal1, double tal2)
        {
            // int tal3 = tal1/tal2; Fel
            return tal1 / tal2;
        }
    }
}
