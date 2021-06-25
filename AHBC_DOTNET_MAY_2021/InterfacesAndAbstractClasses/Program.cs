using System;

namespace InterfacesAndAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AbstractExample
            //can't do this, I am abstract bro
            //var person = new Person();
            var student = new Student
            {
                Age = 20,
                SocialSecurity = 123456123,
                Identification = 1,
                GPA = 3.8,
                UserId = 0
            };
            //Cant do this, it is protected..Only the child class can access it.
            //student.SetSocialSecurity();
            student.PersonalInfo();

            //A student is a Person, Polymorphism
            PrintPerson(student);

            #endregion

            IAnimal cat = new Cat();
            cat.Name = "Fritz";
            cat.Weight = 50;
            cat.HasMouth = true;

            IFeline secondCat = new Cat();
            secondCat.CanPurr = true;
            secondCat.HasNails = true;

            Cat thirdCat = new Cat();
            thirdCat.HasKittens = true;
            thirdCat.ScratchFurniture("Couch"); 
        }

        #region PolymorphismExampleWithAbstactType
        //I can still leverage Polymorphism here
        public static void PrintPerson(Person person)
        {
            Console.WriteLine(person.Name);
        }
        #endregion
    }
}
