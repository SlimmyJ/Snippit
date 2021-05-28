namespace Snippit.Models.ViewModels
{
    using System.Collections.Generic;

    public class SnippitDeleteViewModel
    {
        public ICollection<UserSnippit> Snippits { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public int Rating { get; set; }

        public int AuthorId { get; set; }

        public int LanguageId { get; set; }
    }
}