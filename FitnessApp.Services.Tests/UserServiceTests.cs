
namespace FitnessApp.Services.Tests
{
    using System.Collections.ObjectModel;
    using System.Collections;
    using System.Collections.Generic;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Http;
    
    using NUnit.Framework;
    
    using FitnessApp.Data;
    using FitnessApp.Data.Migrations;
    using static DatabaseSeeder;
    using FitnessApp.Web.ViewModels.User;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Services.Data;

    public class UserServiceTests
    {
        private DbContextOptions<FitnessAppDbContext> dbOptions;
        private FitnessAppDbContext dbContext;
        private IUserService userService;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<FitnessAppDbContext>()
                .UseInMemoryDatabase("FitnessAppInMemory" + Guid.NewGuid().ToString())
                .Options;
            this.dbContext = new FitnessAppDbContext(this.dbOptions);

            dbContext.Database.EnsureCreated();

            SeedDatabase(this.dbContext);

            this.userService = new UserService(this.dbContext);
        }
        [Test]
        public async Task GetAllUsersShouldPass()
        {
            UserViewModel user = new UserViewModel()
            {
                UserName = ApplicationUser.UserName,
                Email = ApplicationUser.Email,
                FirstName = ApplicationUser.FirstName,
                LastName = ApplicationUser.LastName
            };
            ICollection<UserViewModel> userCollection = new List<UserViewModel>();
            userCollection.Add(user);

            //Act
            var result = await this.userService.GetUsers();

            //Assert

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }
    }
}