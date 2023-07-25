using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    public partial class implementConfigurationForApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f151a2a-a225-4170-a56a-a246aa836acf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33447632-ea5c-4b43-8635-f24363b1388f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("770e7976-ad18-4c3e-a363-7fed5934a5cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a85b0493-4fcd-485e-8cd0-42c2323821e5"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("2410011b-ace4-49a0-8b09-c3e097ea1084"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("2590e09c-0eab-4d69-85c8-cbea7e487d2c"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("2b3291b3-fa37-4f51-886d-afe22a1e724b"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("348b4af7-c2c2-4dcd-ae2e-f4e06ff5fe76"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("3b7ffda8-7e74-4013-aa6d-ddcef2c13103"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("6d87d7dd-0cce-46da-8e30-9d57b9d364e6"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("b872bce6-4319-49a0-a86c-faff06de87ac"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("c8dec108-ba28-4f86-85d8-d7b95f7916b2"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("d66b6e07-c655-4fbb-8609-b908aaaa2cc8"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("f6caf93d-89b1-4428-8fec-41039f98421e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Programs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(4068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 25, 6, 41, 26, 790, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price" },
                values: new object[,]
                {
                    { new Guid("2fd3574e-c087-44b6-b540-b9aa8f1193ef"), "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.", "Vital Protein Powder.Chocolate flavor", "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2", 139.99m },
                    { new Guid("330ea03c-fab7-41c6-9a80-ca354db0eb71"), "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.", "Vital Multivitamin", "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg", 16.99m },
                    { new Guid("e19b8d90-308f-4ed3-ac1a-600f45f83f41"), "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.", "Vital Creatine Monohydrate", "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2", 59.99m },
                    { new Guid("f79abeb9-8f02-43a2-b887-3c72ca4d8ce1"), "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.", "Vital Pre-Workout", "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2", 54.99m }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("021e2149-6085-4e24-bf21-20c8f4641460"), 3, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8800), "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.", "Chest Boost", "https://i0.wp.com/www.strengthlog.com/wp-content/uploads/2020/11/Arnold-Schwarzenegger-Chest-Muscles-3.jpg?fit=995%2C720&ssl=1" },
                    { new Guid("0bc1075c-16cc-49f1-8ed7-6613998e35c9"), 1, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8831), "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.", "Her Fit", "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg" },
                    { new Guid("278c2e2a-df11-4538-87df-7075a66552de"), 3, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8808), "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.", "Back Builder", "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg" },
                    { new Guid("7ce273b1-d698-4ec7-a2f7-bac08e37b4c2"), 1, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8818), "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.", "Glute Gain", "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg" },
                    { new Guid("7e1bb685-32a1-4685-ab5c-95e56682a234"), 4, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8797), "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.", "Ultimate Full Body", "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750" },
                    { new Guid("80c4de81-e745-4002-a18f-7b4cf7bd47fe"), 3, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8806), "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.", "Arm Sculptor", "https://www.newbodyplan.co.uk/wp-content/uploads/2021/08/barbell-curl-best-move-for-bigger-biceps.jpg" },
                    { new Guid("95ab65b7-1288-494f-a60e-baa3e1067fb4"), 2, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8813), "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.", "Power Squat", "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg" },
                    { new Guid("9c4f9151-4d44-4649-afd1-5a235d6899e2"), 4, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8795), "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.", "Intermediate/Advanced Push Pull Legs", "https://barbend.com/wp-content/uploads/2021/10/shutterstock_657710845-1.jpg" },
                    { new Guid("ab4db460-a61c-41b0-9e3c-cccee025c82e"), 4, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8767), "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.", "The Essential Program", "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg" },
                    { new Guid("ba03f92d-ea3f-4ce0-8c57-3b0c53e62782"), 2, new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8811), "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.", "Power Bench Press", "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2fd3574e-c087-44b6-b540-b9aa8f1193ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("330ea03c-fab7-41c6-9a80-ca354db0eb71"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e19b8d90-308f-4ed3-ac1a-600f45f83f41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f79abeb9-8f02-43a2-b887-3c72ca4d8ce1"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("021e2149-6085-4e24-bf21-20c8f4641460"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("0bc1075c-16cc-49f1-8ed7-6613998e35c9"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("278c2e2a-df11-4538-87df-7075a66552de"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("7ce273b1-d698-4ec7-a2f7-bac08e37b4c2"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("7e1bb685-32a1-4685-ab5c-95e56682a234"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("80c4de81-e745-4002-a18f-7b4cf7bd47fe"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("95ab65b7-1288-494f-a60e-baa3e1067fb4"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("9c4f9151-4d44-4649-afd1-5a235d6899e2"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("ab4db460-a61c-41b0-9e3c-cccee025c82e"));

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: new Guid("ba03f92d-ea3f-4ce0-8c57-3b0c53e62782"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Programs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 25, 6, 41, 26, 790, DateTimeKind.Utc).AddTicks(8870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 25, 8, 40, 0, 944, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 25, 6, 41, 26, 790, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "IsAvailable", "Name", "PictureUrl", "Price" },
                values: new object[,]
                {
                    { new Guid("2f151a2a-a225-4170-a56a-a246aa836acf"), "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.", false, "Vital Protein Powder.Chocolate flavor", "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2", 139.99m },
                    { new Guid("33447632-ea5c-4b43-8635-f24363b1388f"), "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.", false, "Vital Multivitamin", "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg", 16.99m },
                    { new Guid("770e7976-ad18-4c3e-a363-7fed5934a5cd"), "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.", false, "Vital Creatine Monohydrate", "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2", 59.99m },
                    { new Guid("a85b0493-4fcd-485e-8cd0-42c2323821e5"), "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.", false, "Vital Pre-Workout", "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2", 54.99m }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "IsActive", "Name", "PictureUrl" },
                values: new object[,]
                {
                    { new Guid("2410011b-ace4-49a0-8b09-c3e097ea1084"), 4, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3718), "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.", false, "Ultimate Full Body", "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750" },
                    { new Guid("2590e09c-0eab-4d69-85c8-cbea7e487d2c"), 4, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3716), "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.", false, "Intermediate/Advanced Push Pull Legs", "https://barbend.com/wp-content/uploads/2021/10/shutterstock_657710845-1.jpg" },
                    { new Guid("2b3291b3-fa37-4f51-886d-afe22a1e724b"), 4, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3709), "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.", false, "The Essential Program", "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg" },
                    { new Guid("348b4af7-c2c2-4dcd-ae2e-f4e06ff5fe76"), 2, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3731), "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.", false, "Power Bench Press", "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg" },
                    { new Guid("3b7ffda8-7e74-4013-aa6d-ddcef2c13103"), 3, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3721), "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.", false, "Chest Boost", "https://i0.wp.com/www.strengthlog.com/wp-content/uploads/2020/11/Arnold-Schwarzenegger-Chest-Muscles-3.jpg?fit=995%2C720&ssl=1" },
                    { new Guid("6d87d7dd-0cce-46da-8e30-9d57b9d364e6"), 3, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3728), "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.", false, "Back Builder", "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg" },
                    { new Guid("b872bce6-4319-49a0-a86c-faff06de87ac"), 1, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3748), "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.", false, "Her Fit", "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg" },
                    { new Guid("c8dec108-ba28-4f86-85d8-d7b95f7916b2"), 3, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3726), "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.", false, "Arm Sculptor", "https://www.newbodyplan.co.uk/wp-content/uploads/2021/08/barbell-curl-best-move-for-bigger-biceps.jpg" },
                    { new Guid("d66b6e07-c655-4fbb-8609-b908aaaa2cc8"), 1, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3746), "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.", false, "Glute Gain", "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg" },
                    { new Guid("f6caf93d-89b1-4428-8fec-41039f98421e"), 2, new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3734), "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.", false, "Power Squat", "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg" }
                });
        }
    }
}
