using System;

namespace Tilemap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en labyrint
            int[,] labyrint = {     //new int[5, 6]
                {1, 1, 1, 1, 1, 0,},   // y = 0
                {0, 0, 0, 0, 0, 0,},   // y = 1
                {1, 0, 1, 0, 1, 0,},   // y = 2
                {1, 0, 1, 0, 0, 0,},   // y = 3
                {1, 0, 1, 1, 1, 1,}    // y = 4
            };

            // För att skriva ut UTF-tecken
            Console.OutputEncoding = System.Text.Encoding.Default;

            // Loopa igenom raderna
            for (int y = 0; y < 5; y++)
            {
                // Loopa igenom cellerna 0-4
                for (int x = 0; x < 6; x++)
                {
                    if (labyrint[y, x] == 1)
                    {
                        Console.Write('\u2B1C');    // Vit fyrkant
                    } else
                    {
                        Console.Write('\u2B1B');    // Svart fyrkant
                    }
                  
                   // Console.Write(labyrint[y, x]);      // på samma rad
                }

                // En ny rad
                Console.WriteLine();
            }



        }
    }
}
