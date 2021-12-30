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
    public class MainPageController : Controller
    {

        public IActionResult MainPage()
        {

            List<Movie> movies = movieRepository.getAllMovies();

            Console.WriteLine(movies[0].movieName + movies[0].isShowing);
            Console.WriteLine(movies[1].movieName + movies[1].isShowing);
            Console.WriteLine(movies[2].movieName + movies[2].isShowing);

            return View(movies);
        }

        // BUNA PARAMETRE GÖNDERMEMİZ LAZIM, HANGİ FİLM OLDUĞUNU YOLLA
        public IActionResult MoviePage(int id) // BİR TANE FİLM'İN GÖSTERİLDİĞİ ŞAHSİ, TEKİL SAYFA
        {
            

            Movie movieDetail = movieRepository.getMovieById(id);

            //List<Actor> actors = movieRepository.getActorsById(id);

            //actorMovieViewModel viewModel= new actorMovieViewModel(movieDetail,actors);

            return View(movieDetail);
        }


        public IActionResult Movies() // BÜTÜN FİLMLERİN GÖSTERİLDİĞİ SAYFA
        {

            // Movie mov = _movieService.getMovie();

            List<Movie> movies = movieRepository.getAllMovies();
            Console.WriteLine(movies[0].movieName + movies[0].isShowing);


            return View(movies);
        }

        public IActionResult CinemaHalls() // SİNEMA SALONLARININ GÖSTERİLDİĞİ SAYFA
        {
            List<CinemaHall> cinemaHalls = cinemaHallRepository.getAllCinemaHalls();

            return View(cinemaHalls);
        }



    }
}
