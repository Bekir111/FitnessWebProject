
namespace FitnessApp.Data.Models
{

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProgramUser
    {
        [Required]
        [ForeignKey(nameof(Program))]
        public Guid ProgramId { get; set; }
        public Program Program { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public bool IsActive { get; set; }
    }
}
