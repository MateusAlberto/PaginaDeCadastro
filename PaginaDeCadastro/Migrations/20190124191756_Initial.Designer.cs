﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaginaDeCadastro.Models;

namespace PaginaDeCadastro.Migrations
{
    [DbContext(typeof(PaginaDeCadastroContext))]
    [Migration("20190124191756_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CidadeNac");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("EstadoNac");

                    b.Property<int>("Idade");

                    b.Property<string>("Naturalidade");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeMae");

                    b.Property<string>("NomePai");

                    b.Property<string>("Sobrenome");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
