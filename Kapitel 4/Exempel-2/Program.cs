﻿using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler
            string val = "";

            // Presentera en meny som visas tills användaren säger stopp
            while (val != "3")
            {
                Console.WriteLine("Välj något av följande val:");
                Console.WriteLine("1. addera två tal ");
                Console.WriteLine("2. multiplicera två tal ");
                Console.WriteLine("3. avsluta ");

                // Läs in användarens val
                val = Console.ReadLine();

                // Om val = 1
                if (val == "1")
                {
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1} + {tal2} = " + (tal1 + tal2));
                }

                // Om val = 2
                if (val == "2")
                {
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1} * {tal2} = " + (tal1 * tal2));
                }

                // Om val = 3
                if (val == "3")
                {
                    Console.WriteLine("Tack för idag");
                }

                // Annars?
                switch (val)
                {

                    case "1":
                        Console.WriteLine("Välj något av följande val:");
                        Console.WriteLine("1. addera två tal ");
                        Console.WriteLine("2. multiplicera två tal ");
                        Console.WriteLine("3. avsluta ");
                    break;


                    case "2":
                        Console.WriteLine("Skriv in två tal på var sin rad");
                        double tal1 = double.Parse(Console.ReadLine());
                        double tal2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{tal1} * {tal2} = " + (tal1 * tal2));
                    break;


                    case "3":

                    break;

                    default:

                    break;

                }


            }
        }
    }
}
