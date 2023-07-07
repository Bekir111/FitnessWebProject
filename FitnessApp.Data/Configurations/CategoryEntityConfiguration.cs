using FitnessApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessApp.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.GenerateCategories());
        }

        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;
            category = new Category()
            {
                Id = 1,
                Name = "Programs for women"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Powerlifting"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Body part programs"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Muscle and strength programs"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
