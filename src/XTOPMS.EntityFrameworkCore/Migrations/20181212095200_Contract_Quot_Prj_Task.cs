using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Contract_Quot_Prj_Task : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.AddColumn<string>(
                name: "ExtensionData",
                table: "XTOPMS_Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OrganizationUnitId",
                table: "XTOPMS_Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "XTOPMS_Opportunity",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "XTOPMS_Contract",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    OrganizationUnitId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    OpportunityId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_Contract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_Project",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    OrganizationUnitId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    ContractId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_Quotation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    OrganizationUnitId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    OpportunityId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_Quotation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_Task",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    OrganizationUnitId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_Task", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XTOPMS_Contract");

            migrationBuilder.DropTable(
                name: "XTOPMS_Project");

            migrationBuilder.DropTable(
                name: "XTOPMS_Quotation");

            migrationBuilder.DropTable(
                name: "XTOPMS_Task");

            migrationBuilder.DropColumn(
                name: "ExtensionData",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "OrganizationUnitId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.AddColumn<long>(
                name: "CompanyId",
                table: "XTOPMS_Opportunity",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "PlantId",
                table: "XTOPMS_Opportunity",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
