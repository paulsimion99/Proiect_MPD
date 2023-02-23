﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_MPD.Data;

#nullable disable

namespace Proiect_MPD.Migrations
{
    [DbContext(typeof(Proiect_MPDContext))]
    partial class Proiect_MPDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect_MPD.Models.Categorie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategorieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Cursa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CursaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Cursa");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Locatie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("LocatieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Locatie");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Overview", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CategorieID")
                        .HasColumnType("int");

                    b.Property<int?>("CursaID")
                        .HasColumnType("int");

                    b.Property<int?>("LocatieID")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Varsta")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CategorieID");

                    b.HasIndex("CursaID");

                    b.HasIndex("LocatieID");

                    b.ToTable("Overview");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Overview", b =>
                {
                    b.HasOne("Proiect_MPD.Models.Categorie", "Categorie")
                        .WithMany("overviews")
                        .HasForeignKey("CategorieID");

                    b.HasOne("Proiect_MPD.Models.Cursa", "Cursa")
                        .WithMany("Overviews")
                        .HasForeignKey("CursaID");

                    b.HasOne("Proiect_MPD.Models.Locatie", "Locatie")
                        .WithMany("Overviews")
                        .HasForeignKey("LocatieID");

                    b.Navigation("Categorie");

                    b.Navigation("Cursa");

                    b.Navigation("Locatie");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Categorie", b =>
                {
                    b.Navigation("overviews");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Cursa", b =>
                {
                    b.Navigation("Overviews");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Locatie", b =>
                {
                    b.Navigation("Overviews");
                });
#pragma warning restore 612, 618
        }
    }
}
