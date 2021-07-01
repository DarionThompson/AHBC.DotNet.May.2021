using System;
namespace OOPLabExample
{
    public abstract class Player 
    {
        public string Name { get; set; }
        public RPS Roshambo { get; set; }

        public abstract RPS GenerateRoshambo();

        public virtual RPS GenerateRoshamboOptional()
        {
            Console.WriteLine("Hello World");
            return RPS.Rock;
        }
    }
}
