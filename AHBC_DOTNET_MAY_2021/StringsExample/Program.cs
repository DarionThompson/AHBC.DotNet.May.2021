using System;
using System.Text;

namespace StringsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Review
            //Old way
            //First unit of work
            Console.WriteLine("Hey bro enter a number");

            //Second unit of work
            var userInput = Console.ReadLine();
            var number = int.Parse(userInput);

            //Third
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }

            //fourth unit of work
            Console.WriteLine(number);


            //new way of methods
            DisplayMessage();
            int userNumber = GetUserInput();
            int result = CalculateFactorial(userNumber);
            DisplayResult(result);


            //Strings
            //             012345 
            string name = "darion ";
            string LastName = name;
            LastName += "Thompson";
            Console.WriteLine(LastName[3]);
            Console.WriteLine(LastName[6]);
            //LastName[0] = 'B'; this is a no no 

            Console.WriteLine(name);
            Console.WriteLine(LastName);
            var nameArray = new char[] { 'd', 'a', 'r', 'i'};
            var secondNameArray = nameArray;
            secondNameArray[0] = 'B';

            Console.WriteLine(nameArray[0]);

            //StringBuilder stuff :)
            var stringBuilder = new StringBuilder("Hello World");
            stringBuilder.Append(" Here is some more stuff");
            Console.WriteLine(stringBuilder);

            //initialize
            string person = "darion";
            string emptyString = "";
            string emptyStringTwo = string.Empty;

            //Combine
            string combineString = string.Concat("{0}, {1}", person, name);
            string combineStringTwo = $"{person} {name} ";
            if("hello" == "HeLlO")
            {

            }
            //string equality
            bool isEqual = "hello" == "HeLlO";
            bool isEqualTwo = "hello" == "HeLlO".ToLower();
            bool isEqualThree = "HELLO" == "hello".ToUpper();
            bool isStringEqual = "hello".Equals("HeLlO", StringComparison.OrdinalIgnoreCase);
            var isStringE = string.Compare("Hello", "hellO");
            Console.WriteLine(isStringE);
            Console.WriteLine(isEqualTwo);

            //how do we find stuff
            //             0123456789
            string goat = "Lebron James is the greatest basketball of ALL time";
            int indexOf = goat.IndexOf("James");
            Console.WriteLine(indexOf);
            int lastIndexOf = goat.LastIndexOf("the");
            Console.WriteLine(lastIndexOf);

            bool endsWith = goat.EndsWith("time");
            bool startsWith = goat.StartsWith("Lebron");
            var sentenceArray = goat.Split(" ");

            string babyGoat = "Michael,Jordan,is,the,greatest,basketball,of,ALL,time";
            var babyGoatArray = babyGoat.Split(",");
            foreach (var word in babyGoatArray)
            {
                Console.WriteLine(word);
            }
        }

        static void DisplayMessage()
        {
            Console.WriteLine("Hey Bro Enter a number");
        }

        static int GetUserInput()
        {
            var userInput = Console.ReadLine();
            return int.Parse(userInput);
        }

        static int CalculateFactorial(int number)
        {
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            return number;
        }

        static void DisplayResult(int number)
        {
            Console.WriteLine(number);
        }
    }
}
