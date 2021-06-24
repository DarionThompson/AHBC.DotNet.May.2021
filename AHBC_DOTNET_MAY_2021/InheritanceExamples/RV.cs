using System;
namespace InheritanceExamples
{
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
