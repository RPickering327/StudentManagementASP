using System;

namespace Ewart.Models.Courses
{
    public class TimeTable
    {

        public int TimeTableId { get; set; }

        public DateTime DateOfLesson { get; set; }

        public TimeSpan Duration { get; set; }

        public IndividualSubject SubjectDetails { get; set; }

    }
}
