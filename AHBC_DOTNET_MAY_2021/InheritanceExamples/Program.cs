using System;

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
        }
    }
}
