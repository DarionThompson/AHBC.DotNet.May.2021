using System;

namespace IntroArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            string[] cars = new string[] { "Ford", "chevy", "Chrysler" };
                                         //0    1    2     3    4
            char[] letters = new char[] { 'a', 'b', 'c' , 'd', 'e'};
            Console.WriteLine(letters[1]);

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = "BMW";
            }

            //Will come back to this example. 
            var favoriteCarName = string.Empty;
            //I cannot change or reassign values in the collections
            foreach (var car in cars)
            {
                //this is a no no
                //car = "BMW";
                Console.WriteLine(car);
                favoriteCarName = car == "BMW" ? car : "No favorite car here";

                if(car == "BMW")
                {
                    favoriteCarName = car;
                }
                else
                {
                    favoriteCarName = "No favorite car here"; 
                }
            }
                                         //45 6        23
                                        // 0, 1, 2, 3, 4,   5
            int[] refExample = new int[] { 9, 3, 5, 0, 67, 15 };
            int[] otherArray = refExample;

            otherArray[0] = 45;
            otherArray[1] = 6;
            otherArray[4] = 23;
            Console.WriteLine(refExample[0]);

            int[] copyToArray = new int[6];
            //int[] copyToArray = refExample;
            refExample.CopyTo(copyToArray, 0);

            copyToArray[0] = 6;
            Console.WriteLine(refExample[0]);

        }
    }
}
