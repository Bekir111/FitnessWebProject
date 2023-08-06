
namespace FitnessApp.Web.Areas.Admin.ViewModels.Program
{
    using System.ComponentModel.DataAnnotations;
    using System.Xml.Linq;

    using FitnessApp.Web.Areas.Admin.ViewModels.Category;

    using static FitnessApp.Common.EntityValidationConstants.Program;
    public class ProgramFormModel
    {
        public ProgramFormModel()
        {
            Categories = new HashSet<ProgramSelectCategoryFormModel>();
        }

        [Required]
        [StringLength(ProgramNameMaxLength, MinimumLength = ProgramNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(ProgramDescriptionMaxLength, MinimumLength = ProgramDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(ProgramPictureUrlMaxLength)]
        public string PictureUrl { get; set; } = null!;


        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<ProgramSelectCategoryFormModel> Categories { get; set; }
    }
}
