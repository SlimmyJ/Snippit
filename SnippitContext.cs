namespace Snippit
{
    using Microsoft.EntityFrameworkCore;

    using Snippit.Models;

    public class SnippitContext : DbContext
    {
        public SnippitContext(DbContextOptions<SnippitContext> options)
                : base(options)
        {
        }

        public DbSet<UserSnippit> Snippits { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Moderator> Moderators { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSnippit>()
                        .ToTable("Language");
            modelBuilder.Entity<Moderator>()
                        .ToTable("Moderator");
            modelBuilder.Entity<Author>()
                        .ToTable("Author");
            modelBuilder.Entity<Person>()
                        .ToTable("Person");

            modelBuilder.Entity<LanguageAssignment>()
                        .HasKey(
                            c => new
                                 {
                                     LanguageID = c.LanguageId,
                                     SnippitID = c.SnippitId
                                 });
        }
    }
}