﻿// <auto-generated />
using System;
using DevInCar.API.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevInCar.API.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DevInCar.API.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DevInCar.API.Models.Vehicle", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BuyerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChassisNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoorsNumber")
                        .HasColumnType("int");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<int?>("LoadingCapacity")
                        .HasColumnType("int");

                    b.Property<string>("ManufacturingDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Potency")
                        .HasColumnType("float");

                    b.Property<string>("SaleDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.Property<int>("WheelsNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = "cr_6abc0222-15fa-4dde-8c4e-376b07c7c207",
                            ChassisNumber = "e7170357-f505-453b-bca6-2d6f0044a372",
                            Color = "Prata",
                            DoorsNumber = 4,
                            FuelType = 3,
                            ManufacturingDate = "01-01-2013",
                            Name = "Punto",
                            PlateNumber = "XPT-0000",
                            Potency = 130.0,
                            SaleDate = "",
                            Status = true,
                            Value = 38000.0,
                            VehicleType = 3,
                            WheelsNumber = 4
                        },
                        new
                        {
                            Id = "cr_4e9549f8-a131-43b9-9929-3707a160ab7b",
                            ChassisNumber = "6ebfb808-3f8e-4f24-a1f8-2baaab7e71db",
                            Color = "Preto",
                            DoorsNumber = 4,
                            FuelType = 3,
                            ManufacturingDate = "01-01-2018",
                            Name = "Prisma",
                            PlateNumber = "XPT-1111",
                            Potency = 180.0,
                            SaleDate = "",
                            Status = true,
                            Value = 42000.0,
                            VehicleType = 3,
                            WheelsNumber = 4
                        },
                        new
                        {
                            Id = "cr_fd63fd17-715f-4d34-a8c8-3b3894a1bf6d",
                            ChassisNumber = "c2b18dd3-16dc-47fb-a9f1-2263e4bce272",
                            Color = "Branco",
                            DoorsNumber = 4,
                            FuelType = 3,
                            ManufacturingDate = "01-01-2022",
                            Name = "Creta",
                            PlateNumber = "XPT-2222",
                            Potency = 130.0,
                            SaleDate = "",
                            Status = true,
                            Value = 150000.0,
                            VehicleType = 3,
                            WheelsNumber = 4
                        },
                        new
                        {
                            Id = "mt_ffa94f17-de67-4e00-9f59-b2e49e0c322b",
                            ChassisNumber = "d9251edf-fc7a-41c9-b7c7-f585d90bb1c1",
                            Color = "Branca",
                            FuelType = 1,
                            ManufacturingDate = "01-01-2020",
                            Name = "CG Titan",
                            PlateNumber = "TOP-0666",
                            Potency = 180.0,
                            SaleDate = "",
                            Status = true,
                            Value = 13000.0,
                            VehicleType = 1,
                            WheelsNumber = 2
                        },
                        new
                        {
                            Id = "mt_fe9fbd92-1b72-4816-92fc-8510a3ab2699",
                            ChassisNumber = "97f27931-c34e-43e2-b4d5-25fdaa7fa354",
                            Color = "Branca",
                            FuelType = 1,
                            ManufacturingDate = "01-01-2020",
                            Name = "Fazer",
                            PlateNumber = "TOP-0777",
                            Potency = 180.0,
                            SaleDate = "",
                            Status = true,
                            Value = 13000.0,
                            VehicleType = 1,
                            WheelsNumber = 2
                        },
                        new
                        {
                            Id = "mt_6f94b6e1-428c-4a2a-945b-3138905663d3",
                            ChassisNumber = "688ed208-c289-4d7a-988d-2b95f024a51d",
                            Color = "Vinho",
                            FuelType = 1,
                            ManufacturingDate = "01-01-1994",
                            Name = "750 Four",
                            PlateNumber = "TOP-0999",
                            Potency = 750.0,
                            SaleDate = "",
                            Status = true,
                            Value = 42000.0,
                            VehicleType = 1,
                            WheelsNumber = 2
                        },
                        new
                        {
                            Id = "tk_a10ad5bd-0b99-4ff5-955b-7c1bcb9f8bdd",
                            ChassisNumber = "ee211485-bb5c-4d07-945b-a769d2f7e974",
                            Color = "Preto",
                            DoorsNumber = 4,
                            FuelType = 2,
                            LoadingCapacity = 1000,
                            ManufacturingDate = "01-01-2018",
                            Name = "Hilux",
                            PlateNumber = "ABC-1234",
                            Potency = 450.0,
                            SaleDate = "",
                            Status = true,
                            Value = 80000.0,
                            VehicleType = 4,
                            WheelsNumber = 4
                        },
                        new
                        {
                            Id = "tk_3018749b-b7e7-44f4-9230-761bc67d9c29",
                            ChassisNumber = "9d759744-dab0-45d1-8be3-a0f4612907f1",
                            Color = "Preto",
                            DoorsNumber = 4,
                            FuelType = 2,
                            LoadingCapacity = 2500,
                            ManufacturingDate = "01-01-2009",
                            Name = "F1000",
                            PlateNumber = "ABC-4323",
                            Potency = 800.0,
                            SaleDate = "",
                            Status = true,
                            Value = 70000.0,
                            VehicleType = 4,
                            WheelsNumber = 4
                        },
                        new
                        {
                            Id = "tk_1ec9b454-41aa-4b73-be20-a34038f63133",
                            ChassisNumber = "2e0d419d-4929-4d25-b090-67284e1cc955",
                            Color = "Preto",
                            DoorsNumber = 4,
                            FuelType = 1,
                            LoadingCapacity = 2500,
                            ManufacturingDate = "01-01-2012",
                            Name = "Montana",
                            PlateNumber = "ABC-4341",
                            Potency = 250.0,
                            SaleDate = "",
                            Status = true,
                            Value = 35000.0,
                            VehicleType = 4,
                            WheelsNumber = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
