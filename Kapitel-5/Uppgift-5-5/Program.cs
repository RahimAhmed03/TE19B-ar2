﻿using System;

namespace Uppgift_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Skapa ett program där användaren ska få skriva in åldern på personerna i ett hyreshus. Programmet ska först fråga användaren om en ålder. Därefter ska programmet fråga om användaren vill skriva in en till ålder och förvänta sig svaret "j" eller "n". Användaren ska få fortsätta skriva in nya åldrar tills hen svarar "n". Skriv därefter ut alla åldrar som användaren skrev in.

            Programmet ska tillåta användaren att skriva in upp till 100 åldrar utan att krascha, om användaren har skrivit in 100 åldrar ska programmet skriva ut "Programmet har inte plats för fler åldrar" och därefter skriva ut alla åldrar som har sparats.
            */


            // Programmet tillåter användaren att skriva in upp till 100 åldrar
            int[] åldrar = new int[100]
            int antal = 0;
            string svar = "";


            // Upprepa inmatning = loop
            int antal = 0
            for (int i = 0; i < åldrar.Length; i++)
            {
                // Programmet ska först fråga om användaren om en ålder
                Console.Write("Ange en ålder: ");
                åldrar[i] = int.Parse(Console.ReadLine());
                antal++;

                // Därefter ska programmet fråga om användaren vill skriva in en till ålder och förvänta sig svaret "j" eller "n"
                Console.Write("Vill du mata in ett till årtal (j/n)? ");
                string svar = Console.ReadLine();

                // Om nej avlsuta loopen
                if (svar == "n")
                {
                    break;
                }

                // Om användaren har skrivit in 100 åldrar ska programmet skriva ut "Programmet har inte plats för fler åldrar"
                if (i == 99)
                {
                    Console.WriteLine("Prorammet har inte plats för fler åldrar");
                    break;
                }

            }

            // Programmet ska skriva ut alla åldrar som har sparats
            for (int i = 0; i < antal; i++)
            {
                Console.WriteLine(åldrar[i]);
            }


            // Programmet ska först fråga om användaren om en ålder
            // while (svar != "n" && antal < åldrar.Length)
            // {
            //     Console.WriteLine("Skriv in en ålder");
            //     åldrar[antal] = int.Parse(Console.ReadLine());
            //     antal++;

            //     if (antal == åldrar.Length)
            //     {
            //         // Om användaren har skrivit in 100 åldrar ska programmet skriva ut "Programmet har inte plats för fler åldrar"
            //         Console.WriteLine("Det finns inga platser kvar");
            //     }
            //     else
            //     {
            //         // Därefter ska programmet fråga om användaren vill skriva in en till ålder och förvänta sig svaret "j" eller "n"
            //         Console.WriteLine("Vill du skriva in fler åldrar");
            //         svar = Console.ReadLine();
            //     }
            // }





            // Programmet ska skriva ut alla åldrar som har sparats


        }
    }
}
