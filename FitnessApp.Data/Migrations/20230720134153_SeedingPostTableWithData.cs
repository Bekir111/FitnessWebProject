using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    public partial class SeedingPostTableWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {         
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 20, 13, 41, 52, 781, DateTimeKind.Utc).AddTicks(1465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 20, 10, 12, 33, 399, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreatedOn", "Text", "Title" },
                values: new object[] { 1, new DateTime(2023, 7, 20, 13, 41, 52, 781, DateTimeKind.Utc).AddTicks(1791), "You've probably heard big guys at the gym tossing around the word \"hypertrophy\" when they talk about their lifting goals — but what does that even mean? Are the principles behind the term just some sketchy bro science, a passing fitness fad, or real, lab tested-and-proven physiology?\r\nRest assured, the hype is real. Hypertrophy is, by definition, the enlargement of an organ or tissue from the increase in size of its cells. Not to be confused with hyperplasia, the process of increasing the number of cells, hypertrophy is the process of increasing the size of the cells that are already there.This occurs through a physiologic process that leads to an increased number of contractile proteins (actin and myosin) in each muscle fiber. With the right training regimen, you can catalyze this process — but helps to understand the science behind it.The body has the amazing potential to adapt to its environment. This includes building more strength when repeated stress to the tissue indicates a need to accommodate the new, higher loads. This is exactly what the process of strength training does.When it comes to building muscle, hypertrophy doesn’t just happen on its own. It has to be triggered by a physiological need. Hypertrophy can be thought of as a thickening of muscle fibers, which occurs when the body has been stressed just the right amount to indicate that it must create larger, stronger muscles that can tolerate this new, increased load. This need causes a cellular response, leading to cells synthesizing more materials.For muscles to grow, two things have to happen: stimulation and repair. Dormant cells called satellite cells, which exist between the outer and basement membranes of a muscle fiber become activated by trauma, damage or injury — all possible responses to the stress of weight training. An immune system response is triggered, leading to inflammation, the natural clean up and repair process that occurs on a cellular level.Concurrently, a hormonal response is triggered, causing the release of growth factor, cortisol, and testosterone. These hormones help regulate cell activity. Growth factors help stimulate muscle hypertrophy while testosterone increases protein synthesis. This process leads to satellite cells multiplying and their daughter cells migrating to the damaged tissue. Here, they fuse with skeletal muscle and donate their nuclei to the muscle fibers helping them thicken and grow.", "Hypertrophy to Grow Muscles" });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);


            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 20, 10, 12, 33, 399, DateTimeKind.Utc).AddTicks(4664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 20, 13, 41, 52, 781, DateTimeKind.Utc).AddTicks(1465));

       
        }
    }
}
