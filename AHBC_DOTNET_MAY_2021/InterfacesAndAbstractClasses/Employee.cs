using System;
namespace InterfacesAndAbstractClasses
{
    public class Employee : Person
    {
        public Employee()
        {
        }

        public override int SocialSecurity { get ; set ; }

        public override void PersonalInfo()
        {
            throw new NotImplementedException();
        }
    }
}
