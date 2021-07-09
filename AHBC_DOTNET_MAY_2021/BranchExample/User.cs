using System;
namespace BranchExample
{
    public abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public abstract string SetDarionsAwesomeness();
    }
}
