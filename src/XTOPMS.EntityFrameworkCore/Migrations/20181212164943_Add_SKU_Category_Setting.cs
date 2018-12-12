using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Add_SKU_Category_Setting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XTOPMS_Contract");

            migrationBuilder.RenameColumn(
                name: "ContractId",
                table: "XTOPMS_Project",
                newName: "SalesAgreement");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "XTOPMS_Task",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErpId",
                table: "XTOPMS_Task",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "XTOPMS_Task",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "XTOPMS_Task",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "XTOPMS_Quotation",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErpId",
                table: "XTOPMS_Quotation",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "XTOPMS_Quotation",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "XTOPMS_Quotation",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "XTOPMS_Project",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErpId",
                table: "XTOPMS_Project",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "XTOPMS_Project",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "XTOPMS_Project",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "XTOPMS_Opportunity",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "XTOPMS_Opportunity",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ErpId",
                table: "XTOPMS_Opportunity",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "XTOPMS_Opportunity",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AbpUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AbpUsers",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeNumber",
                table: "AbpUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtensionData",
                table: "AbpUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdCard",
                table: "AbpUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OrganizationUnitId",
                table: "AbpUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AbpUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "AbpUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "AbpUsers",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "XTOPMS_SalesAgreement",
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
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Code = table.Column<string>(maxLength: 256, nullable: true),
                    ErpId = table.Column<string>(maxLength: 256, nullable: true),
                    OpportunityId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_SalesAgreement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_SKU",
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
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Code = table.Column<string>(maxLength: 256, nullable: true),
                    ErpId = table.Column<string>(maxLength: 256, nullable: true),
                    ProductId = table.Column<long>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_SKU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_SKUCategory",
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
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Code = table.Column<string>(maxLength: 256, nullable: true),
                    ErpId = table.Column<string>(maxLength: 256, nullable: true),
                    WBS = table.Column<string>(maxLength: 256, nullable: true),
                    ParentId = table.Column<long>(nullable: false),
                    FullName = table.Column<string>(maxLength: 256, nullable: true),
                    IsSalesProperty = table.Column<bool>(nullable: false),
                    EditType = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_SKUCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_SKUCategoryValue",
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
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Code = table.Column<string>(maxLength: 256, nullable: true),
                    ErpId = table.Column<string>(maxLength: 256, nullable: true),
                    WBS = table.Column<string>(maxLength: 256, nullable: true),
                    SkuCategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_SKUCategoryValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_SKUProperty",
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
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Code = table.Column<string>(maxLength: 256, nullable: true),
                    ErpId = table.Column<string>(maxLength: 256, nullable: true),
                    Sku = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_SKUProperty", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XTOPMS_SalesAgreement");

            migrationBuilder.DropTable(
                name: "XTOPMS_SKU");

            migrationBuilder.DropTable(
                name: "XTOPMS_SKUCategory");

            migrationBuilder.DropTable(
                name: "XTOPMS_SKUCategoryValue");

            migrationBuilder.DropTable(
                name: "XTOPMS_SKUProperty");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "XTOPMS_Task");

            migrationBuilder.DropColumn(
                name: "ErpId",
                table: "XTOPMS_Task");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "XTOPMS_Task");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "XTOPMS_Task");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropColumn(
                name: "ErpId",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "XTOPMS_Project");

            migrationBuilder.DropColumn(
                name: "ErpId",
                table: "XTOPMS_Project");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "XTOPMS_Project");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "XTOPMS_Project");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "ErpId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "EmployeeNumber",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "ExtensionData",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "IdCard",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "OrganizationUnitId",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "AbpUsers");

            migrationBuilder.RenameColumn(
                name: "SalesAgreement",
                table: "XTOPMS_Project",
                newName: "ContractId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "XTOPMS_Opportunity",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "XTOPMS_Contract",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    OpportunityId = table.Column<long>(nullable: true),
                    OrganizationUnitId = table.Column<long>(nullable: true),
                    TenantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_Contract", x => x.Id);
                });
        }
    }
}
