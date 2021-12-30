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



        public IActionResult AdminAddMovie(string MovieName, string MovieReleaseDate, int MovieDuration,
        string MovieTrailerUrl, string MovieSummary, string DirectorFirstName
        , string DirectorLastName, int MovieIsShowing, string MoviePhotoUrl, string MoviePosterUrl, string MovieCategory)
        {
             List<string> allCategoryNames=categoryRepository.getAllCategoryNames();
             

            if (MovieName != null && MovieReleaseDate != null && 
        MovieTrailerUrl != null && MovieSummary != null && DirectorFirstName != null &&
        DirectorLastName != null  && MoviePhotoUrl != null && MoviePosterUrl != null && MovieCategory != null)
            {
                movieRepository.getAllMovieNames();

                if (movieRepository._moviesName != null && !movieRepository._moviesName.Contains(MovieName))
                {

                    directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName);
                    if (directorRepository._director == null)
                    {
                        directorRepository.CreateDirector(DirectorFirstName, DirectorLastName);
                        directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName); //for find directorId
                    }

                    int directorIdTemp = directorRepository._director.directorId;
                    bool isShowing = false;

                    if (MovieIsShowing == 1)
                    {
                        isShowing = true;
                    }

                    Movie m = new Movie(MovieName, MovieReleaseDate, MovieDuration, MovieTrailerUrl, MovieSummary, directorIdTemp,
                    isShowing, MoviePhotoUrl, MoviePosterUrl, MovieCategory, DirectorFirstName, DirectorLastName);

                    movieRepository.SendMovieToDatabase(m);
                    

                    categoryRepository.SendCategoryToDatabase(categoryRepository.getCategoryIdByName(m.movieCategory),movieRepository.getMovieIdByName(m.movieName));

                    return RedirectToAction("AdminMovies");

                }
                else if (movieRepository._moviesName == null)
                {
                    directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName);
                    if (directorRepository._director == null)
                    {
                        directorRepository.CreateDirector(DirectorFirstName, DirectorLastName);
                        directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName); //for find directorId
                    }

                    int directorIdTemp = directorRepository._director.directorId;
                    bool isShowing = false;

                    if (MovieIsShowing == 1)
                    {
                        isShowing = true;
                    }

                    Movie m = new Movie(MovieName, MovieReleaseDate, MovieDuration, MovieTrailerUrl, MovieSummary, directorIdTemp,
                    isShowing, MoviePhotoUrl, MoviePosterUrl, MovieCategory, DirectorFirstName, DirectorLastName);

                    movieRepository.SendMovieToDatabase(m);

                    categoryRepository.SendCategoryToDatabase(categoryRepository.getCategoryIdByName(m.movieCategory),movieRepository.getMovieIdByName(m.movieName));
                    return RedirectToAction("AdminMovies");
                }
                else
                {

                    if (MovieName != null && MovieReleaseDate != null && 
                        MovieTrailerUrl != null && MovieSummary != null && DirectorFirstName != null &&
                        DirectorLastName != null  && MoviePhotoUrl != null && MoviePosterUrl != null && MovieCategory != null)
                    {
                        TempData["MovieCreateError"] = "Movie has already exists in database";
                    }

                    return RedirectToAction("AdminAddMovie");
                }



            }

            return View(allCategoryNames);
        }
    }
}
