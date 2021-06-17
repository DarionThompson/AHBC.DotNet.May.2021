using System;
using System.Text.RegularExpressions;

namespace ErrorHandlingExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TryCatch
            //Write a method that takes two numbers and divides
            //Print the result to the screen

            //try
            //{
            //    var parsedNumber = int.Parse("Lebron James is a GOAT");
            //    var result = DivideNumber(5, 2);
            //    Console.WriteLine(result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw new FacebookException("Hey bro facebook is not available", ex);
            //}
            //finally
            //{
            //    Console.WriteLine("I have executed");
            //    //Make sure any other resource has not executed
            //}
            #endregion

            #region Regex
            ValidateUserInput();
            #endregion
        }
        static void ValidateUserInput()
        {
            Regex pattern = new Regex(@"(\d{3}-)(\d{3}-)(\d{4})");
            Console.WriteLine("Please enter a valid phone number");
            var phoneNumber = Console.ReadLine();

            if (pattern.IsMatch(phoneNumber))
            {
                Console.WriteLine("This Is a real number");
            }
            else
            {
                Console.WriteLine("This number is fake bro");
            }
        }
        #region methods
        static int DivideNumber(int numerator, int denominator)
        {
            return numerator / denominator;

        }

        static string GetUserInput()
        {
            Console.WriteLine("Hey please enter in a number");
            return Console.ReadLine();
        }
        #endregion
    }

    #region CustomException
    class FacebookException : Exception
    {
        public FacebookException(string message, Exception exception)
            :base(message, exception)
        {

        }
    }
    #endregion
}
