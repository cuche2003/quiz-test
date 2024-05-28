using JSQuizTest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JSQuizTest.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Question> Question { get; set; } = default!;
        public DbSet<Choice> Choice { get; set; } = default!;

        public DbSet<Quiz> Quiz { get; set; } = default!;
        public DbSet<Attempt> Attempt { get; set; } = default!;
        public DbSet<AttemptChoice> AttemptChoice { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Attempt>()
                .Property(b => b.Created)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Attempt>()
                .HasOne(e => e.Quiz)
                .WithMany(e => e.Attempts)
                .HasForeignKey(e => e.QuizId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AttemptChoice>()
                .HasOne(e => e.Attempt)
                .WithMany()
                .HasForeignKey(e => e.AttemptId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AttemptChoice>()
                .HasOne(e => e.Choice)
                .WithMany()
                .HasForeignKey(e => e.ChoiceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
