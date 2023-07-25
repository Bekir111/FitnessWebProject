﻿// <auto-generated />
using System;
using FitnessApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    [DbContext(typeof(FitnessAppDbContext))]
    partial class FitnessAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FitnessApp.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Programs for women"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Powerlifting"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Body part programs"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Muscle and strength programs"
                        });
                });

            modelBuilder.Entity("FitnessApp.Data.Models.FoodRecipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("MethodToMake")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FoodRecipes");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 25, 6, 41, 26, 790, DateTimeKind.Utc).AddTicks(8870));

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = new Guid("ed4b6f55-acf4-453b-a429-08db7eef598b"),
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 790, DateTimeKind.Utc).AddTicks(9225),
                            IsActive = false,
                            Text = "You've probably heard big guys at the gym tossing around the word \"hypertrophy\" when they talk about their lifting goals — but what does that even mean? Are the principles behind the term just some sketchy bro science, a passing fitness fad, or real, lab tested-and-proven physiology?\r\nRest assured, the hype is real. Hypertrophy is, by definition, the enlargement of an organ or tissue from the increase in size of its cells. Not to be confused with hyperplasia, the process of increasing the number of cells, hypertrophy is the process of increasing the size of the cells that are already there.This occurs through a physiologic process that leads to an increased number of contractile proteins (actin and myosin) in each muscle fiber. With the right training regimen, you can catalyze this process — but helps to understand the science behind it.The body has the amazing potential to adapt to its environment. This includes building more strength when repeated stress to the tissue indicates a need to accommodate the new, higher loads. This is exactly what the process of strength training does.When it comes to building muscle, hypertrophy doesn’t just happen on its own. It has to be triggered by a physiological need. Hypertrophy can be thought of as a thickening of muscle fibers, which occurs when the body has been stressed just the right amount to indicate that it must create larger, stronger muscles that can tolerate this new, increased load. This need causes a cellular response, leading to cells synthesizing more materials.For muscles to grow, two things have to happen: stimulation and repair. Dormant cells called satellite cells, which exist between the outer and basement membranes of a muscle fiber become activated by trauma, damage or injury — all possible responses to the stress of weight training. An immune system response is triggered, leading to inflammation, the natural clean up and repair process that occurs on a cellular level.Concurrently, a hormonal response is triggered, causing the release of growth factor, cortisol, and testosterone. These hormones help regulate cell activity. Growth factors help stimulate muscle hypertrophy while testosterone increases protein synthesis. This process leads to satellite cells multiplying and their daughter cells migrating to the damaged tissue. Here, they fuse with skeletal muscle and donate their nuclei to the muscle fibers helping them thicken and grow.",
                            Title = "Hypertrophy to Grow Muscles"
                        });
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsAvailable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f151a2a-a225-4170-a56a-a246aa836acf"),
                            Description = "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.",
                            IsAvailable = false,
                            Name = "Vital Protein Powder.Chocolate flavor",
                            PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2",
                            Price = 139.99m
                        },
                        new
                        {
                            Id = new Guid("770e7976-ad18-4c3e-a363-7fed5934a5cd"),
                            Description = "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.",
                            IsAvailable = false,
                            Name = "Vital Creatine Monohydrate",
                            PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2",
                            Price = 59.99m
                        },
                        new
                        {
                            Id = new Guid("a85b0493-4fcd-485e-8cd0-42c2323821e5"),
                            Description = "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.",
                            IsAvailable = false,
                            Name = "Vital Pre-Workout",
                            PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2",
                            Price = 54.99m
                        },
                        new
                        {
                            Id = new Guid("33447632-ea5c-4b43-8635-f24363b1388f"),
                            Description = "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.",
                            IsAvailable = false,
                            Name = "Vital Multivitamin",
                            PictureUrl = "https://cdn01.pharmeasy.in/dam/products_otc/R08152/musclexp-men-daily-vital-fitness-60-tablets-pack-of-3-7-1671744190.jpg",
                            Price = 16.99m
                        });
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ProductReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductReviews");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Program", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3273));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasMaxLength(2083)
                        .HasColumnType("nvarchar(2083)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Programs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2b3291b3-fa37-4f51-886d-afe22a1e724b"),
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3709),
                            Description = "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.",
                            IsActive = false,
                            Name = "The Essential Program",
                            PictureUrl = "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg"
                        },
                        new
                        {
                            Id = new Guid("2590e09c-0eab-4d69-85c8-cbea7e487d2c"),
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3716),
                            Description = "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.",
                            IsActive = false,
                            Name = "Intermediate/Advanced Push Pull Legs",
                            PictureUrl = "https://barbend.com/wp-content/uploads/2021/10/shutterstock_657710845-1.jpg"
                        },
                        new
                        {
                            Id = new Guid("2410011b-ace4-49a0-8b09-c3e097ea1084"),
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3718),
                            Description = "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.",
                            IsActive = false,
                            Name = "Ultimate Full Body",
                            PictureUrl = "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750"
                        },
                        new
                        {
                            Id = new Guid("3b7ffda8-7e74-4013-aa6d-ddcef2c13103"),
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3721),
                            Description = "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.",
                            IsActive = false,
                            Name = "Chest Boost",
                            PictureUrl = "https://i0.wp.com/www.strengthlog.com/wp-content/uploads/2020/11/Arnold-Schwarzenegger-Chest-Muscles-3.jpg?fit=995%2C720&ssl=1"
                        },
                        new
                        {
                            Id = new Guid("c8dec108-ba28-4f86-85d8-d7b95f7916b2"),
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3726),
                            Description = "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.",
                            IsActive = false,
                            Name = "Arm Sculptor",
                            PictureUrl = "https://www.newbodyplan.co.uk/wp-content/uploads/2021/08/barbell-curl-best-move-for-bigger-biceps.jpg"
                        },
                        new
                        {
                            Id = new Guid("6d87d7dd-0cce-46da-8e30-9d57b9d364e6"),
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3728),
                            Description = "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.",
                            IsActive = false,
                            Name = "Back Builder",
                            PictureUrl = "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg"
                        },
                        new
                        {
                            Id = new Guid("348b4af7-c2c2-4dcd-ae2e-f4e06ff5fe76"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3731),
                            Description = "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.",
                            IsActive = false,
                            Name = "Power Bench Press",
                            PictureUrl = "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg"
                        },
                        new
                        {
                            Id = new Guid("f6caf93d-89b1-4428-8fec-41039f98421e"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3734),
                            Description = "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.",
                            IsActive = false,
                            Name = "Power Squat",
                            PictureUrl = "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg"
                        },
                        new
                        {
                            Id = new Guid("d66b6e07-c655-4fbb-8609-b908aaaa2cc8"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3746),
                            Description = "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.",
                            IsActive = false,
                            Name = "Glute Gain",
                            PictureUrl = "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg"
                        },
                        new
                        {
                            Id = new Guid("b872bce6-4319-49a0-a86c-faff06de87ac"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 7, 25, 6, 41, 26, 791, DateTimeKind.Utc).AddTicks(3748),
                            Description = "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.",
                            IsActive = false,
                            Name = "Her Fit",
                            PictureUrl = "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg"
                        });
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ProgramReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<Guid>("ProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.HasIndex("UserId");

                    b.ToTable("ProgramReviews");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ProgramUser", b =>
                {
                    b.Property<Guid>("ProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProgramId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProgramUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FitnessApp.Data.Models.FoodRecipe", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", "User")
                        .WithMany("FoodRecipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Post", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ProductReview", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.Product", "Product")
                        .WithMany("ProductReviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", "User")
                        .WithMany("ProductReviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Program", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.Category", "Category")
                        .WithMany("Programs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ProgramReview", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.Program", "Program")
                        .WithMany("Reviews")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", "User")
                        .WithMany("ProgramReviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Program");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ProgramUser", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.Program", "Program")
                        .WithMany("ProgramUsers")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("FoodRecipes");

                    b.Navigation("Posts");

                    b.Navigation("ProductReviews");

                    b.Navigation("ProgramReviews");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Category", b =>
                {
                    b.Navigation("Programs");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Product", b =>
                {
                    b.Navigation("ProductReviews");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Program", b =>
                {
                    b.Navigation("ProgramUsers");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
