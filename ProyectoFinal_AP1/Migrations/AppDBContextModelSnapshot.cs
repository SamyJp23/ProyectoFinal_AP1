﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal_AP1.DAL;

#nullable disable

namespace ProyectoFinal_AP1.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoFinal_AP1.Models.Entrenador", b =>
                {
                    b.Property<int>("IdEntrenador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEntrenador"));

                    b.Property<byte[]>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEntrenador");

                    b.ToTable("Entrenadores");
                });

            modelBuilder.Entity("ProyectoFinal_AP1.Models.Suscripcion", b =>
                {
                    b.Property<int>("IdSuscripcion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSuscripcion"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("IdEntrenador")
                        .HasColumnType("int");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.HasKey("IdSuscripcion");

                    b.HasIndex("IdEntrenador");

                    b.ToTable("Suscripciones");
                });

            modelBuilder.Entity("ProyectoFinal_AP1.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<byte[]>("FotoPerfil")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdSuscripcion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdSuscripcion")
                        .IsUnique()
                        .HasFilter("[IdSuscripcion] IS NOT NULL");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoFinal_AP1.Models.Suscripcion", b =>
                {
                    b.HasOne("ProyectoFinal_AP1.Models.Entrenador", "Entrenador")
                        .WithMany()
                        .HasForeignKey("IdEntrenador");

                    b.Navigation("Entrenador");
                });

            modelBuilder.Entity("ProyectoFinal_AP1.Models.Usuario", b =>
                {
                    b.HasOne("ProyectoFinal_AP1.Models.Suscripcion", "Suscripcion")
                        .WithOne()
                        .HasForeignKey("ProyectoFinal_AP1.Models.Usuario", "IdSuscripcion");

                    b.Navigation("Suscripcion");
                });
#pragma warning restore 612, 618
        }
    }
}
