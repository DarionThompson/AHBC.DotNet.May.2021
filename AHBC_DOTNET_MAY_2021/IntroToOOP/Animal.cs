using System;

namespace IntroToOOP
{
    //Classes are blueprints the describe how the object will behave and look.
    public class Animal
    {
        //A field is a private member that exists at the class level.
        private int _age;

        //This how they did properties before
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 8)
                {
                    _age = value;
                }
            }
        }

        public string Name { get; set; }

        //Default Constructor.
        public Animal()
        {

        }

        public Animal(string name)
        {

        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
