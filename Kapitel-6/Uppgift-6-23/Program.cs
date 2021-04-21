using System;

namespace Uppgift_6_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en text: ");
            string meddelande = Console.ReadLine();
            Console.WriteLine(GörVarannanStor(meddelande));

            Console.WriteLine("Ange ytterligare en text: ");
            string meddelande2 = Console.ReadLine();
            Console.WriteLine(GörFörstaBokstavStor(meddelande));
        }

        static string GörVarannanStor(string texten)
        {
            // Gör att bokstäver till gemena
            texten = texten.ToLower();

            // Dela upp text vid mellanslag
            string[] orden = texten.Split(' ');

            // Loopa igenom texten
            // Plocka ut varannan
            for (int i = 0; i < orden.Length; i += 2)
            {
                orden[i] = orden[i].ToUpper();
            }

            return String.Join(" ", orden);
        }

        static string GörFörstaBokstavStor(string texten)
        {
            // Gör att bokstäver till gemena
            texten = texten.ToLower();

            // Dela upp text vid mellanslag
            string[] orden = texten.Split(' ');

            // Loopa igenom texten
            // Plocka ut varannan
            for (int i = 0; i < orden.Length; i++)
            {
                orden[i] = orden[i].Substring(0, 1).ToUpper() + orden[i].Substring(1).ToLower();
            }

            return String.Join(" ", orden);
        }
    }
}
