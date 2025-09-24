using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class website : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_InsBranches_InsBranchId",
                table: "Directors");

            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Institutes_InsId",
                table: "Directors");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_InsBranches_InsBranchId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Institutes_InsId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_InsBranchId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_InsId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Directors_InsBranchId",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_InsId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "StdID",
                table: "StudentBasicInfos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "StdtAcademicInfos");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "Directors");

            migrationBuilder.AlterColumn<string>(
                name: "LogoPath",
                table: "Institutes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BannerPath",
                table: "Institutes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AcademicSessions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutUs_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AboutUs_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3024)", maxLength: 3024, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Achievements_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Achievements_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BookLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BookFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookLists_AcademyClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookLists_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookLists_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamAttendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamAttendances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perchantage = table.Column<int>(type: "int", nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamTypes_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamTypes_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3024)", maxLength: 3024, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facility_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facility_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    ClassInterval = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LetterGrade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradePoint = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartInterval = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EndInterval = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_AcademyClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3024)", maxLength: 3024, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_History_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MediaCats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaCatName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaCats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaCats_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MediaCats_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageBody = table.Column<string>(type: "nvarchar(3024)", maxLength: 3024, nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MissionVission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionVission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MissionVission_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MissionVission_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_News_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Room_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Room_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RulesRegulation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RulesRegulation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RulesRegulation_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RulesRegulation_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    instituteId = table.Column<int>(type: "int", nullable: false),
                    MediaName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MediaContennt = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    MediaIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedia_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SocialMedia_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarksEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    SessionID = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    SectionID = table.Column<int>(type: "int", nullable: false),
                    ExamID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    ExamTypeID = table.Column<int>(type: "int", nullable: false),
                    ObtainMark = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarksEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarksEntries_AcademyClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarksEntries_ExamTitles_ExamID",
                        column: x => x.ExamID,
                        principalTable: "ExamTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarksEntries_ExamTypes_ExamTypeID",
                        column: x => x.ExamTypeID,
                        principalTable: "ExamTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarksEntries_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarksEntries_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarksEntries_StudentBasicInfos_StudentID",
                        column: x => x.StudentID,
                        principalTable: "StudentBasicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarksEntries_SubjectInfos_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "SubjectInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    SessionID = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    SectionID = table.Column<int>(type: "int", nullable: false),
                    ExamID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    ExamTypeID = table.Column<int>(type: "int", nullable: false),
                    ObtainMark = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ConvertedMarks = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    isPublished = table.Column<bool>(type: "bit", nullable: false),
                    ResultPublisheDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_AcademyClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_ExamTitles_ExamID",
                        column: x => x.ExamID,
                        principalTable: "ExamTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_ExamTypes_ExamTypeID",
                        column: x => x.ExamTypeID,
                        principalTable: "ExamTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_StudentBasicInfos_StudentID",
                        column: x => x.StudentID,
                        principalTable: "StudentBasicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_SubjectInfos_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "SubjectInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    MediaID = table.Column<int>(type: "int", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Albums_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Albums_MediaCats_MediaID",
                        column: x => x.MediaID,
                        principalTable: "MediaCats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassRoutines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoutines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassRoutines_AcademyClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoutines_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoutines_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoutines_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassRoutines_SubjectInfos_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SubjectInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhotoGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoGalleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoGalleries_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoGalleries_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoGalleries_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VideoGalleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VideoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGalleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoGalleries_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VideoGalleries_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VideoGalleries_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentBasicInfos_ReligionId",
                table: "StudentBasicInfos",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_InsBranchId",
                table: "AboutUs",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_InsId",
                table: "AboutUs",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_InsBranchId",
                table: "Achievements",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Achievements_InsId",
                table: "Achievements",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_InsBranchId",
                table: "Albums",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_InsId",
                table: "Albums",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_MediaID",
                table: "Albums",
                column: "MediaID");

            migrationBuilder.CreateIndex(
                name: "IX_BookLists_ClassID",
                table: "BookLists",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_BookLists_InsBranchId",
                table: "BookLists",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BookLists_InsId",
                table: "BookLists",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoutines_ClassId",
                table: "ClassRoutines",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoutines_InsBranchId",
                table: "ClassRoutines",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoutines_InsId",
                table: "ClassRoutines",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoutines_RoomId",
                table: "ClassRoutines",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoutines_SubjectId",
                table: "ClassRoutines",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamTypes_InsBranchId",
                table: "ExamTypes",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamTypes_InsId",
                table: "ExamTypes",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_InsBranchId",
                table: "Facility",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Facility_InsId",
                table: "Facility",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_ClassID",
                table: "Grades",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_InsBranchId",
                table: "Grades",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_InsId",
                table: "Grades",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_History_InsBranchId",
                table: "History",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_History_InsId",
                table: "History",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_ClassID",
                table: "MarksEntries",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_ExamID",
                table: "MarksEntries",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_ExamTypeID",
                table: "MarksEntries",
                column: "ExamTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_InsBranchId",
                table: "MarksEntries",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_InsId",
                table: "MarksEntries",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_StudentID",
                table: "MarksEntries",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_SubjectID",
                table: "MarksEntries",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_MediaCats_InsBranchId",
                table: "MediaCats",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaCats_InsId",
                table: "MediaCats",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_DirectorId",
                table: "Messages",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_InsBranchId",
                table: "Messages",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_InsId",
                table: "Messages",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionVission_InsBranchId",
                table: "MissionVission",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionVission_InsId",
                table: "MissionVission",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_News_InsBranchId",
                table: "News",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_News_InsId",
                table: "News",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoGalleries_AlbumId",
                table: "PhotoGalleries",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoGalleries_InsBranchId",
                table: "PhotoGalleries",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoGalleries_InsId",
                table: "PhotoGalleries",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ClassID",
                table: "Results",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ExamID",
                table: "Results",
                column: "ExamID");

            migrationBuilder.CreateIndex(
                name: "IX_Results_ExamTypeID",
                table: "Results",
                column: "ExamTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Results_GradeId",
                table: "Results",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_InsBranchId",
                table: "Results",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_InsId",
                table: "Results",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_StudentID",
                table: "Results",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Results_SubjectID",
                table: "Results",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_InsBranchId",
                table: "Room",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_InsId",
                table: "Room",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_RulesRegulation_InsBranchId",
                table: "RulesRegulation",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_RulesRegulation_InsId",
                table: "RulesRegulation",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_InsBranchId",
                table: "SocialMedia",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_InsId",
                table: "SocialMedia",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGalleries_AlbumId",
                table: "VideoGalleries",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGalleries_InsBranchId",
                table: "VideoGalleries",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGalleries_InsId",
                table: "VideoGalleries",
                column: "InsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentBasicInfos_Religions_ReligionId",
                table: "StudentBasicInfos",
                column: "ReligionId",
                principalTable: "Religions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentBasicInfos_Religions_ReligionId",
                table: "StudentBasicInfos");

            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "BookLists");

            migrationBuilder.DropTable(
                name: "ClassRoutines");

            migrationBuilder.DropTable(
                name: "ExamAttendances");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "MarksEntries");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "MissionVission");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "PhotoGalleries");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "RulesRegulation");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "VideoGalleries");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "ExamTitles");

            migrationBuilder.DropTable(
                name: "ExamTypes");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "MediaCats");

            migrationBuilder.DropIndex(
                name: "IX_StudentBasicInfos_ReligionId",
                table: "StudentBasicInfos");

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StdID",
                table: "StudentBasicInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "StdtAcademicInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LogoPath",
                table: "Institutes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BannerPath",
                table: "Institutes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AcademicSessions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_InsBranchId",
                table: "Teachers",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_InsId",
                table: "Teachers",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_InsBranchId",
                table: "Directors",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_InsId",
                table: "Directors",
                column: "InsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_InsBranches_InsBranchId",
                table: "Directors",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Institutes_InsId",
                table: "Directors",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_InsBranches_InsBranchId",
                table: "Teachers",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Institutes_InsId",
                table: "Teachers",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
