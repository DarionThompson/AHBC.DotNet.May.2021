using System;

namespace OOPLabExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var rockPlayer = new RockPlayer();
            rockPlayer.GenerateRoshamboOptional();
            rockPlayer.Roshambo = RPS.Rock;
            Console.WriteLine("Hey User Enter your Name");
            var userInput = Console.ReadLine();

            var humanPlayer = new HumanPlayer(userInput);

            Console.WriteLine(humanPlayer.Name);
        }
    }
}
