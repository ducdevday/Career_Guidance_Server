using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareerGuidance.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB_14092025v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_IndustryId",
                table: "User",
                column: "IndustryId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Industry_IndustryId",
                table: "User",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Industry_IndustryId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_IndustryId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "User");
        }
    }
}
