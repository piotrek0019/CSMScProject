using Microsoft.EntityFrameworkCore.Migrations;

namespace MScInvoice.Database.Migrations
{
    public partial class moreRelationsToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyUserId",
                table: "PayMethods",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyUserId",
                table: "Items",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Invoices",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MyUserId",
                table: "Invoices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PayMethods_MyUserId",
                table: "PayMethods",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_MyUserId",
                table: "Items",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_MyUserId",
                table: "Invoices",
                column: "MyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_AspNetUsers_MyUserId",
                table: "Invoices",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_AspNetUsers_MyUserId",
                table: "Items",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayMethods_AspNetUsers_MyUserId",
                table: "PayMethods",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_AspNetUsers_MyUserId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_AspNetUsers_MyUserId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_PayMethods_AspNetUsers_MyUserId",
                table: "PayMethods");

            migrationBuilder.DropIndex(
                name: "IX_PayMethods_MyUserId",
                table: "PayMethods");

            migrationBuilder.DropIndex(
                name: "IX_Items_MyUserId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_MyUserId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "MyUserId",
                table: "PayMethods");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "MyUserId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "MyUserId",
                table: "Invoices");
        }
    }
}
