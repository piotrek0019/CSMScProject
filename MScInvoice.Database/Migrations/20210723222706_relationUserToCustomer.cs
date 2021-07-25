using Microsoft.EntityFrameworkCore.Migrations;

namespace MScInvoice.Database.Migrations
{
    public partial class relationUserToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyUserId",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MyUserId",
                table: "Customers",
                column: "MyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_MyUserId",
                table: "Customers",
                column: "MyUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_MyUserId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MyUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MyUserId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
