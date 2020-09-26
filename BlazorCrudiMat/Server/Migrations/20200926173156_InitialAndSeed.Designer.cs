﻿// <auto-generated />
using BlazorCrudiMat.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorCrudiMat.Server.Migrations
{
    [DbContext(typeof(Baza))]
    [Migration("20200926173156_InitialAndSeed")]
    partial class InitialAndSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorCrudiMat.Shared.Osoba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Broj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PObox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Osobas");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            Broj = "356",
                            Grad = "asd",
                            Ime = "Pera",
                            PObox = "234",
                            Prezime = "Peric",
                            Ulica = "zklj"
                        },
                        new
                        {
                            ID = -2,
                            Broj = "87",
                            Grad = "zxc",
                            Ime = "Neko",
                            PObox = "567",
                            Prezime = "Nekic",
                            Ulica = "kjhg"
                        },
                        new
                        {
                            ID = -3,
                            Broj = "Neki tamo",
                            Grad = "aefesf",
                            Ime = "Zkljjj",
                            PObox = "233000",
                            Prezime = "Blabla",
                            Ulica = "Neka tamo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
