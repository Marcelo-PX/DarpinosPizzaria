using Microsoft.EntityFrameworkCore.Migrations;

namespace DarpinosPizzaria.Migrations
{
    public partial class relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Cardapios_CardapioId",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CardapioId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CardapioId",
                table: "Pizzas");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Cardapios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "Cardapios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cardapios_ClienteId",
                table: "Cardapios",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Cardapios_PizzaId",
                table: "Cardapios",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cardapios_Clientes_ClienteId",
                table: "Cardapios",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cardapios_Pizzas_PizzaId",
                table: "Cardapios",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cardapios_Clientes_ClienteId",
                table: "Cardapios");

            migrationBuilder.DropForeignKey(
                name: "FK_Cardapios_Pizzas_PizzaId",
                table: "Cardapios");

            migrationBuilder.DropIndex(
                name: "IX_Cardapios_ClienteId",
                table: "Cardapios");

            migrationBuilder.DropIndex(
                name: "IX_Cardapios_PizzaId",
                table: "Cardapios");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Cardapios");

            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Cardapios");

            migrationBuilder.AddColumn<int>(
                name: "CardapioId",
                table: "Pizzas",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CardapioId",
                table: "Pizzas",
                column: "CardapioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Cardapios_CardapioId",
                table: "Pizzas",
                column: "CardapioId",
                principalTable: "Cardapios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
