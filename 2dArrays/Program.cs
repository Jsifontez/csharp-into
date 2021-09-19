using System;

namespace _2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2d Array is an array with nested array elements
            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            // to access 2d array: nameOfTheArray[index of the array, index of the nested array]
            Console.WriteLine(numberGrid[0,1]);
        }
    }
}
