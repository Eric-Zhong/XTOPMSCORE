using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Migration_Customer_Category_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentCompanyId",
                table: "XTOPMS_Customer");

            migrationBuilder.AddColumn<string>(
                name: "BusinessCategoryId",
                table: "XTOPMS_Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ParentId",
                table: "XTOPMS_Customer",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ParentIdId",
                table: "XTOPMS_Customer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "XTOPMS_BusinessCategory",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ParentId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    FullKey = table.Column<string>(nullable: true),
                    FullPath = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    IsLeaf = table.Column<bool>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_BusinessCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XTOPMS_BusinessCategory_XTOPMS_BusinessCategory_ParentId",
                        column: x => x.ParentId,
                        principalTable: "XTOPMS_BusinessCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_CustomerCategory",
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
                    TenantId = table.Column<int>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Code = table.Column<string>(maxLength: 255, nullable: true),
                    ErpId = table.Column<string>(maxLength: 255, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_CustomerCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XTOPMS_CustomerCategory_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_XTOPMS_CustomerCategory_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_XTOPMS_CustomerCategory_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "XTOPMS_CustomerCategorySetting",
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
                    TenantId = table.Column<int>(nullable: false),
                    ExtensionData = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Code = table.Column<string>(maxLength: 255, nullable: true),
                    ErpId = table.Column<string>(maxLength: 255, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CustomerId = table.Column<long>(nullable: false),
                    CustomerCategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_CustomerCategorySetting", x => new { x.Id, x.CustomerId, x.CustomerCategoryId });
                    table.ForeignKey(
                        name: "FK_XTOPMS_CustomerCategorySetting_AbpUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_XTOPMS_CustomerCategorySetting_XTOPMS_CustomerCategory_Custo~",
                        column: x => x.CustomerCategoryId,
                        principalTable: "XTOPMS_CustomerCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_XTOPMS_CustomerCategorySetting_XTOPMS_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "XTOPMS_Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_XTOPMS_CustomerCategorySetting_AbpUsers_DeleterUserId",
                        column: x => x.DeleterUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_XTOPMS_CustomerCategorySetting_AbpUsers_LastModifierUserId",
                        column: x => x.LastModifierUserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Opportunity_AgencyId",
                table: "XTOPMS_Opportunity",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Opportunity_BusinessCategoryId",
                table: "XTOPMS_Opportunity",
                column: "BusinessCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Opportunity_GeneralContractorId",
                table: "XTOPMS_Opportunity",
                column: "GeneralContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Opportunity_OwnerId",
                table: "XTOPMS_Opportunity",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Customer_ParentIdId",
                table: "XTOPMS_Customer",
                column: "ParentIdId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_BusinessCategory_ParentId",
                table: "XTOPMS_BusinessCategory",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_CustomerCategory_CreatorUserId",
                table: "XTOPMS_CustomerCategory",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_CustomerCategory_DeleterUserId",
                table: "XTOPMS_CustomerCategory",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_CustomerCategory_LastModifierUserId",
                table: "XTOPMS_CustomerCategory",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_CustomerCategorySetting_CreatorUserId",
                table: "XTOPMS_CustomerCategorySetting",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_CustomerCategorySetting_CustomerCategoryId",
                table: "XTOPMS_CustomerCategorySetting",
                column: "CustomerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_CustomerCategorySetting_CustomerId",
                table: "XTOPMS_CustomerCategorySetting",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_CustomerCategorySetting_DeleterUserId",
                table: "XTOPMS_CustomerCategorySetting",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_CustomerCategorySetting_LastModifierUserId",
                table: "XTOPMS_CustomerCategorySetting",
                column: "LastModifierUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Customer_XTOPMS_Customer_ParentIdId",
                table: "XTOPMS_Customer",
                column: "ParentIdId",
                principalTable: "XTOPMS_Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_XTOPMS_Customer_AgencyId",
                table: "XTOPMS_Opportunity",
                column: "AgencyId",
                principalTable: "XTOPMS_Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_XTOPMS_BusinessCategory_BusinessCategoryId",
                table: "XTOPMS_Opportunity",
                column: "BusinessCategoryId",
                principalTable: "XTOPMS_BusinessCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_XTOPMS_Customer_GeneralContractorId",
                table: "XTOPMS_Opportunity",
                column: "GeneralContractorId",
                principalTable: "XTOPMS_Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_XTOPMS_Customer_OwnerId",
                table: "XTOPMS_Opportunity",
                column: "OwnerId",
                principalTable: "XTOPMS_Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Customer_XTOPMS_Customer_ParentIdId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_XTOPMS_Customer_AgencyId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_XTOPMS_BusinessCategory_BusinessCategoryId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_XTOPMS_Customer_GeneralContractorId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_XTOPMS_Customer_OwnerId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropTable(
                name: "XTOPMS_BusinessCategory");

            migrationBuilder.DropTable(
                name: "XTOPMS_CustomerCategorySetting");

            migrationBuilder.DropTable(
                name: "XTOPMS_CustomerCategory");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Opportunity_AgencyId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Opportunity_BusinessCategoryId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Opportunity_GeneralContractorId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Opportunity_OwnerId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Customer_ParentIdId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropColumn(
                name: "BusinessCategoryId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropColumn(
                name: "ParentIdId",
                table: "XTOPMS_Customer");

            migrationBuilder.AddColumn<long>(
                name: "ParentCompanyId",
                table: "XTOPMS_Customer",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
