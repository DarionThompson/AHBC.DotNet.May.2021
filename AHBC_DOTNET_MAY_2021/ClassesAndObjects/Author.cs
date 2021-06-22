using System;
namespace ClassesAndObjects
{
    public class Author
    {

        // Name first and last, Age, Pen name, Gender


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string PenName { get; set; }

        public string Gender { get; set; }

        public Author()
        {
        }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Author(string firstName, string lastName, int age, string penName, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PenName = penName;
            Gender = gender;
        }
    }
}
