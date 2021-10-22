using Microsoft.EntityFrameworkCore;
using RegistrationFormAPI.Entities;

namespace RegistrationFormAPI.Data
{

    public class DataContext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionAnswer>()
                .HasKey(bc => new { bc.QuestionId, bc.AnswerId });
            modelBuilder.Entity<Registration>()
                .HasMany(r => r.QuestionAnswers);
        }
    }
}
