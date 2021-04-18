﻿// <auto-generated />
using System;
using DataAcess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAcess.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20210418221447_teste1")]
    partial class teste1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DataAcess.Model.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("DataAcess.Model.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .HasColumnType("text");

                    b.Property<string>("Tipo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("DataAcess.Model.EntradaSaida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("TotalValor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("EntradaSaidas");
                });

            modelBuilder.Entity("DataAcess.Model.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("DataAcess.Model.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("CodigoBarras")
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<int>("EstoqueMaximo")
                        .HasColumnType("int");

                    b.Property<int>("EstoqueMinimo")
                        .HasColumnType("int");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("TipoUnitarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("TipoUnitarioId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("DataAcess.Model.TipoUnitario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("TipoUnitarios");
                });

            modelBuilder.Entity("DataAcess.Model.EntradaSaida", b =>
                {
                    b.HasOne("DataAcess.Model.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAcess.Model.Produto", b =>
                {
                    b.HasOne("DataAcess.Model.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAcess.Model.Fornecedor", "fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAcess.Model.TipoUnitario", "tipoUnitario")
                        .WithMany()
                        .HasForeignKey("TipoUnitarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}