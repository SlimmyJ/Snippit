namespace Snippit.Data
{
    using System.Linq;

    using Snippit.Models;

    public static class DbInitializer
    {
        public static void Initialize(SnippitContext context)
        {
            context.Database.EnsureCreated();

            // Look for any existing Snippits.
            if (context.Snippits.Any())
            {
                return; // DB has been seeded
            }

            var snippits = new Snippit[]
                           {
                               new Snippit
                               {
                                   Id = 2,
                                   AuthorId = 1,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard animal class",
                                   Content = "Code content"
                               },
                               new Snippit
                               {
                                   Id = 1,
                                   AuthorId = 1,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard person class"
                               },
                               new Snippit
                               {
                                   Id = 3,
                                   AuthorId = 4,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard demo class"
                               },
                               new Snippit
                               {
                                   Id = 4,
                                   AuthorId = 3,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard people class"
                               },
                               new Snippit
                               {
                                   Id = 5,
                                   AuthorId = 1,
                                   LanguageId = 5,
                                   Rating = 2,
                                   Title = "Standard women class"
                               },
                           };

            context.Snippits.AddRange(snippits);
            context.SaveChanges();

            var moderators = new Moderator[]
                             {
                                 new Moderator()
                                 {
                                     FirstName = "Jens",
                                     LastName = "VV",
                                     Id = 1,
                                     AreaCode = "9000",
                                     AuthorId = 2,
                                     AccessLevel = 1
                                 },
                             };

            context.Moderators.AddRange(moderators);
            context.SaveChanges();
        }
    }
}