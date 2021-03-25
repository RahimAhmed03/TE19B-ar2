using System;

namespace Uppgift_6_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int addition = Addera (4, 3, 7);
            Console.WriteLine(addition);
        }

        /// <summary>
        /// De här adderar alla tal och ger ut summan
        /// </summary>
        /// <param name="tal1"></param>
        /// <param name="tal2"></param>
        /// <param name="tal3"></param>
        /// <returns></returns>        
        static int Addera (int tal1, int tal2, int tal3)
        {
            int svar = tal1 + tal2 + tal3 ;
            return svar;
        }
    }
}
