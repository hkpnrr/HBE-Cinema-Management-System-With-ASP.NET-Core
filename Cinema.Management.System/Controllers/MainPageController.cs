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

            // List<Movie> movies = movieRepository.getAllMovies();

            List<Movie> isShowingMovies = movieRepository.getAllMoviesByisShowing(true);

            List<Movie> notShowingMovies = movieRepository.getAllMoviesByisShowing(false);

            MovieIsShowingViewModel movieIsShowingViewModel = new MovieIsShowingViewModel(isShowingMovies, notShowingMovies);


            return View(movieIsShowingViewModel);
        }
        [HttpGet]
        // BUNA PARAMETRE GÖNDERMEMİZ LAZIM, HANGİ FİLM OLDUĞUNU YOLLA
        public IActionResult MoviePage(int id) // BİR TANE FİLM'İN GÖSTERİLDİĞİ ŞAHSİ, TEKİL SAYFA
        {

            Movie movieDetail = movieRepository.getMovieById(id);

            List<Actor> actors = movieRepository.getActorsById();

            List<Comment> comments = movieRepository.getAllCommentsByMovieId(id);

            MovieViewModel viewModel = new MovieViewModel(movieDetail, actors, comments);

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult MoviePage(int id, string makeComment) // YORUMU POST ETMEK İÇİN
        {
            

            Movie movieDetail = movieRepository.getMovieById(id);

            Comment tempComment = new Comment(movieDetail.movieId, customerRepository.authUser.userId,
            customerRepository.authUser.firstName, customerRepository.authUser.lastName, makeComment);

            movieRepository.SendCommentToDatabase(tempComment);

            List<Actor> actors = movieRepository.getActorsById();

            List<Comment> comments = movieRepository.getAllCommentsByMovieId(id);

            MovieViewModel viewModel = new MovieViewModel(movieDetail, actors, comments);

            return View(viewModel);
        }


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
