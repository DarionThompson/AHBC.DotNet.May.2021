using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIExample.Migrations
{
    public partial class SeedToolTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tools_Parts_PartId",
                table: "Tools");

            migrationBuilder.DropIndex(
                name: "IX_Tools_PartId",
                table: "Tools");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "Tools");

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "Name", "Price", "Quanity" },
                values: new object[] { 4, "Hammer", 9.9900000000000002, 30 });

            migrationBuilder.InsertData(
                table: "Tools",
                columns: new[] { "Id", "Name", "Price", "Quanity" },
                values: new object[] { 1, "Handle", 2.9900000000000002, 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tools",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "Tools",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tools_PartId",
                table: "Tools",
                column: "PartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tools_Parts_PartId",
                table: "Tools",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
