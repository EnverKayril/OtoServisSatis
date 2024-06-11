using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtoServisSatis.Data.Migrations
{
    public partial class DataAnnotationsEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fiyatı",
                table: "Araclar",
                newName: "Fiyati");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Kullanicilar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 6, 11, 23, 26, 45, 742, DateTimeKind.Local).AddTicks(1935));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fiyati",
                table: "Araclar",
                newName: "Fiyatı");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Kullanicilar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "Id",
                keyValue: 1,
                column: "EklenmeTarihi",
                value: new DateTime(2024, 6, 11, 15, 1, 32, 200, DateTimeKind.Local).AddTicks(8369));
        }
    }
}
