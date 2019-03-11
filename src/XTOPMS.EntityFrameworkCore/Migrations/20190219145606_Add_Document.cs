using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Add_Document : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "XTOPMS_Document",
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
                    FileId = table.Column<string>(nullable: true),
                    BizCode = table.Column<string>(nullable: true),
                    BizId = table.Column<string>(nullable: true),
                    CategoryCode = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    OrginalName = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    FilePath = table.Column<string>(nullable: true),
                    RelativePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_Document", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XTOPMS_Document");
        }
    }
}
