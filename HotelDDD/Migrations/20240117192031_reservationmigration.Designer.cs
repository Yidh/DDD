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
    [Migration("20240117192031_reservationmigration")]
    partial class reservationmigration
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

            modelBuilder.Entity("HotelDDD.Domain.Reservation.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reservation", (string)null);
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
                            Id = new Guid("7f0df708-e5de-4407-aa70-06f4b90d6246"),
                            Amenities = "Lit 1 place,Wifi,TV",
                            PricePerNight = 50m,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("514bc58c-3ee1-426e-bfe2-20c6df502383"),
                            Amenities = "Lit 2 places,Wifi,TV écran plat,Minibar,Climatiseur",
                            PricePerNight = 100m,
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("e346ceb3-5c86-4892-8c57-4458ee3d1ca5"),
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
