
namespace FitnessApp.Services.Tests
{
    using FitnessApp.Data;
    using FitnessApp.Data.Migrations;
    using FitnessApp.Data.Models;
    public static class DatabaseSeeder
    {
        public static ApplicationUser ApplicationUser;

        public static void SeedDatabase(FitnessAppDbContext dbContext)
        {

            ApplicationUser = new ApplicationUser()
            {
                UserName = "Eminem1",
                NormalizedUserName = "EMINEM1",
                Email = "eminem@gmail.com",
                NormalizedEmail = "EMINEM@GMAIL.COM",
                EmailConfirmed = false,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                SecurityStamp = "a8c45fb7-6855-412f-bb0a-fee4ecb27f88",
                ConcurrencyStamp = "9d5467bf-6e77-4e4b-afad-f3db42f2caa3",
                TwoFactorEnabled = false,
                FirstName = "Slim",
                LastName = "Shady"
            };

            dbContext.Users.Add(ApplicationUser);
            dbContext.SaveChanges();
        }
    }
}
