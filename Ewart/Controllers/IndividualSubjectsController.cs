using Ewart.Models.Courses;
using Ewart.Models.Database;
using Ewart.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ewart.Controllers
{
    public class IndividualSubjectsController : Controller
    {
        private readonly EwartContext _context;

        public IndividualSubjectsController(EwartContext context)
        {
            _context = context;
        }

        // GET: IndividualSubjects
        public IActionResult Index()
        {


            var courseViewModel = new CourseViewModel()
            {

                individualSubjects = _context.classes.ToList()


            };

            return View(courseViewModel);
        }



        public IActionResult TimeTable(int month)
        {

            var year = DateTime.Now.Year;

            //Set the month to the current month by default.
            if (month == 0)
            {
                month = DateTime.Now.Month;
            }


            var CurrentMonth = GetDates(2019, month);

            var courseViewModel = new CourseViewModel()
            {
                CalDateTimes = CurrentMonth,
                individualSubjects = _context.classes.ToList(),
                PlannedLesson = _context.timetables.ToList()

            };


            return View(courseViewModel);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TimeTable(CourseViewModel timeTable)
        {



            if (ModelState.IsValid)
            {
                _context.Add(timeTable.ClassTime);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TimeTable));
            }


            return View(timeTable);

        }


        //Get all the days in the current month and year.
        private List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
                .Select(day => new DateTime(year, month, day)) // Map each day to a date
                .ToList(); // Load dates into a list
        }


        // GET: IndividualSubjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var individualSubject = await _context.classes
                .FirstOrDefaultAsync(m => m.SubjectId == id);
            if (individualSubject == null)
            {
                return NotFound();
            }

            return View(individualSubject);
        }

        // GET: IndividualSubjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IndividualSubjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SubjectId,Name,TeacherId,CourseId,LessonDuration,DescriptionOne,DescriptionTwo,DescriptionThree,DescriptionFour")] IndividualSubject individualSubject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(individualSubject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(individualSubject);
        }

        // GET: IndividualSubjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var individualSubject = await _context.classes.FindAsync(id);
            if (individualSubject == null)
            {
                return NotFound();
            }
            return View(individualSubject);
        }

        // POST: IndividualSubjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SubjectId,Name,TeacherId,CourseId,LessonDuration,DescriptionOne,DescriptionTwo,DescriptionThree,DescriptionFour")] IndividualSubject individualSubject)
        {
            if (id != individualSubject.SubjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(individualSubject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndividualSubjectExists(individualSubject.SubjectId))
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
            return View(individualSubject);
        }

        // GET: IndividualSubjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var individualSubject = await _context.classes
                .FirstOrDefaultAsync(m => m.SubjectId == id);
            if (individualSubject == null)
            {
                return NotFound();
            }

            return View(individualSubject);
        }

        // POST: IndividualSubjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var individualSubject = await _context.classes.FindAsync(id);
            _context.classes.Remove(individualSubject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndividualSubjectExists(int id)
        {
            return _context.classes.Any(e => e.SubjectId == id);
        }
    }
}
