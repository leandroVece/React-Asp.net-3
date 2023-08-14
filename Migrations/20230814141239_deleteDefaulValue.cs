using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cadeteria.Migrations
{
    public partial class deleteDefaulValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "rolForeikey",
                table: "usuario",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328"));

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("07899a8d-bc7f-46d4-8d23-b174203f8bb0"),
                column: "password",
                value: "$2a$11$k5Cr9QGAtOQEbnoFiN.64.djdzD5USsTHh1G0Lrk.fk5tV9nzboQy");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("19ccc667-10c5-47b7-abd0-bae699c1cd3e"),
                column: "password",
                value: "$2a$11$..xQWO9lggd0iM1BRL4F9eVjWpgrfp0mRMAomihNtd276lNkkb6q.");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("2d58f017-e038-4efa-acc1-f5f9e2d08668"),
                column: "password",
                value: "$2a$11$uNfm4V0W35R6C4sFWTaGHuLVA6ZqLuDSucXQK4.4b/81j/McWDPFm");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("36126fee-fee7-4d62-a22e-959feb2dd013"),
                column: "password",
                value: "$2a$11$INDr.6mInBKk.aTiszIme.lfEjc.YnnKd4hefZZSqnDnAeQwRLTG6");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("afaa31d8-013f-4dee-b21a-f9d03278d26a"),
                column: "password",
                value: "$2a$11$U0SjlkTbUFQ9NG0mhLjeue4Ytkx5W/SP3ITgoFv7yn2kO44nz0QKW");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("c9d6ff8f-82ac-4eef-80df-de4999c4bb45"),
                column: "password",
                value: "$2a$11$kgNwNTeLWccE2luYsys94el5aCnvqgFouGQWlnf/xMmB5BbEdU/Oi");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("df0efb73-de14-4140-bbd0-c357148d89d1"),
                column: "password",
                value: "$2a$11$.bb/TcdnT4LBkEWz7kfN6OnS1lrRKt4AdwkFo6z0BOK8qOB.uVcsm");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("e0bd0d60-7ff8-43a6-b78b-8dc67780c8c9"),
                column: "password",
                value: "$2a$11$gtBKNAfd42K0ySKgr5dFBOkN1C2ncESNxtH2EjOYHUPhHhrFVKG6m");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328"),
                column: "password",
                value: "$2a$11$g0aEclhmH.q0M9ytyHHB2.FphfgzqwWQ/6PmFUEFp6n6tFUt0baGO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "rolForeikey",
                table: "usuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("07899a8d-bc7f-46d4-8d23-b174203f8bb0"),
                column: "password",
                value: "$2a$11$wvOVlAJDM4U.Iw2acnpK0.yof5tIA2/TrDZuk/P5V7uBmH3GH1G0O");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("19ccc667-10c5-47b7-abd0-bae699c1cd3e"),
                column: "password",
                value: "$2a$11$o7VecbcDsGaD.uTKNCjmWeYol/7ll.8CNvPQiiM2pmzcvVpkkUmJC");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("2d58f017-e038-4efa-acc1-f5f9e2d08668"),
                column: "password",
                value: "$2a$11$gcldY2UAc/qpixjGeVD7K.ZUxkz3iibndqhuuEFOF4a.aAWko47HC");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("36126fee-fee7-4d62-a22e-959feb2dd013"),
                column: "password",
                value: "$2a$11$.NWdhtU46CS0VkMH3JEbjePWO7mjjLomn0ZfFEQYIBATaDlLrF.Oq");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("afaa31d8-013f-4dee-b21a-f9d03278d26a"),
                column: "password",
                value: "$2a$11$xnEfvJFTGaHfNiJid7rGLe4VqZ.3aJWKpPllBDh7PySFr2WpZOkSW");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("c9d6ff8f-82ac-4eef-80df-de4999c4bb45"),
                column: "password",
                value: "$2a$11$sRQApIqchVdCDGAcGyIAW.umtmCcyDtpSs3gVeDCzm9mrV8UBIh12");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("df0efb73-de14-4140-bbd0-c357148d89d1"),
                column: "password",
                value: "$2a$11$o/AQ9pdSQZmE.HgShrL0Yuf40sRnuW24.fh3m.OYlJt18fc8z6yfO");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("e0bd0d60-7ff8-43a6-b78b-8dc67780c8c9"),
                column: "password",
                value: "$2a$11$uZns6wd20Zc/OB8XxK2YE.k5DC.VX8HxF89mVsuWuMdFoN9b9Tg9W");

            migrationBuilder.UpdateData(
                table: "usuario",
                keyColumn: "Id",
                keyValue: new Guid("e2a4980f-7c50-45b0-aba5-6a46d79cf328"),
                column: "password",
                value: "$2a$11$CWzAIOYgn/LCz.Laq8bP1.u3jUAopYKy6yZJOBFKJQ4Kh1/jI8D.i");
        }
    }
}
