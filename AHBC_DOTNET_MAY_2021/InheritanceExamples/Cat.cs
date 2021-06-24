using System;
namespace InheritanceExamples
{
    public class Cat : Animal
    {
        public Cat()
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Yeah I am a cat and I like to MEOW");
        }
    }
}
