using System;

namespace StaticClassAttrs
{
    class Program
    {
        static void Main(string[] args)
        {
            // static attributes are special attrs which are share by a the objects and all the instances of the 'class'
            Console.WriteLine(Song.songCount);

            Song holiday = new Song ("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);

            Song kashmir = new Song ("Kashmir", "Led Zeppelin", 150);

            // for access static attributes, instead of write holiday.artist
            // You use instead: Song.songCount
            Console.WriteLine(Song.songCount);
        }
    }
}
