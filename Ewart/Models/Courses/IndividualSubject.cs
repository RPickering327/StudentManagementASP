using System.ComponentModel.DataAnnotations;

namespace Ewart.Models.Courses
{
    public class IndividualSubject
    {
        [Key]
        public int SubjectId { get; set; }

        public string Name { get; set; }

        public int TeacherId { get; set; }

        public int CourseId { get; set; }

        public string DescriptionOne { get; set; }

        public string DescriptionTwo { get; set; }

        public string DescriptionThree { get; set; }

        public string DescriptionFour { get; set; }

    }
}
