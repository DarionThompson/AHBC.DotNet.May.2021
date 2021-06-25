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
}
