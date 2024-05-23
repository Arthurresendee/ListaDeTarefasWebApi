using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaParaFazer.Migrations
{
    /// <inheritdoc />
    public partial class alteraçãoemalgunscampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Realizada",
                table: "TB_Tarefas",
                type: "BIT",
                nullable: true,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicial",
                table: "TB_Tarefas",
                type: "SMALLDATETIME",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 23, 14, 38, 4, 618, DateTimeKind.Utc).AddTicks(4494),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 22, 12, 4, 36, 310, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinal",
                table: "TB_Tarefas",
                type: "SMALLDATETIME",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 24, 14, 38, 4, 618, DateTimeKind.Utc).AddTicks(4755),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Realizada",
                table: "TB_Tarefas",
                type: "BIT",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "BIT",
                oldNullable: true,
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicial",
                table: "TB_Tarefas",
                type: "SMALLDATETIME",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 22, 12, 4, 36, 310, DateTimeKind.Utc).AddTicks(2533),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 23, 14, 38, 4, 618, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinal",
                table: "TB_Tarefas",
                type: "SMALLDATETIME",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 24, 14, 38, 4, 618, DateTimeKind.Utc).AddTicks(4755));
        }
    }
}
