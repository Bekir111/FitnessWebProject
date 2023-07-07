using FitnessApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessApp.Data.Configurations
{
	public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
            builder
                .Property(x => x.ProductReviewId)
                .IsRequired(false);

            builder
                .Property(x => x.ProgramReviewId)
                .IsRequired(false);
        }
	}
}
