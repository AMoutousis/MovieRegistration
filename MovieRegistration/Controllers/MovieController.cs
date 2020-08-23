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
        public IActionResult Index()
        {
            return View(new Movie());
        }

        public IActionResult Movie(Movie movie)
        {
            /*
             * This if statement is required so the proper page can be loaded if the Model is incorrect
             */
            if (ModelState.IsValid)
            {
                return View("../Movie/AddMovie", movie);
            }
            else
            { 
                return View("../Movie/Index", movie);
            }
        }
    }
}
