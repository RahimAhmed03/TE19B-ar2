using System;
using System.IO;

namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            // presentera programmet
            Console.WriteLine("Program för att hitta länder matchade sökterm.");
            Console.WriteLine("Program listar land och landskod.");

            // Läser in alla rader i textfilen, om det finns
            if (File.Exists("countries.csv"))
            {
                // Läser in alla rader
                string[] rader = File.ReadAllLines("countries.csv");

                // Ber användaren om sökterm
                Console.Write("Ange sökterm (avsluta med return): ");
                string sökterm = Console.ReadLine();

                // Loopa igenom alla rader
                foreach (var rad in rader)
                {
                    // Söka i den röda fältet
                    //Console.WriteLine(rad);   // rad är en string
                    string[] delar = rad.Split(',');
                    
                }   
            } else
            {
                Console.WriteLine("Avbryter! Filen countries.cvs finns inte.");
            }
        }
    }
}
