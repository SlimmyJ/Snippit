namespace Snippit.Models
{
    public class LanguageAssignment
    {
        public int SnippitID { get; set; }

        public int LanguageID { get; set; }

        public Snippit Snippit { get; set; }

        public Language Language { get; set; }
    }
}