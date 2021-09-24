using System;

namespace Inheritance
{
    // to tell some class that inherit all functionality we use double colons an then the name of the class to inherit
    class ItalianChef : Chef
    {
        // here you can create new methods to use ONLY for the class
        public void MakePasta()
        {
            Console.WriteLine("The Chef make pasta");
        }
        // here you can override a class form de super class. In order to do that you need to add the word 'virtual' when you create the method. And in the sub class you change the 'virtual' word for the 'override' word
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}