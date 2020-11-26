using System;

namespace Uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren skriva in städer
            Console.WriteLine("Ange fem städer");
            string[] städer = new string[5];

            // Loopa frågan 5 gånger så att det finns 5 städer  
            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine($"Skriv in stad {i + 1}");
                städer[i] = Console.ReadLine();
            }

            // Skriv ut de städerna
            Console.WriteLine("Här är de städer du skrev in");

            // Skriv ut arrayen med en foreach loop
            foreach (string stad in städer)
            {
                Console.WriteLine(stad);
            }
        }
    }
}
