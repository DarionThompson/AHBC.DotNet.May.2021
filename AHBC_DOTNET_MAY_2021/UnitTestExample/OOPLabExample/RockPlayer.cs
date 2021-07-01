using System;
namespace OOPLabExample
{
    public class RockPlayer : Player
    {
        public RockPlayer()
        {
            Roshambo = RPS.Rock;
        }

        public override RPS GenerateRoshambo()
        {
            return Roshambo;
        }

        ////optional Bro
        //public override RPS GenerateRoshamboOptional()
        //{
        //    var parentResult = base.GenerateRoshamboOptional();
        //    var myResult = RPS.Scissors;
        //    return myResult;
        //}
    }
}
