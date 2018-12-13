using System.Collections.Generic;

namespace StudentManagement.Models
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);

        void EnrollStudent(Student student);

        IEnumerable<Student> GetAllStudents();

    }
}
