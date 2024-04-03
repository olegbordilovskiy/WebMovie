using Microsoft.EntityFrameworkCore;
using WebMovie.Models;

namespace WebMovie.Data
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Name> Names { get; set; }
		public DbSet<Director> Directors { get; set; }
		public DbSet<KnownFor> KnownFors { get; set; }
		public DbSet<Writer> Writers { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Producer> Producers { get; set; }
		public DbSet<Profession> Professions { get; set; }
		public DbSet<Rating> Ratings { get; set; }

		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//         modelBuilder.Entity<Director>().HasKey(d => new { d.MovieId, d.NameId });
			//         modelBuilder.Entity<Director>().HasOne(d => d.Movie).WithMany(m => m.Directors).HasForeignKey(d => d.MovieId);
			//         modelBuilder.Entity<Director>().HasOne(d => d.Name).WithMany(n => n.Directors).HasForeignKey(d => d.NameId);

			//         modelBuilder.Entity<KnownFor>().HasKey(kf => new {kf.MovieId, kf.NameId});
			//modelBuilder.Entity<KnownFor>().HasOne(kf => kf.Movie).WithMany(m => m.KnownFors).HasForeignKey(kf => kf.MovieId);
			//modelBuilder.Entity<KnownFor>().HasOne(kf => kf.Name).WithMany(n => n.KnownFors).HasForeignKey(kf => kf.NameId);

			//modelBuilder.Entity<Writer>().HasKey(w => new { w.MovieId, w.NameId });
			//modelBuilder.Entity<Writer>().HasOne(w => w.Movie).WithMany(m => m.Writers).HasForeignKey(w => w.MovieId);
			//modelBuilder.Entity<Writer>().HasOne(w => w.Name).WithMany(n => n.Writers).HasForeignKey(w => w.NameId);

			//modelBuilder.Entity<Role>().HasKey(r => new { r.MovieId, r.NameId });
			//modelBuilder.Entity<Role>().HasOne(r => r.Movie).WithMany(m => m.Roles).HasForeignKey(r => r.MovieId);
			//modelBuilder.Entity<Role>().HasOne(r => r.Name).WithMany(n => n.Roles).HasForeignKey(r => r.NameId);

			//modelBuilder.Entity<Producer>().HasKey(p => new { p.MovieId, p.NameId });
			//modelBuilder.Entity<Producer>().HasOne(p => p.Movie).WithMany(m => m.Producers).HasForeignKey(p => p.MovieId);
			//modelBuilder.Entity<Producer>().HasOne(p => p.Name).WithMany(n => n.Producers).HasForeignKey(p => p.NameId);

			//modelBuilder.Entity<Profession>().HasKey(p => new { p.NameId, p.MovieProfession });
			//         modelBuilder.Entity<Profession>().HasOne(p => p.Name).WithMany(n => n.Professions).HasForeignKey(p => p.NameId);

			//         modelBuilder.Entity<Rating>().HasKey(r => r.MovieId);
			//         modelBuilder.Entity<Rating>().HasOne(r => r.Movie).WithOne(m => m.Rating).HasForeignKey<Movie>( m => m.Rating);



			//modelBuilder.Entity<Movie>().HasKey(m => new { m.Id });

			//modelBuilder.Entity<Name>().HasKey(n => new { n.Id });





			base.OnModelCreating(modelBuilder);
		}


	}
}
