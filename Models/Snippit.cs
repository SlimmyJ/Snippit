namespace Snippit.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Snippit
    {
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        public string Content { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }

        public int AuthorId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int LanguageId { get; set; }
    }
}