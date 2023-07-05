
namespace FitnessApp.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    
    using FitnessApp.Data.Models;
    public class ProgramUserConfiguration : IEntityTypeConfiguration<ProgramUser>
    {
        public void Configure(EntityTypeBuilder<ProgramUser> builder)
        {
            builder.HasKey(pu => new { pu.ProgramId, pu.UserId });
            builder
                .HasOne(pu => pu.Program)
                .WithMany(p => p.ProgramUsers)
                .HasForeignKey(pu => pu.ProgramId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
