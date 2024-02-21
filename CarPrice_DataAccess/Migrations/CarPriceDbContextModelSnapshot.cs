﻿// <auto-generated />
using System;
using CarPrice_Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarPrice_DataAccess.Migrations
{
    [DbContext(typeof(CarPriceDbContext))]
    partial class CarPriceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarPrice_DataAccess.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CarBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Carozzeria")
                        .HasColumnType("int");

                    b.Property<Guid>("EngineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MilageGroup")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProdYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EngineId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarPrice_DataAccess.Entities.Engine", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("CarPrice_DataAccess.Entities.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvgPrice")
                        .HasColumnType("int");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("MaxPrice")
                        .HasColumnType("int");

                    b.Property<int>("MedianPrice")
                        .HasColumnType("int");

                    b.Property<int>("MinPrice")
                        .HasColumnType("int");

                    b.Property<int>("OffersNuber")
                        .HasColumnType("int");

                    b.Property<int>("Voivoidship")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("CarPrice_DataAccess.Entities.Car", b =>
                {
                    b.HasOne("CarPrice_DataAccess.Entities.Engine", "Engine")
                        .WithMany("Cars")
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engine");
                });

            modelBuilder.Entity("CarPrice_DataAccess.Entities.Record", b =>
                {
                    b.HasOne("CarPrice_DataAccess.Entities.Car", "Car")
                        .WithMany("Records")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarPrice_DataAccess.Entities.Car", b =>
                {
                    b.Navigation("Records");
                });

            modelBuilder.Entity("CarPrice_DataAccess.Entities.Engine", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
