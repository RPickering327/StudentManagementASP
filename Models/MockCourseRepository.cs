using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Models
{
    public class MockCourseRepository : ICourseRepository
    {

        private List<Course> _course;

        public MockCourseRepository()
        {
            if (_course == null)
            {
                InitializeCourse();
            }
        }


        private void InitializeCourse()
        {
            _course = new List<Course>
            {
                new Course { Id = 1, Name = "Advanced Maths", Grade = 85, ShortDescritpion = "Advanced Maths 1", LongDescription = "Advanced maths year one and two students can take to be eligble to get into year 3", NumberOfSpaces = 100, ImageUrl="http://www.mrbartonmaths.com/blog/wp-content/uploads/2017/06/june.png", IsCourseFull = false, ImageThumbnailUrl = "http://www.mrbartonmaths.com/blog/wp-content/uploads/2017/06/june.png" },
                new Course { Id = 2, Name = "Advanced Maths Third Year", Grade = 55, ShortDescritpion = "Advanced Maths 2", LongDescription = "Advanced maths year one and two students can take to be eligble to get into year 3", NumberOfSpaces = 100, ImageUrl="http://www.mrbartonmaths.com/blog/wp-content/uploads/2017/06/june.png", IsCourseFull = false, ImageThumbnailUrl = "http://www.mrbartonmaths.com/blog/wp-content/uploads/2017/06/june.png"  },
                new Course { Id = 3, Name = "IT For beginners", Grade = 60, ShortDescritpion = "Advanced Maths 2", LongDescription = "Advanced maths year one and two students can take to be eligble to get into year 3", NumberOfSpaces = 100, ImageUrl="http://www.mrbartonmaths.com/blog/wp-content/uploads/2017/06/june.png", IsCourseFull = false, ImageThumbnailUrl = "http://www.mrbartonmaths.com/blog/wp-content/uploads/2017/06/june.png"  },
                new Course { Id = 4, Name = "Physics and Business", Grade = 65, ShortDescritpion = "Advanced Maths 2", LongDescription = "Advanced maths year one and two students can take to be eligble to get into year 3", NumberOfSpaces = 100, ImageUrl="http://www.mrbartonmaths.com/blog/wp-content/uploads/2017/06/june.png", IsCourseFull = false, ImageThumbnailUrl = "http://www.mrbartonmaths.com/blog/wp-content/uploads/2017/06/june.png"  }

            };

        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _course;
        }

        public Course GetCourseId(int courseId)
        {
            return _course.FirstOrDefault(p => p.Id == courseId);
        }

        public void AddCourse(Course course)
        {
            //Don't want to mock this.
        }

    }
}
