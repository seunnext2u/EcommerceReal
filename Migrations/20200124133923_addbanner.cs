using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceReal.Migrations
{
    public partial class addbanner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerImage",
                table: "SubCategories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BannerImage",
                table: "SubCategories");
        }
    }
}
