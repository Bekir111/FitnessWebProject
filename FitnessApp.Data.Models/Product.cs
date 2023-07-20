
namespace FitnessApp.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    
    using static FitnessApp.Common.EntityValidationConstants.Product;
    public class Product
    {
        public Product()
        {
            this.Id = Guid.NewGuid();
            this.ProductReviews = new HashSet<ProductReview>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(ProductNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(ProductDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        [Required]
        public string PictureUrl { get; set; } = null!;

        public bool IsAvailable { get; set; }

        public virtual ICollection<ProductReview> ProductReviews { get; set; } = null!;
    }
}
