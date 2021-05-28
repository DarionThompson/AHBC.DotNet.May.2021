using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Review
            Console.WriteLine("Hey can you write");

            string response = Console.ReadLine();

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
                case 1:
                    Console.WriteLine("case one");
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

            //LOOPS
            //While loop
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

            //Do While Loop
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

            //for-loop
            //Oder of exectution
            //1               2       4
            for (int j = 10; j > 0; j--)
            {
                //3
                Console.WriteLine(j);
            }


            int[] array = new int[]
            {
              //0,1,2,3,4
                1,2,3,4,5
            };

            //Oder of exectution
            //1             2       4
            for (int i = 0; i < array.Length; i++)
            {
                //3
                Console.WriteLine(array[i]);
            }

            //foreach loop
            var names = new List<string>
            {
                "Robert",
                "Bobby Bax",
                "The Bax man"
            };
            var nameE = "Robert";

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            //Here is the tryparse example :) 
            Console.WriteLine("Please enter a number");
            var userResponse = Console.ReadLine();

            var canBeParsed = int.TryParse(userResponse, out int result);

            if(canBeParsed)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("you didnt give me a number");
            }
        }
    }
}
