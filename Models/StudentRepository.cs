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

    }
}
