

namespace FitnessApp.Data.Configurations
{
    using FitnessApp.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProgramConfiguration : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder
               .HasOne(p => p.Category)
               .WithMany(c => c.Programs)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(p => p.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);

            builder.HasData(this.GeneratePrograms());
        }

        private Program[] GeneratePrograms()
        {
            ICollection<Program> programs = new HashSet<Program>();

            Program program;

            program = new Program()
            {
                Name = "The Essential Program",
                CategoryId = 4,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://www.bodybuilding.com/images/2016/june/essential-8-exercises-to-get-ripped-v2-5-700xh.jpg",
                Description = "Customized Workout Solutions. Tailored exercise programs designed to meet your fitness goals. Personalized routines for beginners to advanced athletes. Varied exercises targeting strength, cardio, and flexibility. Achieve your desired results with Essential Program, your ultimate workout companion."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Intermediate/Advanced Push Pull Legs",
                CategoryId = 4,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://cdn.shopify.com/s/files/1/1633/7705/articles/push_pull_legs_2000x.jpg?v=1614057323",
                Description = "An Efficient Training Program. Customized push, pull, and leg workouts designed to optimize muscle growth and strength. Balanced exercises targeting major muscle groups. Varied training intensity and progressive overload. Achieve results with time-efficient workouts."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Ultimate Full Body",
                CategoryId = 4,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://cdn.shopify.com/s/files/1/1497/9682/files/1.Differences_Between_Full_Body_and_Split_Workouts.jpg?v=1685531264&width=750",
                Description = "Comprehensive and Time-Saving. A complete workout program targeting all muscle groups. Efficient exercises to maximize strength, endurance, and calorie burn. Balanced routines for optimal results. Achieve total body fitness in minimal time."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Chest Boost",
                CategoryId = 3,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://cdn.shopify.com/s/files/1/1633/7705/articles/outer_chest_exercises_2000x.jpg?v=1649406838",
                Description = "Sculpted Pecs in Focus. A specialized program to enhance chest muscle growth and definition. Targeted exercises to isolate and stimulate the pectoral muscles. Progressive overload for continuous hypertrophy. Sculpt your chest with precision and achieve an impressive upper body physique."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Arm Sculptor",
                CategoryId = 3,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://i.redd.it/6pt9rtvj7ro11.jpg",
                Description = "Build Strong and Impressive Arms. A dedicated program to maximize arm development. Targeted exercises for biceps, triceps, and forearm muscles. Emphasize progressive overload and proper form for optimal muscle growth. Sculpt your arms with Arm Sculptor and showcase your strength and aesthetics."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Back Builder",
                CategoryId = 3,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://img.myloview.com/posters/body-builder-posing-rear-lat-spread-strong-healthy-power-fitness-handsome-athletic-man-with-muscular-trained-body-flexing-his-lateral-back-muscle-on-black-background-700-203829669.jpg",
                Description = "Build Strong, V-Shaped Back. Comprehensive program targeting lats, traps, and erector spinae. Compound exercises and progressive overload for muscle growth. Build a powerful back with Back Builder, your ultimate tool for a chiseled physique."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Power Bench Press",
                CategoryId = 2,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://www.westend61.de/images/0001492699pw/from-above-of-strong-focused-male-athlete-lying-on-bench-press-and-doing-exercises-with-heavy-barbell-during-workout-in-gym-ADSF19039.jpg",
                Description = "Dominate Bench Press. Powerlifting-focused program to maximize your bench press strength. Progressive overload, specialized exercises, and form refinement for optimal gains. Unleash explosive power and achieve new personal records. Conquer the bench and leave a mark in powerlifting."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Power Squat",
                CategoryId = 2,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://wodstarmedia.s3.amazonaws.com/wp-content/uploads/2017/08/squat.jpg",
                Description = "Dominate Squat Powerlifting. Specialized program for maximizing squat strength. Targeted exercises, proper form, and progressive overload. Build explosive power and achieve new personal records. Conquer the squat platform with PowerSquat and rise as a powerlifting force."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Glute Gain",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://www.bodybuilding.com/images/2020/march/glute-and-hamstring-workouts-for-women-1-700xh.jpg",
                Description = "Build Strong, Shapely Glutes. Tailored program for women targeting glute muscle hypertrophy. Targeted exercises, progressive overload, and effective techniques. Sculpt and enhance your lower body with Glute Gain, your key to a curvaceous physique."
            };
            programs.Add(program);

            program = new Program()
            {
                Name = "Her Fit",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                PictureUrl = "https://medicalchannelasia.com/wp-content/uploads/2022/05/2022.05.31-squats.jpg",
                Description = "Customized Workout Solutions for Women. Tailored exercise programs designed to meet the unique fitness goals of women. Varied routines targeting strength, cardio, and flexibility. Achieve your desired results with HerFit, your personalized workout plan for a stronger and healthier you."
            };
            programs.Add(program);

            return programs.ToArray();
        }
    }
}
