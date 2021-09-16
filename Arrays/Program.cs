using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // to creae an array you need to specify he type of value taht array going to storage + [] + name = {elements of the array};
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            // Arrays ara a mutable type
            luckyNumbers[1] = 900;

            // To create an array but you don't know how many element you're going to storage, you use the constructor 'new string[how many element the arr can hold]
            string[] friends = new string[15];

            friends[0] = "Jim";
            friends[1] = "Kelly";

            Console.WriteLine(luckyNumbers[1]);

            Console.ReadLine();
        }
    }
}
