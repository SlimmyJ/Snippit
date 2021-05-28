namespace Snippit.Models.SnippitViewModels
{
    using System.Collections.Generic;

    public class SnippitViewModel
    {
        public ICollection<Snippit> Snippits { get; set; }

        public string Title { get; set; }
    }
}