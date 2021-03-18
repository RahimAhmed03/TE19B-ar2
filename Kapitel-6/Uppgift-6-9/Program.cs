using System;

namespace Uppgift_6_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be om ett tal
            Console.WriteLine("Skriv ett tal");
            double tal = ReadDouble();
            Console.WriteLine($"Du skrev talet {tal} ");
        }

        // Metod för att föra fram decimaltal
        static double ReadDouble()
        {
            double tal;
            while (double.TryParse(Console.ReadLine(), out tal) == false)
            {
                // Ifall det inte är ett giltigt tal skriv felmeddelande
                Console.WriteLine("Du skrev inte ett tal, vg försök igen");   
            }
            // Returnera talet
            return tal;
        }
    }
}
