//Skapa ett program som frågar användaren vilket hur högt hen kan hoppa i höjdhopp mätt i meter. Berätta för användaren hur mycket högre världsrekordet i höjdhopp är (världsrekordet i höjdhopp är 2,45 meter).


using System;

namespace Uppgift_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur högt kan du hoppa i höjdhopp i meter?");
            string höjdText = Console.ReadLine();
            double höjd = double.Parse(höjdText);
            double skillnad = 2.45 - höjd;

            Console.WriteLine("Världsrekordet är " + skillnad + " meter");
        }
    }
}
