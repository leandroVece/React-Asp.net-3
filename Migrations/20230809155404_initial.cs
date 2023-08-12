using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadeteria.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "historial",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    profileForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historial", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rolName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    rolForeikey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    password = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_usuario_rol_rolForeikey",
                        column: x => x.rolForeikey,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "perfil",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userForeiKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfil", x => x.id);
                    table.ForeignKey(
                        name: "FK_perfil_usuario_userForeiKey",
                        column: x => x.userForeiKey,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_pedido_perfil_ClienteForeingKey",
                        column: x => x.ClienteForeingKey,
                        principalTable: "perfil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cadetePedido",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    pedidoForeingKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadetePedido", x => x.id);
                    table.ForeignKey(
                        name: "FK_cadetePedido_pedido_pedidoForeingKey",
                        column: x => x.pedidoForeingKey,
                        principalTable: "pedido",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cadetePedido_usuario_userForeingKey",
                        column: x => x.userForeingKey,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "Id", "rolName" },
                values: new object[] { new Guid("7a86db69-1474-4d92-a18e-91899d876c92"), "cadete" });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "Id", "rolName" },
                values: new object[] { new Guid("7aafd6fb-612e-42c7-99db-cbec0fdad96f"), "admin" });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "Id", "rolName" },
                values: new object[] { new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"), "cliente" });

            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "Id", "password", "rolForeikey", "userName" },
                values: new object[,]
                {
                    { new Guid("07899a8d-bc7f-46d4-8d23-b174203f8bb0"), "$2a$11$mXme/2ZowWZhmO1lZ1aZV.e8nifG/YEkSktmaiOfhLRsOOESTplMm", new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"), "cliente2" },
                    { new Guid("19ccc667-10c5-47b7-abd0-bae699c1cd3e"), "$2a$11$Udh9Sr54ndt1IkwwcHCSpO1so9IZQdn6LocFXahv1hhRJsKz24oai", new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"), "cliente" },
                    { new Guid("2d58f017-e038-4efa-acc1-f5f9e2d08668"), "$2a$11$8wampa97jrBt/kMYa0MlEO8K8aqbSUiLOZdD5aHvEPISIFUp.5DhW", new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"), "cliente3" },
                    { new Guid("36126fee-fee7-4d62-a22e-959feb2dd013"), "$2a$11$7Ha8bJkbuKfU7G1TdIn0peRQZ0zV3q9rX85482n2PmeViSirK45OG", new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"), "cliente" },
                    { new Guid("afaa31d8-013f-4dee-b21a-f9d03278d26a"), "$2a$11$xk56VQcpwSdb.8VXMupbr.ljnuv9NiLweBYZ07vhnUOTaJOvtrVC.", new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"), "cliente2" },
                    { new Guid("c9d6ff8f-82ac-4eef-80df-de4999c4bb45"), "$2a$11$9BIdiMH/8U5peOHfQ0yrGeF55u5o/2YckSSjRlkYM4Q7I/jGka.LS", new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"), "cliente3" },
                    { new Guid("df0efb73-de14-4140-bbd0-c357148d89d1"), "$2a$11$L6PufPT7k4iKmF6u67bGwuFU5zVh.CxLS5bnRGCpN61gqykVi6nOS", new Guid("7a86db69-1474-4d92-a18e-91899d876c92"), "cadete" },
                    { new Guid("e0bd0d60-7ff8-43a6-b78b-8dc67780c8c9"), "$2a$11$kui6mIKWXyjRdC3e1IA0kOhtjxjjMJm.O0Y16ORT/XNQ9XYtM0oKu", new Guid("f0601b48-a878-4fb5-a767-3f1340b8c0d8"), "cadete2" },
                    { new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328"), "$2a$11$T5rUVZFgJyb/o6dj3F9NOeXuXRtAZ4FsmdDLtqvu0Ayfo0GQVKnUa", new Guid("7aafd6fb-612e-42c7-99db-cbec0fdad96f"), "admin" }
                });

            migrationBuilder.InsertData(
                table: "perfil",
                columns: new[] { "id", "Direccion", "Nombre", "Referencia", "Telefono", "userForeiKey" },
                values: new object[,]
                {
                    { new Guid("0a9fa564-0604-4dfa-88df-3636fe395651"), "independencia", "Ana Hume", null, "231321231", new Guid("2d58f017-e038-4efa-acc1-f5f9e2d08668") },
                    { new Guid("0a9fa564-0604-4dfa-88df-3636fe395678"), "independencia", "Fer Hume", null, "654321", new Guid("07899a8d-bc7f-46d4-8d23-b174203f8bb0") },
                    { new Guid("2544db67-7dd3-4a16-99ec-7f1451c00558"), "independencia", "Fer Nanda", null, "654321", new Guid("c9d6ff8f-82ac-4eef-80df-de4999c4bb45") },
                    { new Guid("4978a844-a5d3-4d32-86e9-7046eefddea2"), "Entre rios", "Jaun Antonio", null, "231321231", new Guid("19ccc667-10c5-47b7-abd0-bae699c1cd3e") },
                    { new Guid("7b5e9399-8e95-4ae8-8745-9542a01e2cc0"), "Entre rios", "Jaun Castellanos", null, "231321231", new Guid("e0bd0d60-7ff8-43a6-b78b-8dc67780c8c9") },
                    { new Guid("910381a0-3a65-4ab9-9929-44faca09b567"), "cordoba", "Chichu Han", null, "654321", new Guid("df0efb73-de14-4140-bbd0-c357148d89d1") },
                    { new Guid("b140ee23-f61b-45a7-8ef0-177d5c76a317"), "italia", "Jessy Jade", null, "654321", new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328") },
                    { new Guid("e04a530d-f4bb-4ff1-898f-b3c00160dc28"), "corrientes", "Pancho Estrada", null, "654321", new Guid("36126fee-fee7-4d62-a22e-959feb2dd013") },
                    { new Guid("e41d99f0-2afd-4c25-b677-514bcf897f6b"), "independencia", "Ana Pradera", null, "231321231", new Guid("afaa31d8-013f-4dee-b21a-f9d03278d26a") }
                });

            migrationBuilder.InsertData(
                table: "pedido",
                columns: new[] { "id", "ClienteForeingKey", "Estado", "Obs" },
                values: new object[] { new Guid("adc4aba6-b2b6-4ca6-a715-e563987fd02e"), new Guid("0a9fa564-0604-4dfa-88df-3636fe395678"), "Pendiente", "Coca" });

            migrationBuilder.CreateIndex(
                name: "IX_cadetePedido_pedidoForeingKey",
                table: "cadetePedido",
                column: "pedidoForeingKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cadetePedido_userForeingKey",
                table: "cadetePedido",
                column: "userForeingKey");

            migrationBuilder.CreateIndex(
                name: "IX_pedido_ClienteForeingKey",
                table: "pedido",
                column: "ClienteForeingKey");

            migrationBuilder.CreateIndex(
                name: "IX_perfil_userForeiKey",
                table: "perfil",
                column: "userForeiKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuario_rolForeikey",
                table: "usuario",
                column: "rolForeikey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cadetePedido");

            migrationBuilder.DropTable(
                name: "historial");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "perfil");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "rol");
        }
    }
}
