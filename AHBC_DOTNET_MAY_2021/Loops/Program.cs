using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hey can you write");

            //string response = Console.ReadLine();

            if (true)
            {
                //Then execute this line of code
            }
            else
            {
                //Then execute this line of code
            }

            int switchNumber = 5;

            switch (switchNumber)
            {
                case 1: Console.WriteLine("case one");
                    break;

                case 5:
                    Console.WriteLine("Case 5");
                    break;

                default:
                    break;
            }

            //Explicit casting
            double number = 22.50;
            int secondNumber = (int)number;

            //implicit Casting
            int thirdNumber = 3;
            double num = thirdNumber;

            while (num <= 5)
            {
                Console.WriteLine("I Just looped bro");
                num++;
            }
            //Example of an infinite loop
            //while (false)
            //{
            //    Console.WriteLine("I will never end bro");
            //}

            int secondControlNumber = 0;
            do
            {
                Console.WriteLine("I will always execute at least once");
                secondControlNumber++;
            } while (secondControlNumber <= 5);

            //I want to keep looping until the user tells me no (N)
            Console.WriteLine("Hey Bro Can you tell me (Y) yes or (N) no ?");
            string userInput = "";
            do
            {
                Console.WriteLine("Do you want me to keep looping");
                userInput = Console.ReadLine();

            } while (userInput != "N");
        }
    }
}
