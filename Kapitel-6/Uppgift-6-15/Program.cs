using System;

namespace Uppgift_6_15
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivBaklänges("European Space Agency");

            SkrivBaklänges(1975);

            SkrivBaklänges(6.7);
        }

        /// <summary>
        /// Skriver meddelandet baklänges i en rad
        /// </summary>
        /// <param name="meddelande"></param>
        static void SkrivBaklänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.Write(meddelande[i]);
            }
        }

        /// <summary>
        /// Skriver talet baklänges i en rad
        /// </summary>
        /// <param name="tal"></param>
        static void SkrivBaklänges(int tal)
        {
            SkrivBaklänges(tal.ToString());
        }

        /// <summary>
        /// Skriver tal med komma/punkt i en rad
        /// </summary>
        /// <param name="talet"></param>
        static void SkrivBaklänges(double talet)
        {
            SkrivBaklänges(talet.ToString());
        }
    }
}
