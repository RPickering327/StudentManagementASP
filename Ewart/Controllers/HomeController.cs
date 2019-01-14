
using Ewart.Models.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Ewart.Controllers
{
    public class HomeController : Controller
    {

        private readonly EwartContext _context;

        public HomeController(EwartContext context)
        {
            _context = context;
        }


        //Display the custom user settings e.g. school name and so on.
        public async Task<IActionResult> Index(int? id)
        {
            id = 1;

            if (id == null)
            {
                return NotFound();
            }

            var userSettings = await _context.userSettings
                .FirstOrDefaultAsync(m => m.OrganizationId == id);
            if (userSettings == null)
            {
                return NotFound();
            }

            return View(userSettings);
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
