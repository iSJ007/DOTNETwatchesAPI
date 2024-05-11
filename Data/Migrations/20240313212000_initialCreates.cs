using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace watchesASP.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialCreates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watches_Types_MovTypeId",
                table: "Watches");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Watches");

            migrationBuilder.RenameColumn(
                name: "Movement",
                table: "Watches",
                newName: "Style");

            migrationBuilder.AlterColumn<int>(
                name: "MovTypeId",
                table: "Watches",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Automatic" },
                    { 2, "Mechanical" },
                    { 3, "Quartz" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Watches_Types_MovTypeId",
                table: "Watches",
                column: "MovTypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watches_Types_MovTypeId",
                table: "Watches");

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Style",
                table: "Watches",
                newName: "Movement");

            migrationBuilder.AlterColumn<int>(
                name: "MovTypeId",
                table: "Watches",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Watches",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Watches_Types_MovTypeId",
                table: "Watches",
                column: "MovTypeId",
                principalTable: "Types",
                principalColumn: "Id");
        }
    }
}
