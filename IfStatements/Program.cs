using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall) {
                Console.WriteLine("You are a short male");
            } else if (!isMale) {
                Console.WriteLine("You are not a male but you're tall");
            } else
            {
                Console.WriteLine("You are either not male and not tall");
            }
        }
    }
}
