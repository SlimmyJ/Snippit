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

            var snippits = new UserSnippit[]
                           {
                               new UserSnippit
                               {
                                   Id = 2,
                                   AuthorId = 1,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard animal class",
                                   Content = "Code content"
                               },
                               new UserSnippit
                               {
                                   Id = 1,
                                   AuthorId = 1,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard person class"
                               },
                               new UserSnippit
                               {
                                   Id = 3,
                                   AuthorId = 4,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard demo class"
                               },
                               new UserSnippit
                               {
                                   Id = 4,
                                   AuthorId = 3,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard people class"
                               },
                               new UserSnippit
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