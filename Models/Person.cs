namespace Snippit.Models
{
    using System.ComponentModel.DataAnnotations;

    public abstract class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}