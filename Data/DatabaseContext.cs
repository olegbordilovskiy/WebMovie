using Microsoft.EntityFrameworkCore;
using WebMovie.Models;

namespace WebMovie.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Names> Names { get; set; }
        public DbSet<Directors> Directors { get; set; }
        public DbSet<KnownFor> KnownFor { get; set; }
        public DbSet<Writers> Writers { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Producers> Producers { get; set; }
        public DbSet<Professions> Professions{ get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Directors>().HasKey(d => new { d.MovieId, d.NameId });

            modelBuilder.Entity<Directors>().HasOne(d => d.Movie).WithMany(m => m.Directors).HasForeignKey(d => d.MovieId);
            modelBuilder.Entity<Directors>().HasOne(d => d.Name).WithMany(n => n.Directors).HasForeignKey(d => d.NameId);

            base.OnModelCreating(modelBuilder);
        }


    }
}
