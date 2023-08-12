using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadeteria.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("07899a8d-bc7f-46d4-8d23-b174203f8bb0"),
                columns: new[] { "password", "userName" },
                values: new object[] { "$2a$11$nFgzvVYDwqdrh4dXEQCwYOtCr6S8nPH12t8mTpaJVMt7CZ62UxJ3q", "cliente02" });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("19ccc667-10c5-47b7-abd0-bae699c1cd3e"),
                columns: new[] { "password", "userName" },
                values: new object[] { "$2a$11$GcwjSR8Jtj.Qt.hGR.8Z7.0Mkrc29mY46o6UYkx0eQd7hXp9sJjMC", "cliente01" });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("2d58f017-e038-4efa-acc1-f5f9e2d08668"),
                columns: new[] { "password", "userName" },
                values: new object[] { "$2a$11$tvp8XRXnEFcFFBoFc0RwXe37ypmckc1ptRl4hO2zlPwYyb1lcXnFi", "cliente03" });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("36126fee-fee7-4d62-a22e-959feb2dd013"),
                column: "password",
                value: "$2a$11$zBTGS8Fcyu6/UnRQpqfuAOB0ea7mR3X4VuDXa0ytfxd6XZeNC4VQa");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("afaa31d8-013f-4dee-b21a-f9d03278d26a"),
                column: "password",
                value: "$2a$11$.3M7Cm2K0db/CwSWjgZK5.dGOZmtxzpp5Ls6EHFWLIO./1Vgbyh/u");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("c9d6ff8f-82ac-4eef-80df-de4999c4bb45"),
                column: "password",
                value: "$2a$11$9pJkCAMxSi9JPOTFAGKz7Onkdj8VJPsCnnCN1EKNLpq..hqxAuNsa");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("df0efb73-de14-4140-bbd0-c357148d89d1"),
                column: "password",
                value: "$2a$11$eKWOask9oz5V6MuJMVZ1ae8FaC6Hd53AAAUpyogFedyDGVC9d/ERS");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("e0bd0d60-7ff8-43a6-b78b-8dc67780c8c9"),
                column: "password",
                value: "$2a$11$nIzQVZgbmp.Cyg79RuFxeecMpUH.4mMg1PD7pwuuMxBuGc6867L9O");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328"),
                column: "password",
                value: "$2a$11$Ke8WamQTQkKCB5QAmr3DUudet26xYcDeHH/b2H/lLyCCDnAO3ChXy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("07899a8d-bc7f-46d4-8d23-b174203f8bb0"),
                columns: new[] { "password", "userName" },
                values: new object[] { "$2a$11$mXme/2ZowWZhmO1lZ1aZV.e8nifG/YEkSktmaiOfhLRsOOESTplMm", "cliente2" });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("19ccc667-10c5-47b7-abd0-bae699c1cd3e"),
                columns: new[] { "password", "userName" },
                values: new object[] { "$2a$11$Udh9Sr54ndt1IkwwcHCSpO1so9IZQdn6LocFXahv1hhRJsKz24oai", "cliente" });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("2d58f017-e038-4efa-acc1-f5f9e2d08668"),
                columns: new[] { "password", "userName" },
                values: new object[] { "$2a$11$8wampa97jrBt/kMYa0MlEO8K8aqbSUiLOZdD5aHvEPISIFUp.5DhW", "cliente3" });

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("36126fee-fee7-4d62-a22e-959feb2dd013"),
                column: "password",
                value: "$2a$11$7Ha8bJkbuKfU7G1TdIn0peRQZ0zV3q9rX85482n2PmeViSirK45OG");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("afaa31d8-013f-4dee-b21a-f9d03278d26a"),
                column: "password",
                value: "$2a$11$xk56VQcpwSdb.8VXMupbr.ljnuv9NiLweBYZ07vhnUOTaJOvtrVC.");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("c9d6ff8f-82ac-4eef-80df-de4999c4bb45"),
                column: "password",
                value: "$2a$11$9BIdiMH/8U5peOHfQ0yrGeF55u5o/2YckSSjRlkYM4Q7I/jGka.LS");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("df0efb73-de14-4140-bbd0-c357148d89d1"),
                column: "password",
                value: "$2a$11$L6PufPT7k4iKmF6u67bGwuFU5zVh.CxLS5bnRGCpN61gqykVi6nOS");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("e0bd0d60-7ff8-43a6-b78b-8dc67780c8c9"),
                column: "password",
                value: "$2a$11$kui6mIKWXyjRdC3e1IA0kOhtjxjjMJm.O0Y16ORT/XNQ9XYtM0oKu");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328"),
                column: "password",
                value: "$2a$11$T5rUVZFgJyb/o6dj3F9NOeXuXRtAZ4FsmdDLtqvu0Ayfo0GQVKnUa");
        }
    }
}
