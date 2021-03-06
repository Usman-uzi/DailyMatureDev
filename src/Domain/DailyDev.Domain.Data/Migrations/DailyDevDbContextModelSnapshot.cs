﻿// <auto-generated />
using DailyDev.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DailyDev.Domain.Data.Migrations
{
    [DbContext(typeof(DailyDevDbContext))]
    partial class DailyDevDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wrapt Dev",
                            Priority = 1,
                            Url = "https://wrapt.dev/feed.xml"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Codeopinion",
                            Priority = 1,
                            Url = "https://codeopinion.com/feed/"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dev Blogs",
                            Priority = 1,
                            Url = "https://devblogs.microsoft.com/dotnet/feed/"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Developers Redhat",
                            Priority = 1,
                            Url = "https://developers.redhat.com/blog/feed/"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Rehansaeed",
                            Priority = 1,
                            Url = "https://rehansaeed.com/rss.xml"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Red Gate",
                            Priority = 1,
                            Url = "https://www.red-gate.com/simple-talk/feed/"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Channel 9",
                            Priority = 1,
                            Url = "https://s.ch9.ms/Feeds/RSS"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Rick Strahl",
                            Priority = 1,
                            Url = "http://feeds.feedburner.com/rickstrahl"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Lizzy Gallagher",
                            Priority = 1,
                            Url = "https://lizzy-gallagher.github.io/feed.xml"
                        },
                        new
                        {
                            Id = 11,
                            Name = "AzureTipsAndTricks",
                            Priority = 1,
                            Url = "https://microsoft.github.io/AzureTipsAndTricks/rss.xml"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Haacked",
                            Priority = 1,
                            Url = "http://feeds.haacked.com/haacked"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Diogo Monica",
                            Priority = 1,
                            Url = "https://feedly.com/i/subscription/feed%2Fhttps%3A%2F%2Fdiogomonica.com%2Frss%2F"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Andrewlock",
                            Priority = 1,
                            Url = "https://andrewlock.net/rss.xml"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Aspnetmonsters",
                            Priority = 1,
                            Url = "https://www.aspnetmonsters.com/atom.xml"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Dusted",
                            Priority = 1,
                            Url = "https://dusted.codes/feed/rss"
                        },
                        new
                        {
                            Id = 17,
                            Name = "TroyHunt",
                            Priority = 1,
                            Url = "https://feeds.feedburner.com/TroyHunt"
                        });
                });

            modelBuilder.Entity("DailyDev.Domain.Models.TempLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("FeedPostId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TempLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
