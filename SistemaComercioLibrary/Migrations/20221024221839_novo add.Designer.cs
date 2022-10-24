﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SistemaComercioLibrary.Persistence.Context;

namespace SistemaComercioLibrary.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20221024221839_novo add")]
    partial class novoadd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SistemaComercioBiblioteca.Classes.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<double>("Preco")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.Property<int>("Quantidade_Estoque")
                        .HasColumnType("integer")
                        .HasMaxLength(255);

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<double>("Saldo")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Caixa");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("character varying(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("character varying(18)")
                        .HasMaxLength(18);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasMaxLength(4);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("character varying(13)")
                        .HasMaxLength(13);

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(255);

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("integer");

                    b.Property<string>("Situacao_Compra")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<double>("Total_Compra")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaPagar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data_Lancamento")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(10);

                    b.Property<DateTime>("Data_Pagamento")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(10);

                    b.Property<DateTime>("Data_Vencimento")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(10);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Id_Fornecedor")
                        .HasColumnType("integer");

                    b.Property<double>("Pago")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.Property<double>("Valor")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.Property<double>("Valor_Pagamento")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_Fornecedor");

                    b.ToTable("ContaPagar");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaReceber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data_Lancamento")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(10);

                    b.Property<DateTime>("Data_Recebimento")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(10);

                    b.Property<DateTime>("Data_Vencimento")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(10);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("integer");

                    b.Property<double>("Recebido")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.Property<double>("Valor")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.Property<double>("Valor_Recebimento")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("ContaReceber");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.FormaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("character varying(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Cpf_Cnpj")
                        .IsRequired()
                        .HasColumnType("character varying(18)")
                        .HasMaxLength(18);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("character varying(4)")
                        .HasMaxLength(4);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("character varying(13)")
                        .HasMaxLength(13);

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.MovimentoCaixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data_Movimento")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(10);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("Hora_Movimento")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(5);

                    b.Property<int>("Id_Caixa")
                        .HasColumnType("integer");

                    b.Property<string>("Tipo_Movimento")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<double>("Valor")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_Caixa");

                    b.ToTable("MovimentoCaixa");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(10);

                    b.Property<DateTime>("Hora")
                        .HasColumnType("timestamp without time zone")
                        .HasMaxLength(5);

                    b.Property<int>("Id_Cliente")
                        .HasColumnType("integer");

                    b.Property<string>("Situacao_Venda")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<double>("Total_Venda")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_Cliente");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.Adm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Adm");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.FormaPagamentoVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id_FormaPagamento")
                        .HasColumnType("integer");

                    b.Property<int>("Id_Venda")
                        .HasColumnType("integer");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_FormaPagamento");

                    b.HasIndex("Id_Venda");

                    b.ToTable("FormaPagamentoVenda");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id_Compra")
                        .HasColumnType("integer");

                    b.Property<int>("Id_Produto")
                        .HasColumnType("integer");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer")
                        .HasMaxLength(255);

                    b.Property<double>("Total_Item")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.Property<double>("Valor_Unitario")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_Compra");

                    b.HasIndex("Id_Produto");

                    b.ToTable("ItemCompra");
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemVenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id_Produto")
                        .HasColumnType("integer");

                    b.Property<int>("Id_Venda")
                        .HasColumnType("integer");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer")
                        .HasMaxLength(255);

                    b.Property<double>("Total_Item")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.Property<double>("Valor_Unitario")
                        .HasColumnType("double precision")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Id_Produto");

                    b.HasIndex("Id_Venda");

                    b.ToTable("ItemVenda");
                });

            modelBuilder.Entity("SistemaComercioBiblioteca.Classes.Produto", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("Produto")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Compra", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("Compra")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaPagar", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Fornecedor", "Fornecedor")
                        .WithMany("ContaPagar")
                        .HasForeignKey("Id_Fornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.ContaReceber", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Cliente", "Cliente")
                        .WithMany("ContaReceber")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.MovimentoCaixa", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Caixa", "Caixa")
                        .WithMany("MovimentoCaixa")
                        .HasForeignKey("Id_Caixa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Classes.Venda", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Cliente", "Cliente")
                        .WithMany("Venda")
                        .HasForeignKey("Id_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.FormaPagamentoVenda", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.FormaPagamento", "FormaPagamento")
                        .WithMany("FormaPagamentoVenda")
                        .HasForeignKey("Id_FormaPagamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioLibrary.Classes.Venda", "Venda")
                        .WithMany("FormaPagamentoVenda")
                        .HasForeignKey("Id_Venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemCompra", b =>
                {
                    b.HasOne("SistemaComercioLibrary.Classes.Compra", "Compra")
                        .WithMany("ItemCompra")
                        .HasForeignKey("Id_Compra")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioBiblioteca.Classes.Produto", "Produto")
                        .WithMany("ItemCompra")
                        .HasForeignKey("Id_Produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SistemaComercioLibrary.Entity.ItemVenda", b =>
                {
                    b.HasOne("SistemaComercioBiblioteca.Classes.Produto", "Produto")
                        .WithMany("ItemVenda")
                        .HasForeignKey("Id_Produto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaComercioLibrary.Classes.Venda", "Venda")
                        .WithMany("ItemVenda")
                        .HasForeignKey("Id_Venda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
