using Microsoft.EntityFrameworkCore.Migrations;

namespace net_Oponeo.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Season",
                table: "Rims");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Rims",
                newName: "Diameter");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Diameter",
                table: "Rims",
                newName: "Size");

            migrationBuilder.AddColumn<string>(
                name: "Season",
                table: "Rims",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
