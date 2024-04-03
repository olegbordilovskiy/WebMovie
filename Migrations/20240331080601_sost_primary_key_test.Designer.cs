﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebMovie.Data;

#nullable disable

namespace WebMovie.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240331080601_sost_primary_key_test")]
    partial class sost_primary_key_test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebMovie.Models.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("NameId");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("WebMovie.Models.KnownFor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("NameId");

                    b.ToTable("KnownFors");
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

                    b.Property<int>("EndYear")
                        .HasColumnType("int");

                    b.Property<string>("EnglishTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MPAA")
                        .HasColumnType("int");

                    b.Property<string>("PosterImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RuntimeMinutes")
                        .HasColumnType("int");

                    b.Property<int>("StartYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("WebMovie.Models.Name", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BirthYear")
                        .HasColumnType("int");

                    b.Property<int?>("DeathYear")
                        .HasColumnType("int");

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("NameId");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("WebMovie.Models.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieProfession")
                        .HasColumnType("int");

                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NameId");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("WebMovie.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AverageRating")
                        .HasColumnType("decimal(2, 1)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("VotesNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("WebMovie.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

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
                        .WithMany("KnownFors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMovie.Models.Name", "Name")
                        .WithMany("KnownFors")
                        .HasForeignKey("NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("WebMovie.Models.Producer", b =>
                {
                    b.HasOne("WebMovie.Models.Movie", "Movie")
                        .WithMany("Producers")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebMovie.Models.Name", "Name")
                        .WithMany("Producers")
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

            modelBuilder.Entity("WebMovie.Models.Rating", b =>
                {
                    b.HasOne("WebMovie.Models.Movie", "Movie")
                        .WithOne("Rating")
                        .HasForeignKey("WebMovie.Models.Rating", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
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

                    b.Navigation("KnownFors");

                    b.Navigation("Producers");

                    b.Navigation("Rating")
                        .IsRequired();

                    b.Navigation("Roles");

                    b.Navigation("Writers");
                });

            modelBuilder.Entity("WebMovie.Models.Name", b =>
                {
                    b.Navigation("Directors");

                    b.Navigation("KnownFors");

                    b.Navigation("Producers");

                    b.Navigation("Professions");

                    b.Navigation("Roles");

                    b.Navigation("Writers");
                });
#pragma warning restore 612, 618
        }
    }
}
