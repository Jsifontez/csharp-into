using System;

namespace GettersAndSetters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; // Because is private only code inside the Movie Class is gonna be able to access to the rating

        public Movie (string aTitle, string aDirector, string aRating)
        {
          title = aTitle;
          director = aDirector;
          // to avoid assign an invalid vaue for rating when the Movie is initialize, instead of assing 'rating', You should use the setter 'Rating'
          Rating = aRating;
        }
        // To start a getters and setters
        public string Rating
        {
            // getter will allow to 'get' the rating attribute
            get { return rating; }
            // is allow to modify ('set') the value of the rating
            set
            {
                // here we can specify the value that can be accepted
                // value is the parameters that was passed to the getter
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}