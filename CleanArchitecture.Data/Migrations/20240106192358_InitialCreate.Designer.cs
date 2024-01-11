﻿// <auto-generated />
using System;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    [DbContext(typeof(PGSQLDbContext))]
    [Migration("20240106192358_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.Agenda", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<long>("PropiedadId")
                        .HasColumnType("bigint");

                    b.Property<long>("TipoEstadoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("fecha_fin")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fecha_inicio")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("fecha_registro")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("PropiedadId");

                    b.HasIndex("TipoEstadoId");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.Ciudad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<long>("PaisId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.DetalleServicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("PropiedadId")
                        .HasColumnType("bigint");

                    b.Property<long>("ServicioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PropiedadId");

                    b.HasIndex("ServicioId");

                    b.ToTable("DetalleServicio");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.Pais", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.Propiedad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<long?>("CiudadId")
                        .HasColumnType("bigint");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<long?>("TipoproPiedadId")
                        .HasColumnType("bigint");

                    b.Property<bool>("esverificado")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.HasIndex("TipoproPiedadId");

                    b.ToTable("Propiedad");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.ReglasCasa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<long>("PropiedadId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PropiedadId");

                    b.ToTable("ReglasCasa");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.Servicio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.TipoEstado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TipoEstado");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.TipoPropiedad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<long>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TipoPropidad");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.Agenda", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Propiedad.Propiedad", "Propiedad")
                        .WithMany()
                        .HasForeignKey("PropiedadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitecture.Domain.Models.Propiedad.TipoEstado", "TipoEstado")
                        .WithMany()
                        .HasForeignKey("TipoEstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propiedad");

                    b.Navigation("TipoEstado");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.Ciudad", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Propiedad.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.DetalleServicio", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Propiedad.Propiedad", "Propiedad")
                        .WithMany()
                        .HasForeignKey("PropiedadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitecture.Domain.Models.Propiedad.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("ServicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propiedad");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.Propiedad", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Propiedad.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId");

                    b.HasOne("CleanArchitecture.Domain.Models.Propiedad.TipoPropiedad", "TipoPropiedad")
                        .WithMany()
                        .HasForeignKey("TipoproPiedadId");

                    b.Navigation("Ciudad");

                    b.Navigation("TipoPropiedad");
                });

            modelBuilder.Entity("CleanArchitecture.Domain.Models.Propiedad.ReglasCasa", b =>
                {
                    b.HasOne("CleanArchitecture.Domain.Models.Propiedad.Propiedad", "Propiedad")
                        .WithMany()
                        .HasForeignKey("PropiedadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propiedad");
                });
#pragma warning restore 612, 618
        }
    }
}
