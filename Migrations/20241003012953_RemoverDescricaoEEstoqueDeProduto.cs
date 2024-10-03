using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DsiVendas.Migrations
{
    /// <inheritdoc />
    public partial class RemoverDescricaoEEstoqueDeProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Estoque",
                table: "Produtos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estoque",
                table: "Produtos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
