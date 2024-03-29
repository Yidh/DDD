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
    [Migration("20240104145448_MiseAJourDuModeleCustomerAjoutdeWallet")]
    partial class MiseAJourDuModeleCustomerAjoutdeWallet
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
                            Id = new Guid("cd6181dd-dc43-4865-b84d-a141251df6ec"),
                            Amenities = "Lit 1 place,Wifi,TV",
                            PricePerNight = 50m,
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("cec37761-7d07-4f02-9c05-0ad460a4d10a"),
                            Amenities = "Lit 2 places,Wifi,TV écran plat,Minibar,Climatiseur",
                            PricePerNight = 100m,
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("bd98b734-c46e-45be-ab21-2606da92b9dd"),
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

                    b.Property<int>("PreferredCurrency")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Wallet", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
