using System.Collections.Generic;

namespace StudentManagement.Models
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();

        Course GetCourseId(int courseId);

        void AddCourse(Course course);

    }
}
