using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class u5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamwithSubject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamTitleId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ExamTypeId = table.Column<int>(type: "int", nullable: false),
                    FullMarks = table.Column<int>(type: "int", nullable: false),
                    PassingMarks = table.Column<int>(type: "int", nullable: false),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ExamwithSubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamwithSubject_ExamTitles_ExamTitleId",
                        column: x => x.ExamTitleId,
                        principalTable: "ExamTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamwithSubject_ExamTypes_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamwithSubject_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamwithSubject_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction );
                    table.ForeignKey(
                        name: "FK_ExamwithSubject_SubjectInfos_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SubjectInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamwithSubject_ExamTitleId",
                table: "ExamwithSubject",
                column: "ExamTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamwithSubject_ExamTypeId",
                table: "ExamwithSubject",
                column: "ExamTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamwithSubject_InsBranchId",
                table: "ExamwithSubject",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamwithSubject_InsId",
                table: "ExamwithSubject",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamwithSubject_SubjectId",
                table: "ExamwithSubject",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamwithSubject");
        }
    }
}
