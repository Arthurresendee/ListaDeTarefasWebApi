using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaParaFazer.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParaFazer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: true),
                    DiasParaRealizar = table.Column<int>(type: "INTEGER", nullable: false),
                    DataInicial = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Realizada = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParaFazer", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParaFazer");
        }
    }
}
