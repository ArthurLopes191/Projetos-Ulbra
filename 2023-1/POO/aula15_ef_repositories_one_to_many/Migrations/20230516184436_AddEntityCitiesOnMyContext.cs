using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestandoORM.Migrations
{
    /// <inheritdoc />
    public partial class AddEntityCitiesOnMyContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_City_CityId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Pessoas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_Cities_CityId",
                table: "Pessoas",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoas_Cities_CityId",
                table: "Pessoas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Pessoas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoas_City_CityId",
                table: "Pessoas",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");
        }
    }
}
