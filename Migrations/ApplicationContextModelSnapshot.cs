﻿// <auto-generated />
using System;
using Fornecedores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fornecedores.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fornecedores.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("EstadoId");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("EmpresaId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Fornecedores.Models.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoEstado")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("SiglaEstado")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("EstadoId");

                    b.ToTable("Estado");

                    b.HasData(
                        new { EstadoId = 1, DescricaoEstado = "Acre", SiglaEstado = "AC" },
                        new { EstadoId = 2, DescricaoEstado = "Alagoas", SiglaEstado = "AL" },
                        new { EstadoId = 3, DescricaoEstado = "Amapá", SiglaEstado = "AP" },
                        new { EstadoId = 4, DescricaoEstado = "Amazonas", SiglaEstado = "AM" },
                        new { EstadoId = 5, DescricaoEstado = "Bahia", SiglaEstado = "BA" },
                        new { EstadoId = 6, DescricaoEstado = "Ceará", SiglaEstado = "CE" },
                        new { EstadoId = 7, DescricaoEstado = "Espirito Santo", SiglaEstado = "ES" },
                        new { EstadoId = 8, DescricaoEstado = "Goiás", SiglaEstado = "GO" },
                        new { EstadoId = 9, DescricaoEstado = "Maranhão", SiglaEstado = "MA" },
                        new { EstadoId = 10, DescricaoEstado = "Mato Grosso", SiglaEstado = "MT" },
                        new { EstadoId = 11, DescricaoEstado = "Mato Grosso do Sul", SiglaEstado = "MS" },
                        new { EstadoId = 12, DescricaoEstado = "Minas Gerais", SiglaEstado = "MG" },
                        new { EstadoId = 13, DescricaoEstado = "Pará", SiglaEstado = "PA" },
                        new { EstadoId = 14, DescricaoEstado = "Paraíba", SiglaEstado = "PB" },
                        new { EstadoId = 15, DescricaoEstado = "Paraná", SiglaEstado = "PR" },
                        new { EstadoId = 16, DescricaoEstado = "Pernambuco", SiglaEstado = "PE" },
                        new { EstadoId = 17, DescricaoEstado = "Piauí", SiglaEstado = "PI" },
                        new { EstadoId = 18, DescricaoEstado = "Rio de Janeiro", SiglaEstado = "RJ" },
                        new { EstadoId = 19, DescricaoEstado = "Rio Grande do Norte", SiglaEstado = "RN" },
                        new { EstadoId = 20, DescricaoEstado = "Rio Grande do Sul", SiglaEstado = "RS" },
                        new { EstadoId = 21, DescricaoEstado = "Rondônia", SiglaEstado = "RO" },
                        new { EstadoId = 22, DescricaoEstado = "Roraima", SiglaEstado = "RR" },
                        new { EstadoId = 23, DescricaoEstado = "Santa Catarina", SiglaEstado = "SC" },
                        new { EstadoId = 24, DescricaoEstado = "São Paulo", SiglaEstado = "SP" },
                        new { EstadoId = 25, DescricaoEstado = "Sergipe", SiglaEstado = "SE" },
                        new { EstadoId = 26, DescricaoEstado = "Tocantins", SiglaEstado = "TO" },
                        new { EstadoId = 27, DescricaoEstado = "Distrito Federal", SiglaEstado = "DF" }
                    );
                });

            modelBuilder.Entity("Fornecedores.Models.Fornecedor", b =>
                {
                    b.Property<int>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF_CNPJ")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<DateTime>("DataInclusao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("NomeFornecedor")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("PessoaFisica");

                    b.Property<string>("RG");

                    b.HasKey("FornecedorId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Fornecedores.Models.Telefone", b =>
                {
                    b.Property<int>("TelefoneId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FornecedorId");

                    b.Property<string>("NumeroTelefone")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("TelefoneId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("Fornecedores.Models.Empresa", b =>
                {
                    b.HasOne("Fornecedores.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fornecedores.Models.Fornecedor", b =>
                {
                    b.HasOne("Fornecedores.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fornecedores.Models.Telefone", b =>
                {
                    b.HasOne("Fornecedores.Models.Fornecedor")
                        .WithMany("Telefones")
                        .HasForeignKey("FornecedorId");
                });
#pragma warning restore 612, 618
        }
    }
}
