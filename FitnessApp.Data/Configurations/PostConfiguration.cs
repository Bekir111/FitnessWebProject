
namespace FitnessApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;

    using FitnessApp.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder
                .Property(p => p.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);

        }
    }
}
