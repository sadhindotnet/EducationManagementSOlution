using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "TransactionMasters");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "AccountGroupTops");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "AccountGroupMides");

            migrationBuilder.DropColumn(
                name: "SchoolID",
                table: "AccountGroupLowers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TransactionMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "TransactionMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "TransactionMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TransactionDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "TransactionDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "TransactionDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "AccountGroupTops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "AccountGroupTops",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "AccountGroupMides",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "AccountGroupMides",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AccountGroupLowers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "AccountGroupLowers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "AccountGroupLowers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsBranchId",
                table: "AccountCharts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "AccountCharts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionMasters_InsBranchId",
                table: "TransactionMasters",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionMasters_InsId",
                table: "TransactionMasters",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionMasters_VoucherTypeID",
                table: "TransactionMasters",
                column: "VoucherTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_InsBranchId",
                table: "TransactionDetails",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_InsId",
                table: "TransactionDetails",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_TransactionMasterID",
                table: "TransactionDetails",
                column: "TransactionMasterID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroupTops_InsBranchId",
                table: "AccountGroupTops",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroupTops_InsId",
                table: "AccountGroupTops",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroupMides_InsBranchId",
                table: "AccountGroupMides",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroupMides_InsId",
                table: "AccountGroupMides",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroupMides_TopGroupID",
                table: "AccountGroupMides",
                column: "TopGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroupLowers_InsBranchId",
                table: "AccountGroupLowers",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroupLowers_InsId",
                table: "AccountGroupLowers",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountGroupLowers_MidGroupID",
                table: "AccountGroupLowers",
                column: "MidGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCharts_InsBranchId",
                table: "AccountCharts",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCharts_InsId",
                table: "AccountCharts",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCharts_LowergroupID",
                table: "AccountCharts",
                column: "LowergroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCharts_AccountGroupLowers_LowergroupID",
                table: "AccountCharts",
                column: "LowergroupID",
                principalTable: "AccountGroupLowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCharts_InsBranches_InsBranchId",
                table: "AccountCharts",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCharts_Institutes_InsId",
                table: "AccountCharts",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountGroupLowers_AccountGroupMides_MidGroupID",
                table: "AccountGroupLowers",
                column: "MidGroupID",
                principalTable: "AccountGroupMides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountGroupLowers_InsBranches_InsBranchId",
                table: "AccountGroupLowers",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountGroupLowers_Institutes_InsId",
                table: "AccountGroupLowers",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountGroupMides_AccountGroupTops_TopGroupID",
                table: "AccountGroupMides",
                column: "TopGroupID",
                principalTable: "AccountGroupTops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountGroupMides_InsBranches_InsBranchId",
                table: "AccountGroupMides",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountGroupMides_Institutes_InsId",
                table: "AccountGroupMides",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountGroupTops_InsBranches_InsBranchId",
                table: "AccountGroupTops",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountGroupTops_Institutes_InsId",
                table: "AccountGroupTops",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_InsBranches_InsBranchId",
                table: "TransactionDetails",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_Institutes_InsId",
                table: "TransactionDetails",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionDetails_TransactionMasters_TransactionMasterID",
                table: "TransactionDetails",
                column: "TransactionMasterID",
                principalTable: "TransactionMasters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionMasters_InsBranches_InsBranchId",
                table: "TransactionMasters",
                column: "InsBranchId",
                principalTable: "InsBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionMasters_Institutes_InsId",
                table: "TransactionMasters",
                column: "InsId",
                principalTable: "Institutes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionMasters_VoucherTypes_VoucherTypeID",
                table: "TransactionMasters",
                column: "VoucherTypeID",
                principalTable: "VoucherTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountCharts_AccountGroupLowers_LowergroupID",
                table: "AccountCharts");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountCharts_InsBranches_InsBranchId",
                table: "AccountCharts");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountCharts_Institutes_InsId",
                table: "AccountCharts");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountGroupLowers_AccountGroupMides_MidGroupID",
                table: "AccountGroupLowers");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountGroupLowers_InsBranches_InsBranchId",
                table: "AccountGroupLowers");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountGroupLowers_Institutes_InsId",
                table: "AccountGroupLowers");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountGroupMides_AccountGroupTops_TopGroupID",
                table: "AccountGroupMides");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountGroupMides_InsBranches_InsBranchId",
                table: "AccountGroupMides");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountGroupMides_Institutes_InsId",
                table: "AccountGroupMides");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountGroupTops_InsBranches_InsBranchId",
                table: "AccountGroupTops");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountGroupTops_Institutes_InsId",
                table: "AccountGroupTops");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_InsBranches_InsBranchId",
                table: "TransactionDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_Institutes_InsId",
                table: "TransactionDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionDetails_TransactionMasters_TransactionMasterID",
                table: "TransactionDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionMasters_InsBranches_InsBranchId",
                table: "TransactionMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionMasters_Institutes_InsId",
                table: "TransactionMasters");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionMasters_VoucherTypes_VoucherTypeID",
                table: "TransactionMasters");

            migrationBuilder.DropIndex(
                name: "IX_TransactionMasters_InsBranchId",
                table: "TransactionMasters");

            migrationBuilder.DropIndex(
                name: "IX_TransactionMasters_InsId",
                table: "TransactionMasters");

            migrationBuilder.DropIndex(
                name: "IX_TransactionMasters_VoucherTypeID",
                table: "TransactionMasters");

            migrationBuilder.DropIndex(
                name: "IX_TransactionDetails_InsBranchId",
                table: "TransactionDetails");

            migrationBuilder.DropIndex(
                name: "IX_TransactionDetails_InsId",
                table: "TransactionDetails");

            migrationBuilder.DropIndex(
                name: "IX_TransactionDetails_TransactionMasterID",
                table: "TransactionDetails");

            migrationBuilder.DropIndex(
                name: "IX_AccountGroupTops_InsBranchId",
                table: "AccountGroupTops");

            migrationBuilder.DropIndex(
                name: "IX_AccountGroupTops_InsId",
                table: "AccountGroupTops");

            migrationBuilder.DropIndex(
                name: "IX_AccountGroupMides_InsBranchId",
                table: "AccountGroupMides");

            migrationBuilder.DropIndex(
                name: "IX_AccountGroupMides_InsId",
                table: "AccountGroupMides");

            migrationBuilder.DropIndex(
                name: "IX_AccountGroupMides_TopGroupID",
                table: "AccountGroupMides");

            migrationBuilder.DropIndex(
                name: "IX_AccountGroupLowers_InsBranchId",
                table: "AccountGroupLowers");

            migrationBuilder.DropIndex(
                name: "IX_AccountGroupLowers_InsId",
                table: "AccountGroupLowers");

            migrationBuilder.DropIndex(
                name: "IX_AccountGroupLowers_MidGroupID",
                table: "AccountGroupLowers");

            migrationBuilder.DropIndex(
                name: "IX_AccountCharts_InsBranchId",
                table: "AccountCharts");

            migrationBuilder.DropIndex(
                name: "IX_AccountCharts_InsId",
                table: "AccountCharts");

            migrationBuilder.DropIndex(
                name: "IX_AccountCharts_LowergroupID",
                table: "AccountCharts");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "TransactionMasters");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "TransactionMasters");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "TransactionDetails");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "AccountGroupTops");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "AccountGroupTops");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "AccountGroupMides");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "AccountGroupMides");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "AccountGroupLowers");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "AccountGroupLowers");

            migrationBuilder.DropColumn(
                name: "InsBranchId",
                table: "AccountCharts");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "AccountCharts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TransactionMasters",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "TransactionMasters",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TransactionDetails",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "TransactionDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "AccountGroupTops",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "AccountGroupMides",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AccountGroupLowers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "SchoolID",
                table: "AccountGroupLowers",
                type: "int",
                nullable: true);
        }
    }
}
