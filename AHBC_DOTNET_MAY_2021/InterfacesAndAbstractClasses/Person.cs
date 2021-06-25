using System;
namespace InterfacesAndAbstractClasses
{
    public abstract class Person : User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract int SocialSecurity { get; set; }

        public abstract void PersonalInfo();

        protected void SetSocialSecurity()
        {
            //Define 
        }

        public virtual bool DoesPersonHaveSoc()
        {
            return SocialSecurity > 0; 
        }
    }
}
