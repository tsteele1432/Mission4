using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        private MovieContext movieContext { get; set; }

        public HomeController(MovieContext someName)
        {
            movieContext = someName;
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

            ViewBag.Categories = movieContext.categories.ToList();

            return View();
        }

        //Post method for MovieForm page
        [HttpPost]
        public IActionResult MovieForm(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(movie);
                movieContext.SaveChanges();

                return View("Submission", movie);
            }
            else
            {
                ViewBag.Categories = movieContext.categories.ToList();
                return View();
            }
            

        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = movieContext.movies
                .Include(x => x.Category)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = movieContext.categories.ToList();

            var movie = movieContext.movies.Single(x => x.MovieId == movieid);

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit (Movie blah)
        {
            movieContext.Update(blah);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = movieContext.movies.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete (Movie movie)
        {
            movieContext.movies.Remove(movie);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
