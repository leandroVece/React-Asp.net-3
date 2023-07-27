using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadeteria.Migrations
{
    public partial class cadpedAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cadetePedido",
                columns: table => new
                {
                    Id_cadPed = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CadeteForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PedidoForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadetePedido", x => x.Id_cadPed);
                    table.ForeignKey(
                        name: "FK_cadetePedido_cadete_CadeteForeingKey",
                        column: x => x.CadeteForeingKey,
                        principalTable: "cadete",
                        principalColumn: "Id_cadete",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cadetePedido_pedido_PedidoForeingKey",
                        column: x => x.PedidoForeingKey,
                        principalTable: "pedido",
                        principalColumn: "Id_pedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cadetePedido_CadeteForeingKey",
                table: "cadetePedido",
                column: "CadeteForeingKey");

            migrationBuilder.CreateIndex(
                name: "IX_cadetePedido_PedidoForeingKey",
                table: "cadetePedido",
                column: "PedidoForeingKey",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cadetePedido");
        }
    }
}
