namespace Snippit.Models
{
    public class Moderator : Person
    {
        public int AuthorId { get; set; }

        public int AccessLevel { get; set; }
    }
}