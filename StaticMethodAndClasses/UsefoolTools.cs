using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodAndClasses
{
    // a static Class is used to avoid create a new instance of it. Instead is used to store mutiple static methods
    static class Tools
    {
      public static void SayHi(string name)
      {
        Console.WriteLine("Hello " + name);
      }
    }
}