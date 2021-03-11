using System;

namespace Uppgift_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // användarens svar
            string svar = "";
            while (svar != "4")
            {
                // Visa huvudmenyn och svaret sparas
                visaMeny();
                svar = Console.ReadLine();
                Console.WriteLine();

                // Switch för alla möjliga alternativ. Addera, Subtrahera, Multiplicera
                switch (svar)
                {
                    case "1":
                        Addera();
                        break;
                    case "2":
                        Subtrahera();
                        break;
                    case "3":
                        Multiplicera();
                        break;
                    case "4":
                        Console.WriteLine("Tack och hejdå");
                        break;
                    default:
                        Console.WriteLine("Du valde ett ogiltigt alternativ");
                        break;
                }
                Console.WriteLine();
            }
        }

        // Skriv ut en meny med alternativen
        static void visaMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Subtrahera två tal");
            Console.WriteLine("3. Multiplicera två tal");
            Console.WriteLine("4. Avsluta programmet");
        }

        // Addition meny
        static void Addera()
        {
            Console.WriteLine("Skriv in två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
        }

        // Subtration meny
        static void Subtrahera()
        {
            Console.WriteLine("Skriv in två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1} - {tal2} = {tal1 - tal2}");
        }

        // Multiplikation meny
        static void Multiplicera()
        {
            Console.WriteLine("Skriv in två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1} * {tal2} = {tal1 * tal2}");
        }
        }
    }

