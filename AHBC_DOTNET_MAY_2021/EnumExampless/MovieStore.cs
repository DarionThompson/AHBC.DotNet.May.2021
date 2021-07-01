using System;
using System.Collections.Generic;

namespace EnumExampless
{
    public class MovieStore
    {
        public List<Genre> Genres { get; set; }
        public MovieStore()
        {
        }

        public void SetGenresForStore()
        {

            //Magic strings 
            //Genres = new List<string>
            //{
            //    "Horror",
            //    "Comedy"
            //};

            //More Readable and reusable 
            Genres = new List<Genre>
            {
                Genre.Anime,
                Genre.Comedy,
            };
        }
    }
}
