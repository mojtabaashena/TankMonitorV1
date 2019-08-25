using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TankMonitorV1.Migrations
{
    public partial class addfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descript",
                table: "tblStations",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Enable",
                table: "tblStations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "tblStations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumber",
                table: "tblStations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TankCount",
                table: "tblStations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tblTanks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TankNumber = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<int>(nullable: false),
                    Capasity = table.Column<int>(nullable: false),
                    FuelType = table.Column<int>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    Descript = table.Column<string>(nullable: true),
                    GSID = table.Column<int>(nullable: false),
                    StationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblTanks_tblStations_StationId",
                        column: x => x.StationId,
                        principalTable: "tblStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblTanks_StationId",
                table: "tblTanks",
                column: "StationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblTanks");

            migrationBuilder.DropColumn(
                name: "Descript",
                table: "tblStations");

            migrationBuilder.DropColumn(
                name: "Enable",
                table: "tblStations");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "tblStations");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "tblStations");

            migrationBuilder.DropColumn(
                name: "TankCount",
                table: "tblStations");
        }
    }
}
