using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcess.Migrations
{
    public partial class Initial02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Empresa",
                table: "Fornecedores");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Produtos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Fornecedores",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Fornecedores");

            migrationBuilder.AddColumn<string>(
                name: "Empresa",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
