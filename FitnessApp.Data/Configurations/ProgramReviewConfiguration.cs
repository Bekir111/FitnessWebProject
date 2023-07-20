using FitnessApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessApp.Data.Configurations
{
    public class ProgramReviewConfiguration : IEntityTypeConfiguration<ProgramReview>
    {
        public void Configure(EntityTypeBuilder<ProgramReview> builder)
        {
            builder
                .HasOne(pr => pr.User)
                .WithOne(u => u.ProgramReview)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(pr => pr.Program)
                .WithMany(p => p.Reviews)
                .HasForeignKey(pr => pr.ProgramId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(pr => pr.IsActive)
                .HasDefaultValue(true);
        }
    }
}
