using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fornecedores.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    EstadoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiglaEstado = table.Column<string>(maxLength: 2, nullable: false),
                    DescricaoEstado = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EstadoId = table.Column<int>(nullable: false),
                    NomeFantasia = table.Column<string>(maxLength: 255, nullable: false),
                    CNPJ = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.EmpresaId);
                    table.ForeignKey(
                        name: "FK_Empresa_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmpresaId = table.Column<int>(nullable: false),
                    NomeFornecedor = table.Column<string>(maxLength: 255, nullable: false),
                    CPF_CNPJ = table.Column<string>(maxLength: 20, nullable: false),
                    RG = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    PessoaFisica = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.FornecedorId);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    TelefoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroTelefone = table.Column<string>(maxLength: 20, nullable: false),
                    FornecedorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.TelefoneId);
                    table.ForeignKey(
                        name: "FK_Telefone_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "EstadoId", "DescricaoEstado", "SiglaEstado" },
                values: new object[,]
                {
                    { 1, "Acre", "AC" },
                    { 25, "Sergipe", "SE" },
                    { 24, "São Paulo", "SP" },
                    { 23, "Santa Catarina", "SC" },
                    { 22, "Roraima", "RR" },
                    { 21, "Rondônia", "RO" },
                    { 20, "Rio Grande do Sul", "RS" },
                    { 19, "Rio Grande do Norte", "RN" },
                    { 18, "Rio de Janeiro", "RJ" },
                    { 17, "Piauí", "PI" },
                    { 16, "Pernambuco", "PE" },
                    { 15, "Paraná", "PR" },
                    { 26, "Tocantins", "TO" },
                    { 14, "Paraíba", "PB" },
                    { 12, "Minas Gerais", "MG" },
                    { 11, "Mato Grosso do Sul", "MS" },
                    { 10, "Mato Grosso", "MT" },
                    { 9, "Maranhão", "MA" },
                    { 8, "Goiás", "GO" },
                    { 7, "Espirito Santo", "ES" },
                    { 6, "Ceará", "CE" },
                    { 5, "Bahia", "BA" },
                    { 4, "Amazonas", "AM" },
                    { 3, "Amapá", "AP" },
                    { 2, "Alagoas", "AL" },
                    { 13, "Pará", "PA" },
                    { 27, "Distrito Federal", "DF" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EstadoId",
                table: "Empresa",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_EmpresaId",
                table: "Fornecedor",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_FornecedorId",
                table: "Telefone",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
