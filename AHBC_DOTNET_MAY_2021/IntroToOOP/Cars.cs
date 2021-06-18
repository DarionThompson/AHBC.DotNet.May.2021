using System;
namespace IntroToOOP
{
    public class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }
        public int Mph { get; set; }

        public Cars()
        {

        }
        public Cars(string make, string model)
        {
            Make = make;
            Model = model;
        }


        public void Speed()
        {
            Mph += 10;
            Console.WriteLine($"I am speeding, my speed is: {Mph}" );
        }
    }
}
