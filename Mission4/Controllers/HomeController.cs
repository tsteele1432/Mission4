using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        //Returns Homepage
        public IActionResult Index()
        {
            return View();
        }

        //Returns MyPodcasts page
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //Get method for MovieForm page
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        //Post method for MovieForm page
        [HttpPost]
        public IActionResult MovieForm(Movie movie)
        {
            blahContext.Add(movie);
            blahContext.SaveChanges();

            return View("Submission", movie);

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
