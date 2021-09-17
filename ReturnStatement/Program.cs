using System;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);
        }

        static int Cube(int num) {
            int result = num * num * num;
            return result;
        }
    }
}
