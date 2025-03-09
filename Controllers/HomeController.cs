using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PakoBlog.Models;

namespace PakoBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PakoBlogDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, PakoBlogDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var postsToShow = _dbContext.Post.Include(p => p.Category).ToList();
            foreach (var post in postsToShow)
            {
                post.Author = _dbContext.Author.FirstOrDefault(a => a.ID == post.AuthorID);
            }
            return View(postsToShow);
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Post(int postID)
        {
            var post = _dbContext.Post.Include(p => p.Author)
                .FirstOrDefault(p => p.ID == postID);
            post.ImagePath = "/img/" + post.ImagePath;
            return View(post);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
