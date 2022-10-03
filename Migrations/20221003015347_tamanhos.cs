using Microsoft.EntityFrameworkCore.Migrations;

namespace DarpinosPizzaria.Migrations
{
    public partial class tamanhos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tamanho",
                table: "Pizzas");

            migrationBuilder.AddColumn<string>(
                name: "Tamanho",
                table: "Cardapios",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tamanho",
                table: "Cardapios");

            migrationBuilder.AddColumn<string>(
                name: "Tamanho",
                table: "Pizzas",
                type: "TEXT",
                nullable: true);
        }
    }
}
