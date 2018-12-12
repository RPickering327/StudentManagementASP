using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICourseRepository _courseRepository;


        public HomeController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {


            var course = _courseRepository.GetAllCourses().OrderBy(c => c.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Current courses offered at this university",
                Courses = course.ToList()


            };

            return View(homeViewModel);
        }


        public IActionResult Details(int id)
        {

            var course = _courseRepository.GetCourseId(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);

        }

        public IActionResult AddCourse()
        {

            return View();


        }


        [HttpPost]
        public IActionResult AddCourse(Course course)
        {

            if (ModelState.IsValid)
            {
                _courseRepository.AddCourse(course);

                return RedirectToAction("AddCourse");
            }

            return View(course);

        }
    }
}
