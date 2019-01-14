using Ewart.Models.Courses;
using Ewart.Models.Users;
using System;
using System.Collections.Generic;

namespace Ewart.ViewModel
{
    public class CourseViewModel
    {

        public IEnumerable<IndividualSubject> individualSubjects { get; set; }

        public IEnumerable<Course> Courses { get; set; }

        public IEnumerable<Student> User { get; set; }

        public List<DateTime> CalDateTimes = new List<DateTime>();


    }
}
