using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyApi.Migrations
{
    public partial class AddingAddressFieldToBranches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "branches",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "branches");
        }
    }
}
