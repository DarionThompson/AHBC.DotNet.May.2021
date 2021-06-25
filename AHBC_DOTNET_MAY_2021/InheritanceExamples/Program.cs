using System;
using System.Collections.Generic;

namespace InheritanceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AnimalExample
            var animal = new Animal();
            animal.Name = "LION";
            animal.NumberOfLegs = 4;
            animal.HasWings = false;
            animal.MakeNoise();

            var dog = new Dog();
            dog.Name = "Oliver";
            dog.HasWings = false;
            dog.NumberOfLegs = 4;
            dog.MakeNoise();

            var cat = new Cat();
            cat.Name = "Zeus";
            cat.HasWings = false;
            cat.NumberOfLegs = 4;
            cat.MakeNoise();
            #endregion

            #region AutomibileExample
            var chevyLoveTruck = new Truck();
            chevyLoveTruck.HasBed = true;
            chevyLoveTruck.Drive();

            var rv = new RV();
            rv.NumberOfBeds = 2;
            rv.HasBathroom = true;
            rv.HasKitchen = true;
            rv.Drive();


            var motorcycle = new MotorCycle();
            motorcycle.Drive();

            var truckTwo = new Truck(true);

            #endregion

            //parent object 
            var automobile = new Automobile();

            //child object
            var sedan = new Sedan();

            //child object
            var truck = new Truck();

            //child object
            var motorCycle = new MotorCycle();

            var subaru = new Subaru();

            List<Automobile> automobiles = new List<Automobile>();
            automobiles.Add(automobile);
            automobiles.Add(sedan);
            automobiles.Add(truck);
            automobiles.Add(motorCycle);
            automobiles.Add(subaru);

            //Example of try to use poly with no relationship 
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            //numbers.Add("Lebron");
            //numbers.Add(true);
         }

        private static void AddAnimal(Animal animal)
        {
            Console.WriteLine(animal.Name);
        }

        private static void AddAnimal(Cat animal)
        {
            Console.WriteLine(animal.Name);
        }

        private static void AddAnimal(Dog animal)
        {
            Console.WriteLine(animal.Name);
        }

    }
}
