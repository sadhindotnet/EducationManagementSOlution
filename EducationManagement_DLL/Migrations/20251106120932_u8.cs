using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class u8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesJobHistroy_NationalCertificate_NationalCertificateId",
                table: "EmployeesJobHistroy");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesJobHistroy_NationalCertificateId",
                table: "EmployeesJobHistroy");

            migrationBuilder.DropColumn(
                name: "NationalCertificateId",
                table: "EmployeesJobHistroy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NationalCertificateId",
                table: "EmployeesJobHistroy",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesJobHistroy_NationalCertificateId",
                table: "EmployeesJobHistroy",
                column: "NationalCertificateId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesJobHistroy_NationalCertificate_NationalCertificateId",
                table: "EmployeesJobHistroy",
                column: "NationalCertificateId",
                principalTable: "NationalCertificate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
