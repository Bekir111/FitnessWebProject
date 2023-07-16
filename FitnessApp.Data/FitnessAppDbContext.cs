namespace FitnessApp.Data
{
    using System.Reflection;

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    using FitnessApp.Data.Models;

    public class FitnessAppDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>, Guid>
    {
        public FitnessAppDbContext(DbContextOptions<FitnessAppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<FoodRecipe> FoodRecipes { get; set; } = null!;

        public DbSet<Post> Posts { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<ProductReview> ProductReviews { get; set; } = null!;

        public DbSet<Program> Programs { get; set; } = null!;

        public DbSet<ProgramReview> ProgramReviews { get; set; } = null!;

        public DbSet<ProgramUser> ProgramUsers { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(FitnessAppDbContext))
                ?? Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(configAssembly);

            

            base.OnModelCreating(builder);
        }
    }
}