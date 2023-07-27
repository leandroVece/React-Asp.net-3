using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadeteria.Migrations
{
    public partial class initail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cadete",
                columns: table => new
                {
                    Id_cadete = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadete", x => x.Id_cadete);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id_cliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "cadeteCliente",
                columns: table => new
                {
                    Id_cadClient = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CadeteForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadeteCliente", x => x.Id_cadClient);
                    table.ForeignKey(
                        name: "FK_cadeteCliente_cadete_CadeteForeingKey",
                        column: x => x.CadeteForeingKey,
                        principalTable: "cadete",
                        principalColumn: "Id_cadete",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cadeteCliente_cliente_ClienteForeingKey",
                        column: x => x.ClienteForeingKey,
                        principalTable: "cliente",
                        principalColumn: "Id_cliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    Id_pedido = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.Id_pedido);
                    table.ForeignKey(
                        name: "FK_pedido_cliente_ClienteForeingKey",
                        column: x => x.ClienteForeingKey,
                        principalTable: "cliente",
                        principalColumn: "Id_cliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cadete",
                columns: new[] { "Id_cadete", "Direccion", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { new Guid("0a9fa564-0604-4dfa-88df-3636fe395651"), "independencia", "Ana Hume", "231321231" },
                    { new Guid("0a9fa564-0604-4dfa-88df-3636fe395678"), "independencia", "Fer Hume", "654321" },
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc0"), "Entre rios", "Jaun Castellanos", "231321231" }
                });

            migrationBuilder.InsertData(
                table: "cliente",
                columns: new[] { "Id_cliente", "Direccion", "Nombre", "Referencia", "Telefono" },
                values: new object[,]
                {
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc1"), "independencia", "Lucio Hume", null, "8321156" },
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc3"), "Entre rios", "Pancho Castellanos", null, "5231234" },
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc5"), "independencia", "Val Hume", null, "975313" }
                });

            migrationBuilder.InsertData(
                table: "pedido",
                columns: new[] { "Id_pedido", "ClienteForeingKey", "Estado", "Obs" },
                values: new object[] { new Guid("adc4aba6-b2b6-4ca6-a715-e563987fd02e"), new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc3"), "Pendiente", "Coca" });

            migrationBuilder.CreateIndex(
                name: "IX_cadeteCliente_CadeteForeingKey",
                table: "cadeteCliente",
                column: "CadeteForeingKey");

            migrationBuilder.CreateIndex(
                name: "IX_cadeteCliente_ClienteForeingKey",
                table: "cadeteCliente",
                column: "ClienteForeingKey");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_ClienteForeingKey",
                table: "pedido",
                column: "ClienteForeingKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cadeteCliente");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "cadete");

            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
