using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // static methods are methods that belong to the class itself. This mean that it is not necessary to create a new instance of the class to access to that method.
            // an example of static method are the Math.sqrt()
            Console.WriteLine(Math.Sqrt(144));

            Tools.SayHi("Casimiro");

            // a static Class is used to avoid create a new instance of it. Instead is used to store mutiple static methods
        }
    }
}
