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


            /*
             * First Method
             Description Prompt the user to enter a number.
              Second Method
             Use a for-loop to calculate the sum of all the numbers from 1 to the number entered.
             */
           
        }
        static int FirstMethod(string one)


        static int AddTwoNumbers(string numberOne, string numberTwo)
        {
            //Put the logic here instead.

            int convertedNumber = int.Parse(numberOne);
            int convertSecondNumber = int.Parse(numberTwo);
            int result = convertedNumber + convertSecondNumber;
            return result;
        }
    }
}
