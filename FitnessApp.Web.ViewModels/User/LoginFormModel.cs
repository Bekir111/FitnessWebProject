using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Web.ViewModels.User
{
    public class LoginFormModel
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9._]+$")]
        [DataType(DataType.Text)]
        public string Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
