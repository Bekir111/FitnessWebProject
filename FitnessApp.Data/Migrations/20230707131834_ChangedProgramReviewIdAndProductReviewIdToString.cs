﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    public partial class ChangedProgramReviewIdAndProductReviewIdToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("090aeb2d-9da6-4618-829a-5ae9f6b671ee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09872d33-e965-45bb-98a8-69d052673e51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dce78659-8e95-4c73-9385-e5a7fa9bd08b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f22cbd51-948f-4b55-83d1-af48ea176cb6"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("0a44bafc-eda1-4c0e-9e06-deb458d2d914"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("34fe7f91-25ef-477c-a4b8-a5e464761d03"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("4255ea39-72d9-4d48-bec4-e520071de04c"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("468f9bf5-7e8f-4aea-9ef5-c49de2730574"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("54c182d6-eb65-48ac-9892-7bfa6aa86da2"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("6a68658e-a978-4c84-acd3-e1d89fb545c8"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("bd22de88-7581-4cd0-bec6-1dd91b2b553d"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("c0e9affe-c81f-47b0-bdf9-6dcc792004ba"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("dd84c37e-e7a8-4a41-99fe-a6708acd66eb"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("f73958f9-ec36-4b25-b727-3a81246a0487"));

            migrationBuilder.AlterColumn<string>(
                name: "ProgramReviewId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "ProductReviewId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price" },
                values: new object[,]
                {
                    { new Guid("2a3a6296-f389-4609-8573-febacaa4c209"), "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.", "Vital Pre-Workout", "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2", 54.99m },
                    { new Guid("5910d326-c057-41dc-9880-954d2860e1ec"), "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.", "Vital Creatine Monohydrate", "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2", 59.99m },
                    { new Guid("a6ec0eda-2c60-47c5-9ab7-4e28f80fcd3d"), "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.", "Vital Multivitamin", "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg", 16.99m },
                    { new Guid("cb0c070e-207c-40e6-b53b-b50fa526bfb2"), "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.", "Vital Protein Powder.Chocolate flavor", "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2", 139.99m }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("0734b43b-8f79-4155-9655-51d1a2c1c27c"), 3, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8535), "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.", "Chest Boost", "https://cdn.shopify.com/s/files/1/1633/7705/articles/outer_chest_exercises_2000x.jpg?v=1649406838" },
                    { new Guid("08e2763c-05d6-4e3f-9f2e-22dc2643a675"), 3, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8543), "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.", "Back Builder", "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg" },
                    { new Guid("5140ae84-4eb2-40d3-abe5-29609a9483a3"), 4, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8533), "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.", "Ultimate Full Body", "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750" },
                    { new Guid("5654670b-5903-41f1-a1d4-908fe78c0891"), 4, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8493), "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.", "The Essential Program", "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg" },
                    { new Guid("6c067e01-bd74-490f-b656-04840b26a726"), 4, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8501), "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.", "Intermediate/Advanced Push Pull Legs", "https://cdn.shopify.com/s/files/1/1633/7705/articles/push_pull_legs_2000x.jpg?v=1614057323" },
                    { new Guid("7cb6d5bd-b5c8-43ca-afcf-b01dce26b2c4"), 1, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8552), "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.", "Her Fit", "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg" },
                    { new Guid("ba0ba02e-0ac5-443b-937a-1ffb0d2f28e4"), 2, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8546), "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.", "Power Bench Press", "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg" },
                    { new Guid("c90d798d-e6f3-4cfe-86ab-5a8966a84a8a"), 3, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8541), "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.", "Arm Sculptor", "https://i.redd.it/6pt9rtvj7ro11.jpg" },
                    { new Guid("e344833c-bb8e-41c1-bbec-27bb0d60b67d"), 2, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8548), "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.", "Power Squat", "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg" },
                    { new Guid("ec26d1e2-5031-4432-aa9e-fbab6398e5fa"), 1, new DateTime(2023, 7, 7, 13, 18, 34, 143, DateTimeKind.Utc).AddTicks(8551), "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.", "Glute Gain", "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a3a6296-f389-4609-8573-febacaa4c209"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5910d326-c057-41dc-9880-954d2860e1ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6ec0eda-2c60-47c5-9ab7-4e28f80fcd3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb0c070e-207c-40e6-b53b-b50fa526bfb2"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("0734b43b-8f79-4155-9655-51d1a2c1c27c"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("08e2763c-05d6-4e3f-9f2e-22dc2643a675"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("5140ae84-4eb2-40d3-abe5-29609a9483a3"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("5654670b-5903-41f1-a1d4-908fe78c0891"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("6c067e01-bd74-490f-b656-04840b26a726"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("7cb6d5bd-b5c8-43ca-afcf-b01dce26b2c4"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("ba0ba02e-0ac5-443b-937a-1ffb0d2f28e4"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("c90d798d-e6f3-4cfe-86ab-5a8966a84a8a"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("e344833c-bb8e-41c1-bbec-27bb0d60b67d"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("ec26d1e2-5031-4432-aa9e-fbab6398e5fa"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ProgramReviewId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductReviewId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price" },
                values: new object[,]
                {
                    { new Guid("090aeb2d-9da6-4618-829a-5ae9f6b671ee"), "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.", "Vital Pre-Workout", "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2", 54.99m },
                    { new Guid("09872d33-e965-45bb-98a8-69d052673e51"), "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.", "Vital Creatine Monohydrate", "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2", 59.99m },
                    { new Guid("dce78659-8e95-4c73-9385-e5a7fa9bd08b"), "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.", "Vital Multivitamin", "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg", 16.99m },
                    { new Guid("f22cbd51-948f-4b55-83d1-af48ea176cb6"), "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.", "Vital Protein Powder.Chocolate flavor", "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2", 139.99m }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("0a44bafc-eda1-4c0e-9e06-deb458d2d914"), 4, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2170), "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.", "Intermediate/Advanced Push Pull Legs", "https://cdn.shopify.com/s/files/1/1633/7705/articles/push_pull_legs_2000x.jpg?v=1614057323" },
                    { new Guid("34fe7f91-25ef-477c-a4b8-a5e464761d03"), 4, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2172), "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.", "Ultimate Full Body", "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750" },
                    { new Guid("4255ea39-72d9-4d48-bec4-e520071de04c"), 3, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2193), "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.", "Arm Sculptor", "https://i.redd.it/6pt9rtvj7ro11.jpg" },
                    { new Guid("468f9bf5-7e8f-4aea-9ef5-c49de2730574"), 3, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2195), "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.", "Back Builder", "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg" },
                    { new Guid("54c182d6-eb65-48ac-9892-7bfa6aa86da2"), 2, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2197), "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.", "Power Bench Press", "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg" },
                    { new Guid("6a68658e-a978-4c84-acd3-e1d89fb545c8"), 1, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2248), "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.", "Her Fit", "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg" },
                    { new Guid("bd22de88-7581-4cd0-bec6-1dd91b2b553d"), 4, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2163), "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.", "The Essential Program", "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg" },
                    { new Guid("c0e9affe-c81f-47b0-bdf9-6dcc792004ba"), 1, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2246), "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.", "Glute Gain", "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg" },
                    { new Guid("dd84c37e-e7a8-4a41-99fe-a6708acd66eb"), 2, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2199), "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.", "Power Squat", "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg" },
                    { new Guid("f73958f9-ec36-4b25-b727-3a81246a0487"), 3, new DateTime(2023, 7, 6, 9, 59, 39, 378, DateTimeKind.Utc).AddTicks(2174), "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.", "Chest Boost", "https://cdn.shopify.com/s/files/1/1633/7705/articles/outer_chest_exercises_2000x.jpg?v=1649406838" }
                });
        }
    }
}
