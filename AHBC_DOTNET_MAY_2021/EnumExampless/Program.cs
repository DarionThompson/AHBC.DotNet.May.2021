using System;

namespace EnumExampless
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Enum Start
            Console.WriteLine("Hello pick a day");

            var userInput = Console.ReadLine();

            //This is okay...but we can do better
            //Error handling 
            if(userInput == "Monday")
            {
                Console.WriteLine("Blah");
            }
            else if(userInput == "Tuesday")
            {
                Console.WriteLine("Blah Blah");
            }

            var isParsed = Enum.TryParse<Week>(userInput, out var week);

            if (isParsed)
            {
                switch (week)
                {
                    case Week.Monday:
                        Console.WriteLine("Hey its monday...");
                        break;
                    case Week.Friday:
                        Console.WriteLine("Its Friday...WHaatttttt");
                        break;
                    default:
                        break;
                }
            }
            var example = Week.Monday;

            #endregion

            var userResponse = GetUserInput();

            var movie = new Movie();
            var result = movie.FindMovieByGenre(userResponse);

        }

        public static string GetUserInput()
        {
            Console.WriteLine("Please Enter a Genre for your movie search");
            return Console.ReadLine();
        }
    }
}
