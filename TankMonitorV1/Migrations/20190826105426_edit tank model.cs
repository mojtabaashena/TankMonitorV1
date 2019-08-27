using Microsoft.EntityFrameworkCore.Migrations;

namespace TankMonitorV1.Migrations
{
    public partial class edittankmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FuelType",
                table: "tblTanks",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FuelType",
                table: "tblTanks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
