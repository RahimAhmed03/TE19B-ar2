using System;

namespace HIttaBokstav
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ange en bokstav
            Console.Write("Ange en bokstav ");
            string bokstav = Console.ReadLine().ToUpper();

            // För säkerhetsskull omvandla till versaler
            //bokstav = bokstav.ToUpper();

            // Skapa en samling för alfabetet (string)
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ";

            // Hitta bokstavens plats i alfabetet
            int index = alfabetet.IndexOf(bokstav);

            // Vart finns bokstaven?
            Console.WriteLine($"{bokstav} finns på position {index}");

            // Skapa en samling för morsekod (array)
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };

            Console.WriteLine($"{morse[0]} {morse[20]}");

            // Skriv ut morsekoden för bokstav
            string morseBokstav = morse[index];
            Console.WriteLine($"{bokstav}'s morsekod är {morseBokstav}");

        }
    }
}
