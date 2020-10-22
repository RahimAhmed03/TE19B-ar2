using System;

namespace Prov_1b_marginalskatt
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Frågar användaren hur mycket bruttolönde får
            Console.WriteLine("Vad är ditt bruttolön i kr?");
            double lön = double.Parse(Console.ReadLine());
            double skatt;

            // int lön = int.Parse(Console.ReadLine());
            //  while (lön == 0)
            {


                //  Console.WriteLine("Vad är ditt bruttolön i kr?");
                //int lön = int.Parse(Console.ReadLine());
               // while ()
               // användaren skriver in tal och ser ifall det är mer än 1 kr
                {
                   if (lön > 0)
                    {
                        Console.WriteLine("Bra då räknar vi ut lönen!");
                    }
                    else
                    {
                        Console.WriteLine("Det måste vara mer än 1 kr!");
                    }
                    // nettolönen räknas ut beroende på bruttolönen

                    if (lön < 10000)
                    {
                    // Console.WriteLine($"{lön} * {100-8} = " (lön / 100));
                        skatt = .08 * lön;
                    }
                    if (lön > 10000 && lön < 145000)
                    {
                        // Console.WriteLine($"{lön} * {100-22} = " (lön / 100)); 
                        skatt = .22 * lön;

                    }
                    if (lön > 145000 && lön < 515000)
                    {
                        //Console.WriteLine($"{lön} * {100-33} = " (lön / 100)); 
                        skatt = .33 * lön;

                    }
                    if (lön >= 515000)
                    {
                        //Console.WriteLine($"{lön} * {100-53} = " (lön / 100));
                        skatt = .53 * lön;

                    }
                }





            }

        }
    }
}
