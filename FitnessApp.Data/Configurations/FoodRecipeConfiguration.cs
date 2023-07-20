
namespace FitnessApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FitnessApp.Data.Models;
    public class FoodRecipeConfiguration : IEntityTypeConfiguration<FoodRecipe>
    {
        public void Configure(EntityTypeBuilder<FoodRecipe> builder)
        {
            builder
                .HasOne(fr => fr.User)
                .WithMany(u => u.FoodRecipes)
                .HasForeignKey(fr => fr.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(fr => fr.IsActive)
                .HasDefaultValue(true);
        }
    }
}
