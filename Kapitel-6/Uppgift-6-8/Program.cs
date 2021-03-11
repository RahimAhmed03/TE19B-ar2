using System;

namespace Uppgift_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera vad du letar efter i vilket ord
            Console.WriteLine(AntalISträng('r', " nord-väster-sjö-kust-artilleri-flyg-spanings-simulator-anläggnings-materiel-underhålls-uppföljnings-system-diskussions-inläggs-förberedelse-arbeten"));
        }

        // Metod för att leta hur många av den specifika bokstaven det finns i orden
        static int AntalISträng(char tecken, string text)
        {
            // Deklarera variabel
            int antal = 0;
            for (int i = 0; i < text.Length; i++)
            {
                // ifall det finns bokstaven i orden lägg till den i antal variabel
                if (text[i] == tecken)
                {
                    antal++;
                }
            }

            // Returnera antal som det finns
            return antal;
        }
    }
}
