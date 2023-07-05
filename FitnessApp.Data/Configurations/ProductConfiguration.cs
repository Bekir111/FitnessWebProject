
namespace FitnessApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    
    using FitnessApp.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System.Reflection.Emit;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Price)
                .HasColumnType("decimal(18,4)");

        }
    }
}
