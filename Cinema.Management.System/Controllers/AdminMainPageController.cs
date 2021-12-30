using Microsoft.AspNetCore.Mvc;
using Cinema.Management.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Data;
using Cinema.Management.System.ViewModels;

namespace Cinema.Management.System.Controllers
{
    public class AdminMainPageController : Controller
    {
        public IActionResult AdminMainPage()
        {

            return View();
        }


        public IActionResult AdminMovies()
        {

            List<Movie> movies = movieRepository.getAllMovies();
            //Console.WriteLine(movies[0].movieName + movies[0].isShowing);


            return View(movies);
        }

        public IActionResult AdminMoviePage(int id)
        {

            Movie movieDetail = movieRepository.getMovieById(id);

            //List<Actor> actors = movieRepository.getActorsById(id);

            //actorMovieViewModel viewModel= new actorMovieViewModel(movieDetail,actors);

            return View(movieDetail);
        }



        public IActionResult AdminAddMovie()
        {

            return View();
        }
    }
}
