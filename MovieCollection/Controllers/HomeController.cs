using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //home view
        public IActionResult Index()
        {
            return View();
        }

        //podcast link view
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //add film view
        [HttpGet]
        public IActionResult AddFilm()
        {
            return View();
        }

        //upon form post submission, AddFilm action
        [HttpPost]
        public IActionResult AddFilm(FilmModel film)
        {
            //if input is valid
            if (ModelState.IsValid)
            {
                //save data
                FilmStorage.AddFilm(film);
                //return view for confirmation of the added film
                return View("ConfirmSubmission", film);
            }
            //if input is invalid
            else
            {
                //return current view
                return View();
            }
        }

        //list films
        public IActionResult ListFilms()
        {
            return View(FilmStorage.ConcatFilms);
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
