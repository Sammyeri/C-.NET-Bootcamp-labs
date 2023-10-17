using Microsoft.AspNetCore.Mvc;
using PaupersRedditLab.Models;
using PaupersRedditLab.Models.Interfaces;
using System.Diagnostics;

namespace PaupersRedditLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetPostsService _getPostsService;

        public HomeController(ILogger<HomeController> logger, IGetPostsService getPostsService)
        {
            _logger = logger;
            _getPostsService = getPostsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DisplayPosts()
        {
            var posts = await _getPostsService.GetPosts();
            return View(posts);
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