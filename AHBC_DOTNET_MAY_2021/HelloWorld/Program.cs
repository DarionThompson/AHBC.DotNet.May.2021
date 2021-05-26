using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ////Value types
            int numberOne = 10;
            int numberTwo = numberOne;
            numberOne = 20;


            ////Reference Types.
            string name = "Darion";

            //We will get into this soon
            StringBuilder stringBuilder = new StringBuilder("Darion slow down");
            StringBuilder stringBuilderTwo = stringBuilder;
            stringBuilder.Append("You are being crazy");


            //User to enter a number
            //Take the value and transfor the value from a string into a number
            //Print out the value as a number.
            Console.Write("Enter a number");
            string userInput = Console.ReadLine();
            int value = int.Parse(userInput);

            Console.WriteLine(value);

            //Assignment Operators
            int number = 5;
            //number = number + 5;
            number += 5;

            number *= 5;

            number /= 1;

            //Explicit Casting
            double salary = 10.00;
            int salaryNumber = (int)salary;

            //implicit casting
            int numOne = 50;
            float coolerNumber = numberOne;


            //Conditional Statments, boolen statments logical operators
            Console.WriteLine("please enter age");
            string userReponse = Console.ReadLine();
            int age = int.Parse(userReponse);
            string result = "";
            if (age >= 21 && age < 80 || age > 18)
            {
                result = "Welcome to the party";
            }
            else
            {
                result = "Your too young bro";
            }

            //If vs If else

            if (numberOne == numberTwo)
            {
                Console.WriteLine("We are equal bro");
            }
            else if (numberOne != numberTwo)
            {
                Console.WriteLine("We are not equal bro");
            }
            else if (numberOne >= 2)
            {
                Console.WriteLine("this is a number");
            }
            else
            {
                Console.WriteLine("what ");
            }

            //Switch statement
            switch (age)
            {
                case 21:
                    Console.WriteLine("You are old enough bro");
                    break;

                case 10:
                    Console.WriteLine("you are too young");
                    break;

                default:
                    Console.WriteLine("I dont know");
                    break;
            }


            //Ternary Operator
            result = age >= 21 ? "you are old enough"
                                   : "You are not old enough";

        }
    }
}
