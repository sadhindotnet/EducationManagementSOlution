using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationManagement_DLL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AcademicDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountCharts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LowergroupID = table.Column<int>(type: "int", nullable: false),
                    AccountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTypeID = table.Column<int>(type: "int", nullable: false),
                    OpeningBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    table.PrimaryKey("PK_AccountCharts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountGroupLowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MidGroupID = table.Column<int>(type: "int", nullable: false),
                    LowerGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LowerGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTypeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountGroupLowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountGroupMides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopGroupID = table.Column<int>(type: "int", nullable: false),
                    MidGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MidGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTypeID = table.Column<int>(type: "int", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_AccountGroupMides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountGroupTops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTypeID = table.Column<int>(type: "int", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_AccountGroupTops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdministrativeDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AdministrativeDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeExperiences",
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
                    table.PrimaryKey("PK_EmployeeExperiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeQualification",
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
                    table.PrimaryKey("PK_EmployeeQualification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_EmployeesGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstituteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_InstituteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalCertificate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_NationalCertificate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MethodType = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Religions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShareHolderInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShareHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShareValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NoOfShare = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InActiveDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolID = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShareHolderInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionMasterID = table.Column<int>(type: "int", nullable: false),
                    VoucherDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeID = table.Column<int>(type: "int", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    DebitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RefAccountID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransactionMasters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueID = table.Column<int>(type: "int", nullable: false),
                    VoucherDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherTypeID = table.Column<int>(type: "int", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: true),
                    TotalDebitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalCreditAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CurrencyID = table.Column<int>(type: "int", nullable: true),
                    RefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChequeNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolID = table.Column<int>(type: "int", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionMasters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoucherTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucharName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrefixCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_VoucherTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Institutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstituteName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminEmailPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BannerPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstituteTypeId = table.Column<int>(type: "int", nullable: false),
                    Ownership = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Institutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institutes_InstituteTypes_InstituteTypeId",
                        column: x => x.InstituteTypeId,
                        principalTable: "InstituteTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsBranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConatcNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMainbranch = table.Column<bool>(type: "bit", nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    GenderType = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_InsBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsBranches_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_AcademicSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicSessions_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademicSessions_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AcademyClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationYear = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AcademyClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademyClasses_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcademyClasses_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    InstituteID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_InsBranches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Institutes_InstituteID",
                        column: x => x.InstituteID,
                        principalTable: "Institutes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesigName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Designations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designations_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Designations_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    StartPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_Directors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Directors_AdministrativeDepartments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "AdministrativeDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Directors_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Directors_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationalGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_EducationalGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalGroups_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EducationalGroups_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ProgramGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramGroups_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramGroups_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shifts_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsibilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staffs_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StdPaymentSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LateFeePercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LateFeeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDuration = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_StdPaymentSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdPaymentSettings_InsBranches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StdPaymentSettings_Institutes_InstituteID",
                        column: x => x.InstituteID,
                        principalTable: "Institutes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentBasicInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StdID = table.Column<int>(type: "int", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentFatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentFathersProfession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentFathersNID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentFathersContract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentMotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentMothersProfession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentMothersNID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentMothersContract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentContract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentEmargencyContract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentBirthRegNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentMarritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentPresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentPermanentAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentNationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReligionId = table.Column<int>(type: "int", nullable: true),
                    StudentBloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGender = table.Column<int>(type: "int", nullable: false),
                    StudentLocalGurdian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLocalGurdianAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentLocalGurdianContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentPicturePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentStatus = table.Column<int>(type: "int", nullable: false),
                    InstituteID = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_StudentBasicInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentBasicInfos_InsBranches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentBasicInfos_Institutes_InstituteID",
                        column: x => x.InstituteID,
                        principalTable: "Institutes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClassSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademyClassId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ClassSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSections_AcademyClasses_AcademyClassId",
                        column: x => x.AcademyClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSections_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassSections_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassWiseFees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountChartId = table.Column<int>(type: "int", nullable: false),
                    InstituteID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ClassWiseFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassWiseFees_AcademyClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassWiseFees_AccountCharts_AccountChartId",
                        column: x => x.AccountChartId,
                        principalTable: "AccountCharts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassWiseFees_InsBranches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassWiseFees_Institutes_InstituteID",
                        column: x => x.InstituteID,
                        principalTable: "Institutes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StdInvoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StdID = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    AccountChartId = table.Column<int>(type: "int", nullable: false),
                    InstituteID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_StdInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdInvoices_AcademyClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StdInvoices_AccountCharts_AccountChartId",
                        column: x => x.AccountChartId,
                        principalTable: "AccountCharts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StdInvoices_InsBranches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StdInvoices_Institutes_InstituteID",
                        column: x => x.InstituteID,
                        principalTable: "Institutes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIDNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JoinigDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReligionId = table.Column<int>(type: "int", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRESENTADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PERMANENTADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthRegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DesignationID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Designations_DesignationID",
                        column: x => x.DesignationID,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    IsOptional = table.Column<bool>(type: "bit", nullable: false),
                    EducationalGroupId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_SubjectInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectInfos_EducationalGroups_EducationalGroupId",
                        column: x => x.EducationalGroupId,
                        principalTable: "EducationalGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectInfos_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectInfos_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramGroupId = table.Column<int>(type: "int", nullable: false),
                    StartLevel = table.Column<int>(type: "int", nullable: false),
                    EndLevel = table.Column<int>(type: "int", nullable: false),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsId = table.Column<int>(type: "int", nullable: false),
                    InsBranchId = table.Column<int>(type: "int", nullable: false),
                    InstituteTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Programs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programs_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Programs_InstituteTypes_InstituteTypeId",
                        column: x => x.InstituteTypeId,
                        principalTable: "InstituteTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Programs_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Programs_ProgramGroups_ProgramGroupId",
                        column: x => x.ProgramGroupId,
                        principalTable: "ProgramGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShiftwiseClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    ShiftId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ShiftwiseClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShiftwiseClasses_AcademyClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShiftwiseClasses_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShiftwiseClasses_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShiftwiseClasses_Shifts_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StdPayments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StdID = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    MethodType = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituteID = table.Column<int>(type: "int", nullable: true),
                    BranchID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_StdPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdPayments_InsBranches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StdPayments_Institutes_InstituteID",
                        column: x => x.InstituteID,
                        principalTable: "Institutes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StdPayments_StdInvoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "StdInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<int>(type: "int", nullable: false),
                    SalaryAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_EmployeeSalaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSalaries_Employees_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSalaries_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeSalaries_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesEducations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    NationalCertificateID = table.Column<int>(type: "int", nullable: false),
                    AchievedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_EmployeesEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesEducations_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesEducations_NationalCertificate_NationalCertificateID",
                        column: x => x.NationalCertificateID,
                        principalTable: "NationalCertificate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeWithGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    EmpID = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_EmployeeWithGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeWithGroups_EmployeesGroups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "EmployeesGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeWithGroups_Employees_EmpID",
                        column: x => x.EmpID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Employees_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teachers_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassWiseSubjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SubId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_ClassWiseSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassWiseSubjects_AcademyClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassWiseSubjects_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassWiseSubjects_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassWiseSubjects_SubjectInfos_SubId",
                        column: x => x.SubId,
                        principalTable: "SubjectInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSubjecTeacherIns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
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
                    table.PrimaryKey("PK_ClassSubjecTeacherIns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSubjecTeacherIns_AcademyClasses_ClassId",
                        column: x => x.ClassId,
                        principalTable: "AcademyClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubjecTeacherIns_InsBranches_InsBranchId",
                        column: x => x.InsBranchId,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassSubjecTeacherIns_Institutes_InsId",
                        column: x => x.InsId,
                        principalTable: "Institutes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassSubjecTeacherIns_SubjectInfos_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "SubjectInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubjecTeacherIns_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StdtAcademicInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    ShiftID = table.Column<int>(type: "int", nullable: false),
                    SectionID = table.Column<int>(type: "int", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RollNo = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<float>(type: "real", nullable: false),
                    Medium = table.Column<int>(type: "int", nullable: false),
                    ClassSubjecTeacherInsId = table.Column<int>(type: "int", nullable: false),
                    ClassSectionId = table.Column<int>(type: "int", nullable: false),
                    AcademicSessionId = table.Column<int>(type: "int", nullable: true),
                    InstituteID = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_StdtAcademicInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StdtAcademicInfos_AcademicSessions_AcademicSessionId",
                        column: x => x.AcademicSessionId,
                        principalTable: "AcademicSessions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StdtAcademicInfos_ClassSections_ClassSectionId",
                        column: x => x.ClassSectionId,
                        principalTable: "ClassSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StdtAcademicInfos_ClassSubjecTeacherIns_ClassSubjecTeacherInsId",
                        column: x => x.ClassSubjecTeacherInsId,
                        principalTable: "ClassSubjecTeacherIns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StdtAcademicInfos_InsBranches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "InsBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StdtAcademicInfos_Institutes_InstituteID",
                        column: x => x.InstituteID,
                        principalTable: "Institutes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StdtAcademicInfos_Shifts_ShiftID",
                        column: x => x.ShiftID,
                        principalTable: "Shifts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StdtAcademicInfos_StudentBasicInfos_StdID",
                        column: x => x.StdID,
                        principalTable: "StudentBasicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSessions_InsBranchId",
                table: "AcademicSessions",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicSessions_InsId",
                table: "AcademicSessions",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyClasses_InsBranchId",
                table: "AcademyClasses",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyClasses_InsId",
                table: "AcademyClasses",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_BranchID",
                table: "AspNetUsers",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_InstituteID",
                table: "AspNetUsers",
                column: "InstituteID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSections_AcademyClassId",
                table: "ClassSections",
                column: "AcademyClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSections_InsBranchId",
                table: "ClassSections",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSections_InsId",
                table: "ClassSections",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjecTeacherIns_ClassId",
                table: "ClassSubjecTeacherIns",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjecTeacherIns_InsBranchId",
                table: "ClassSubjecTeacherIns",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjecTeacherIns_InsId",
                table: "ClassSubjecTeacherIns",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjecTeacherIns_SubjectId",
                table: "ClassSubjecTeacherIns",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjecTeacherIns_TeacherId",
                table: "ClassSubjecTeacherIns",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWiseFees_AccountChartId",
                table: "ClassWiseFees",
                column: "AccountChartId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWiseFees_BranchID",
                table: "ClassWiseFees",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWiseFees_ClassID",
                table: "ClassWiseFees",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWiseFees_InstituteID",
                table: "ClassWiseFees",
                column: "InstituteID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWiseSubjects_ClassId",
                table: "ClassWiseSubjects",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWiseSubjects_InsBranchId",
                table: "ClassWiseSubjects",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWiseSubjects_InsId",
                table: "ClassWiseSubjects",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassWiseSubjects_SubId",
                table: "ClassWiseSubjects",
                column: "SubId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_InsBranchId",
                table: "Designations",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_InsId",
                table: "Designations",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_DepartmentID",
                table: "Directors",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_InsBranchId",
                table: "Directors",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_InsId",
                table: "Directors",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalGroups_InsBranchId",
                table: "EducationalGroups",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalGroups_InsId",
                table: "EducationalGroups",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DesignationID",
                table: "Employees",
                column: "DesignationID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_InsBranchId",
                table: "Employees",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_InsId",
                table: "Employees",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReligionId",
                table: "Employees",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalaries_EmpId",
                table: "EmployeeSalaries",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalaries_InsBranchId",
                table: "EmployeeSalaries",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalaries_InsId",
                table: "EmployeeSalaries",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesEducations_EmployeeID",
                table: "EmployeesEducations",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesEducations_NationalCertificateID",
                table: "EmployeesEducations",
                column: "NationalCertificateID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWithGroups_EmpID",
                table: "EmployeeWithGroups",
                column: "EmpID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWithGroups_GroupID",
                table: "EmployeeWithGroups",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_InsBranches_InsId",
                table: "InsBranches",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutes_InstituteName_ShortName",
                table: "Institutes",
                columns: new[] { "InstituteName", "ShortName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Institutes_InstituteTypeId",
                table: "Institutes",
                column: "InstituteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramGroups_InsBranchId",
                table: "ProgramGroups",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramGroups_InsId",
                table: "ProgramGroups",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_InsBranchId",
                table: "Programs",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_InsId",
                table: "Programs",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_InstituteTypeId",
                table: "Programs",
                column: "InstituteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_ProgramGroupId",
                table: "Programs",
                column: "ProgramGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_InsBranchId",
                table: "Shifts",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_InsId",
                table: "Shifts",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftwiseClasses_ClassId",
                table: "ShiftwiseClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftwiseClasses_InsBranchId",
                table: "ShiftwiseClasses",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftwiseClasses_InsId",
                table: "ShiftwiseClasses",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftwiseClasses_ShiftId",
                table: "ShiftwiseClasses",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_InsBranchId",
                table: "Staffs",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_InsId",
                table: "Staffs",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_StdInvoices_AccountChartId",
                table: "StdInvoices",
                column: "AccountChartId");

            migrationBuilder.CreateIndex(
                name: "IX_StdInvoices_BranchID",
                table: "StdInvoices",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_StdInvoices_ClassId",
                table: "StdInvoices",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StdInvoices_InstituteID",
                table: "StdInvoices",
                column: "InstituteID");

            migrationBuilder.CreateIndex(
                name: "IX_StdPayments_BranchID",
                table: "StdPayments",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_StdPayments_InstituteID",
                table: "StdPayments",
                column: "InstituteID");

            migrationBuilder.CreateIndex(
                name: "IX_StdPayments_InvoiceId",
                table: "StdPayments",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StdPaymentSettings_BranchID",
                table: "StdPaymentSettings",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_StdPaymentSettings_InstituteID",
                table: "StdPaymentSettings",
                column: "InstituteID");

            migrationBuilder.CreateIndex(
                name: "IX_StdtAcademicInfos_AcademicSessionId",
                table: "StdtAcademicInfos",
                column: "AcademicSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_StdtAcademicInfos_BranchID",
                table: "StdtAcademicInfos",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_StdtAcademicInfos_ClassSectionId",
                table: "StdtAcademicInfos",
                column: "ClassSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StdtAcademicInfos_ClassSubjecTeacherInsId",
                table: "StdtAcademicInfos",
                column: "ClassSubjecTeacherInsId");

            migrationBuilder.CreateIndex(
                name: "IX_StdtAcademicInfos_InstituteID",
                table: "StdtAcademicInfos",
                column: "InstituteID");

            migrationBuilder.CreateIndex(
                name: "IX_StdtAcademicInfos_ShiftID",
                table: "StdtAcademicInfos",
                column: "ShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_StdtAcademicInfos_StdID",
                table: "StdtAcademicInfos",
                column: "StdID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentBasicInfos_BranchId",
                table: "StudentBasicInfos",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentBasicInfos_InstituteID",
                table: "StudentBasicInfos",
                column: "InstituteID");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectInfos_EducationalGroupId",
                table: "SubjectInfos",
                column: "EducationalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectInfos_InsBranchId",
                table: "SubjectInfos",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectInfos_InsId",
                table: "SubjectInfos",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_EmpId",
                table: "Teachers",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_InsBranchId",
                table: "Teachers",
                column: "InsBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_InsId",
                table: "Teachers",
                column: "InsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicDepartments");

            migrationBuilder.DropTable(
                name: "AccountGroupLowers");

            migrationBuilder.DropTable(
                name: "AccountGroupMides");

            migrationBuilder.DropTable(
                name: "AccountGroupTops");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ClassWiseFees");

            migrationBuilder.DropTable(
                name: "ClassWiseSubjects");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "EmployeeExperiences");

            migrationBuilder.DropTable(
                name: "EmployeeQualification");

            migrationBuilder.DropTable(
                name: "EmployeeSalaries");

            migrationBuilder.DropTable(
                name: "EmployeesEducations");

            migrationBuilder.DropTable(
                name: "EmployeeWithGroups");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "ShareHolderInformations");

            migrationBuilder.DropTable(
                name: "ShiftwiseClasses");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "StdPayments");

            migrationBuilder.DropTable(
                name: "StdPaymentSettings");

            migrationBuilder.DropTable(
                name: "StdtAcademicInfos");

            migrationBuilder.DropTable(
                name: "TransactionDetails");

            migrationBuilder.DropTable(
                name: "TransactionMasters");

            migrationBuilder.DropTable(
                name: "VoucherTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AdministrativeDepartments");

            migrationBuilder.DropTable(
                name: "NationalCertificate");

            migrationBuilder.DropTable(
                name: "EmployeesGroups");

            migrationBuilder.DropTable(
                name: "ProgramGroups");

            migrationBuilder.DropTable(
                name: "StdInvoices");

            migrationBuilder.DropTable(
                name: "AcademicSessions");

            migrationBuilder.DropTable(
                name: "ClassSections");

            migrationBuilder.DropTable(
                name: "ClassSubjecTeacherIns");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "StudentBasicInfos");

            migrationBuilder.DropTable(
                name: "AccountCharts");

            migrationBuilder.DropTable(
                name: "AcademyClasses");

            migrationBuilder.DropTable(
                name: "SubjectInfos");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "EducationalGroups");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "InsBranches");

            migrationBuilder.DropTable(
                name: "Institutes");

            migrationBuilder.DropTable(
                name: "InstituteTypes");
        }
    }
}
