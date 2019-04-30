using Microsoft.EntityFrameworkCore.Migrations;

namespace XTOPMS.Migrations
{
    public partial class Migration_DataSyncService_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Task_CreatorUserId",
                table: "XTOPMS_Task",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Task_DeleterUserId",
                table: "XTOPMS_Task",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Task_LastModifierUserId",
                table: "XTOPMS_Task",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUProperty_CreatorUserId",
                table: "XTOPMS_SKUProperty",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUProperty_DeleterUserId",
                table: "XTOPMS_SKUProperty",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUProperty_LastModifierUserId",
                table: "XTOPMS_SKUProperty",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUCategoryValue_CreatorUserId",
                table: "XTOPMS_SKUCategoryValue",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUCategoryValue_DeleterUserId",
                table: "XTOPMS_SKUCategoryValue",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUCategoryValue_LastModifierUserId",
                table: "XTOPMS_SKUCategoryValue",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUCategory_CreatorUserId",
                table: "XTOPMS_SKUCategory",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUCategory_DeleterUserId",
                table: "XTOPMS_SKUCategory",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKUCategory_LastModifierUserId",
                table: "XTOPMS_SKUCategory",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKU_CreatorUserId",
                table: "XTOPMS_SKU",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKU_DeleterUserId",
                table: "XTOPMS_SKU",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SKU_LastModifierUserId",
                table: "XTOPMS_SKU",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SalesAgreement_CreatorUserId",
                table: "XTOPMS_SalesAgreement",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SalesAgreement_DeleterUserId",
                table: "XTOPMS_SalesAgreement",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_SalesAgreement_LastModifierUserId",
                table: "XTOPMS_SalesAgreement",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Quotation_CreatorUserId",
                table: "XTOPMS_Quotation",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Quotation_DeleterUserId",
                table: "XTOPMS_Quotation",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Quotation_LastModifierUserId",
                table: "XTOPMS_Quotation",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Project_CreatorUserId",
                table: "XTOPMS_Project",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Project_DeleterUserId",
                table: "XTOPMS_Project",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Project_LastModifierUserId",
                table: "XTOPMS_Project",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Opportunity_CreatorUserId",
                table: "XTOPMS_Opportunity",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Opportunity_DeleterUserId",
                table: "XTOPMS_Opportunity",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Opportunity_LastModifierUserId",
                table: "XTOPMS_Opportunity",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Document_CreatorUserId",
                table: "XTOPMS_Document",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Document_DeleterUserId",
                table: "XTOPMS_Document",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Document_LastModifierUserId",
                table: "XTOPMS_Document",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Customer_CreatorUserId",
                table: "XTOPMS_Customer",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Customer_DeleterUserId",
                table: "XTOPMS_Customer",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_XTOPMS_Customer_LastModifierUserId",
                table: "XTOPMS_Customer",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Alibaba_DataSyncService_AccessTokenId",
                table: "Alibaba_DataSyncService",
                column: "AccessTokenId");

            migrationBuilder.CreateIndex(
                name: "IX_Alibaba_DataSyncService_CreatorUserId",
                table: "Alibaba_DataSyncService",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Alibaba_DataSyncService_DeleterUserId",
                table: "Alibaba_DataSyncService",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Alibaba_DataSyncService_LastModifierUserId",
                table: "Alibaba_DataSyncService",
                column: "LastModifierUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Alibaba_AccessToken_CreatorUserId",
                table: "Alibaba_AccessToken",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Alibaba_AccessToken_DeleterUserId",
                table: "Alibaba_AccessToken",
                column: "DeleterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Alibaba_AccessToken_LastModifierUserId",
                table: "Alibaba_AccessToken",
                column: "LastModifierUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alibaba_AccessToken_AbpUsers_CreatorUserId",
                table: "Alibaba_AccessToken",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alibaba_AccessToken_AbpUsers_DeleterUserId",
                table: "Alibaba_AccessToken",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alibaba_AccessToken_AbpUsers_LastModifierUserId",
                table: "Alibaba_AccessToken",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alibaba_DataSyncService_Alibaba_AccessToken_AccessTokenId",
                table: "Alibaba_DataSyncService",
                column: "AccessTokenId",
                principalTable: "Alibaba_AccessToken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Alibaba_DataSyncService_AbpUsers_CreatorUserId",
                table: "Alibaba_DataSyncService",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alibaba_DataSyncService_AbpUsers_DeleterUserId",
                table: "Alibaba_DataSyncService",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alibaba_DataSyncService_AbpUsers_LastModifierUserId",
                table: "Alibaba_DataSyncService",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Customer_AbpUsers_CreatorUserId",
                table: "XTOPMS_Customer",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Customer_AbpUsers_DeleterUserId",
                table: "XTOPMS_Customer",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Customer_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Customer",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Document_AbpUsers_CreatorUserId",
                table: "XTOPMS_Document",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Document_AbpUsers_DeleterUserId",
                table: "XTOPMS_Document",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Document_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Document",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_CreatorUserId",
                table: "XTOPMS_Opportunity",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_DeleterUserId",
                table: "XTOPMS_Opportunity",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Opportunity",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Project_AbpUsers_CreatorUserId",
                table: "XTOPMS_Project",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Project_AbpUsers_DeleterUserId",
                table: "XTOPMS_Project",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Project_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Project",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Quotation_AbpUsers_CreatorUserId",
                table: "XTOPMS_Quotation",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Quotation_AbpUsers_DeleterUserId",
                table: "XTOPMS_Quotation",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Quotation_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Quotation",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SalesAgreement_AbpUsers_CreatorUserId",
                table: "XTOPMS_SalesAgreement",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SalesAgreement_AbpUsers_DeleterUserId",
                table: "XTOPMS_SalesAgreement",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SalesAgreement_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SalesAgreement",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKU_AbpUsers_CreatorUserId",
                table: "XTOPMS_SKU",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKU_AbpUsers_DeleterUserId",
                table: "XTOPMS_SKU",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKU_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SKU",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUCategory_AbpUsers_CreatorUserId",
                table: "XTOPMS_SKUCategory",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUCategory_AbpUsers_DeleterUserId",
                table: "XTOPMS_SKUCategory",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUCategory_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SKUCategory",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUCategoryValue_AbpUsers_CreatorUserId",
                table: "XTOPMS_SKUCategoryValue",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUCategoryValue_AbpUsers_DeleterUserId",
                table: "XTOPMS_SKUCategoryValue",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUCategoryValue_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SKUCategoryValue",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUProperty_AbpUsers_CreatorUserId",
                table: "XTOPMS_SKUProperty",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUProperty_AbpUsers_DeleterUserId",
                table: "XTOPMS_SKUProperty",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_SKUProperty_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SKUProperty",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Task_AbpUsers_CreatorUserId",
                table: "XTOPMS_Task",
                column: "CreatorUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Task_AbpUsers_DeleterUserId",
                table: "XTOPMS_Task",
                column: "DeleterUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_XTOPMS_Task_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Task",
                column: "LastModifierUserId",
                principalTable: "AbpUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alibaba_AccessToken_AbpUsers_CreatorUserId",
                table: "Alibaba_AccessToken");

            migrationBuilder.DropForeignKey(
                name: "FK_Alibaba_AccessToken_AbpUsers_DeleterUserId",
                table: "Alibaba_AccessToken");

            migrationBuilder.DropForeignKey(
                name: "FK_Alibaba_AccessToken_AbpUsers_LastModifierUserId",
                table: "Alibaba_AccessToken");

            migrationBuilder.DropForeignKey(
                name: "FK_Alibaba_DataSyncService_Alibaba_AccessToken_AccessTokenId",
                table: "Alibaba_DataSyncService");

            migrationBuilder.DropForeignKey(
                name: "FK_Alibaba_DataSyncService_AbpUsers_CreatorUserId",
                table: "Alibaba_DataSyncService");

            migrationBuilder.DropForeignKey(
                name: "FK_Alibaba_DataSyncService_AbpUsers_DeleterUserId",
                table: "Alibaba_DataSyncService");

            migrationBuilder.DropForeignKey(
                name: "FK_Alibaba_DataSyncService_AbpUsers_LastModifierUserId",
                table: "Alibaba_DataSyncService");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Customer_AbpUsers_CreatorUserId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Customer_AbpUsers_DeleterUserId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Customer_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Document_AbpUsers_CreatorUserId",
                table: "XTOPMS_Document");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Document_AbpUsers_DeleterUserId",
                table: "XTOPMS_Document");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Document_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Document");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_CreatorUserId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_DeleterUserId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Opportunity_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Project_AbpUsers_CreatorUserId",
                table: "XTOPMS_Project");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Project_AbpUsers_DeleterUserId",
                table: "XTOPMS_Project");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Project_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Project");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Quotation_AbpUsers_CreatorUserId",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Quotation_AbpUsers_DeleterUserId",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Quotation_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SalesAgreement_AbpUsers_CreatorUserId",
                table: "XTOPMS_SalesAgreement");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SalesAgreement_AbpUsers_DeleterUserId",
                table: "XTOPMS_SalesAgreement");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SalesAgreement_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SalesAgreement");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKU_AbpUsers_CreatorUserId",
                table: "XTOPMS_SKU");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKU_AbpUsers_DeleterUserId",
                table: "XTOPMS_SKU");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKU_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SKU");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUCategory_AbpUsers_CreatorUserId",
                table: "XTOPMS_SKUCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUCategory_AbpUsers_DeleterUserId",
                table: "XTOPMS_SKUCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUCategory_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SKUCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUCategoryValue_AbpUsers_CreatorUserId",
                table: "XTOPMS_SKUCategoryValue");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUCategoryValue_AbpUsers_DeleterUserId",
                table: "XTOPMS_SKUCategoryValue");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUCategoryValue_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SKUCategoryValue");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUProperty_AbpUsers_CreatorUserId",
                table: "XTOPMS_SKUProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUProperty_AbpUsers_DeleterUserId",
                table: "XTOPMS_SKUProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_SKUProperty_AbpUsers_LastModifierUserId",
                table: "XTOPMS_SKUProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Task_AbpUsers_CreatorUserId",
                table: "XTOPMS_Task");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Task_AbpUsers_DeleterUserId",
                table: "XTOPMS_Task");

            migrationBuilder.DropForeignKey(
                name: "FK_XTOPMS_Task_AbpUsers_LastModifierUserId",
                table: "XTOPMS_Task");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Task_CreatorUserId",
                table: "XTOPMS_Task");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Task_DeleterUserId",
                table: "XTOPMS_Task");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Task_LastModifierUserId",
                table: "XTOPMS_Task");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUProperty_CreatorUserId",
                table: "XTOPMS_SKUProperty");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUProperty_DeleterUserId",
                table: "XTOPMS_SKUProperty");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUProperty_LastModifierUserId",
                table: "XTOPMS_SKUProperty");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUCategoryValue_CreatorUserId",
                table: "XTOPMS_SKUCategoryValue");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUCategoryValue_DeleterUserId",
                table: "XTOPMS_SKUCategoryValue");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUCategoryValue_LastModifierUserId",
                table: "XTOPMS_SKUCategoryValue");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUCategory_CreatorUserId",
                table: "XTOPMS_SKUCategory");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUCategory_DeleterUserId",
                table: "XTOPMS_SKUCategory");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKUCategory_LastModifierUserId",
                table: "XTOPMS_SKUCategory");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKU_CreatorUserId",
                table: "XTOPMS_SKU");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKU_DeleterUserId",
                table: "XTOPMS_SKU");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SKU_LastModifierUserId",
                table: "XTOPMS_SKU");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SalesAgreement_CreatorUserId",
                table: "XTOPMS_SalesAgreement");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SalesAgreement_DeleterUserId",
                table: "XTOPMS_SalesAgreement");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_SalesAgreement_LastModifierUserId",
                table: "XTOPMS_SalesAgreement");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Quotation_CreatorUserId",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Quotation_DeleterUserId",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Quotation_LastModifierUserId",
                table: "XTOPMS_Quotation");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Project_CreatorUserId",
                table: "XTOPMS_Project");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Project_DeleterUserId",
                table: "XTOPMS_Project");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Project_LastModifierUserId",
                table: "XTOPMS_Project");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Opportunity_CreatorUserId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Opportunity_DeleterUserId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Opportunity_LastModifierUserId",
                table: "XTOPMS_Opportunity");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Document_CreatorUserId",
                table: "XTOPMS_Document");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Document_DeleterUserId",
                table: "XTOPMS_Document");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Document_LastModifierUserId",
                table: "XTOPMS_Document");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Customer_CreatorUserId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Customer_DeleterUserId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropIndex(
                name: "IX_XTOPMS_Customer_LastModifierUserId",
                table: "XTOPMS_Customer");

            migrationBuilder.DropIndex(
                name: "IX_Alibaba_DataSyncService_AccessTokenId",
                table: "Alibaba_DataSyncService");

            migrationBuilder.DropIndex(
                name: "IX_Alibaba_DataSyncService_CreatorUserId",
                table: "Alibaba_DataSyncService");

            migrationBuilder.DropIndex(
                name: "IX_Alibaba_DataSyncService_DeleterUserId",
                table: "Alibaba_DataSyncService");

            migrationBuilder.DropIndex(
                name: "IX_Alibaba_DataSyncService_LastModifierUserId",
                table: "Alibaba_DataSyncService");

            migrationBuilder.DropIndex(
                name: "IX_Alibaba_AccessToken_CreatorUserId",
                table: "Alibaba_AccessToken");

            migrationBuilder.DropIndex(
                name: "IX_Alibaba_AccessToken_DeleterUserId",
                table: "Alibaba_AccessToken");

            migrationBuilder.DropIndex(
                name: "IX_Alibaba_AccessToken_LastModifierUserId",
                table: "Alibaba_AccessToken");
        }
    }
}
