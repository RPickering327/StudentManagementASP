using System.ComponentModel.DataAnnotations.Schema;

namespace Ewart.Models.Users
{
    public class Student : BaseUser
    {

        [ForeignKey("BaseUser")]
        public int TeacherId { get; set; }

        public int CourseId { get; set; }

        public string Allergies { get; set; }

        public string EmergencyContact { get; set; }

        public string Notes { get; set; }

    }
}
