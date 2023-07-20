using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    public partial class AddedNewColumnsForSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodRecipes_AspNetUsers_UserId",
                table: "FoodRecipes");           

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Programs",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProgramReviews",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ProductReviews",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "FoodRecipes",
                type: "bit",
                nullable: false,
                defaultValue: true);


            migrationBuilder.AddForeignKey(
                name: "FK_FoodRecipes_AspNetUsers_UserId",
                table: "FoodRecipes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodRecipes_AspNetUsers_UserId",
                table: "FoodRecipes");


            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProgramReviews");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ProductReviews");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "FoodRecipes");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodRecipes_AspNetUsers_UserId",
                table: "FoodRecipes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
