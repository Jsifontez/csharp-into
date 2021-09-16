using System;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";

            // special character to jump line is '\n'
            Console.WriteLine("Hello\nWorld");

            // to write quotation marks use '\"'
            Console.WriteLine("Hello\" World");

            // to know the length of a string
            Console.WriteLine(phrase.Length);

            // to convert all the string in uppercase
            Console.WriteLine(phrase.ToUpper());

            // to know if a string have a substring
            Console.WriteLine(phrase.Contains("Academy"));

            // to know if a string has a substring and the position
            Console.WriteLine(phrase.IndexOf("Academy")); // Is goign to tell where the word 'Academy' starts. If the character o word doesn't is in the string return -1

            // to retrieve a substring from a string you can use .Substring method
            Console.WriteLine(phrase.Substring(8));
        }
    }
}
