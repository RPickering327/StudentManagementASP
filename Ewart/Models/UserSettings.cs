using System.ComponentModel.DataAnnotations;

namespace Ewart.Models
{
    public class UserSettings
    {
        [Key]
        public int OrganizationId { get; set; }

        [Required(ErrorMessage = "Please enter a school name.")]
        public string OrganizationName { get; set; }

        [Required(ErrorMessage = "Please select an image to upload.")]
        public string LogoUrl { get; set; }

        [Required(ErrorMessage = "A contact number is required.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "A email address is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A motto or slogan is required.")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "A long description is required")]
        public string LongDescription { get; set; }

        [Required(ErrorMessage = "The address field must be filled in.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The yearly budget field must be filled in.")]
        public double YearlyBudget { get; set; }


    }
}
