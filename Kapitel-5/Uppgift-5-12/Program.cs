using System;

namespace Uppgift_5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            string[] meningar = { "Jag heter Rahim.", "jag gillar fotboll.", "Min favorit färg är Grön." };

            foreach (string mening in meningar)
            {
                Console.WriteLine(mening);
                Console.WriteLine();
            }
        }
    }
}
