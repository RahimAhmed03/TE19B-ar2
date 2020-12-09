using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Rahim", 17);
            SayHi("Hussein", 16);
            SayHi("Robin", 17);

            Console.ReadLine();
        }

        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }


    }
}
