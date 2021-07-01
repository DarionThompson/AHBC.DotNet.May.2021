using System;
namespace OOPLabExample
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name)
        {
            Name = name;
        }

        public HumanPlayer(string name, RPS rps)
        {
            Name = name;
            Roshambo = rps;
        }
        public HumanPlayer()
        {
        }

        public override RPS GenerateRoshambo()
        {
            throw new NotImplementedException();
        }

        public RPS GenerateHumanRoshambo(int userInput)
        {
            var rps = (RPS)userInput;

            return rps;
        }
    }
}
