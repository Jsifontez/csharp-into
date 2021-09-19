using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 9, 15, 16, 23, 42};

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
