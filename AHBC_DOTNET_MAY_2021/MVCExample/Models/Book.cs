using System.ComponentModel.DataAnnotations;

namespace MVCExample.Models
{
    public class Book
    {
        public Book(string name)
        {
            Name = name;
        }
        public Book()
        {

        }
        [Required(ErrorMessage = "Yo bro no Id")]
        public int Id { get; set; }

        public string  Name { get; set; }

        public string Author { get; set; }

        //This property doesnt belong but its a cool example
        [EmailAddress]
        public string Email { get; set; }
    }
}