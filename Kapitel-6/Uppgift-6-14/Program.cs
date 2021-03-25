using System;

namespace Uppgift_6_14
{
    class Program
    {
        static Random slump = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine($"Det blev rad {SlumpaRad()} och kolumnen blev {SlumpaKolumn()} och då är positionen {SlumpaPositionen()}");
        }

        /// <summary>
        /// Slumpar ett tal mellan 1 - 8
        /// </summary>
        /// <returns></returns>
        static int SlumpaRad()
        {
            return slump.Next(1, 9);
        }

        static char SlumpaKolumn()
        {
            
        }

    }
}
