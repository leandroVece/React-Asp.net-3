﻿// <auto-generated />
using System;
using Cadeteria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cadeteria.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230809155404_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Cadeteria.Models.CadetesPedido", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("pedidoForeingKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("userForeingKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("pedidoForeingKey")
                        .IsUnique();

                    b.HasIndex("userForeingKey");

                    b.ToTable("cadetePedido", (string)null);
                });

            modelBuilder.Entity("Cadeteria.Models.Historial", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("profileForeingKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("userForeingKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.ToTable("historial", (string)null);
                });

            modelBuilder.Entity("Cadeteria.Models.Pedido", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteForeingKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Obs")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.HasIndex("ClienteForeingKey");

                    b.ToTable("pedido", (string)null);

                    b.HasData(
                        new
                        {
                            id = new Guid("adc4aba6-b2b6-4ca6-a715-e563987fd02e"),
                            ClienteForeingKey = new Guid("0a9fa564-0604-4dfa-88df-3636fe395678"),
                            Estado = "Pendiente",
                            Obs = "Coca"
                        });
                });

            modelBuilder.Entity("Cadeteria.Models.Profile", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("userForeiKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("userForeiKey")
                        .IsUnique();

                    b.ToTable("perfil", (string)null);

                    b.HasData(
                        new
                        {
                            id = new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc0"),
                            Direccion = "Entre rios",
                            Nombre = "Jaun Castellanos",
                            Telefono = "231321231",
                            userForeiKey = new Guid("e0bd0d60-7ff8-43a6-b78b-8dc67780c8c9")
                        },
                        new
                        {
                            id = new Guid("0a9fa564-0604-4dfa-88df-3636fe395651"),
                            Direccion = "independencia",
                            Nombre = "Ana Hume",
                            Telefono = "231321231",
                            userForeiKey = new Guid("2d58f017-e038-4efa-acc1-f5f9e2d08668")
                        },
                        new
                        {
                            id = new Guid("0a9fa564-0604-4dfa-88df-3636fe395678"),
                            Direccion = "independencia",
                            Nombre = "Fer Hume",
                            Telefono = "654321",
                            userForeiKey = new Guid("07899a8d-bc7f-46d4-8d23-b174203f8bb0")
                        },
                        new
                        {
                            id = new Guid("e04a530d-f4bb-4ff1-898f-b3c00160dc28"),
                            Direccion = "corrientes",
                            Nombre = "Pancho Estrada",
                            Telefono = "654321",
                            userForeiKey = new Guid("36126fee-fee7-4d62-a22e-959feb2dd013")
                        },
                        new
                        {
                            id = new Guid("910381a0-3a65-4ab9-9929-44faca09b567"),
                            Direccion = "cordoba",
                            Nombre = "Chichu Han",
                            Telefono = "654321",
                            userForeiKey = new Guid("df0efb73-de14-4140-bbd0-c357148d89d1")
                        },
                        new
                        {
                            id = new Guid("b140ee23-f61b-45a7-8ef0-177d5c76a317"),
                            Direccion = "italia",
                            Nombre = "Jessy Jade",
                            Telefono = "654321",
                            userForeiKey = new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328")
                        },
                        new
                        {
                            id = new Guid("4978a844-a5d3-4d32-86e9-7046eefddea2"),
                            Direccion = "Entre rios",
                            Nombre = "Jaun Antonio",
                            Telefono = "231321231",
                            userForeiKey = new Guid("19ccc667-10c5-47b7-abd0-bae699c1cd3e")
                        },
                        new
                        {
                            id = new Guid("e41d99f0-2afd-4c25-b677-514bcf897f6b"),
                            Direccion = "independencia",
                            Nombre = "Ana Pradera",
                            Telefono = "231321231",
                            userForeiKey = new Guid("afaa31d8-013f-4dee-b21a-f9d03278d26a")
                        },
                        new
                        {
                            id = new Guid("2544db67-7dd3-4a16-99ec-7f1451c00558"),
                            Direccion = "independencia",
                            Nombre = "Fer Nanda",
                            Telefono = "654321",
                            userForeiKey = new Guid("c9d6ff8f-82ac-4eef-80df-de4999c4bb45")
                        });
                });

            modelBuilder.Entity("Cadeteria.Models.Rol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("rolName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("7aafd6fb-612e-42c7-99db-cbec0fdad96f"),
                            rolName = "admin"
                        },
                        new
                        {
                            Id = new Guid("7a86db69-1474-4d92-a18e-91899d876c92"),
                            rolName = "cadete"
                        },
                        new
                        {
                            Id = new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"),
                            rolName = "cliente"
                        });
                });

            modelBuilder.Entity("Cadeteria.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<Guid>("rolForeikey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("rolForeikey");

                    b.ToTable("usuario", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328"),
                            password = "$2a$11$T5rUVZFgJyb/o6dj3F9NOeXuXRtAZ4FsmdDLtqvu0Ayfo0GQVKnUa",
                            rolForeikey = new Guid("7aafd6fb-612e-42c7-99db-cbec0fdad96f"),
                            userName = "admin"
                        },
                        new
                        {
                            Id = new Guid("df0efb73-de14-4140-bbd0-c357148d89d1"),
                            password = "$2a$11$L6PufPT7k4iKmF6u67bGwuFU5zVh.CxLS5bnRGCpN61gqykVi6nOS",
                            rolForeikey = new Guid("7a86db69-1474-4d92-a18e-91899d876c92"),
                            userName = "cadete"
                        },
                        new
                        {
                            Id = new Guid("36126fee-fee7-4d62-a22e-959feb2dd013"),
                            password = "$2a$11$7Ha8bJkbuKfU7G1TdIn0peRQZ0zV3q9rX85482n2PmeViSirK45OG",
                            rolForeikey = new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"),
                            userName = "cliente"
                        },
                        new
                        {
                            Id = new Guid("19ccc667-10c5-47b7-abd0-bae699c1cd3e"),
                            password = "$2a$11$Udh9Sr54ndt1IkwwcHCSpO1so9IZQdn6LocFXahv1hhRJsKz24oai",
                            rolForeikey = new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"),
                            userName = "cliente"
                        },
                        new
                        {
                            Id = new Guid("afaa31d8-013f-4dee-b21a-f9d03278d26a"),
                            password = "$2a$11$xk56VQcpwSdb.8VXMupbr.ljnuv9NiLweBYZ07vhnUOTaJOvtrVC.",
                            rolForeikey = new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"),
                            userName = "cliente2"
                        },
                        new
                        {
                            Id = new Guid("c9d6ff8f-82ac-4eef-80df-de4999c4bb45"),
                            password = "$2a$11$9BIdiMH/8U5peOHfQ0yrGeF55u5o/2YckSSjRlkYM4Q7I/jGka.LS",
                            rolForeikey = new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"),
                            userName = "cliente3"
                        },
                        new
                        {
                            Id = new Guid("07899a8d-bc7f-46d4-8d23-b174203f8bb0"),
                            password = "$2a$11$mXme/2ZowWZhmO1lZ1aZV.e8nifG/YEkSktmaiOfhLRsOOESTplMm",
                            rolForeikey = new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"),
                            userName = "cliente2"
                        },
                        new
                        {
                            Id = new Guid("2d58f017-e038-4efa-acc1-f5f9e2d08668"),
                            password = "$2a$11$8wampa97jrBt/kMYa0MlEO8K8aqbSUiLOZdD5aHvEPISIFUp.5DhW",
                            rolForeikey = new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"),
                            userName = "cliente3"
                        },
                        new
                        {
                            Id = new Guid("e0bd0d60-7ff8-43a6-b78b-8dc67780c8c9"),
                            password = "$2a$11$kui6mIKWXyjRdC3e1IA0kOhtjxjjMJm.O0Y16ORT/XNQ9XYtM0oKu",
                            rolForeikey = new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"),
                            userName = "cadete2"
                        });
                });

            modelBuilder.Entity("Cadeteria.Models.CadetesPedido", b =>
                {
                    b.HasOne("Cadeteria.Models.Pedido", "Pedido")
                        .WithOne("Cadp")
                        .HasForeignKey("Cadeteria.Models.CadetesPedido", "pedidoForeingKey")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Cadeteria.Models.User", "Cadete")
                        .WithMany("Cadp")
                        .HasForeignKey("userForeingKey")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cadete");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Cadeteria.Models.Pedido", b =>
                {
                    b.HasOne("Cadeteria.Models.Profile", "Cliente")
                        .WithMany("listaPedido")
                        .HasForeignKey("ClienteForeingKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Cadeteria.Models.Profile", b =>
                {
                    b.HasOne("Cadeteria.Models.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Cadeteria.Models.Profile", "userForeiKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cadeteria.Models.User", b =>
                {
                    b.HasOne("Cadeteria.Models.Rol", "Rol")
                        .WithMany("User")
                        .HasForeignKey("rolForeikey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Cadeteria.Models.Pedido", b =>
                {
                    b.Navigation("Cadp");
                });

            modelBuilder.Entity("Cadeteria.Models.Profile", b =>
                {
                    b.Navigation("listaPedido");
                });

            modelBuilder.Entity("Cadeteria.Models.Rol", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("Cadeteria.Models.User", b =>
                {
                    b.Navigation("Cadp");

                    b.Navigation("Profile");
                });
#pragma warning restore 612, 618
        }
    }
}
