using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class u6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_SectionID",
                table: "MarksEntries",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_MarksEntries_SessionID",
                table: "MarksEntries",
                column: "SessionID");

            migrationBuilder.AddForeignKey(
                name: "FK_MarksEntries_AcademicSessions_SessionID",
                table: "MarksEntries",
                column: "SessionID",
                principalTable: "AcademicSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarksEntries_ClassSections_SectionID",
                table: "MarksEntries",
                column: "SectionID",
                principalTable: "ClassSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MarksEntries_AcademicSessions_SessionID",
                table: "MarksEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_MarksEntries_ClassSections_SectionID",
                table: "MarksEntries");

            migrationBuilder.DropIndex(
                name: "IX_MarksEntries_SectionID",
                table: "MarksEntries");

            migrationBuilder.DropIndex(
                name: "IX_MarksEntries_SessionID",
                table: "MarksEntries");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Teachers");
        }
    }
}
