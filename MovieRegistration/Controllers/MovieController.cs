using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index(Movie movie)
        {
            return View(movie);
        }

        public IActionResult Movie(Movie movie)
        {
            return View("../Movie/AddMovie", movie);
        }
    }
}
