namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static FitnessApp.Common.EntityValidationConstants.Program;
    public class Program
    {
        public Program()
        {
            this.Id = Guid.NewGuid();
            this.Reviews = new HashSet<ProgramReview>();
            this.ProgramUsers = new HashSet<ProgramUser>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(ProgramNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ProgramDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ProgramPictureUrlMaxLength)]
        public string PictureUrl { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;

        public virtual ICollection<ProgramUser> ProgramUsers { get; set; } = null!;

        public virtual ICollection<ProgramReview> Reviews { get; set; } = null!;

        public double AverageRating => CalculateAverageRating();


        private double CalculateAverageRating()
        {
            if (this.Reviews.Count == 0)
            {
                return 0;
            }
            return Reviews.Average(r => r.Rating);
        }

    }
}
