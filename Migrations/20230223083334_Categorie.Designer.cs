﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_MPD.Data;

#nullable disable

namespace Proiect_MPD.Migrations
{
    [DbContext(typeof(Proiect_MPDContext))]
    [Migration("20230223083334_Categorie")]
    partial class Categorie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Proiect_MPD.Models.Overview", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("CategorieID")
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

                    b.ToTable("Overview");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Overview", b =>
                {
                    b.HasOne("Proiect_MPD.Models.Categorie", "Categorie")
                        .WithMany("overviews")
                        .HasForeignKey("CategorieID");

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("Proiect_MPD.Models.Categorie", b =>
                {
                    b.Navigation("overviews");
                });
#pragma warning restore 612, 618
        }
    }
}
