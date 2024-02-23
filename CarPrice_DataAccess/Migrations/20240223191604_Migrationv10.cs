using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPrice_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Migrationv10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Carozzeria",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MilageGroup",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ProdYear",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarProdYear",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MilageGroup",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarProdYear",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "MilageGroup",
                table: "Records");

            migrationBuilder.AddColumn<int>(
                name: "Carozzeria",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MilageGroup",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdYear",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
