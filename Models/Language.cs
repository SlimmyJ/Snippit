namespace Snippit.Models
{
    public enum Languages
    {
    }

    public class Language
    {
        public int LanguageId { get; set; }

        public int SnippitId { get; set; }

        public int AuthorId { get; set; }

        public Snippit Snippit { get; set; }

        public enum Languages
        {
            Csharp,

            Php,

            Sql,

            Angular,

            Nodejs,

            Reactjs,

            Html,

            Css,

            Javascript,

            Typescript
        }
    }
}