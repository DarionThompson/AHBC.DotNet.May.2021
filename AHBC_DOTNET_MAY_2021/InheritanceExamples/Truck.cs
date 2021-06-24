using System;
namespace InheritanceExamples
{
    public class Truck : Automobile
    {
        public bool HasBed { get; set; }

        public Truck()
           : base (4, 4)
        {

        }
        public Truck(bool hasBed)
            :base(4, 4)
        {
            HasBed = hasBed;
        }

    }

    public class MotorCycle : Automobile
    {
        
        public MotorCycle()
        {

        }

        public void Drive()
        {
            base.Drive();
            Console.WriteLine("I am a motorcycle and I go 200 mph :) I have no Doors :)");
        }
    }

    public class Sedan : Automobile
    {
        
        public Sedan()
        {

        }
    }

    public class SUV : Automobile
    {
        
        public SUV()
        {

        }
    }

    public class RV : Automobile
    {
        public bool HasBathroom { get; set; }
        public bool HasKitchen { get; set; }
        public int NumberOfBeds { get; set; }
        public RV()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"I am an RV I can drive and Camp {NumberOfBeds} : {HasKitchen}");
        }
    }
}
