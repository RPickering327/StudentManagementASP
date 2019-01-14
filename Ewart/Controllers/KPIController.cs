using Ewart.Models.Database;
using Ewart.Models.KPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ewart.Controllers
{
    public class KPIController : Controller
    {

        private readonly EwartContext _context;

        public KPIController(EwartContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> SchoolKPI()
        {

            //Generate the bar chart 
            var kpiBarChart = await NumberOfStudentsBarChart();


            var schoolOverview = new SchoolOverview()
            {

                NumberOfStudents = kpiBarChart,
                BudgetBurnDown = BudgetBurnDown()



            };


            return View(schoolOverview);

        }


        // GET: UserSettings
        public ActionResult StudentKPI()
        {
            return View();
        }




        //Return the number of students per teacher into a json format
        private async Task<string> NumberOfStudentsBarChart()
        {

            //Get the students table
            var teacher = _context.users.Where(c => c.UserType.Contains("Teacher"));

            //Header
            string chart = "['Teacher', 'Number of students']";

            foreach (var teachers in teacher)
            {
                var student =
                   await _context.students.Where(c => c.UserType.Contains("Student") && c.TeacherId == teachers.UserId).ToListAsync();


                chart += $",['{teachers.FirstName} {teachers.LastName}', {student.Count()}]";

            }

            return chart;

        }



        private string BudgetBurnDown()
        {

            var teacher = _context.users.Where(c => c.UserType.Contains("Teacher"));
            var budget = _context.userSettings.First().YearlyBudget;

            var chart = "['Expenditure', 'Total']";

            double totalSalary = 0;
            double remaingBudget = 0;

            foreach (var teachers in teacher)
            {

                totalSalary += teachers.CostPerWeek;

            }


            totalSalary = (52 * totalSalary);
            remaingBudget = budget - totalSalary;

            chart += $",['Staff Wages', {totalSalary}]";
            chart += $",['Remaining Budget', {remaingBudget}]";

            return chart;

        }
    }
}
