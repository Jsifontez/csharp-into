using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Alexander", 30);
            SayHi("John", 27);
            SayHi("Tom", 15);
        }
        
        // to created a method need to be created outside of the Main function. To create it you need to follow with: static + the return value (void if the method doesn't return anything) + the name of the methods + ([parameters])
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
