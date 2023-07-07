using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    public partial class ChangedProgramReviewIdAndProductReviewIdToBeNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductReviewId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price" },
                values: new object[,]
                {
                    { new Guid("5cb99474-2363-403a-953d-cbb3e5febe6f"), "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.", "Vital Pre-Workout", "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2", 54.99m },
                    { new Guid("9d6b3f09-fd5e-42cd-9dd2-be721f08003b"), "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.", "Vital Creatine Monohydrate", "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2", 59.99m },
                    { new Guid("c49b970f-08d1-4c43-bfa9-f95c471ac5c8"), "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.", "Vital Multivitamin", "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg", 16.99m },
                    { new Guid("ffb4ae5f-dcb6-43ff-b435-f6c425f38577"), "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.", "Vital Protein Powder.Chocolate flavor", "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2", 139.99m }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("1f22f087-bf4f-4815-b7f7-a47a1a492309"), 1, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4626), "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.", "Glute Gain", "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg" },
                    { new Guid("27e818ea-2601-4b38-8c81-8a0eb299ca64"), 3, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4590), "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.", "Chest Boost", "https://cdn.shopify.com/s/files/1/1633/7705/articles/outer_chest_exercises_2000x.jpg?v=1649406838" },
                    { new Guid("2e0a3cbc-b3cb-4310-9390-51d5e5278d0d"), 4, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4517), "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.", "The Essential Program", "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg" },
                    { new Guid("4d4b2334-8b81-4f39-8955-da74edbb42ba"), 4, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4527), "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.", "Intermediate/Advanced Push Pull Legs", "https://cdn.shopify.com/s/files/1/1633/7705/articles/push_pull_legs_2000x.jpg?v=1614057323" },
                    { new Guid("568ddcd7-6ff6-4586-920c-bf4c75c2a449"), 2, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4623), "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.", "Power Squat", "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg" },
                    { new Guid("85f82511-5d09-4791-bc9d-224f0eb0ff36"), 4, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4587), "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.", "Ultimate Full Body", "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750" },
                    { new Guid("93a268cc-d715-4789-87e1-80a3df828d6f"), 2, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4601), "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.", "Power Bench Press", "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg" },
                    { new Guid("9f06f415-3d00-4a12-8411-7f1bf57baba3"), 3, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4597), "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.", "Arm Sculptor", "https://i.redd.it/6pt9rtvj7ro11.jpg" },
                    { new Guid("bbc3c616-0fa8-4850-8420-ec5c9b47d918"), 1, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4628), "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.", "Her Fit", "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg" },
                    { new Guid("c76ff025-ef82-4c46-9c05-035979bb6311"), 3, new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4599), "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.", "Back Builder", "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5cb99474-2363-403a-953d-cbb3e5febe6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d6b3f09-fd5e-42cd-9dd2-be721f08003b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c49b970f-08d1-4c43-bfa9-f95c471ac5c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffb4ae5f-dcb6-43ff-b435-f6c425f38577"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("1f22f087-bf4f-4815-b7f7-a47a1a492309"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("27e818ea-2601-4b38-8c81-8a0eb299ca64"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("2e0a3cbc-b3cb-4310-9390-51d5e5278d0d"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("4d4b2334-8b81-4f39-8955-da74edbb42ba"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("568ddcd7-6ff6-4586-920c-bf4c75c2a449"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("85f82511-5d09-4791-bc9d-224f0eb0ff36"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("93a268cc-d715-4789-87e1-80a3df828d6f"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("9f06f415-3d00-4a12-8411-7f1bf57baba3"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("bbc3c616-0fa8-4850-8420-ec5c9b47d918"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("c76ff025-ef82-4c46-9c05-035979bb6311"));

            migrationBuilder.AlterColumn<string>(
                name: "ProgramReviewId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductReviewId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
    }
}
