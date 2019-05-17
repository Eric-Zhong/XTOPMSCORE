using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Migration_AlibabaCallbackTB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RetryCount",
                table: "AlibabaMessage",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RetryCount",
                table: "AlibabaMessage");
        }
    }
}
