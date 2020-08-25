using System;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        public IList<Movie> movieList = new List<Movie>();
        public List<Movie> hardMovies = new List<Movie>()
        {
            new Movie(99, "X-Men", Genre.Scifi, DateTime.Parse("2000/1/1"), "Hugh Jackman", "Patrick Stewart"),
            new Movie(100, "The Girl With The Dragon Tattoo", Genre.Action, DateTime.Parse("2002/1/1"), "Daniel Craig", "Joss Whedon")
        };
        public List<Movie> shoppingCart = new List<Movie>();
        public List<Movie> wishList = new List<Movie>();

        public IActionResult Index()
        {
            return View(new Movie());
        }

        public IActionResult WishList()
        {

            return View();
        }

        public ActionResult ListMovies()
        {
            
            ViewBag.list = movieList;
            return View("ListMovies", ViewBag.list);
        }

        public IActionResult ShoppingCart()
        {
            ViewBag.shopping = shoppingCart;
            return View("ShoppingCart", ViewBag.shopping);
        }
        public IActionResult Movie(Movie movie)
        {
            /*
             * This if statement is required so the proper page can be loaded if the Model is incorrect
             */
            if (ModelState.IsValid)
            {
                return View("../Movie/ListMovies", movie);
            }
            else
            { 
                return View("../Movie/Index", movie);
            }
        }
        public IActionResult FullMovieForm(Movie movie)
        {
            string movieListJSON = HttpContext.Session.GetString("MovieListSession") ?? "EmptySession";
            if (movieListJSON != "EmptySession")
            {
                movieList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
            }

            movieList.Add(movie);

            movieListJSON = JsonSerializer.Serialize(movieList);
            HttpContext.Session.SetString("MovieListSession", movieListJSON);

            //for loop to keep track of movieList length for hard list comparison
            int movieCount = 0;

            //for (int i = 0; i < movieList.Count; i++)
            //{
            //    movieCount = i;
            //}

            //foreach (Movie hMovie in hardMovies)
            //{
            //    if the id entered matches the ID of an existing hard coded list item, add it to the shopping cart
            //    else add it to the wishlist
            //    if (hMovie.ID == movieList[movieCount].ID)
            //    {
            //        shoppingCart.AddRange(movieList);
            //        ViewBag.shopping = shoppingCart;
            //        return View("ShoppingCart", ViewBag.shopping);

            //    }
            //    else
            //    {
            //        wishList.AddRange(movieList);
            //        ViewBag.wish = wishList;
            //        return View("WishList", ViewBag.wish);

            //    }
            //}


            return View("ListMovies", ViewBag.list);
        }


    }
}
