using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class grade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_AcademyClasses_ClassID",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_InsBranches_InsBranchId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Institutes_InsId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_ClassID",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_InsBranchId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_InsId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "ClassInterval",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "Grades");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassID",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ClassInterval",
                table: "Grades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "Grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_AcademyClasses_ClassID",
                table: "Grades",
                column: "ClassID",
                principalTable: "AcademyClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_InsBranches_InsBranchId",
                table: "Grades",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Institutes_InsId",
                table: "Grades",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
