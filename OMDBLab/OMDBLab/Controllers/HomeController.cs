using Microsoft.AspNetCore.Mvc;
using OMDBLab.Models;
using OMDBLab.Models.Interfaces;
using System.Diagnostics;

namespace OMDBLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetMovieByIdService _getMovieByIdService;

        public HomeController(ILogger<HomeController> logger, IGetMovieByIdService getMovieByIdService)
        {
            _logger = logger;
            _getMovieByIdService = getMovieByIdService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieSearchForm()
        {
            return View("MovieSearch");
        }

        [HttpPost]
        public async Task<IActionResult> MovieSearchResults([FromForm] string Title)
        {
           Movie movie = await _getMovieByIdService.GetMovieByIdAsync(Title);

            
            return View("MovieSearch", movie);
        }

        //movie search

        [HttpGet]
        public IActionResult MovieNightForm()
        {
            return View("MovieNight");
        }

        [HttpPost]
        public async Task<IActionResult> MovieNightResults([FromForm]string Title1, string Title2,  string Title3)
        {
            Movie movie1 = await _getMovieByIdService.GetMovieByIdAsync(Title1);
            Movie movie2 = await _getMovieByIdService.GetMovieByIdAsync(Title2);
            Movie movie3 = await _getMovieByIdService.GetMovieByIdAsync(Title3);

            List<Movie> movies = new List<Movie>
            {
                movie1,
                movie2,
                movie3
            };

            ReturnMovieResponse response = new ReturnMovieResponse();
            response.Movies = movies; 
            return View("MovieNight", response);
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