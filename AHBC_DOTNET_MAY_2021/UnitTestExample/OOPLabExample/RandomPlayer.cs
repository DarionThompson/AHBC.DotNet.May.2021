using System;
namespace OOPLabExample
{
    public class RandomPlayer : Player
    {
        public RandomPlayer()
        {

        }

        public override RPS GenerateRoshambo()
        {
            Random random = new Random();
            var randomValue = (RPS)random.Next(2);
            return randomValue;
        }
    }
}
