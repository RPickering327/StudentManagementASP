using Microsoft.AspNetCore.Mvc;

namespace Ewart.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult EmailSent()
        {
            return View();
        }


    }
}