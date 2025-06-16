using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CareerGuidance.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init_DbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WardId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    WardName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DistrictId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Industry_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Industry_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QnAPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Replies = table.Column<int>(type: "int", nullable: true),
                    Ups = table.Column<int>(type: "int", nullable: true),
                    Downs = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QnAPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QnAPost_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QnAPost_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiktokUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Company_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstablishmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiktokUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                    table.ForeignKey(
                        name: "FK_School_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_School_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_School_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThumnailUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeForReadValue = table.Column<int>(type: "int", nullable: false),
                    TimeForReadType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blog_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blog_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Blog_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoAdsUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ThumnalUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    RatingStar = table.Column<double>(type: "float", nullable: true),
                    RatingCount = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Draft"),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Course_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TiktokUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mentor_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mentor_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mentor_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mentor_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumnail = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatingStar = table.Column<double>(type: "float", nullable: true),
                    RatingCount = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Draft"),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tour_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tour_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tour_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tour_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workshop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumnail = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    TimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatingStar = table.Column<double>(type: "float", nullable: true),
                    RatingCount = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Draft"),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workshop_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workshop_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workshop_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workshop_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QnAComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ups = table.Column<int>(type: "int", nullable: true),
                    Downs = table.Column<int>(type: "int", nullable: true),
                    QnAPostId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QnAComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QnAComment_QnAPost_QnAPostId",
                        column: x => x.QnAPostId,
                        principalTable: "QnAPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QnAComment_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QnAComment_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QnAPostInteraction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsUp = table.Column<bool>(type: "bit", nullable: false),
                    IsDown = table.Column<bool>(type: "bit", nullable: false),
                    QnAPostId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QnAPostInteraction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QnAPostInteraction_QnAPost_QnAPostId",
                        column: x => x.QnAPostId,
                        principalTable: "QnAPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QnAPostInteraction_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QnAPostInteraction_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserIndustry",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIndustry", x => new { x.CompanyId, x.IndustryId });
                    table.ForeignKey(
                        name: "FK_UserIndustry_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserIndustry_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserIndustry_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserIndustry_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolIndustry",
                columns: table => new
                {
                    SchoolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolIndustry", x => new { x.SchoolId, x.IndustryId });
                    table.ForeignKey(
                        name: "FK_SchoolIndustry_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolIndustry_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolIndustry_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SchoolIndustry_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BlogComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComment_Blog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogComment_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BlogComment_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapter_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chapter_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chapter_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructor_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructor_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instructor_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserEnrollCourse",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEnrollCourse", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_UserEnrollCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEnrollCourse_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEnrollCourse_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEnrollCourse_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourReview",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourReview_Tour_TourId",
                        column: x => x.TourId,
                        principalTable: "Tour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourReview_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourReview_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserEnrollTour",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEnrollTour", x => new { x.UserId, x.TourId });
                    table.ForeignKey(
                        name: "FK_UserEnrollTour_Tour_TourId",
                        column: x => x.TourId,
                        principalTable: "Tour",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEnrollTour_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEnrollTour_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEnrollTour_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEnrollWorkshop",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkshopId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEnrollWorkshop", x => new { x.UserId, x.WorkshopId });
                    table.ForeignKey(
                        name: "FK_UserEnrollWorkshop_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEnrollWorkshop_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEnrollWorkshop_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEnrollWorkshop_Workshop_WorkshopId",
                        column: x => x.WorkshopId,
                        principalTable: "Workshop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkshopReview",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    WorkShopId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkshopReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkshopReview_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkshopReview_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkshopReview_Workshop_WorkShopId",
                        column: x => x.WorkShopId,
                        principalTable: "Workshop",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QnACommentInteraction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsUp = table.Column<bool>(type: "bit", nullable: false),
                    IsDown = table.Column<bool>(type: "bit", nullable: false),
                    QnACommentId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QnACommentInteraction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QnACommentInteraction_QnAComment_QnACommentId",
                        column: x => x.QnACommentId,
                        principalTable: "QnAComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QnACommentInteraction_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QnACommentInteraction_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ThumnalUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_Chapter_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lesson_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lesson_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SourceUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SourceType = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resource_Lesson_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resource_User_InsertById",
                        column: x => x.InsertById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Resource_User_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_InsertById",
                table: "Address",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UpdatedById",
                table: "Address",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_IndustryId",
                table: "Blog",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_InsertById",
                table: "Blog",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_UpdatedById",
                table: "Blog",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_BlogId",
                table: "BlogComment",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_InsertById",
                table: "BlogComment",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_UpdatedById",
                table: "BlogComment",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_CourseId",
                table: "Chapter",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_InsertById",
                table: "Chapter",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_UpdatedById",
                table: "Chapter",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AddressId",
                table: "Company",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Company_InsertById",
                table: "Company",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Company_UpdatedById",
                table: "Company",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Course_IndustryId",
                table: "Course",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_InsertById",
                table: "Course",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Course_UpdatedById",
                table: "Course",
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
                name: "IX_Instructor_CourseId",
                table: "Instructor",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_InsertById",
                table: "Instructor",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_UpdatedById",
                table: "Instructor",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ChapterId",
                table: "Lesson",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_InsertById",
                table: "Lesson",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_UpdatedById",
                table: "Lesson",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_AddressId",
                table: "Mentor",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_IndustryId",
                table: "Mentor",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_InsertById",
                table: "Mentor",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_UpdatedById",
                table: "Mentor",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAComment_InsertById",
                table: "QnAComment",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAComment_QnAPostId",
                table: "QnAComment",
                column: "QnAPostId");

            migrationBuilder.CreateIndex(
                name: "IX_QnAComment_UpdatedById",
                table: "QnAComment",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_QnACommentInteraction_InsertById",
                table: "QnACommentInteraction",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_QnACommentInteraction_QnACommentId",
                table: "QnACommentInteraction",
                column: "QnACommentId");

            migrationBuilder.CreateIndex(
                name: "IX_QnACommentInteraction_UpdatedById",
                table: "QnACommentInteraction",
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
                name: "IX_QnAPostInteraction_InsertById",
                table: "QnAPostInteraction",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_QnAPostInteraction_QnAPostId",
                table: "QnAPostInteraction",
                column: "QnAPostId");

            migrationBuilder.CreateIndex(
                name: "IX_QnAPostInteraction_UpdatedById",
                table: "QnAPostInteraction",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_InsertById",
                table: "Resource",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_LessonId",
                table: "Resource",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Resource_UpdatedById",
                table: "Resource",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_School_AddressId",
                table: "School",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_School_InsertById",
                table: "School",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_School_UpdatedById",
                table: "School",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolIndustry_IndustryId",
                table: "SchoolIndustry",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolIndustry_InsertById",
                table: "SchoolIndustry",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolIndustry_UpdatedById",
                table: "SchoolIndustry",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_AddressId",
                table: "Tour",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tour_IndustryId",
                table: "Tour",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_InsertById",
                table: "Tour",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_UpdatedById",
                table: "Tour",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TourReview_InsertById",
                table: "TourReview",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_TourReview_TourId",
                table: "TourReview",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourReview_UpdatedById",
                table: "TourReview",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_InsertById",
                table: "User",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_User_PhoneNumber",
                table: "User",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UpdatedById",
                table: "User",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollCourse_CourseId",
                table: "UserEnrollCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollCourse_InsertById",
                table: "UserEnrollCourse",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollCourse_UpdatedById",
                table: "UserEnrollCourse",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollTour_InsertById",
                table: "UserEnrollTour",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollTour_TourId",
                table: "UserEnrollTour",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnrollTour_UpdatedById",
                table: "UserEnrollTour",
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
                name: "IX_UserEnrollWorkshop_WorkshopId",
                table: "UserEnrollWorkshop",
                column: "WorkshopId");

            migrationBuilder.CreateIndex(
                name: "IX_UserIndustry_IndustryId",
                table: "UserIndustry",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserIndustry_InsertById",
                table: "UserIndustry",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_UserIndustry_UpdatedById",
                table: "UserIndustry",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_AddressId",
                table: "Workshop",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_IndustryId",
                table: "Workshop",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_InsertById",
                table: "Workshop",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_Workshop_UpdatedById",
                table: "Workshop",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkshopReview_InsertById",
                table: "WorkshopReview",
                column: "InsertById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkshopReview_UpdatedById",
                table: "WorkshopReview",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_WorkshopReview_WorkShopId",
                table: "WorkshopReview",
                column: "WorkShopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComment");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "QnACommentInteraction");

            migrationBuilder.DropTable(
                name: "QnAPostInteraction");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "SchoolIndustry");

            migrationBuilder.DropTable(
                name: "TourReview");

            migrationBuilder.DropTable(
                name: "UserEnrollCourse");

            migrationBuilder.DropTable(
                name: "UserEnrollTour");

            migrationBuilder.DropTable(
                name: "UserEnrollWorkshop");

            migrationBuilder.DropTable(
                name: "UserIndustry");

            migrationBuilder.DropTable(
                name: "WorkshopReview");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "QnAComment");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Workshop");

            migrationBuilder.DropTable(
                name: "QnAPost");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Industry");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
