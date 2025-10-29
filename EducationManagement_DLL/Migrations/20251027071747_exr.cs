using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class exr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamRoutines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    SessionID = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    DayOfWeek = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamRoutines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_ExamTitles_ExamId",
                        column: x => x.ExamId,
                        principalTable: "ExamTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExamRoutines_SubjectInfos_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SubjectInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_AcademyClassId",
                table: "ExamRoutines",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_ExamId",
                table: "ExamRoutines",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_InsBranchId",
                table: "ExamRoutines",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_InsId",
                table: "ExamRoutines",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamRoutines_SubjectId",
                table: "ExamRoutines",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamRoutines");
        }
    }
}
