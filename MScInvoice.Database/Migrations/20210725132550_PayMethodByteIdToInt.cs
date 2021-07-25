using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MScInvoice.Database.Migrations
{
    public partial class PayMethodByteIdToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PayMethodId",
                table: "Invoices",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PayMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    MyUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayMethods_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_PayMethodId",
                table: "Invoices",
                column: "PayMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_PayMethods_MyUserId",
                table: "PayMethods",
                column: "MyUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_PayMethods_PayMethodId",
                table: "Invoices",
                column: "PayMethodId",
                principalTable: "PayMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_PayMethods_PayMethodId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "PayMethods");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_PayMethodId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "PayMethodId",
                table: "Invoices");
        }
    }
}
