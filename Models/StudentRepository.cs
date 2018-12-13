using System.Collections.Generic;

namespace StudentManagement.Models
{
    public class StudentRepository : IStudentRepository
    {

        private readonly AppDbContext _appDbContext;


        public StudentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        public void AddStudent(Student student)
        {

            _appDbContext.Students.Add(student);
            _appDbContext.SaveChanges();

        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _appDbContext.Students;
        }

        public void EnrollStudent(Student student)
        {
            _appDbContext.Students.Update(student);
            _appDbContext.SaveChanges();
        }

    }
}
