﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToddlerScan.Data;

namespace ToddlerScan.Data.Migrations
{
    [DbContext(typeof(ToddlerScanContext))]
    [Migration("20190806080117_addedFluentApi")]
    partial class addedFluentApi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToddlerScan.Domain.Scan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("TeacherId");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.ToTable("Scans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Middagpauze",
                            TeacherId = 1,
                            TripId = 1
                        });
                });

            modelBuilder.Entity("ToddlerScan.Domain.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Kris",
                            LastName = "Hermans"
                        });
                });

            modelBuilder.Entity("ToddlerScan.Domain.Toddler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Grade");

                    b.Property<string>("LastName");

                    b.Property<int?>("TripId");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Toddlers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Kevin",
                            Grade = "3",
                            LastName = "Traets"
                        });
                });

            modelBuilder.Entity("ToddlerScan.Domain.ToddlerScan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ScanId");

                    b.Property<int>("ToddlerId");

                    b.HasKey("Id");

                    b.HasIndex("ScanId");

                    b.HasIndex("ToddlerId");

                    b.ToTable("ToddlerScans");
                });

            modelBuilder.Entity("ToddlerScan.Domain.ToddlerTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ToddlerId");

                    b.Property<int>("TripId");

                    b.HasKey("Id");

                    b.HasIndex("ToddlerId");

                    b.HasIndex("TripId");

                    b.ToTable("ToddlerTrips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ToddlerId = 1,
                            TripId = 1
                        });
                });

            modelBuilder.Entity("ToddlerScan.Domain.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("TeacherId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2019, 8, 6, 10, 1, 16, 239, DateTimeKind.Local).AddTicks(7683),
                            TeacherId = 1,
                            Title = "Zee"
                        });
                });

            modelBuilder.Entity("ToddlerScan.Domain.Toddler", b =>
                {
                    b.HasOne("ToddlerScan.Domain.Trip")
                        .WithMany("Toddlers")
                        .HasForeignKey("TripId");
                });

            modelBuilder.Entity("ToddlerScan.Domain.ToddlerScan", b =>
                {
                    b.HasOne("ToddlerScan.Domain.Scan")
                        .WithMany("ToddlerScans")
                        .HasForeignKey("ScanId");

                    b.HasOne("ToddlerScan.Domain.Toddler", "Toddler")
                        .WithMany()
                        .HasForeignKey("ToddlerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToddlerScan.Domain.ToddlerTrip", b =>
                {
                    b.HasOne("ToddlerScan.Domain.Toddler", "Toddler")
                        .WithMany()
                        .HasForeignKey("ToddlerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ToddlerScan.Domain.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToddlerScan.Domain.Trip", b =>
                {
                    b.HasOne("ToddlerScan.Domain.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}