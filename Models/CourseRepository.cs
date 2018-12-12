using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Models
{
    public class CourseRepository : ICourseRepository
    {

        private readonly AppDbContext _appDbContext;

        public CourseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Check if the data is populated if not load the data from the database
        public IEnumerable<Course> GetAllCourses()
        {
            return _appDbContext.Courses;
        }


        //Get the course by ID and all the properties that go with it e.g.  name, grade so on....
        public Course GetCourseId(int courseId)
        {
            return _appDbContext.Courses.FirstOrDefault(c => c.Id == courseId);
        }


        //Take an instance of course and add it to the database
        public void AddCourse(Course course)
        {

            _appDbContext.Courses.Add(course);
            _appDbContext.SaveChanges();


        }
    }
}
