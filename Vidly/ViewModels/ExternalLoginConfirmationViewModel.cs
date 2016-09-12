using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        [StringLength(255)]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [StringLength(50)]
        public string Phone { get; set; }
    }
}