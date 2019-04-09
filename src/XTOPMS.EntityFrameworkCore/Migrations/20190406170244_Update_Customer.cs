using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Update_Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "XTOPMS_Customer",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ParentCompanyId",
                table: "XTOPMS_Customer",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "XTOPMS_Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RateReason",
                table: "XTOPMS_Customer",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "XTOPMS_Customer",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "XTOPMS_Customer");

            migrationBuilder.DropColumn(
                name: "ParentCompanyId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "XTOPMS_Customer");

            migrationBuilder.DropColumn(
                name: "RateReason",
                table: "XTOPMS_Customer");

            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "XTOPMS_Customer");
        }
    }
}
