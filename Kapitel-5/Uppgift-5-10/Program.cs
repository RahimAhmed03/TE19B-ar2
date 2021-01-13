using System;

namespace Uppgift_5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en sträng som berättar hur många rutor det finns
            string[,] karta = new string[4, 2];

            // placera ut de du vill ha 
            karta[0, 0] = "Ö";
            karta[1, 0] = "Hav";
            karta[2, 0] = "Hav";
            karta[3, 0] = "Skog";
            karta[0, 1] = "Hav";
            karta[1, 1] = "Hav";
            karta[2, 1] = "Skog";
            karta[3, 1] = "Skog";

            // Fråga användaren vilka koordinater de vill
            Console.WriteLine("Skriv in en X-koordinat (0 - 3)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in en Y-koordinat (0 - 1)");
            int y = int.Parse(Console.ReadLine());

            // Skriv ut var de ligger
            Console.WriteLine($"På denna ruta finns {karta[x,y]}");
        }
    }
}
