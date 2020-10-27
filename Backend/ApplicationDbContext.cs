using Backend.Entities;
using Microsoft.EntityFrameworkCore;



namespace Backend
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Seminar> Seminars { get; set; }
        public DbSet<UserSeminar> userSeminars { get; set; }


        /*public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Backend;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserSeminar>().HasKey(sc => new { sc.userId, sc.seminarId });
        }
    }
}
