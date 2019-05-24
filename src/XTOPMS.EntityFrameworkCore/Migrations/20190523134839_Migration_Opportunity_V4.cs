using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Migration_Opportunity_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "XTOPMS_Opportunity",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BidDeadline",
                table: "XTOPMS_Opportunity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "XTOPMS_Opportunity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "BidDeadline",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "XTOPMS_Opportunity");
        }
    }
}
