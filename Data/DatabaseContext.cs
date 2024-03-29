﻿using Microsoft.EntityFrameworkCore;
using WebMovie.Models;

namespace WebMovie.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<KnownFor> KnownFor { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Profession> Professions{ get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasKey(d => new { d.MovieId, d.NameId });

            modelBuilder.Entity<Director>().HasOne(d => d.Movie).WithMany(m => m.Directors).HasForeignKey(d => d.MovieId);
            modelBuilder.Entity<Director>().HasOne(d => d.Name).WithMany(n => n.Directors).HasForeignKey(d => d.NameId);

            modelBuilder.Entity<KnownFor>().HasKey(kf => new {kf.MovieId, kf.NameId});

            modelBuilder.Entity<Producer>().HasKey(p => new { p.MovieId, p.NameId });

            modelBuilder.Entity<Movie>().HasKey(m => new {m.Id});

            modelBuilder.Entity<Name>().HasKey(n => new { n.Id });

            modelBuilder.Entity<Profession>().HasKey(p => new { p.NameId , p.MovieProfession});

            modelBuilder.Entity<Role>().HasKey(r => new { r.MovieId, r.NameId });

            modelBuilder.Entity<Writer>().HasKey(w => new { w.MovieId, w.NameId });

            base.OnModelCreating(modelBuilder);
        }


    }
}
