using System;

namespace prov_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej i Detta program ska vi räkna ut din ålder på en annan planet");
            Console.WriteLine("Ange din ålder i jordår:");
            double Ålder = ReadDouble();
            string användarensVal = "";
            while (användarensVal != "8")
            {
                SkrivMeny();
                användarensVal = Console.ReadLine();
                Console.WriteLine();

                switch (användarensVal)
                {
                    case "1":
                        ÅlderPåMerkurius();
                        break;
                    case "2":
                        ÅlderPåVenus();
                        break;
                    case "3":
                        ÅlderPåMars();
                        break;
                    case "4":
                        ÅlderPåJupiter();
                        break;
                    case "5":
                        ÅlderPåSaturnus();
                        break;
                    case "6":
                        ÅlderPåUranus();
                        break;
                    case "7":
                        ÅlderPåNeptunus();
                        break;
                    case "8":
                        break;
                    default:
                    Console.WriteLine("Du valde ett ogiltigt alternativ");
                        break;
                }
            }
        }
        static void SkrivMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Räkna ut ålder på Merkurius");
            Console.WriteLine("2. Räkna ut ålder på Venus");
            Console.WriteLine("3. Räkna ut ålder på Mars");
            Console.WriteLine("4. Räkna ut ålder på Jupiter");
            Console.WriteLine("5. Räkna ut ålder på Saturnus");
            Console.WriteLine("6. Räkna ut ålder på Uranus");
            Console.WriteLine("7. Räkna ut ålder på Neptunus");
            Console.WriteLine("8. Avsluta");
        }
        static double ReadDouble()
        {
            double svar;
            while (double.TryParse(Console.ReadLine(), out svar) == false)
            {
                // Ifall det inte är ett giltigt tal skriv felmeddelande
                Console.WriteLine("Du skrev inte ett tal, vg försök igen");
            }
        }
        static double ÅlderPåMerkurius()
        {
            return Ålder / 0.2408467;
        }
        static double ÅlderPåVenus()
        {
            return Ålder / 0.61519726;
        }
        static double ÅlderPåMars()
        {
            return Ålder / 1.8808158;
        }
        static double ÅlderPåJupiter()
        {
            return Ålder / 11.862615;
        }
        static double ÅlderPåSaturnus()
        {
            return Ålder / 29.447498;
        }
        static double ÅlderPåUranus()
        {
            return Ålder / 84.016846;
        }
        static double ÅlderPåNeptunus()
        {
            return Ålder / 164.79132;
        }
    }
}
