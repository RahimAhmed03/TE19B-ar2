using System;

namespace Uppgift_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en array med tal
            int[] talLista = { 95, 123, 7, -150, -14 };

            // Ange summa
            int summa = 0;

            // Beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop
            foreach (int tal in talLista)
            {
                summa += tal;
            }

            Console.WriteLine($"Summan av talen är {summa}");
        }
    }
}
