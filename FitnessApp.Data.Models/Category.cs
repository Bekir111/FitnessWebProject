
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static FitnessApp.Common.EntityValidationConstants.Category;
    public class Category
    {
        public Category()
        {
            this.Programs = new HashSet<Program>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual ICollection<Program> Programs { get; set; } = null!;
    }
}
