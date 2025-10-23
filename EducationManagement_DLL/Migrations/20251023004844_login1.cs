using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class login1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LoginModels");

            migrationBuilder.DropColumn(
                name: "DomainName",
                table: "LoginModels");

            migrationBuilder.DropColumn(
                name: "IP",
                table: "LoginModels");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "LoginModels");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "LoginModels");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "LoginModels");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "LoginModels",
                newName: "LogoutTime");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "LoginModels",
                newName: "LoggedTime");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LogoutTime",
                table: "LoginModels",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "LoggedTime",
                table: "LoginModels",
                newName: "CreatedDate");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LoginModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DomainName",
                table: "LoginModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IP",
                table: "LoginModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "LoginModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "LoginModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "LoginModels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
