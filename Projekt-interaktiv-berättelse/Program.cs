using System;

namespace Projekt_interaktiv_berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du landa på mars eller skicka en satellit?");
            string svar = Console.ReadLine();

            if (svar == "mars")
            {
                Console.WriteLine("Ok du har valt att landa, vill du landa snabbt och spara på bränsle men få en chans på att krascha eller sakta men få en chans på att få slut bränsle och hoppas på hitta bränsle?");
                svar = Console.ReadLine();
                if (svar == "snabbt")
                {
                    Random rnd = new Random();
                    int slumpat = rnd.Next(2);
                    if (slumpat == 0)
                    {
                        Console.WriteLine("Du har klarat dig och sparat bränsle för att komma tillbaka till Jorden");
                    } else
                    {
                        Console.WriteLine("Du kraschade och de bestämmer för att vänta med att skicka flera till mars");
                    }
                }
            } else 
            {
                Console.WriteLine("Ok du har valt att skicka en satelit vill du att den ska vara i omloppsbana och analysera gaser eller energin? ");
                svar = Console.ReadLine();
            }
    }
}}
