using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaParaFazer.Migrations
{
    /// <inheritdoc />
    public partial class ConfigurantoMapeamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParaFazer",
                table: "ParaFazer");

            migrationBuilder.RenameTable(
                name: "ParaFazer",
                newName: "TB_Tarefas");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TB_Tarefas",
                type: "nvarchar",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<bool>(
                name: "Realizada",
                table: "TB_Tarefas",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DiasParaRealizar",
                table: "TB_Tarefas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "TB_Tarefas",
                type: "nvarchar",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicial",
                table: "TB_Tarefas",
                type: "SMALLDATETIME",
                nullable: true,
                defaultValue: new DateTime(2024, 5, 22, 12, 4, 36, 310, DateTimeKind.Utc).AddTicks(2533),
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinal",
                table: "TB_Tarefas",
                type: "SMALLDATETIME",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Tarefas",
                table: "TB_Tarefas",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Tarefas",
                table: "TB_Tarefas");

            migrationBuilder.RenameTable(
                name: "TB_Tarefas",
                newName: "ParaFazer");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "ParaFazer",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Realizada",
                table: "ParaFazer",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AlterColumn<int>(
                name: "DiasParaRealizar",
                table: "ParaFazer",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ParaFazer",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInicial",
                table: "ParaFazer",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldNullable: true,
                oldDefaultValue: new DateTime(2024, 5, 22, 12, 4, 36, 310, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinal",
                table: "ParaFazer",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParaFazer",
                table: "ParaFazer",
                column: "Id");
        }
    }
}
