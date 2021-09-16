using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // plain text
            string phrase = "Giraffe Academy";
            char grade = 'A';
            
            // numbers
            int age = 30;
            // for decimals numbres there's 3 way of storing: float, double, decimal (from least to most accurate)
            double gpa = 3.258;

            // bolean (true or false)
            bool isMale = false;

            Console.WriteLine(phrase);
            Console.WriteLine(grade);
            Console.WriteLine(age);
            Console.WriteLine(gpa);
            Console.WriteLine(isMale);
        }
    }
}
