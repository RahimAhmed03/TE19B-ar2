using System;

namespace Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();
        }

        static double cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
