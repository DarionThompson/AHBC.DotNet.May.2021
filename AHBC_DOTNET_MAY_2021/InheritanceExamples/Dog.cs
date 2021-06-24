using System;
namespace InheritanceExamples
{
    public class Dog : Animal
    {
        public Dog()
        {
        }

        public override void MakeNoise()
        {
            //base.MakeNoise();
            Console.WriteLine("Yeah but I am a dog and I like to Bark");
        }
    }
}
