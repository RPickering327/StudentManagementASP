using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using System.Linq;

namespace StudentManagement.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {

        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {

            if (ModelState.IsValid)
            {
                _studentRepository.AddStudent(student);

                return RedirectToAction("StudentAdded");
            }

            return View(student);

        }


        public IActionResult StudentAdded()
        {

            return View();


        }

        public IActionResult EnrolledStudents()
        {

            var student = _studentRepository.GetAllStudents().OrderBy(c => c.StudentId);

            var studentViewModel = new StudentViewModel()
            {

                Students = student.ToList()


            };

            return View(studentViewModel);
        }


    }


}
