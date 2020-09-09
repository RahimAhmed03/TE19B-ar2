using System;

namespace Konsolen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ändra bakgrundsfärg på terminalen
            Console.BackgroundColor = ConsoleColor.Blue;

            //Ändra textfärg i terminalen
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Hello World!");
        }
    }
}
