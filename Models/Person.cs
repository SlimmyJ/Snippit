namespace Snippit.Models
{
    using System.ComponentModel.DataAnnotations;

    public abstract class Person : BaseModel
    {
        public string FirstName { get; set; }

        public string AreaCode { get; set; }

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