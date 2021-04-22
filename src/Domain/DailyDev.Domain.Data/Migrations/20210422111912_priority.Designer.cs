﻿// <auto-generated />
using DailyDev.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DailyDev.Domain.Data.Migrations
{
    [DbContext(typeof(DailyDevDbContext))]
    [Migration("20210422111912_priority")]
    partial class priority
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("DailyDev.Domain.Models.SiteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SiteModels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Code Maze",
                            Priority = 1,
                            Url = "https://code-maze.com/feed/"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
