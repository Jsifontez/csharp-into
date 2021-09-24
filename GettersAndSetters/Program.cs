using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // getters and setters are two kind of methods that can be defined inside a class. They controll the access that people have to the attributes to that classes
            Movie avengers = new Movie ("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie ("Shrek", "Adam Adamsom", "PG");

            Console.WriteLine(avengers.Rating);

            avengers.Rating = "R";

            Console.WriteLine(avengers.Rating);
        }
    }
}
