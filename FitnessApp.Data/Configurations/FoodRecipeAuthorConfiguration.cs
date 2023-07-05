
namespace FitnessApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    
    using FitnessApp.Data.Models;
    public class FoodRecipeAuthorConfiguration : IEntityTypeConfiguration<FoodRecipeAuthor>
    {
        public void Configure(EntityTypeBuilder<FoodRecipeAuthor> builder)
        {
            builder.HasKey(fa => new { fa.AuthorId, fa.FoodRecipeId });
            builder
                .HasOne(fra => fra.FoodRecipe)
                .WithMany(fr => fr.FoodRecipeAuthors)
                .HasForeignKey(fra => fra.FoodRecipeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
