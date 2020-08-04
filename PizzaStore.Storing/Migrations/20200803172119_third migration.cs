using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaStore.Storing.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderModelId",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderModelId",
                table: "Pizzas",
                column: "OrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Orders_OrderModelId",
                table: "Pizzas",
                column: "OrderModelId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Orders_OrderModelId",
                table: "Pizzas");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_OrderModelId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "Pizzas");
        }
    }
}
