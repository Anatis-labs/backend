using Backend.Entities;
using Microsoft.EntityFrameworkCore;


namespace Backend
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Seminar> Seminars { get; set; }


        /*public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SignToSeminar;Trusted_Connection=True;");
        }
    }
}
