using System;

namespace Uppgift_6_13
{
    class Program
    {
        static Random slump = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine($"Det blev år {SlumpÅrtal()} och månaden blev {SlumpMånad()}");
        }
        /// <summary>
        /// Slumpar ett heltal mellan 1900 - 1999
        /// </summary>
        /// <returns>Slump Heltal mellan 1900 - 1999</returns>
        static int SlumpÅrtal()
        {
            return slump.Next(1900, 2000);
        }

        /// <summary>
        /// Slumpar ett heltal mellan 
        /// </summary>
        /// <returns></returns>
        static int SlumpMånad()
        {
            return slump.Next(1, 13);
        }
    }
}
