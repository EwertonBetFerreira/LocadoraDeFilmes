using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoLocadoraRepository.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ListaFilmes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPFCliente = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    DataLocacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacoes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Filmes",
                columns: new[] { "Id", "Ativo", "DataCriacao", "Genero", "Nome" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 30, 18, 25, 31, 24, DateTimeKind.Local).AddTicks(3118), "Terror", "Filme1" },
                    { 2, 1, new DateTime(2021, 5, 30, 18, 25, 31, 25, DateTimeKind.Local).AddTicks(5303), "Comedia", "Filme2" },
                    { 3, 0, new DateTime(2021, 5, 30, 18, 25, 31, 25, DateTimeKind.Local).AddTicks(5321), "Aventura", "Filme3" },
                    { 4, 0, new DateTime(2021, 5, 30, 18, 25, 31, 25, DateTimeKind.Local).AddTicks(5323), "Ficcao", "Filme4" },
                    { 5, 1, new DateTime(2021, 5, 30, 18, 25, 31, 25, DateTimeKind.Local).AddTicks(5325), "Romance", "Filme5" }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "Id", "Ativo", "DataCriacao", "Nome" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 5, 30, 18, 25, 31, 26, DateTimeKind.Local).AddTicks(8794), "Terror" },
                    { 2, 1, new DateTime(2021, 5, 30, 18, 25, 31, 26, DateTimeKind.Local).AddTicks(9502), "Comedia" },
                    { 3, 0, new DateTime(2021, 5, 30, 18, 25, 31, 26, DateTimeKind.Local).AddTicks(9508), "Aventura" },
                    { 4, 0, new DateTime(2021, 5, 30, 18, 25, 31, 26, DateTimeKind.Local).AddTicks(9510), "Ficcao" },
                    { 5, 1, new DateTime(2021, 5, 30, 18, 25, 31, 26, DateTimeKind.Local).AddTicks(9512), "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Locacoes",
                columns: new[] { "Id", "CPFCliente", "DataLocacao", "ListaFilmes" },
                values: new object[,]
                {
                    { 1, "69874521830", new DateTime(2021, 5, 30, 18, 25, 31, 27, DateTimeKind.Local).AddTicks(1003), "Filme 1, Filme 2, Filme 3" },
                    { 2, "12457865420", new DateTime(2021, 5, 30, 18, 25, 31, 27, DateTimeKind.Local).AddTicks(1359), "Filme 1" },
                    { 3, "98563258741", new DateTime(2021, 5, 30, 18, 25, 31, 27, DateTimeKind.Local).AddTicks(1364), "Filme 2, Filme 3" },
                    { 4, "98633365792", new DateTime(2021, 5, 30, 18, 25, 31, 27, DateTimeKind.Local).AddTicks(1366), "Filme 3" },
                    { 5, "11478569831", new DateTime(2021, 5, 30, 18, 25, 31, 27, DateTimeKind.Local).AddTicks(1367), "Filme 5, Filme 6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Locacoes");
        }
    }
}
