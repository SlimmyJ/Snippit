﻿namespace Snippit.Models
{
    public class LanguageAssignment
    {
        public int SnippitId { get; set; }

        public int LanguageId { get; set; }

        public UserSnippit Snippit { get; set; }

        public Language Language { get; set; }
    }
}