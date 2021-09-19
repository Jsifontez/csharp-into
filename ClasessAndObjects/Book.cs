using System;

namespace ClasessAndObjects
{
    public class Book
    {
        // this are class atributes. Variables that describe what thing of the 
        public string title;
        public string author;
        public int pages;
        // constructor is a special method inside of a class that is called when the object is created
        // the constructor can be modeled to be able to pass a parameter when the object is created. With that you don't have to change the attributes in the way: bookX.title = 'some title 1'. Instead, you can call it with new Book(attrs)
        public Book(string aTitle, string aAuthor, int aPages) // this is the constructor for this class
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        // you can create as many constructors as you want. In this case if you want to be able to created books without passing any values, just create an empty constructor
        public Book()
        {}
    }
}
