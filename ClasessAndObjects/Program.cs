using System;

namespace ClasessAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // clasess and objects are used to create a new data type
            // an object is an instance of a class. And class is the template of what you want to create or mimic
            // to instantiate an object from a class is the same as we create any variable in c#: DataType + Name = new DataType();
            Book book1 = new Book("Harry Potter", "J. K. Rowling", 400); // this an instance of a book

            // to change the value of the attributes of the created book, just access to it with the dot notation (only if the attrs doesn't are specified in the constructor of the classs)
            // the code bellow  change the value of the book1 stablish in the constructor
            // book1.title = "Harry Potter";
            // book1.author = "J. K. Rowling";
            // book1.pages = 400;

            Book book2 = new Book("Lord of the Rings", "J. R. Tolkien", 700);
            Console.WriteLine(book2.title);
        }
    }
}
