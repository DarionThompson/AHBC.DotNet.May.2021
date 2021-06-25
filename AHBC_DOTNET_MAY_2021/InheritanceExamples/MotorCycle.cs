using System;
namespace InheritanceExamples
{
    //Child Class
    public class MotorCycle : Automobile
    {

        public MotorCycle()
        {

        }

        //we need the override keyword to change the default implementation
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("I am a motorcycle and I go 200 mph :) I have no Doors :)");
        }
    }
}
