using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ewart.Models.Courses
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string CourseDescription { get; set; }

        [ForeignKey("BaseUser")]
        public int TeacherId { get; set; }




    }
}
