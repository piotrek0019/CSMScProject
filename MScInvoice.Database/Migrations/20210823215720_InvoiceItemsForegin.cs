using Microsoft.EntityFrameworkCore.Migrations;

namespace MScInvoice.Database.Migrations
{
    public partial class InvoiceItemsForegin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_InvoiceSections_InvoiceSectionId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_InvoiceSectionId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "InvoiceSectionId",
                table: "Items");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceSectionId",
                table: "Items",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_InvoiceSectionId",
                table: "Items",
                column: "InvoiceSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_InvoiceSections_InvoiceSectionId",
                table: "Items",
                column: "InvoiceSectionId",
                principalTable: "InvoiceSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
