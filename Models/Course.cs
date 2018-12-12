using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Course
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Short description is required")]
        public string ShortDescritpion { get; set; }

        [Required(ErrorMessage = "A long description is required")]
        public string LongDescription { get; set; }

        [Required(ErrorMessage = "Minimum grade for the course is required")]
        public decimal Grade { get; set; }

        [Required(ErrorMessage = "Picture URL is needed")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Picture thumbnail URL is needed")]
        public string ImageThumbnailUrl { get; set; }

        [Required(ErrorMessage = "Please enter number of spaces on the course")]
        public int NumberOfSpaces { get; set; }

        public bool IsCourseFull { get; set; }

    }
}

