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

            return View(movies);
        }

        // BUNA PARAMETRE GÖNDERMEMİZ LAZIM, HANGİ FİLM OLDUĞUNU YOLLA
        public IActionResult MoviePage(int id) // BİR TANE FİLM'İN GÖSTERİLDİĞİ ŞAHSİ, TEKİL SAYFA
        {


            Movie movieDetail = movieRepository.getMovieById(id);

            List<Actor> actors = movieRepository.getActorsById();

            List<Comment> comments = movieRepository.getAllCommentsByMovieId(id);

            MovieViewModel viewModel = new MovieViewModel(movieDetail, actors, comments);

            return View(viewModel);
        }

        // public IActionResult AddCommentMoviePage(int id, string commentContent) // YORUMU POST ETMEK İÇİN
        // {
        //     Console.WriteLine(id + " " + commentContent + " ADD-COMMENT-MOVIEPAGE"); // comment content'i çekemedim

        //     Movie movieDetail = movieRepository.getMovieById(id);

        //     Comment tempComment = new Comment(movieDetail.movieId, customerRepository.authUser.userId, 
        //     customerRepository.authUser.firstName, customerRepository.authUser.lastName, commentContent);

        //     movieRepository.SendCommentToDatabase(tempComment);


        //     return RedirectToAction("MoviePage");
        // }


        public IActionResult Movies() // BÜTÜN FİLMLERİN GÖSTERİLDİĞİ SAYFA
        {

            // Movie mov = _movieService.getMovie();

            List<Movie> movies = movieRepository.getAllMovies();

            return View(movies);
        }

        public IActionResult CinemaHalls() // SİNEMA SALONLARININ GÖSTERİLDİĞİ SAYFA
        {
            List<CinemaHall> cinemaHalls = cinemaHallRepository.getAllCinemaHalls();

            return View(cinemaHalls);
        }



    }
}
