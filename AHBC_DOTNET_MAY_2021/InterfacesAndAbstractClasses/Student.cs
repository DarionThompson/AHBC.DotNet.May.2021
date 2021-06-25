using System;
namespace InterfacesAndAbstractClasses
{
    public class Student : Person
    {
        public int Identification { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public override int SocialSecurity { get; set ; }

        public Student()
        {

        }
        public override void PersonalInfo()
        {
            SetSocialSecurity();
            Console.WriteLine($"Name: {Name}, GPA: {GPA}");
        }
        //How you override default implementions in classes.
        public override bool DoesPersonHaveSoc()
        {
            return base.DoesPersonHaveSoc();
        }
    }

    public class User
    {
        public int UserId { get; set; }
    }
}
