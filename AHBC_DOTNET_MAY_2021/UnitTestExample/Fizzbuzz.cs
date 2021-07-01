using System;
namespace UnitTestExample
{
    public class Fizzbuzz
    {
        
        public string GetFizzbuzz(int number)
        {
            var result = string.Empty;
            if(number % 3 == 0)
            {
                result = "Fizz";
            }
            return result;
        }
    }
}
