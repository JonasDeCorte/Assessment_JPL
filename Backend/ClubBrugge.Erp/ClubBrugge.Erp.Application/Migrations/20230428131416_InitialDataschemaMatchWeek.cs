using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubBrugge.Erp.Application.Migrations
{
    public partial class InitialDataschemaMatchWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchWeek",
                table: "Matches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MatchWeek",
                table: "Matches");
        }
    }
}
