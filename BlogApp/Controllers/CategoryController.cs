using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public IActionResult Index()
        {
            var categories = new List<Category>
        {
            new Category { Id = 1, Name = "Teknoloji" },
            new Category { Id = 2, Name = "Sağlık" },
            new Category { Id = 3, Name = "Eğitim" }
        };

           
            ViewBag.Categories = categories;

            return View(categories);
        }

    }
}
