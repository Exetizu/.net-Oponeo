using Microsoft.EntityFrameworkCore.Migrations;

namespace net_Oponeo.Migrations
{
    public partial class fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Diameter",
                table: "Rims",
                newName: "Color");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Rims",
                newName: "Diameter");
        }
    }
}
