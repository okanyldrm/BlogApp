﻿// <auto-generated />
using BlogApp.DataAccess.Concrete.EntitiyFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlogApp.DataAccess.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20201123202508_AddedFirstMigration")]
    partial class AddedFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.Concrete.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Four")
                        .HasColumnType("text");

                    b.Property<string>("One")
                        .HasColumnType("text");

                    b.Property<string>("Three")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Title2")
                        .HasColumnType("text");

                    b.Property<string>("Title2Content")
                        .HasColumnType("text");

                    b.Property<string>("Title3")
                        .HasColumnType("text");

                    b.Property<string>("Title3Content")
                        .HasColumnType("text");

                    b.Property<string>("Title4")
                        .HasColumnType("text");

                    b.Property<string>("Title4Content")
                        .HasColumnType("text");

                    b.Property<string>("Two")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });
#pragma warning restore 612, 618
        }
    }
}