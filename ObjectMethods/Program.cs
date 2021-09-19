using System;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // an object methods is a method defined inside a class. The objects of that class can use
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
    }
}
