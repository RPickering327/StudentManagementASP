using Ewart.Models.Courses;
using Ewart.Models.Users;
using System.Collections.Generic;

namespace Ewart.ViewModel
{
    public class BaseUserViewModel
    {
        //For staff at the organization
        public IEnumerable<BaseUser> ListUsers { get; set; }
        public BaseUser BaseUser2 { get; set; }


        //For students at the organization
        public IEnumerable<Student> ListStudents { get; set; }
        public Student Student { get; set; }


        //Display the current year groups a student can be put into
        public IEnumerable<Course> Course { get; set; }
    }
}
