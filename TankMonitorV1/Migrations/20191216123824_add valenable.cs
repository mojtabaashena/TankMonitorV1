using Microsoft.EntityFrameworkCore.Migrations;

namespace TankMonitorV1.Migrations
{
    public partial class addvalenable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "fldValEnable",
                table: "tblValues",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fldValEnable",
                table: "tblValues");
        }
    }
}
