using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception handling is the process of catching the exceptions throw by some errors of the program. That is done with try and catch block
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1/num2);
            }
            catch (Exception e) // with this the catch is recieving am argument that is the exception itselft
            // If I want to target an specific exception I can do it on the way:
            // catch (DivideByZeroException e)
            // on this way I can just catcth the zero division exception
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // this code is going to executed no mather what
            }

            Console.ReadLine();
        }
    }
}
