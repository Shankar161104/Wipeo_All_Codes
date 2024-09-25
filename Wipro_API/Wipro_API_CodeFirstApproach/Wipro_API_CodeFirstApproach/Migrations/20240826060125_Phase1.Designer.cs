﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wipro_API_CodeFirstApproach.Entity_Framework;

#nullable disable

namespace Wipro_API_CodeFirstApproach.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240826060125_Phase1")]
    partial class Phase1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Wipro_API_CodeFirstApproach.Model.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleID"));

                    b.Property<string>("VehicleBrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VehicleColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VehicleDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleManufactureYear")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("VehicleMileage")
                        .HasColumnType("int");

                    b.Property<string>("VehicleModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehiclePrice")
                        .HasColumnType("int");

                    b.Property<string>("VehicleRegistNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleID");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}