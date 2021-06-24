using System;
namespace InheritanceExamples
{
    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public bool HasWings { get; set; }

        public Animal()
        {
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine($"Hi I am animal {Name} I make noise");
        }
    }
}
