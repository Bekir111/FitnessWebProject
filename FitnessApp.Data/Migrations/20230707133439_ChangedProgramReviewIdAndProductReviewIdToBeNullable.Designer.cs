﻿// <auto-generated />
using System;
using FitnessApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessApp.Data.Migrations
{
    [DbContext(typeof(FitnessAppDbContext))]
    [Migration("20230707133439_ChangedProgramReviewIdAndProductReviewIdToBeNullable")]
    partial class ChangedProgramReviewIdAndProductReviewIdToBeNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<Guid?>("ProductReviewId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProgramReviewId")
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<string>("MethodToMake")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("FoodRecipes");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.FoodRecipeAuthor", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FoodRecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorId", "FoodRecipeId");

                    b.HasIndex("FoodRecipeId");

                    b.ToTable("FoodRecipesAuthors");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Posts");
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
                            Id = new Guid("ffb4ae5f-dcb6-43ff-b435-f6c425f38577"),
                            Description = "Elevate Your Performance. High-quality protein powder for muscle recovery and growth. Packed with essential nutrients and amino acids. Enjoy the delicious taste and smooth texture. Unleash your potential with Vital Protein, the key to maximizing your performance and vitality.",
                            Name = "Vital Protein Powder.Chocolate flavor",
                            PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/133/images/504/Main-Image-Whey__17399.1590994371.1280.1280.jpg?c=2",
                            Price = 139.99m
                        },
                        new
                        {
                            Id = new Guid("9d6b3f09-fd5e-42cd-9dd2-be721f08003b"),
                            Description = "Unleash Your Power. Pure and potent creatine monohydrate supplement. Enhances strength, power, and muscular endurance. Supports explosive workouts and accelerated muscle recovery. Unleash your true potential with Vital Creatine, the ultimate tool for maximizing your athletic performance.",
                            Name = "Vital Creatine Monohydrate",
                            PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/150/images/563/Creatine-main-image-450__28099.1603079104.1280.1280.jpg?c=2",
                            Price = 59.99m
                        },
                        new
                        {
                            Id = new Guid("5cb99474-2363-403a-953d-cbb3e5febe6f"),
                            Description = "Ignite Your Workouts. Boosts energy, focus, and endurance. Enhances strength and intensity during training. Experience heightened performance with Vital Pre-Workout, your secret weapon for crushing your workouts and surpassing your limits.",
                            Name = "Vital Pre-Workout",
                            PictureUrl = "https://cdn10.bigcommerce.com/s-quxuy/products/229/images/525/225g-Pre-Workour-Main__55780.1633392104.386.513.jpg?c=2",
                            Price = 54.99m
                        },
                        new
                        {
                            Id = new Guid("c49b970f-08d1-4c43-bfa9-f95c471ac5c8"),
                            Description = "Nourish Your Well-being. Provides essential nutrients for optimal health and vitality. Supports immune function, energy levels, and overall well-being. Prioritize your health with Vital Multivitamin, your daily source of essential nutrients for a vibrant life.",
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

                    b.HasIndex("UserId")
                        .IsUnique();

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
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

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
                            Id = new Guid("2e0a3cbc-b3cb-4310-9390-51d5e5278d0d"),
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4517),
                            Description = "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion.",
                            Name = "The Essential Program",
                            PictureUrl = "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg"
                        },
                        new
                        {
                            Id = new Guid("4d4b2334-8b81-4f39-8955-da74edbb42ba"),
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4527),
                            Description = "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts.",
                            Name = "Intermediate/Advanced Push Pull Legs",
                            PictureUrl = "https://cdn.shopify.com/s/files/1/1633/7705/articles/push_pull_legs_2000x.jpg?v=1614057323"
                        },
                        new
                        {
                            Id = new Guid("85f82511-5d09-4791-bc9d-224f0eb0ff36"),
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4587),
                            Description = "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time.",
                            Name = "Ultimate Full Body",
                            PictureUrl = "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750"
                        },
                        new
                        {
                            Id = new Guid("27e818ea-2601-4b38-8c81-8a0eb299ca64"),
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4590),
                            Description = "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique.",
                            Name = "Chest Boost",
                            PictureUrl = "https://cdn.shopify.com/s/files/1/1633/7705/articles/outer_chest_exercises_2000x.jpg?v=1649406838"
                        },
                        new
                        {
                            Id = new Guid("9f06f415-3d00-4a12-8411-7f1bf57baba3"),
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4597),
                            Description = "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics.",
                            Name = "Arm Sculptor",
                            PictureUrl = "https://i.redd.it/6pt9rtvj7ro11.jpg"
                        },
                        new
                        {
                            Id = new Guid("c76ff025-ef82-4c46-9c05-035979bb6311"),
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4599),
                            Description = "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique.",
                            Name = "Back Builder",
                            PictureUrl = "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg"
                        },
                        new
                        {
                            Id = new Guid("93a268cc-d715-4789-87e1-80a3df828d6f"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4601),
                            Description = "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting.",
                            Name = "Power Bench Press",
                            PictureUrl = "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg"
                        },
                        new
                        {
                            Id = new Guid("568ddcd7-6ff6-4586-920c-bf4c75c2a449"),
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4623),
                            Description = "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force.",
                            Name = "Power Squat",
                            PictureUrl = "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg"
                        },
                        new
                        {
                            Id = new Guid("1f22f087-bf4f-4815-b7f7-a47a1a492309"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4626),
                            Description = "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique.",
                            Name = "Glute Gain",
                            PictureUrl = "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg"
                        },
                        new
                        {
                            Id = new Guid("bbc3c616-0fa8-4850-8420-ec5c9b47d918"),
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 7, 7, 13, 34, 38, 932, DateTimeKind.Utc).AddTicks(4628),
                            Description = "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you.",
                            Name = "Her Fit",
                            PictureUrl = "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg"
                        });
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ProgramReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.HasIndex("UserId")
                        .IsUnique();

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

            modelBuilder.Entity("FitnessApp.Data.Models.FoodRecipeAuthor", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessApp.Data.Models.FoodRecipe", "FoodRecipe")
                        .WithMany("FoodRecipeAuthors")
                        .HasForeignKey("FoodRecipeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("FoodRecipe");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.ProductReview", b =>
                {
                    b.HasOne("FitnessApp.Data.Models.Product", "Product")
                        .WithMany("ProductReviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FitnessApp.Data.Models.ApplicationUser", "User")
                        .WithOne("ProductReview")
                        .HasForeignKey("FitnessApp.Data.Models.ProductReview", "UserId")
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
                        .WithOne("ProgramReview")
                        .HasForeignKey("FitnessApp.Data.Models.ProgramReview", "UserId")
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
                    b.Navigation("ProductReview")
                        .IsRequired();

                    b.Navigation("ProgramReview")
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessApp.Data.Models.Category", b =>
                {
                    b.Navigation("Programs");
                });

            modelBuilder.Entity("FitnessApp.Data.Models.FoodRecipe", b =>
                {
                    b.Navigation("FoodRecipeAuthors");
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