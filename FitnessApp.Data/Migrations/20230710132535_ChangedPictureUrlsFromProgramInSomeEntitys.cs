﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    public partial class ChangedPictureUrlsFromProgramInSomeEntitys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bdfe7a1-a1c8-4e4c-8f60-c650c50762b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5adf7e6e-6f71-4830-bfad-15089e4e5047"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4da11a5-af95-4f55-ac3c-0e18093d2be0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed79a5c5-04b8-4874-8c33-97e1bb6b6ca7"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("0f549ad9-ecad-470e-a0c6-2c20c6305727"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("3b0d19aa-23eb-48e6-9273-320a4d843960"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("a1eb02df-b3fe-40a4-a5ab-5b603d7d522a"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("ae9a8800-5b92-419f-81c7-0f2779b01bbd"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("b0cc6836-a3f3-4451-9685-fbfca07d0130"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("c3ad4e26-c0b4-4872-b5b9-e0a4dd754340"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("cc7c5381-f4ed-454d-9101-2bbe5e21355e"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("ce593618-3f13-4d14-993a-3306fdaddd3a"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("d2e7d062-3f6f-47eb-b91e-1bdb7dae7611"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("e26b95c3-d984-4847-be3a-0db27461f55b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Programs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(6685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 10, 13, 25, 34, 426, DateTimeKind.Utc).AddTicks(8767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 9, 10, 54, 27, 350, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price" },
                values: new object[,]
                {
                    { new Guid("3a85591c-df06-45bc-b9dc-d848507ee17a"), "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.", "Vital Multivitamin", "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg", 16.99m },
                    { new Guid("6229e9ef-1544-46ff-bc4e-db9eb87b2463"), "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.", "Vital Protein Powder.Chocolate flavor", "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2", 139.99m },
                    { new Guid("a6efc008-16a2-4b44-99ae-d0098a5ca60b"), "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.", "Vital Pre-Workout", "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2", 54.99m },
                    { new Guid("fc35a3b3-c705-4086-aa4b-508046816109"), "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.", "Vital Creatine Monohydrate", "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2", 59.99m }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("1c314873-b4bb-4be7-a8dd-a24e802e8fd3"), 4, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7119), "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.", "Ultimate Full Body", "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750" },
                    { new Guid("2352b8f8-7f67-46b0-bd2c-8a16bad48beb"), 4, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7116), "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.", "Intermediate/Advanced Push Pull Legs", "https://barbend.com/wp-content/uploads/2021/10/shutterstock_657710845-1.jpg" },
                    { new Guid("3f202a83-a41b-4cae-8900-14856d8bccea"), 3, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7314), "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.", "Chest Boost", "https://i0.wp.com/www.strengthlog.com/wp-content/uploads/2020/11/Arnold-Schwarzenegger-Chest-Muscles-3.jpg?fit=995%2C720&ssl=1" },
                    { new Guid("55919b15-0319-44cb-aca8-01d106f34e83"), 1, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7669), "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.", "Her Fit", "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg" },
                    { new Guid("63fde9dc-6295-4cf6-b7da-9b3fbfc2be47"), 2, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7346), "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.", "Power Bench Press", "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg" },
                    { new Guid("84aadd2d-761a-491a-82bc-8ddeb42f0965"), 3, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7341), "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.", "Back Builder", "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg" },
                    { new Guid("8c1a24f3-eb4b-466d-aa2e-a1826c7b0d18"), 4, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7100), "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.", "The Essential Program", "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg" },
                    { new Guid("cc5ce1e6-8c22-44c3-ba8b-bebd684d1f07"), 2, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7620), "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.", "Power Squat", "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg" },
                    { new Guid("cf032a0d-6444-4e7f-a351-1999aa09ef3c"), 1, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7665), "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.", "Glute Gain", "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg" },
                    { new Guid("e4436629-135a-4398-9a5f-b318f4716f77"), 3, new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(7337), "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.", "Arm Sculptor", "https://www.newbodyplan.co.uk/wp-content/uploads/2021/08/barbell-curl-best-move-for-bigger-biceps.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a85591c-df06-45bc-b9dc-d848507ee17a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6229e9ef-1544-46ff-bc4e-db9eb87b2463"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6efc008-16a2-4b44-99ae-d0098a5ca60b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc35a3b3-c705-4086-aa4b-508046816109"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("1c314873-b4bb-4be7-a8dd-a24e802e8fd3"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("2352b8f8-7f67-46b0-bd2c-8a16bad48beb"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("3f202a83-a41b-4cae-8900-14856d8bccea"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("55919b15-0319-44cb-aca8-01d106f34e83"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("63fde9dc-6295-4cf6-b7da-9b3fbfc2be47"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("84aadd2d-761a-491a-82bc-8ddeb42f0965"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("8c1a24f3-eb4b-466d-aa2e-a1826c7b0d18"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("cc5ce1e6-8c22-44c3-ba8b-bebd684d1f07"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("cf032a0d-6444-4e7f-a351-1999aa09ef3c"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("e4436629-135a-4398-9a5f-b318f4716f77"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Programs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 10, 13, 25, 34, 430, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 9, 10, 54, 27, 350, DateTimeKind.Utc).AddTicks(5383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 10, 13, 25, 34, 426, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price" },
                values: new object[,]
                {
                    { new Guid("1bdfe7a1-a1c8-4e4c-8f60-c650c50762b1"), "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.", "Vital Multivitamin", "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg", 16.99m },
                    { new Guid("5adf7e6e-6f71-4830-bfad-15089e4e5047"), "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.", "Vital Creatine Monohydrate", "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2", 59.99m },
                    { new Guid("a4da11a5-af95-4f55-ac3c-0e18093d2be0"), "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.", "Vital Protein Powder.Chocolate flavor", "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2", 139.99m },
                    { new Guid("ed79a5c5-04b8-4874-8c33-97e1bb6b6ca7"), "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.", "Vital Pre-Workout", "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2", 54.99m }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("0f549ad9-ecad-470e-a0c6-2c20c6305727"), 1, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1353), "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.", "Her Fit", "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg" },
                    { new Guid("3b0d19aa-23eb-48e6-9273-320a4d843960"), 4, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1328), "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.", "Ultimate Full Body", "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750" },
                    { new Guid("a1eb02df-b3fe-40a4-a5ab-5b603d7d522a"), 3, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1330), "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.", "Chest Boost", "https://cdn.shopify.com/s/files/1/1633/7705/articles/outer_chest_exercises_2000x.jpg?v=1649406838" },
                    { new Guid("ae9a8800-5b92-419f-81c7-0f2779b01bbd"), 4, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1288), "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.", "Intermediate/Advanced Push Pull Legs", "https://cdn.shopify.com/s/files/1/1633/7705/articles/push_pull_legs_2000x.jpg?v=1614057323" },
                    { new Guid("b0cc6836-a3f3-4451-9685-fbfca07d0130"), 4, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1282), "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.", "The Essential Program", "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg" },
                    { new Guid("c3ad4e26-c0b4-4872-b5b9-e0a4dd754340"), 2, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1347), "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.", "Power Squat", "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg" },
                    { new Guid("cc7c5381-f4ed-454d-9101-2bbe5e21355e"), 2, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1346), "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.", "Power Bench Press", "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg" },
                    { new Guid("ce593618-3f13-4d14-993a-3306fdaddd3a"), 3, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1342), "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.", "Arm Sculptor", "https://i.redd.it/6pt9rtvj7ro11.jpg" },
                    { new Guid("d2e7d062-3f6f-47eb-b91e-1bdb7dae7611"), 3, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1344), "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.", "Back Builder", "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg" },
                    { new Guid("e26b95c3-d984-4847-be3a-0db27461f55b"), 1, new DateTime(2023, 7, 9, 10, 54, 27, 352, DateTimeKind.Utc).AddTicks(1351), "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.", "Glute Gain", "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg" }
                });
        }
    }
}
