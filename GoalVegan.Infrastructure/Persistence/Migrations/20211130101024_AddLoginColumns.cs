using Microsoft.EntityFrameworkCore.Migrations;

namespace GoalVegan.Infrastructure.Persistence.Migrations
{
    public partial class AddLoginColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Sellers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Buyers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Sellers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Buyers");
        }
    }
}
