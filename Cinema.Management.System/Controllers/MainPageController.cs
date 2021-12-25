using Microsoft.AspNetCore.Mvc;
using Cinema.Management.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Data;

namespace Cinema.Management.System.Controllers
{
    public class MainPageController : Controller
    {

        public IActionResult MainPage()
        {
            List<Movie> movies = movieRepository.getAllMovies();
            Console.WriteLine(movies[0].movieName + movies[0].isShowing);

            return View(movies);
        }

        public IActionResult MoviePage()
        {
            //
            // Movie mov = _movieService.getMovie();

            List<Movie> movies = movieRepository.getAllMovies();
            Console.WriteLine(movies[0].movieName + movies[0].isShowing);


            return View(movies);
        }
    }
}
