using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            var userInput = Console.ReadLine();
            var userInputTwo = Console.ReadLine();

            //Put the logic here Add two numbers.
            var thingOne = AddTwoNumbers(userInput, userInputTwo);

            //Method overloading
            Console.WriteLine();
            Console.WriteLine("srting");
            Console.WriteLine(true);

            Console.WriteLine();


            //Use a for-loop to calculate the sum of all the numbers from 1 to the number entered
            //Console.WriteLine("Hello World!");
            //var result = FirstNumber();
            //Console.WriteLine(result);

            //var stuff = Loop(result);
            //Console.WriteLine(stuff);

            //Pass by value
            int number = 1;
            int result = PassByValue(number);
            Console.WriteLine(result);

            //pass by reference
            int numberTwo = 10;
            PassByReference(ref numberTwo);
            Console.WriteLine(numberTwo);

            //out keyword
            var isParsed = int.TryParse("5", out int numberThree);
            var isPositive = TryAddPositiveNumber(5, 4, out int positiveNumber);
            Console.WriteLine(positiveNumber);
        }

        static int AddTwoNumbers(string numberOne, string numberTwo)
        {
            //Put the logic here instead.

            int convertedNumber = int.Parse(numberOne);
            int convertSecondNumber = int.Parse(numberTwo);
            int result = convertedNumber + convertSecondNumber;
            return result;
        }

        //out
        static bool TryAddPositiveNumber(int x, int y, out int result)
        {

            if (x > 0 && y > 0)
            {
                result = x + y;
                return true;
            }
            else
            {
                result = 0;
                return false;
            }
        }

        static void PassByReference(ref int numberTwo)
        {
            numberTwo += 3;
        }

        static int PassByValue(int number)
        {
            return number + 2;
        }


        //class hands on keyboard exercise
        static int FirstNumber()
        {
            Console.WriteLine("Please enter a number");
            int numberOne = int.Parse(Console.ReadLine());
            return numberOne;
        }

        static int Loop(int whatever)
        {
            int sum = 0;
            for (int i = 1; i <= whatever; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
