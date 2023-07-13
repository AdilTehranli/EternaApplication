using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaApp.Migrations
{
    public partial class UpdatedServiceFeatureColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "ServicesFeature",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "ServicesFeature");
        }
    }
}
