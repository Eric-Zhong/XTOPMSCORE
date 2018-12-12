using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Add_Opportunity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "XTOPMS_Opportunity",
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
                    Name = table.Column<string>(nullable: true),
                    CompanyId = table.Column<long>(nullable: false),
                    PlantId = table.Column<long>(nullable: false),
                    SalesId = table.Column<long>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    Currency = table.Column<long>(nullable: false),
                    Country = table.Column<long>(nullable: false),
                    Province = table.Column<long>(nullable: false),
                    City = table.Column<long>(nullable: false),
                    Region = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XTOPMS_Opportunity", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "XTOPMS_Opportunity");
        }
    }
}
