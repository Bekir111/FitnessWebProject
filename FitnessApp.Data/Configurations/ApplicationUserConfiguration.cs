using FitnessApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessApp.Data.Configurations
{
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
        }
    }
}
