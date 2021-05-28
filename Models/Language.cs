namespace Snippit.Models
{
    public enum Languages
    {
    }

    public class Language : BaseModel
    {
        public int SnippitId { get; set; }

        public int AuthorId { get; set; }

        public UserSnippit Snippit { get; set; }

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