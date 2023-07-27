
namespace FitnessApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FitnessApp.Data.Models;
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(u => u.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.ProgramReviews)
                .WithOne(p => p.User)
                .HasForeignKey(u => u.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.ProductReviews)
               .WithOne(p => p.User)
               .HasForeignKey(u => u.Id)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.FoodRecipes)
               .WithOne(p => p.User)
               .HasForeignKey(u => u.Id)
               .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(u => u.FirstName)
                .HasDefaultValue("Test");

            builder
                .Property(u => u.LastName)
                .HasDefaultValue("Testov");
        }
    }
}
