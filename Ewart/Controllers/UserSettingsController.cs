using Ewart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ewart.Controllers
{
    public class UserSettingsController : Controller
    {
        private readonly Models.Database.EwartContext _context;

        public UserSettingsController(Models.Database.EwartContext context)
        {
            _context = context;
        }

        // GET: UserSettings
        public async Task<IActionResult> Index()
        {
            return View(await _context.userSettings.ToListAsync());
        }

        // GET: UserSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
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

        // GET: UserSettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserSettings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrganizationId,OrganizationName,LogoUrl,PhoneNumber,Email,ShortDescription,LongDescription,Address")] UserSettings userSettings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userSettings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userSettings);
        }

        // GET: UserSettings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userSettings = await _context.userSettings.FindAsync(id);
            if (userSettings == null)
            {
                return NotFound();
            }
            return View(userSettings);
        }

        // POST: UserSettings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrganizationId,OrganizationName,LogoUrl,PhoneNumber,Email,ShortDescription,LongDescription,Address,YearlyBudget")] UserSettings userSettings)
        {
            if (id != userSettings.OrganizationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userSettings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserSettingsExists(userSettings.OrganizationId))
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
            return View(userSettings);
        }

        // GET: UserSettings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
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

        // POST: UserSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userSettings = await _context.userSettings.FindAsync(id);
            _context.userSettings.Remove(userSettings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserSettingsExists(int id)
        {
            return _context.userSettings.Any(e => e.OrganizationId == id);
        }
    }
}
