﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(TiendaContext))]
    partial class TiendaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.Property<string>("CodEstado")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("CodPais")
                        .HasColumnType("longtext");

                    b.Property<string>("IdPais")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreEstado")
                        .HasColumnType("longtext");

                    b.Property<string>("PaisCodPais")
                        .HasColumnType("varchar(255)");

                    b.HasKey("CodEstado");

                    b.HasIndex("PaisCodPais");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Property<string>("CodPais")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombrePais")
                        .HasColumnType("longtext");

                    b.HasKey("CodPais");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.Property<string>("IdPersona")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ApellidosPersona")
                        .HasColumnType("longtext");

                    b.Property<string>("EmailPersona")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdRegion")
                        .HasColumnType("longtext");

                    b.Property<int?>("IdTipoPersona")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .HasColumnType("longtext");

                    b.Property<string>("RegionCodRegion")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("TipoPersonaId")
                        .HasColumnType("int");

                    b.HasKey("IdPersona");

                    b.HasIndex("EmailPersona")
                        .IsUnique();

                    b.HasIndex("RegionCodRegion");

                    b.HasIndex("TipoPersonaId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Core.Entities.PersonaProducto", b =>
                {
                    b.Property<string>("IdPersona")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("IdPersona", "IdProducto");

                    b.HasIndex("ProductoId");

                    b.ToTable("PersonaProductos");
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Core.Entities.Region", b =>
                {
                    b.Property<string>("CodRegion")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("EstadoCodEstado")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdEstado")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreRegion")
                        .HasColumnType("longtext");

                    b.HasKey("CodRegion");

                    b.HasIndex("EstadoCodEstado");

                    b.ToTable("Regiones");
                });

            modelBuilder.Entity("Core.Entities.TipoPersona", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoPersonas");
                });

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.HasOne("Core.Entities.Pais", "Pais")
                        .WithMany("Estados")
                        .HasForeignKey("PaisCodPais");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.HasOne("Core.Entities.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionCodRegion");

                    b.HasOne("Core.Entities.TipoPersona", "TipoPersona")
                        .WithMany()
                        .HasForeignKey("TipoPersonaId");

                    b.Navigation("Region");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Core.Entities.PersonaProducto", b =>
                {
                    b.HasOne("Core.Entities.Persona", "Persona")
                        .WithMany()
                        .HasForeignKey("IdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId");

                    b.Navigation("Persona");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Core.Entities.Region", b =>
                {
                    b.HasOne("Core.Entities.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoCodEstado");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Navigation("Estados");
                });
#pragma warning restore 612, 618
        }
    }
}
