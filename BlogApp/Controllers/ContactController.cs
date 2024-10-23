using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Send(string fullName, string email, string subject, string message)
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
