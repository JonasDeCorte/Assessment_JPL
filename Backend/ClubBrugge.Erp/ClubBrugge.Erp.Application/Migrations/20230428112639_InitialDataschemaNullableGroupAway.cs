﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubBrugge.Erp.Application.Migrations
{
    public partial class InitialDataschemaNullableGroupAway : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AwayTeamGroup",
                table: "AwayTeams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AwayTeamGroup",
                table: "AwayTeams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
