﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWebApp.Models;
using VidlyWebApp.ViewModels;
using System.Data.Entity.Validation;

namespace VidlyWebApp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }




        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewmodel = new MovieFormViewModel()
            {
            Genres = genres
            };
            return View("MovieForm", viewmodel);
        }




        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewmodel = new MovieFormViewModel(movie)
            {
                //Movie = movie,
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewmodel);
        }




        // GET: Movies
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movies movie)
        {
            if(!ModelState.IsValid)
            {
                var viewmodel = new MovieFormViewModel(movie)
                {
                    //Movie = movie,
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewmodel);
            }

            if(movie.Id==0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }

            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id==movie.Id);
                movieInDb.MovieName = movie.MovieName;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleasedDate = movie.ReleasedDate;
            }


                _context.SaveChanges();
          

            return RedirectToAction("Index", "Movies");
        }


    }
}