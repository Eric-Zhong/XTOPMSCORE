using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Migration_CustomerV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Customer_XTOPMS_Customer_ParentIdId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Customer_ParentIdId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropColumn(
                name: "ParentIdId",
                table: "XTOPMS_Customer");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Customer_ParentId",
                table: "XTOPMS_Customer",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Customer_XTOPMS_Customer_ParentId",
                table: "XTOPMS_Customer",
                column: "ParentId",
                principalTable: "XTOPMS_Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Customer_XTOPMS_Customer_ParentId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Customer_ParentId",
                table: "XTOPMS_Customer");

            migrationBuilder.AddColumn<long>(
                name: "ParentIdId",
                table: "XTOPMS_Customer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Customer_ParentIdId",
                table: "XTOPMS_Customer",
                column: "ParentIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Customer_XTOPMS_Customer_ParentIdId",
                table: "XTOPMS_Customer",
                column: "ParentIdId",
                principalTable: "XTOPMS_Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
