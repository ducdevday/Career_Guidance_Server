using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareerGuidance.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_DbContext_22062025v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailVerifications_User_UserId",
                table: "EmailVerifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_TemplateVersions_TemplateVersionId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_User_UserId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateFields_TemplateVersions_TemplateVersionId",
                table: "TemplateFields");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateVersions_Templates_TemplateId",
                table: "TemplateVersions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemplateVersions",
                table: "TemplateVersions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Templates",
                table: "Templates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemplateFields",
                table: "TemplateFields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailVerifications",
                table: "EmailVerifications");

            migrationBuilder.RenameTable(
                name: "TemplateVersions",
                newName: "TemplateVersion");

            migrationBuilder.RenameTable(
                name: "Templates",
                newName: "Template");

            migrationBuilder.RenameTable(
                name: "TemplateFields",
                newName: "TemplateField");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "Notification");

            migrationBuilder.RenameTable(
                name: "EmailVerifications",
                newName: "EmailVerification");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateVersions_TemplateId",
                table: "TemplateVersion",
                newName: "IX_TemplateVersion_TemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateFields_TemplateVersionId",
                table: "TemplateField",
                newName: "IX_TemplateField_TemplateVersionId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_UserId",
                table: "Notification",
                newName: "IX_Notification_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_TemplateVersionId",
                table: "Notification",
                newName: "IX_Notification_TemplateVersionId");

            migrationBuilder.RenameIndex(
                name: "IX_EmailVerifications_UserId",
                table: "EmailVerification",
                newName: "IX_EmailVerification_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "EmailVerification",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "EmailVerification",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemplateVersion",
                table: "TemplateVersion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Template",
                table: "Template",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemplateField",
                table: "TemplateField",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notification",
                table: "Notification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailVerification",
                table: "EmailVerification",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TokenHash = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUsed = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_TokenHash",
                table: "RefreshToken",
                column: "TokenHash",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailVerification_User_UserId",
                table: "EmailVerification",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_TemplateVersion_TemplateVersionId",
                table: "Notification",
                column: "TemplateVersionId",
                principalTable: "TemplateVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_User_UserId",
                table: "Notification",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateField_TemplateVersion_TemplateVersionId",
                table: "TemplateField",
                column: "TemplateVersionId",
                principalTable: "TemplateVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateVersion_Template_TemplateId",
                table: "TemplateVersion",
                column: "TemplateId",
                principalTable: "Template",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailVerification_User_UserId",
                table: "EmailVerification");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_TemplateVersion_TemplateVersionId",
                table: "Notification");

            migrationBuilder.DropForeignKey(
                name: "FK_Notification_User_UserId",
                table: "Notification");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateField_TemplateVersion_TemplateVersionId",
                table: "TemplateField");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateVersion_Template_TemplateId",
                table: "TemplateVersion");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemplateVersion",
                table: "TemplateVersion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TemplateField",
                table: "TemplateField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Template",
                table: "Template");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notification",
                table: "Notification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailVerification",
                table: "EmailVerification");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "EmailVerification");

            migrationBuilder.RenameTable(
                name: "TemplateVersion",
                newName: "TemplateVersions");

            migrationBuilder.RenameTable(
                name: "TemplateField",
                newName: "TemplateFields");

            migrationBuilder.RenameTable(
                name: "Template",
                newName: "Templates");

            migrationBuilder.RenameTable(
                name: "Notification",
                newName: "Notifications");

            migrationBuilder.RenameTable(
                name: "EmailVerification",
                newName: "EmailVerifications");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateVersion_TemplateId",
                table: "TemplateVersions",
                newName: "IX_TemplateVersions_TemplateId");

            migrationBuilder.RenameIndex(
                name: "IX_TemplateField_TemplateVersionId",
                table: "TemplateFields",
                newName: "IX_TemplateFields_TemplateVersionId");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_UserId",
                table: "Notifications",
                newName: "IX_Notifications_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_TemplateVersionId",
                table: "Notifications",
                newName: "IX_Notifications_TemplateVersionId");

            migrationBuilder.RenameIndex(
                name: "IX_EmailVerification_UserId",
                table: "EmailVerifications",
                newName: "IX_EmailVerifications_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "EmailVerifications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(6)",
                oldMaxLength: 6);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemplateVersions",
                table: "TemplateVersions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TemplateFields",
                table: "TemplateFields",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Templates",
                table: "Templates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailVerifications",
                table: "EmailVerifications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailVerifications_User_UserId",
                table: "EmailVerifications",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_TemplateVersions_TemplateVersionId",
                table: "Notifications",
                column: "TemplateVersionId",
                principalTable: "TemplateVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_User_UserId",
                table: "Notifications",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateFields_TemplateVersions_TemplateVersionId",
                table: "TemplateFields",
                column: "TemplateVersionId",
                principalTable: "TemplateVersions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateVersions_Templates_TemplateId",
                table: "TemplateVersions",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
