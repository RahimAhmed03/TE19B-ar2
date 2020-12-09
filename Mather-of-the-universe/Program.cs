using System;

namespace Mather_of_the_universe
{
    class Program
    {
        static void Main(string[] args)
        {

            int poäng = 0;
            int gissning = 0;
            string gissningText = "";
            //bool lyckades = false;
            int korrekt = 0;

            // Ställa frågan
            Console.WriteLine("Vad är x i formeln x * 6 = 42?");

            // Läs in användarens svar tills det funkar
            while (gissning == 0)
            {
                // Läs in det användaren skriver
                gissningText = Console.ReadLine();

                // Är det ett tal eller inte?
                // Blir true eller false
               if (int.TryParse(gissningText, out gissning));
               {
                   flagga == 1;
               } 

                // Varnar anändaren om hen inte matat in ett tal
                Console.WriteLine("Fel! Mata in ett tal.");

            }
            // Kolla om gissningen är korrekt eller inte
            if (gissning == 7)
            {
                
            }



            // Console.WriteLine("Om x * 6 = 42 vad blir då x? ");

            // int svar = 7;

            // while (svar != 7)
            // {
            //     Console.WriteLine("Skriv talet du tror blir x");

            //     string input = Console.ReadLine();

            //     // Försöker översätta till ett heltal
            //     if (int.TryParse(input, out svar))
            //     {
            //         Console.WriteLine("Vad bra att du matade in ett tal!");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Nej! Jag bad om ett tal! Försök igen!");
            //     }
            //     // Kolla om gissningen är rätt
            //     if (svar != 7)
            //     {
            //         Console.WriteLine("Fel svar! Försök igen!");
            //     }
            // }

            // // Rätt svar
            // Console.WriteLine("Rätt svar!"); 
        }
    }
}

