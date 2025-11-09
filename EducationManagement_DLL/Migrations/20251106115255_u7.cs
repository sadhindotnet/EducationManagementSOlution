using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class u7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StdtAcademicInfos_AcademicSessions_AcademicSessionId",
                table: "StdtAcademicInfos");

            migrationBuilder.RenameColumn(
                name: "AcademicSessionId",
                table: "StdtAcademicInfos",
                newName: "academicSessionId");

            migrationBuilder.RenameIndex(
                name: "IX_StdtAcademicInfos_AcademicSessionId",
                table: "StdtAcademicInfos",
                newName: "IX_StdtAcademicInfos_academicSessionId");

            migrationBuilder.AlterColumn<int>(
                name: "academicSessionId",
                table: "StdtAcademicInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeesJobHistroy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    StartPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NationalCertificateId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_EmployeesJobHistroy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesJobHistroy_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesJobHistroy_NationalCertificate_NationalCertificateId",
                        column: x => x.NationalCertificateId,
                        principalTable: "NationalCertificate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StdtAcademicInfos_SessionId",
                table: "StdtAcademicInfos",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_EmployeeID",
                table: "Staffs",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesJobHistroy_EmployeeID",
                table: "EmployeesJobHistroy",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesJobHistroy_NationalCertificateId",
                table: "EmployeesJobHistroy",
                column: "NationalCertificateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Employees_EmployeeID",
                table: "Staffs",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StdtAcademicInfos_AcademicSessions_SessionId",
                table: "StdtAcademicInfos",
                column: "SessionId",
                principalTable: "AcademicSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StdtAcademicInfos_AcademicSessions_academicSessionId",
                table: "StdtAcademicInfos",
                column: "academicSessionId",
                principalTable: "AcademicSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Employees_EmployeeID",
                table: "Staffs");

            migrationBuilder.DropForeignKey(
                name: "FK_StdtAcademicInfos_AcademicSessions_SessionId",
                table: "StdtAcademicInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_StdtAcademicInfos_AcademicSessions_academicSessionId",
                table: "StdtAcademicInfos");

            migrationBuilder.DropTable(
                name: "EmployeesJobHistroy");

            migrationBuilder.DropIndex(
                name: "IX_StdtAcademicInfos_SessionId",
                table: "StdtAcademicInfos");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_EmployeeID",
                table: "Staffs");

            migrationBuilder.RenameColumn(
                name: "academicSessionId",
                table: "StdtAcademicInfos",
                newName: "AcademicSessionId");

            migrationBuilder.RenameIndex(
                name: "IX_StdtAcademicInfos_academicSessionId",
                table: "StdtAcademicInfos",
                newName: "IX_StdtAcademicInfos_AcademicSessionId");

            migrationBuilder.AlterColumn<int>(
                name: "AcademicSessionId",
                table: "StdtAcademicInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_StdtAcademicInfos_AcademicSessions_AcademicSessionId",
                table: "StdtAcademicInfos",
                column: "AcademicSessionId",
                principalTable: "AcademicSessions",
                principalColumn: "Id");
        }
    }
}
