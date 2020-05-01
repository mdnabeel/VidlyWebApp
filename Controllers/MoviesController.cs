using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWebApp.Models;

namespace VidlyWebApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        private IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies { Id = 1, MovieName = "Money Heist" },
                new Movies { Id = 2, MovieName = "Shawshank Redemption" },
                new Movies { Id = 3, MovieName = "The Accountant" },
                new Movies { Id = 4, MovieName = "Dunkirk" },
                new Movies { Id = 5, MovieName = "The Revenant" },
                new Movies { Id = 6, MovieName = "Interstellar" },
                new Movies { Id = 7, MovieName = "Parasite" }

            };
        }
    }
}