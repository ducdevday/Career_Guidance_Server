using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareerGuidance.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_DBContext_20082025v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_Address_AddressId",
                table: "Mentor");

            migrationBuilder.DropForeignKey(
                name: "FK_School_Address_AddressId",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Address_AddressId",
                table: "Workshop");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkshopReview_Workshop_WorkShopId",
                table: "WorkshopReview");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Workshop_AddressId",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_School_AddressId",
                table: "School");

            migrationBuilder.DropIndex(
                name: "IX_Mentor_AddressId",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "EstablishmentDate",
                table: "School");

            migrationBuilder.DropColumn(
                name: "About",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "InstagramUrl",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "TiktokUrl",
                table: "Mentor");

            migrationBuilder.RenameColumn(
                name: "WorkShopId",
                table: "WorkshopReview",
                newName: "WorkshopId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkshopReview_WorkShopId",
                table: "WorkshopReview",
                newName: "IX_WorkshopReview_WorkshopId");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Workshop",
                newName: "WardId");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "School",
                newName: "StreetName");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "School",
                newName: "FullAddress");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "School",
                newName: "WardId");

            migrationBuilder.RenameColumn(
                name: "About",
                table: "School",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Website",
                table: "Mentor",
                newName: "Avatar");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Mentor",
                newName: "YOE");

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Workshop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FullAddress",
                table: "Workshop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Workshop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Workshop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "School",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Mentor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Mentor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_DistrictId",
                table: "Workshop",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_ProvinceId",
                table: "Workshop",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_WardId",
                table: "Workshop",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_School_DistrictId",
                table: "School",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_School_ProvinceId",
                table: "School",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_School_WardId",
                table: "School",
                column: "WardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentor_User_Id",
                table: "Mentor",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_School_District_DistrictId",
                table: "School",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_School_Province_ProvinceId",
                table: "School",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_School_User_Id",
                table: "School",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_School_Ward_WardId",
                table: "School",
                column: "WardId",
                principalTable: "Ward",
                principalColumn: "WardId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_District_DistrictId",
                table: "Workshop",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Province_ProvinceId",
                table: "Workshop",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Ward_WardId",
                table: "Workshop",
                column: "WardId",
                principalTable: "Ward",
                principalColumn: "WardId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkshopReview_Workshop_WorkshopId",
                table: "WorkshopReview",
                column: "WorkshopId",
                principalTable: "Workshop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_User_Id",
                table: "Mentor");

            migrationBuilder.DropForeignKey(
                name: "FK_School_District_DistrictId",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_School_Province_ProvinceId",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_School_User_Id",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_School_Ward_WardId",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_District_DistrictId",
                table: "Workshop");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Province_ProvinceId",
                table: "Workshop");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_Ward_WardId",
                table: "Workshop");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkshopReview_Workshop_WorkshopId",
                table: "WorkshopReview");

            migrationBuilder.DropIndex(
                name: "IX_Workshop_DistrictId",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_Workshop_ProvinceId",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_Workshop_WardId",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_School_DistrictId",
                table: "School");

            migrationBuilder.DropIndex(
                name: "IX_School_ProvinceId",
                table: "School");

            migrationBuilder.DropIndex(
                name: "IX_School_WardId",
                table: "School");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Workshop");

            migrationBuilder.DropColumn(
                name: "FullAddress",
                table: "Workshop");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Workshop");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Workshop");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "School");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "School");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Mentor");

            migrationBuilder.RenameColumn(
                name: "WorkshopId",
                table: "WorkshopReview",
                newName: "WorkShopId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkshopReview_WorkshopId",
                table: "WorkshopReview",
                newName: "IX_WorkshopReview_WorkShopId");

            migrationBuilder.RenameColumn(
                name: "WardId",
                table: "Workshop",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "WardId",
                table: "School",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "StreetName",
                table: "School",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "FullAddress",
                table: "School",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "School",
                newName: "About");

            migrationBuilder.RenameColumn(
                name: "YOE",
                table: "Mentor",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "Avatar",
                table: "Mentor",
                newName: "Website");

            migrationBuilder.AddColumn<DateTime>(
                name: "EstablishmentDate",
                table: "School",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Mentor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Mentor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "Mentor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramUrl",
                table: "Mentor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "Mentor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TiktokUrl",
                table: "Mentor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DistrictId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StreetNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WardId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_AddressId",
                table: "Workshop",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_School_AddressId",
                table: "School",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_AddressId",
                table: "Mentor",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentor_Address_AddressId",
                table: "Mentor",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_School_Address_AddressId",
                table: "School",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_Address_AddressId",
                table: "Workshop",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkshopReview_Workshop_WorkShopId",
                table: "WorkshopReview",
                column: "WorkShopId",
                principalTable: "Workshop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
