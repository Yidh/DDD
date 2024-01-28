﻿// <auto-generated />
using System;
using HotelDDD.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelDDD.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240108110913_UpdateSchema")]
    partial class UpdateSchema
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelDDD.Domain.Customer.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("HotelDDD.Domain.Room.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Amenities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Room", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d6cee7cf-5a30-4677-b9bb-48718da0b959"),
                            Amenities = "Lit 1 place,Wifi,TV",
                            PricePerNight = 50m,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("e37e480d-8c2c-4b39-9a16-d2c072065a65"),
                            Amenities = "Lit 2 places,Wifi,TV écran plat,Minibar,Climatiseur",
                            PricePerNight = 100m,
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("9b99f7d9-a951-4710-ac66-b421ce93484f"),
                            Amenities = "Lit 2 places,Wifi,TV écran plat,Minibar,Climatiseur,Baignoire,Terrasse",
                            PricePerNight = 200m,
                            Type = 2
                        });
                });

            modelBuilder.Entity("HotelDDD.Domain.Wallet.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PreferredCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Id");

                    b.ToTable("Wallet", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
