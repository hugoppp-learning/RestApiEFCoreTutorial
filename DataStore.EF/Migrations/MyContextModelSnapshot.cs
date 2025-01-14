﻿// <auto-generated />
using DataStore.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataStore.EF.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DataStore.EF.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Title = "project 1"
                        },
                        new
                        {
                            ProjectId = 2,
                            Title = "project 2"
                        });
                });

            modelBuilder.Entity("DataStore.EF.Models.Ticket", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<int>("TicketId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ProjectId", "TicketId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            TicketId = 1,
                            Description = "Lorem",
                            Title = "ticket 1"
                        },
                        new
                        {
                            ProjectId = 1,
                            TicketId = 2,
                            Description = "ipsum",
                            Title = "ticket 2"
                        },
                        new
                        {
                            ProjectId = 1,
                            TicketId = 3,
                            Title = "ticket 3"
                        },
                        new
                        {
                            ProjectId = 2,
                            TicketId = 1,
                            Title = "ticket 4"
                        },
                        new
                        {
                            ProjectId = 2,
                            TicketId = 2,
                            Title = "ticket 5"
                        });
                });

            modelBuilder.Entity("DataStore.EF.Models.Ticket", b =>
                {
                    b.HasOne("DataStore.EF.Models.Project", "Project")
                        .WithMany("Tickets")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("DataStore.EF.Models.Project", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
