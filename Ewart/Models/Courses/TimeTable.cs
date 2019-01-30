using System;

namespace Ewart.Models.Courses
{
    public class TimeTable
    {

        public int TimeTableId { get; set; }

        public int TeacherId { get; set; }

        public DateTime DateOfLesson { get; set; }

        public TimeSpan Duration { get; set; }


        public int SubjectDetailsSubjectId { get; set; }


    }
}
