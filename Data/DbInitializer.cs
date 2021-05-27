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
                                   AuthorId = 1,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard animal class"
                               },
                               new Snippit
                               {
                                   AuthorId = 1,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard person class"
                               },
                               new Snippit
                               {
                                   AuthorId = 4,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard demo class"
                               },
                               new Snippit
                               {
                                   AuthorId = 3,
                                   LanguageId = 1,
                                   Rating = 4,
                                   Title = "Standard people class"
                               },
                               new Snippit
                               {
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
                                 },
                             };

            context.Moderators.AddRange(moderators);
            context.SaveChanges();
        }
    }
}