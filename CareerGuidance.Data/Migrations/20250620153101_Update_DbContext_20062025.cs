using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareerGuidance.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_DbContext_20062025 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_InsertById",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UpdatedById",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_User_InsertById",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_Blog_User_UpdatedById",
                table: "Blog");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogComment_User_InsertById",
                table: "BlogComment");

            migrationBuilder.DropForeignKey(
                name: "FK_BlogComment_User_UpdatedById",
                table: "BlogComment");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_User_InsertById",
                table: "Chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_User_UpdatedById",
                table: "Chapter");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_User_InsertById",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_User_UpdatedById",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_User_InsertById",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_User_UpdatedById",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Industry_User_InsertById",
                table: "Industry");

            migrationBuilder.DropForeignKey(
                name: "FK_Industry_User_UpdatedById",
                table: "Industry");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_User_InsertById",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_User_UpdatedById",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_User_InsertById",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_User_UpdatedById",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_User_InsertById",
                table: "Mentor");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_User_UpdatedById",
                table: "Mentor");

            migrationBuilder.DropForeignKey(
                name: "FK_QnAComment_User_InsertById",
                table: "QnAComment");

            migrationBuilder.DropForeignKey(
                name: "FK_QnAComment_User_UpdatedById",
                table: "QnAComment");

            migrationBuilder.DropForeignKey(
                name: "FK_QnACommentInteraction_User_InsertById",
                table: "QnACommentInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_QnACommentInteraction_User_UpdatedById",
                table: "QnACommentInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_QnAPost_User_InsertById",
                table: "QnAPost");

            migrationBuilder.DropForeignKey(
                name: "FK_QnAPost_User_UpdatedById",
                table: "QnAPost");

            migrationBuilder.DropForeignKey(
                name: "FK_QnAPostInteraction_User_InsertById",
                table: "QnAPostInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_QnAPostInteraction_User_UpdatedById",
                table: "QnAPostInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_User_InsertById",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_Resource_User_UpdatedById",
                table: "Resource");

            migrationBuilder.DropForeignKey(
                name: "FK_School_User_InsertById",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_School_User_UpdatedById",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolIndustry_User_InsertById",
                table: "SchoolIndustry");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolIndustry_User_UpdatedById",
                table: "SchoolIndustry");

            migrationBuilder.DropForeignKey(
                name: "FK_Tour_User_InsertById",
                table: "Tour");

            migrationBuilder.DropForeignKey(
                name: "FK_Tour_User_UpdatedById",
                table: "Tour");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReview_User_InsertById",
                table: "TourReview");

            migrationBuilder.DropForeignKey(
                name: "FK_TourReview_User_UpdatedById",
                table: "TourReview");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_InsertById",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_UpdatedById",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEnrollCourse_User_InsertById",
                table: "UserEnrollCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEnrollCourse_User_UpdatedById",
                table: "UserEnrollCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEnrollTour_User_InsertById",
                table: "UserEnrollTour");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEnrollTour_User_UpdatedById",
                table: "UserEnrollTour");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEnrollWorkshop_User_InsertById",
                table: "UserEnrollWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEnrollWorkshop_User_UpdatedById",
                table: "UserEnrollWorkshop");

            migrationBuilder.DropForeignKey(
                name: "FK_UserIndustry_User_InsertById",
                table: "UserIndustry");

            migrationBuilder.DropForeignKey(
                name: "FK_UserIndustry_User_UpdatedById",
                table: "UserIndustry");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_User_InsertById",
                table: "Workshop");

            migrationBuilder.DropForeignKey(
                name: "FK_Workshop_User_UpdatedById",
                table: "Workshop");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkshopReview_User_InsertById",
                table: "WorkshopReview");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkshopReview_User_UpdatedById",
                table: "WorkshopReview");

            migrationBuilder.DropIndex(
                name: "IX_WorkshopReview_InsertById",
                table: "WorkshopReview");

            migrationBuilder.DropIndex(
                name: "IX_WorkshopReview_UpdatedById",
                table: "WorkshopReview");

            migrationBuilder.DropIndex(
                name: "IX_Workshop_InsertById",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_Workshop_UpdatedById",
                table: "Workshop");

            migrationBuilder.DropIndex(
                name: "IX_UserIndustry_InsertById",
                table: "UserIndustry");

            migrationBuilder.DropIndex(
                name: "IX_UserIndustry_UpdatedById",
                table: "UserIndustry");

            migrationBuilder.DropIndex(
                name: "IX_UserEnrollWorkshop_InsertById",
                table: "UserEnrollWorkshop");

            migrationBuilder.DropIndex(
                name: "IX_UserEnrollWorkshop_UpdatedById",
                table: "UserEnrollWorkshop");

            migrationBuilder.DropIndex(
                name: "IX_UserEnrollTour_InsertById",
                table: "UserEnrollTour");

            migrationBuilder.DropIndex(
                name: "IX_UserEnrollTour_UpdatedById",
                table: "UserEnrollTour");

            migrationBuilder.DropIndex(
                name: "IX_UserEnrollCourse_InsertById",
                table: "UserEnrollCourse");

            migrationBuilder.DropIndex(
                name: "IX_UserEnrollCourse_UpdatedById",
                table: "UserEnrollCourse");

            migrationBuilder.DropIndex(
                name: "IX_User_InsertById",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UpdatedById",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_TourReview_InsertById",
                table: "TourReview");

            migrationBuilder.DropIndex(
                name: "IX_TourReview_UpdatedById",
                table: "TourReview");

            migrationBuilder.DropIndex(
                name: "IX_Tour_InsertById",
                table: "Tour");

            migrationBuilder.DropIndex(
                name: "IX_Tour_UpdatedById",
                table: "Tour");

            migrationBuilder.DropIndex(
                name: "IX_SchoolIndustry_InsertById",
                table: "SchoolIndustry");

            migrationBuilder.DropIndex(
                name: "IX_SchoolIndustry_UpdatedById",
                table: "SchoolIndustry");

            migrationBuilder.DropIndex(
                name: "IX_School_InsertById",
                table: "School");

            migrationBuilder.DropIndex(
                name: "IX_School_UpdatedById",
                table: "School");

            migrationBuilder.DropIndex(
                name: "IX_Resource_InsertById",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_Resource_UpdatedById",
                table: "Resource");

            migrationBuilder.DropIndex(
                name: "IX_QnAPostInteraction_InsertById",
                table: "QnAPostInteraction");

            migrationBuilder.DropIndex(
                name: "IX_QnAPostInteraction_UpdatedById",
                table: "QnAPostInteraction");

            migrationBuilder.DropIndex(
                name: "IX_QnAPost_InsertById",
                table: "QnAPost");

            migrationBuilder.DropIndex(
                name: "IX_QnAPost_UpdatedById",
                table: "QnAPost");

            migrationBuilder.DropIndex(
                name: "IX_QnACommentInteraction_InsertById",
                table: "QnACommentInteraction");

            migrationBuilder.DropIndex(
                name: "IX_QnACommentInteraction_UpdatedById",
                table: "QnACommentInteraction");

            migrationBuilder.DropIndex(
                name: "IX_QnAComment_InsertById",
                table: "QnAComment");

            migrationBuilder.DropIndex(
                name: "IX_QnAComment_UpdatedById",
                table: "QnAComment");

            migrationBuilder.DropIndex(
                name: "IX_Mentor_InsertById",
                table: "Mentor");

            migrationBuilder.DropIndex(
                name: "IX_Mentor_UpdatedById",
                table: "Mentor");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_InsertById",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Lesson_UpdatedById",
                table: "Lesson");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_InsertById",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_UpdatedById",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Industry_InsertById",
                table: "Industry");

            migrationBuilder.DropIndex(
                name: "IX_Industry_UpdatedById",
                table: "Industry");

            migrationBuilder.DropIndex(
                name: "IX_Course_InsertById",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_UpdatedById",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Company_InsertById",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_UpdatedById",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Chapter_InsertById",
                table: "Chapter");

            migrationBuilder.DropIndex(
                name: "IX_Chapter_UpdatedById",
                table: "Chapter");

            migrationBuilder.DropIndex(
                name: "IX_BlogComment_InsertById",
                table: "BlogComment");

            migrationBuilder.DropIndex(
                name: "IX_BlogComment_UpdatedById",
                table: "BlogComment");

            migrationBuilder.DropIndex(
                name: "IX_Blog_InsertById",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_UpdatedById",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Address_InsertById",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_UpdatedById",
                table: "Address");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "WorkshopReview",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Workshop",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "UserIndustry",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "UserEnrollWorkshop",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "UserEnrollTour",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "UserEnrollCourse",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "User",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Verified",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "TourReview",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Tour",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "SchoolIndustry",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "School",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Resource",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "QnAPostInteraction",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "QnAPost",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "QnAPost",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "QnACommentInteraction",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "QnAComment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "QnAComment",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Mentor",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Lesson",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Instructor",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Industry",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Course",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Company",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Chapter",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "BlogComment",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Blog",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Address",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "WorkshopReview",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Workshop",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "UserIndustry",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "UserEnrollWorkshop",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "UserEnrollTour",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "UserEnrollCourse",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Verified");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "TourReview",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Tour",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "SchoolIndustry",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "School",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Resource",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "QnAPostInteraction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "QnAPost",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "QnAPost",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "QnACommentInteraction",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "QnAComment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "QnAComment",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Mentor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Lesson",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Instructor",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Industry",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Course",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Company",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Chapter",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "BlogComment",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Blog",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedById",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkshopReview_InsertById",
                table: "WorkshopReview",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkshopReview_UpdatedById",
                table: "WorkshopReview",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_InsertById",
                table: "Workshop",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_UpdatedById",
                table: "Workshop",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserIndustry_InsertById",
                table: "UserIndustry",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_UserIndustry_UpdatedById",
                table: "UserIndustry",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollWorkshop_InsertById",
                table: "UserEnrollWorkshop",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollWorkshop_UpdatedById",
                table: "UserEnrollWorkshop",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollTour_InsertById",
                table: "UserEnrollTour",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollTour_UpdatedById",
                table: "UserEnrollTour",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollCourse_InsertById",
                table: "UserEnrollCourse",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollCourse_UpdatedById",
                table: "UserEnrollCourse",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_User_InsertById",
                table: "User",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_User_UpdatedById",
                table: "User",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TourReview_InsertById",
                table: "TourReview",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_TourReview_UpdatedById",
                table: "TourReview",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_InsertById",
                table: "Tour",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_UpdatedById",
                table: "Tour",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolIndustry_InsertById",
                table: "SchoolIndustry",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolIndustry_UpdatedById",
                table: "SchoolIndustry",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_School_InsertById",
                table: "School",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_School_UpdatedById",
                table: "School",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_InsertById",
                table: "Resource",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_UpdatedById",
                table: "Resource",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAPostInteraction_InsertById",
                table: "QnAPostInteraction",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAPostInteraction_UpdatedById",
                table: "QnAPostInteraction",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAPost_InsertById",
                table: "QnAPost",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAPost_UpdatedById",
                table: "QnAPost",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_QnACommentInteraction_InsertById",
                table: "QnACommentInteraction",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_QnACommentInteraction_UpdatedById",
                table: "QnACommentInteraction",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAComment_InsertById",
                table: "QnAComment",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAComment_UpdatedById",
                table: "QnAComment",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_InsertById",
                table: "Mentor",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_UpdatedById",
                table: "Mentor",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_InsertById",
                table: "Lesson",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_UpdatedById",
                table: "Lesson",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_InsertById",
                table: "Instructor",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_UpdatedById",
                table: "Instructor",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_InsertById",
                table: "Industry",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_UpdatedById",
                table: "Industry",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Course_InsertById",
                table: "Course",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Course_UpdatedById",
                table: "Course",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Company_InsertById",
                table: "Company",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Company_UpdatedById",
                table: "Company",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_InsertById",
                table: "Chapter",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_UpdatedById",
                table: "Chapter",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_InsertById",
                table: "BlogComment",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_UpdatedById",
                table: "BlogComment",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_InsertById",
                table: "Blog",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_UpdatedById",
                table: "Blog",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Address_InsertById",
                table: "Address",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UpdatedById",
                table: "Address",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_InsertById",
                table: "Address",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UpdatedById",
                table: "Address",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_User_InsertById",
                table: "Blog",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_User_UpdatedById",
                table: "Blog",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComment_User_InsertById",
                table: "BlogComment",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComment_User_UpdatedById",
                table: "BlogComment",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_User_InsertById",
                table: "Chapter",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_User_UpdatedById",
                table: "Chapter",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_User_InsertById",
                table: "Company",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_User_UpdatedById",
                table: "Company",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_User_InsertById",
                table: "Course",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_User_UpdatedById",
                table: "Course",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Industry_User_InsertById",
                table: "Industry",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Industry_User_UpdatedById",
                table: "Industry",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_User_InsertById",
                table: "Instructor",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_User_UpdatedById",
                table: "Instructor",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_User_InsertById",
                table: "Lesson",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_User_UpdatedById",
                table: "Lesson",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentor_User_InsertById",
                table: "Mentor",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentor_User_UpdatedById",
                table: "Mentor",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QnAComment_User_InsertById",
                table: "QnAComment",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QnAComment_User_UpdatedById",
                table: "QnAComment",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QnACommentInteraction_User_InsertById",
                table: "QnACommentInteraction",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QnACommentInteraction_User_UpdatedById",
                table: "QnACommentInteraction",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QnAPost_User_InsertById",
                table: "QnAPost",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QnAPost_User_UpdatedById",
                table: "QnAPost",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QnAPostInteraction_User_InsertById",
                table: "QnAPostInteraction",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_QnAPostInteraction_User_UpdatedById",
                table: "QnAPostInteraction",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_User_InsertById",
                table: "Resource",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Resource_User_UpdatedById",
                table: "Resource",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_School_User_InsertById",
                table: "School",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_School_User_UpdatedById",
                table: "School",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolIndustry_User_InsertById",
                table: "SchoolIndustry",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolIndustry_User_UpdatedById",
                table: "SchoolIndustry",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_User_InsertById",
                table: "Tour",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tour_User_UpdatedById",
                table: "Tour",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReview_User_InsertById",
                table: "TourReview",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TourReview_User_UpdatedById",
                table: "TourReview",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_InsertById",
                table: "User",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_UpdatedById",
                table: "User",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEnrollCourse_User_InsertById",
                table: "UserEnrollCourse",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEnrollCourse_User_UpdatedById",
                table: "UserEnrollCourse",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEnrollTour_User_InsertById",
                table: "UserEnrollTour",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEnrollTour_User_UpdatedById",
                table: "UserEnrollTour",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEnrollWorkshop_User_InsertById",
                table: "UserEnrollWorkshop",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEnrollWorkshop_User_UpdatedById",
                table: "UserEnrollWorkshop",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserIndustry_User_InsertById",
                table: "UserIndustry",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserIndustry_User_UpdatedById",
                table: "UserIndustry",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_User_InsertById",
                table: "Workshop",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Workshop_User_UpdatedById",
                table: "Workshop",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkshopReview_User_InsertById",
                table: "WorkshopReview",
                column: "InsertById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkshopReview_User_UpdatedById",
                table: "WorkshopReview",
                column: "UpdatedById",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
