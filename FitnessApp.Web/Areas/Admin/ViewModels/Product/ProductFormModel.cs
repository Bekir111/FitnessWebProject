using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Web.Areas.Admin.ViewModels.Product
{
    using static FitnessApp.Common.EntityValidationConstants.Product;
    using static FitnessApp.Common.EntityValidationConstants.Program;
    public class ProductFormModel
    {
        [Required]
        [StringLength(ProductNameMaxLength , MinimumLength = ProductNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(ProductDescriptionMaxLength, MinimumLength = ProductDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ProgramPictureUrlMaxLength)]
        [Display(Name = "Image Link")]
        public string PictureUrl { get; set; } = null!;

        [Range(typeof(decimal), "0", "1000")]
        public decimal Price { get; set; }
    }
}
