using Ewart.Models.Database;
using Ewart.Models.Users;
using Ewart.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ewart.Controllers
{
    public class BaseUsersController : Controller
    {
        private readonly EwartContext _context;

        public BaseUsersController(EwartContext context)
        {
            _context = context;
        }

        // GET: BaseUsers
        public IActionResult Index()
        {

            var student = _context.users.Where(c => c.UserType.Contains("Teacher") || c.UserType.Contains("Admin"));

            var studentViewModel = new BaseUserViewModel()
            {

                ListUsers = student.ToList()


            };

            return View(studentViewModel);

        }

        //Display for all students
        public IActionResult Student(int? id)
        {

            var student = _context.students.Where(c => c.UserType.Contains("Student"));
            var teacher = _context.users.Where(c => c.UserType.Contains("Teacher"));
            var course = _context.courses.ToList();




            var baseViewModel = new BaseUserViewModel()
            {

                ListStudents = student.ToList(),
                ListUsers = teacher.ToList(),
                Course = course


            };

            return View(baseViewModel);
        }

        //When a new teacher of teaching assitant is added
        [HttpPost]
        public async Task<IActionResult> Index(BaseUserViewModel User)
        {

            if (ModelState.IsValid)
            {

                if (User.BaseUser2 != null)
                {

                    _context.Add(User.BaseUser2);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    _context.Add(User.Student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Student));
                }

            }
            else
            {
                if (User.BaseUser2 != null)
                {

                    var student = _context.users.Where(c => c.UserType.Contains("Teacher") || c.UserType.Contains("Admin"));
                    var studentViewModel = new BaseUserViewModel()
                    {

                        ListUsers = student.ToList()


                    };

                    return View(studentViewModel);
                }
                else
                {
                    var student = _context.students.OrderBy(c => c.UserId);
                    var studentViewModel = new BaseUserViewModel()
                    {

                        ListUsers = student.ToList()


                    };

                    return RedirectToAction(nameof(Student));
                }


            }

        }









        // GET: BaseUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseUser = await _context.users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (baseUser == null)
            {
                return NotFound();
            }

            return View(baseUser);
        }




        // GET: BaseUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseUser = await _context.users.FindAsync(id);
            if (baseUser == null)
            {
                return NotFound();
            }
            return View(baseUser);
        }

        // POST: BaseUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FirstName,LastName,DateOfBirth,Email,Address,UserType,CostPerWeek")] BaseUser baseUser)
        {
            if (id != baseUser.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(baseUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BaseUserExists(baseUser.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(baseUser);
        }

        // GET: BaseUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var baseUser = await _context.users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (baseUser == null)
            {
                return NotFound();
            }

            return View(baseUser);
        }

        // POST: BaseUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var baseUser = await _context.users.FindAsync(id);
            _context.users.Remove(baseUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BaseUserExists(int id)
        {
            return _context.users.Any(e => e.UserId == id);
        }
    }
}
