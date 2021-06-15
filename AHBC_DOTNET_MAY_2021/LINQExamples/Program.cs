using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LambdaExpressions and Delegates
            //args => expression
            //If we dont have arguments
            // () => ....
            // x => ...
            // (x,y,z) => ...
            //number => number * number;
            //no keywords needed : static, public, Name of method, return
            Action<string> print = Print;
            print("Roberto");

            Func<int, int> squareNumber = SquareNumber;
            Func<int, int> squareNumberBro = number => number * number;

            Console.WriteLine(squareNumberBro(5));

            List<int> numbers = new List<int> { 1, 4, 6, 7, 85, 45, 6, 23, 31 };

            //                       The Collection.ExtensionMethod(Lambda expression) -> (arg) => Expression 
            var numbersLessThanTen = numbers.FindAll(number => number < 10);

            //We can also chain these extension methods. .Where().OrderByAscending()
            var numbersGreaterThanTen = numbers.Where(number => number > 10).OrderBy(num => num);
            #endregion

            #region Titles
            var movieTitles = new List<string>
            {
                "Back to the Future",
                "Coming to America",
                "Jurrasic Park",
                "Lord of the Rings",
                "August Rush",
                "Mrs Doubtfire",
                "Sling Blade",
                "Hook"
            };

            //To Find a movie based on the title -> hook

           // lines 51- 57 is the long method
            foreach (var title in movieTitles)
            {
                if (title == "Hook")
                {
                    Console.WriteLine(title);
                }
            }
            // line 59 can replace 51-57
            var hookTitle = movieTitles.Single(title => title == "Hook");
            var secondTitle = movieTitles.SingleOrDefault(title => title == "DarionIsATrash");
            if(secondTitle != null)
            {
                Console.WriteLine(secondTitle);
            }
            #endregion

            #region MoreLinqExamples
            var firstTitle = movieTitles.First();
            var firstHookTitle = movieTitles.First(title => title == "Hook");
            var emptyList = new List<string>();
            var emptyTitle = emptyList.FirstOrDefault();


            Console.WriteLine(firstTitle);
            Console.WriteLine(firstHookTitle);

            var pagedTitles = movieTitles.Skip(2).Take(2);
            foreach (var title in pagedTitles)
            {
                Console.WriteLine(title);
            }

            var numberList = new List<int> {1, 2, 4, 5, 7, 8,};
            var count = numberList.Count();
            var sum = numberList.Sum();
            var max = numberList.Max();
            var min = numberList.Min();

            var evenNumbers = numberList.FindAll(number => number %2 == 0);
            foreach (var even in evenNumbers)
            {
                Console.WriteLine(even);
            }
            #endregion
        }

        //Line 30 will can replace this entire method ! Whaaaaaaaaaa
        static List<int> FindAllNumbersLessThan10(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                if (number < 10)
                {
                    result.Add(number);
                }
            }
            return result;
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void Print(string name)
        {
            Console.WriteLine(name);
        }


    }
}
