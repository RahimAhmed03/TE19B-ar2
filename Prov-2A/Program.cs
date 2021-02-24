using System;

namespace Prov_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler och initialisera
            int antalFilmer = 50;
            string filnamn = "movies.tsv";

            // Format: Filmens namn, intäkter, årtal
            string tomtFilmBeskrivning = "ingen,0,0";

            // Array för att spara filmerna
            string[] filmInformation;

            // Presentera programmet för användaren
            Console.WriteLine("Detta är ett program för att hitta filmer");

            // Finss larginsfilen?
            if (File.Exists(filnamn))
            {
                // Läs in alla rader, dvs filmerna
                filmInformation = File.ReadAllLines(filnamn);
                Console.WriteLine("Filmerna lästes in från fil");
            }
            else
            {
                // Meddela användaren att filen eller filmerna inte finns
                Console.WriteLine("Tyvärr finns inte det du sökte efter");

                // Skapa en tom radlista i arrayen
                // Lagra detta i filen
                filmInformation = new string[antalFilmer];   // 50 nya tomma positioner

                // Fyll arrayen med tomma filmer: 0, 1, 2, 3, 4, 5, 6, 7
                for (int i = 0; i < antalFilmer; i++)
                {
                    filmInformation[i] = tomtFilmBeskrivning;
                }

                // Lagra i filen
                File.WriteAllLines(filnamn, filmInformation);
                Console.WriteLine("Fil med bordsinformation saknas, ny fil skapades");
            }


        

        // Huvudloopen
        string menyVal = "";
        while (menyVal != "3")
        {
            // Skriv ut huvudmenyn
            Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Visa alla filmer");
                Console.WriteLine("2. Sök år");
                Console.WriteLine("3. Avsluta");
                menyVal = Console.ReadLine();

                // Hantera menyVal
                string filmNamn = "", intäkter = "", årTal = "";
                int svar = 0, filmNr = 0, antalIntäkter = 0, året = 0;
                string[] delar;
                switch (menyVal)
                {
                    // Visa alla filmer
                    case "1":
                        int totaltAntalFilmer = 0;
                        for (int i = 0; i < antalFilmer; i++)
                        {
                            if (filmInformation[i] == tomtFilmBeskrivning)
                            {
                                // Filmen finns inte
                                Console.WriteLine($"Film {i + 1} - ingen film");
                            }
                            else
                            {
                                // Filmen finns
                                // Plocka ut namn, intäkter och år
                                delar = filmInformation[i].Split(',');
                                string antalFilmerString = delar[0];
                                filmNamn = delar[1];
                                intäkter = delar[2];
                                årTal = delar[3];

                                // Summera alla filmer
                                totaltAntalFilmer += int.Parse(antalFilmerString);

                                // Skriv ut filmerna
                                Console.WriteLine($"Film {i + 1} - Namn: {filmNamn}, antal filmer: {antalFilmerString}, intäkter: {intäkter}, år: {årTal}");
                        }
                    }

                    // Summera
                    Console.WriteLine($"Totalt antal filmer: {totaltAntalFilmer}");
                    break;

                // Sök efter år
                case "2":
                    // Fråga årtal
                    Console.WriteLine("Vilket år söker du?");
                    while (!int.TryParse(Console.ReadLine(), out svar) || svar < 1990 || svar > 2021)
                    {
                        Console.WriteLine("Icke giltigt år, försök igen");
                    }
                    filmNr = svar;

                    // finns en film i det året?
                    if (filmNr = true)
                    {
                        Console.WriteLine("Hittade filmen/filmerna");
                    }
                    else
                    {
                        Console.WriteLine("tyvärr det finns inga filmer de året");
                    }

                    // Skriv ut filmen/filmera som finns i årtalet
                    Console.WriteLine($"");

                    case "3":
                        // Tacka användaren för att de använde programmet
                        Console.WriteLine("Tack för att du använde detta program");
                        break;
        

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }
}
        }
    }
}
