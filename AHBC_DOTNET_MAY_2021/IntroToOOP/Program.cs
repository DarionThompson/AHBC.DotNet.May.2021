using System;
using System.Collections.Generic;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Animal Example
            Animal bear = new Animal();

            var animal = new Animal();
            animal.Age = 5;
            animal.Name = "Dog";

            var secondAnimal = new Animal("Bubbles", 5);

            var thirdAnimal = secondAnimal;
            thirdAnimal.Age = 6;

            Console.WriteLine($"Here is the animals age: {animal.Age}");
            Console.WriteLine($"Here is the animals age: {secondAnimal.Age}");
            #endregion

            #region Cars Example
            var ford = new Cars("Ford", "Mustang");
            ford.ModelYear = 2022;
            ford.Color = "Blue";
            ford.Mph = 115;

            var chevy = new Cars
            {
                Color = "Silver",
                Make = "Chevy",
                Model = "Camaro",
                ModelYear = 1998,
                Mph = 65
            };

            var del = new Cars
            {
                Color = "silver",
                Make = "Delorean",
                Model = "Delorean",
                ModelYear = 1985,
                Mph = 88

            };

            List<Cars> cars = new List<Cars> {};
            cars.Add(ford);
            cars.Add(chevy);
            cars.Add(del);

            Acceleration(cars);

            #endregion
        }

        public static void Acceleration(List<Cars> cars)
        {
            foreach (var car in cars)
            {
                car.Speed();
                Console.WriteLine($"Hers is the MPH for {car.Make} : {car.Mph}");

            }
        }
    }
}
 