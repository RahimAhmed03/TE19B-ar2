using System;

namespace PROV_1d_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentation
            Console.WriteLine("Det här programmet räknar ut din BMI, dvs Body Mass Index.");

            // Loop
            string igen = "j";
            while (igen == "j")
            {
                // Upprepa om anändaren skriver in < 0
                int längd = 0;
                int vikt = 0;
                while (längd <= 0 && vikt <= 0)
                {
                    // Först matar användaren in längd i cm
                    Console.WriteLine("Ange din längd i m: ");
                    string längdSträng =Console.ReadLine();

                    // Översätt från sträng till ett heltal
                    //längd = int.Parse(längdSträng);
                    bool flaggaLängd = int.TryParse(längdSträng, out längd);

                    // Varna användaren om hen matar in något annat än ett heltal
                    if (flaggaLängd == false)
                    {
                        Console.WriteLine("Var god mata in ett heltal!");
                    }
                    else if (längd <= 0) // Om längd <0 skriv ut felmeddelande
                    {

                        Console.WriteLine("Längd måste vara > 0 cm!");
                    }
                    {

                    }

                    // Nu matar använadren sin vikt i kg
                    Console.WriteLine("Ange din vikt i kg: ");
                    string viktSträng = Console.ReadLine();

                    // Översätt från sträng till ett heltal
                    // längd = int.Parse (viktSträng)
                    bool flaggaVikt = int.TryParse(viktSträng, out vikt);


                    // Varna användaren om hen matar in något annat än ett heltal
                    if (flaggaVikt == false)
                    {
                        Console.WriteLine("Var god mata in ett heltal!");
                    }
                    else if (vikt <= 0) // Om längs <0 skriv ut felmeddelande
                    {

                        Console.WriteLine("vikt måste vara > 0 kg!");
                    }
                    {

                    }

                    // Därefter räknas BMI
                    int BMI = vikt / längd * längd;
                    if (BMI <= 16)
                    {
                        Console.WriteLine("Du är kraftik underviktig");
                    }
                    else if (BMI < 16 && BMI < 16.99)
                    {
                        Console.WriteLine("Du är undervikt");
                    }
                    else if (BMI < 17 && BMI < 18.49)
                    {
                        Console.WriteLine("Du kan vara lite undervikt");
                    }
                    else if (BMI < 18.50 && BMI < 24.99)
                    {
                        Console.WriteLine("Du är undervikt");
                    }
                    else if (BMI < 25 && BMI < 27.49)
                    {
                        Console.WriteLine("Du är undervikt");
                    }







                }
                // Anslutningsvis frågar programmet om användaren vill göra en ny beräkning
                Console.Write("Vill du göra en ny beräkning. (j/n)");
                igen = Console.ReadLine();


                // Acceptera svaret även om användaren skriver med versaler
                igen = igen.ToLower();
            }


        }
    }
}
