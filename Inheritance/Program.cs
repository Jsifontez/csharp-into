using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // inheritance is a tecnique that allow a class inherit all the functionaity of another class.
            // i.e. You going to have a super class and sub classes
            Chef chef = new Chef();
            chef.MakeSpecialDish();
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();
        }
    }
}
