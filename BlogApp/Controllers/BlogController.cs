using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;



namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public IActionResult Index()
        {
            var blogPosts = new List<BlogPost>
        {
            new BlogPost { Id = 1, Title = "Blog Yazısı 1", Summary = "Bu, ilk blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=1" },
            new BlogPost { Id = 2, Title = "Blog Yazısı 2", Summary = "Bu, ikinci blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=2" },
            new BlogPost { Id = 3, Title = "Blog Yazısı 3", Summary = "Bu, üçüncü blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=3" },
            new BlogPost { Id = 4, Title = "Blog Yazısı 4", Summary = "Bu, dördüncü blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=4" },
            new BlogPost { Id = 5, Title = "Blog Yazısı 5", Summary = "Bu, beşinci blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=5" },
            new BlogPost { Id = 6, Title = "Blog Yazısı 6", Summary = "Bu, altıncı blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=6" },
            new BlogPost { Id = 7, Title = "Blog Yazısı 7", Summary = "Bu, yedinci blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=7" },
            new BlogPost { Id = 8, Title = "Blog Yazısı 8", Summary = "Bu, sekizinci blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=8" },
            new BlogPost { Id = 9, Title = "Blog Yazısı 9", Summary = "Bu, dokuzuncu blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=9" },
            new BlogPost { Id = 10, Title = "Blog Yazısı 10", Summary = "Bu, onuncu blog yazısının özeti.", ImageUrl = "https://picsum.photos/200/150?random=10" }
        };
            return View(blogPosts);
        }

    }
}
