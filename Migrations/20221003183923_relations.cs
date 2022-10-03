using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DarpinosPizzaria.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pizzas",
                newName: "PizzaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cardapios",
                newName: "CardapioId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Clientes");

            migrationBuilder.RenameColumn(
                name: "PizzaId",
                table: "Pizzas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CardapioId",
                table: "Cardapios",
                newName: "Id");
        }
    }
}
