﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieHunt.Models;
using MovieHunt.ViewModel;
using System.Data.Entity;


namespace MovieHunt.Controllers
{
    public class MovieController : Controller
    {
        protected ApplicationDbContext _context;

        public MovieController()
        {
            _context= new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

       
       
        
    }
}