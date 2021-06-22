using System;

namespace ClassesAndObjects
{
    class Pen
    {
        public string Color { get; set; }

        public string TipType { get; set; }

        public string Brand { get; set; }

        public int InkLevel { get; set; }

        public Pen()
        {

        }
        public void Write()
        {
            Console.WriteLine("I am writing!");

            InkLevel -= 2;
        }
    }
}
