using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class cl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrgId",
                table: "AcademyClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AcademyClasses_PrgId",
                table: "AcademyClasses",
                column: "PrgId");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademyClasses_Programs_PrgId",
                table: "AcademyClasses",
                column: "PrgId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademyClasses_Programs_PrgId",
                table: "AcademyClasses");

            migrationBuilder.DropIndex(
                name: "IX_AcademyClasses_PrgId",
                table: "AcademyClasses");

            migrationBuilder.DropColumn(
                name: "PrgId",
                table: "AcademyClasses");
        }
    }
}
