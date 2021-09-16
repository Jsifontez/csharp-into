using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // dividing two integer number return a integer
            Console.WriteLine(5/2); // return 2

            // to get a decimal answer I divide with a float
            Console.WriteLine(5/2.0); // return 2.5

            // to increast o decreast a number
            int num = 5;
            Console.WriteLine("Num is " + num);
            num = 3;
            Console.WriteLine(num++); 
            num = 2;
            Console.WriteLine(num--); 

            // using Math object
            Console.WriteLine(Math.Pow(3, 2)); // 3 to the second power

            // to know which number is greater
            Console.WriteLine(Math.Max(4, 50));

            /*To know more about number methos, google: csharp Math methods*/
        }
    }
}
