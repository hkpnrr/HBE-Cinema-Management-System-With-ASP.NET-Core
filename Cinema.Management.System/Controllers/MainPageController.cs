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


        public IActionResult AddToWatchList(int MovieId)
        {
            Console.WriteLine(MovieId);
            int userIdTemp = customerRepository.authUser.userId;
            if (movieRepository.CheckWatchedByUserIdMovieId(MovieId, userIdTemp) == null)
            {
                movieRepository.AddMovieToWatcList(MovieId, userIdTemp);
            }
            else
            {
                TempData["MovieWatcedError"] = "You have added this film already";
                return RedirectToAction("MoviePage", new { id = MovieId });
            }

            return RedirectToAction("MoviePage", new { id = MovieId });
        }

        public IActionResult Profile()
        {
            return View(new ProfileViewModel(customerRepository.authUser, movieRepository.GetWatchedMovies(customerRepository.authUser.userId)));
        }


        [HttpGet]
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

            List<CinemaHallsViewModel> CinemaHallsWithMovies = cinemaHallRepository.getCinemaHallsWithMovies();
            List<List<CinemaHallsViewModel>> listOfList = new List<List<CinemaHallsViewModel>>();
            int j = 0;
            int tempId = 0;

            for (int i = 0; i < CinemaHallsWithMovies.Count(); i++)
            {

                if (i == 0)
                {
                    listOfList.Add(new List<CinemaHallsViewModel>());
                    tempId = CinemaHallsWithMovies[i].cinemaHallId;
                    listOfList[j].Add(CinemaHallsWithMovies[i]);
                }
                else
                {
                    tempId = CinemaHallsWithMovies[i - 1].cinemaHallId;
                    if (tempId == CinemaHallsWithMovies[i].cinemaHallId)
                    {
                        listOfList[j].Add(CinemaHallsWithMovies[i]);
                    }
                    else
                    {
                        j++;
                        listOfList.Add(new List<CinemaHallsViewModel>());
                        listOfList[j].Add(CinemaHallsWithMovies[i]);
                    }

                }
            }


            return View(listOfList);
        }



    }
}
