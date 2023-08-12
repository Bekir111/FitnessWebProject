using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    public partial class RemovedSoftDeleteColumnFromMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProgramUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProgramUsers",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }
    }
}
