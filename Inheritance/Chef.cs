using System;

namespace Inheritance
{
    class Chef
    {
        // inheritance is a tecnique that allow a class inherit all the functionaity of another class.
        // i.e. You going to have a super class and sub classes
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        // 'virtual' is used to allow sub classes to overwrite the methods from a super class
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}