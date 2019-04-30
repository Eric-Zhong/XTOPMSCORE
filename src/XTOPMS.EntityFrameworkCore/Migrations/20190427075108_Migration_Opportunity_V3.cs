using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Migration_Opportunity_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_SalesId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.AlterColumn<long>(
                name: "SalesId",
                table: "XTOPMS_Opportunity",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_SalesId",
                table: "XTOPMS_Opportunity",
                column: "SalesId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_SalesId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.AlterColumn<long>(
                name: "SalesId",
                table: "XTOPMS_Opportunity",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_SalesId",
                table: "XTOPMS_Opportunity",
                column: "SalesId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
