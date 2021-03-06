﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaginaDeCadastro.Models;

namespace PaginaDeCadastro.Migrations
{
    [DbContext(typeof(PaginaDeCadastroContext))]
    partial class PaginaDeCadastroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PaginaDeCadastro.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CidadeNat")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("EstadoNat")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<int>("Idade");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("NomePai")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
