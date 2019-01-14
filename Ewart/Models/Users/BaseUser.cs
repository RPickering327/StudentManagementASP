using System;
using System.ComponentModel.DataAnnotations;

namespace Ewart.Models.Users
{
    public class BaseUser
    {


        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        public string UserType { get; set; }

        [Required(ErrorMessage = "Cost per week is required.")]
        public int CostPerWeek { get; set; }

    }
}
