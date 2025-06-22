using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareerGuidance.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_DbContext_22062025v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "TemplateVersion",
                newName: "InsertDate");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "TemplateVersion",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TemplateVersion",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "TemplateVersion",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<Guid>(
                name: "InsertById",
                table: "TemplateVersion",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "TemplateVersion",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "TemplateVersion",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "TemplateField",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "InsertById",
                table: "TemplateField",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "TemplateField",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "TemplateField",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "TemplateField",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Template",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "InsertById",
                table: "Template",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Template",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Template",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Template",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Notification",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<Guid>(
                name: "InsertById",
                table: "Notification",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "Notification",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Notification",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Notification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "EmailVerification",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<Guid>(
                name: "InsertById",
                table: "EmailVerification",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "EmailVerification",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "EmailVerification",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmailVerification",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "TemplateVersion");

            migrationBuilder.DropColumn(
                name: "InsertById",
                table: "TemplateVersion");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "TemplateVersion");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "TemplateVersion");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "TemplateField");

            migrationBuilder.DropColumn(
                name: "InsertById",
                table: "TemplateField");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "TemplateField");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "TemplateField");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "TemplateField");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "InsertById",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Template");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "InsertById",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "EmailVerification");

            migrationBuilder.DropColumn(
                name: "InsertById",
                table: "EmailVerification");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "EmailVerification");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "EmailVerification");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EmailVerification");

            migrationBuilder.RenameColumn(
                name: "InsertDate",
                table: "TemplateVersion",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "TemplateVersion",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TemplateVersion",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
