﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebMovie.Data;

#nullable disable

namespace WebMovie.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebMovie.Models.Director", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("NameId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("MovieId", "NameId");

                    b.HasIndex("NameId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("WebMovie.Models.KnownFor", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("NameId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("MovieId", "NameId");

                    b.HasIndex("NameId");

                    b.ToTable("KnownFor");
                });

            modelBuilder.Entity("WebMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("EndYear")
                        .HasColumnType("date");

                    b.Property<string>("EnglishTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RuntimeMinutes")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartYear")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("WebMovie.Models.Name", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthYear")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DeathYear")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Names");
                });

            modelBuilder.Entity("WebMovie.Models.Producer", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("NameId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("MovieId", "NameId");

                    b.HasIndex("NameId");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("WebMovie.Models.Profession", b =>
                {
                    b.Property<int>("NameId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("MovieProfession")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("NameId", "MovieProfession");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("WebMovie.Models.Role", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("NameId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId", "NameId");

                    b.HasIndex("NameId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebMovie.Models.Writer", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("NameId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.HasKey("MovieId", "NameId");

                    b.HasIndex("NameId");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("WebMovie.Models.Director", b =>
                {
                    b.HasOne("WebMovie.Models.Movie", "Movie")
                        .WithMany("Directors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMovie.Models.Name", "Name")
                        .WithMany("Directors")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("WebMovie.Models.KnownFor", b =>
                {
                    b.HasOne("WebMovie.Models.Movie", "Movie")
                        .WithMany("KnownFor")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMovie.Models.Name", "Name")
                        .WithMany("KnownFor")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("WebMovie.Models.Producer", b =>
                {
                    b.HasOne("WebMovie.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMovie.Models.Name", "Name")
                        .WithMany()
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("WebMovie.Models.Profession", b =>
                {
                    b.HasOne("WebMovie.Models.Name", "Name")
                        .WithMany("Professions")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Name");
                });

            modelBuilder.Entity("WebMovie.Models.Role", b =>
                {
                    b.HasOne("WebMovie.Models.Movie", "Movie")
                        .WithMany("Roles")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMovie.Models.Name", "Name")
                        .WithMany("Roles")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("WebMovie.Models.Writer", b =>
                {
                    b.HasOne("WebMovie.Models.Movie", "Movie")
                        .WithMany("Writers")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMovie.Models.Name", "Name")
                        .WithMany("Writers")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("WebMovie.Models.Movie", b =>
                {
                    b.Navigation("Directors");

                    b.Navigation("KnownFor");

                    b.Navigation("Roles");

                    b.Navigation("Writers");
                });

            modelBuilder.Entity("WebMovie.Models.Name", b =>
                {
                    b.Navigation("Directors");

                    b.Navigation("KnownFor");

                    b.Navigation("Professions");

                    b.Navigation("Roles");

                    b.Navigation("Writers");
                });
#pragma warning restore 612, 618
        }
    }
}
