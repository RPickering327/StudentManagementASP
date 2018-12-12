using StudentManagement.Models;
using System.Collections.Generic;

namespace StudentManagement.ViewModels
{
    public class HomeViewModel
    {

        public string Title { get; set; }

        public List<Course> Courses { get; set; }

    }
}
