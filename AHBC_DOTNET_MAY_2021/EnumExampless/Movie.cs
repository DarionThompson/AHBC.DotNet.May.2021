using System;
using System.Collections.Generic;

namespace EnumExampless
{
    public class Movie
    {
        public string Title { get; set; }

        public Genre Category { get; set; }


        public string FindMovieByGenre(string userInput)
        {
            var isParsed = Enum.TryParse<Genre>(userInput, out var genre);
            var isNumber = int.TryParse(userInput, out var number);

            if (isParsed)
            {
                switch (genre)
                {
                    case Genre.Horror:
                        return "The bed that Eats";

                    case Genre.Anime:
                        return "DBZ";

                    case Genre.SciFi:
                        return "Back to The Future";

                    case Genre.Comedy:
                        return "Ace Venture : Pet Detective";

                    case Genre.Drama:
                        return "The God Father";
                    default:
                        break;
                }
            }
            
            return string.Empty;
        }
    }
}
