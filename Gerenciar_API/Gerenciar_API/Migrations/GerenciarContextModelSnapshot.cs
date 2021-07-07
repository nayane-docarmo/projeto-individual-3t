﻿// <auto-generated />
using System;
using API_Gerenciar.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gerenciar_API.Migrations
{
    [DbContext(typeof(GerenciarContext))]
    partial class GerenciarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gerenciar_API.Domains.Equipamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NPatrimonio")
                        .HasColumnType("int");

                    b.Property<int>("NSerie")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("Gerenciar_API.Domains.Sala", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Andar")
                        .HasColumnType("int");

                    b.Property<float>("Metragem")
                        .HasColumnType("real");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("Gerenciar_API.Domains.Sala_Equipamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdEquipamento")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSala")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("StatusG")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipamento");

                    b.HasIndex("IdSala");

                    b.ToTable("Sala_Equipamentos");
                });

            modelBuilder.Entity("Gerenciar_API.Domains.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Gerenciar_API.Domains.Sala_Equipamento", b =>
                {
                    b.HasOne("Gerenciar_API.Domains.Equipamento", "Equipamento")
                        .WithMany()
                        .HasForeignKey("IdEquipamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gerenciar_API.Domains.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("IdSala")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipamento");

                    b.Navigation("Sala");
                });
#pragma warning restore 612, 618
        }
    }
}
