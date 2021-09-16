using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*For create a variable You need to specify the type of value that is going to be stored*/
            // type of value + name
            string characterName = "John";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge +" years old");
            Console.WriteLine(" ");
            characterName = "Mike";

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like beign " + characterAge);

            Console.ReadLine();
        }
    }
}
