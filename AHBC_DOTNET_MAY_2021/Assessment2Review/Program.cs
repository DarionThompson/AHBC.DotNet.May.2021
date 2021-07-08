using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment2Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = BuySomeWeed("Darion");
            Console.WriteLine(result);

            var completedList = CompleteTheList("Darion", "Darion");

            
        }

        public static List<int> AddNumbers(int a, int b, int c, int d)
        {
            List<int> numbers = new List<int>
            {
                a,b,c,d
            };
            return numbers;
        }

        public static double GetAverage(int[] numbers)
        {
            var linqAverage = numbers.Average();
            var linqSum = numbers.Sum();
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            double average = linqSum / numbers.Length;
            return average;
        }

        public static List<string> CompleteTheList(string colorOne, string colorTwo)
        {
            List<string> colorList = new List<string>
            {
                colorOne, colorTwo, "Red", "Green", "Blue"
            };
            return colorList;
        }

        public static string BuySomeWeed(string age)
        {
            try
            {
                int oldEnough = int.Parse(age);
                if (oldEnough > 21)
                {
                    return "Enjoy your wine";
                }
                else
                {
                    return "Yo mamma";
                }
            }
            catch(Exception e)
            {
                return "Return get outta here kid";
            }
        }
    }
}
