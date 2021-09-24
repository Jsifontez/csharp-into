using System;

namespace StaticClassAttrs
{
    class Song
    {
      // every attribute that is not static is 'unique' for every instances of the class
      public string title;
      public string artist;
      public int duration;
      // the static attributes are the same for every instances
      // to create a static attrs is: public|private + static + type + name + = value
      public static int songCount = 0; // its going to tell me the number of song that has been created

      public Song (string aTitle, string aArtist, int aDuration)
      {
        title = aTitle;
        artist = aArtist;
        duration = aDuration;
        songCount++;
      }
    }
}