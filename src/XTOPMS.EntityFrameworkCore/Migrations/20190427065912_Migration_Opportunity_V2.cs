using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Migration_Opportunity_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Opportunity_SalesId",
                table: "XTOPMS_Opportunity",
                column: "SalesId");

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_SalesId",
                table: "XTOPMS_Opportunity",
                column: "SalesId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_SalesId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Opportunity_SalesId",
                table: "XTOPMS_Opportunity");
        }
    }
}
