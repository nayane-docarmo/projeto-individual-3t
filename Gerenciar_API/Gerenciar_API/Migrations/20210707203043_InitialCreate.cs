using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gerenciar_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSerie = table.Column<int>(type: "int", nullable: false),
                    NPatrimonio = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Andar = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Metragem = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Setor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sala_Equipamentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSala = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEquipamento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusG = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala_Equipamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sala_Equipamentos_Equipamentos_IdEquipamento",
                        column: x => x.IdEquipamento,
                        principalTable: "Equipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sala_Equipamentos_Salas_IdSala",
                        column: x => x.IdSala,
                        principalTable: "Salas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sala_Equipamentos_IdEquipamento",
                table: "Sala_Equipamentos",
                column: "IdEquipamento");

            migrationBuilder.CreateIndex(
                name: "IX_Sala_Equipamentos_IdSala",
                table: "Sala_Equipamentos",
                column: "IdSala");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sala_Equipamentos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
