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

        [HttpGet]
        public IActionResult AdminComments()
        {

            List<Comment> allComments = movieRepository.getAllComments();

            return View(allComments);
        }

        [HttpPost]
        public IActionResult AdminComments(int commentId)
        {

            movieRepository.deleteCommentById(commentId);
            return RedirectToAction("AdminComments");
        }


        [HttpGet]
        public IActionResult AdminAddSessions(int cinemaHallId, int movieId, string sessionTime, int sessionPrice)
        {
            sessionViewModel viewModel = new sessionViewModel(movieRepository.getAllCinemaHalls(), movieRepository.getAllMovies());

            if (Convert.ToString(cinemaHallId).Length != 0 && Convert.ToString(movieId).Length != 0 && sessionTime != null && Convert.ToString(sessionPrice).Length != 0)
            {
                Session session = movieRepository.GetSessionByMovieIdAndCinemaHallId(movieId, cinemaHallId, sessionTime);


                if (session == null)
                {

                    //create new session
                    movieRepository.CreateSession(movieId, cinemaHallId, sessionTime, sessionPrice);

                    //session ı oluşturulan movie nin isShowingini true yap

                    int seatNumber = cinemaHallRepository.getSeatNumberByCinemaHallId(cinemaHallId);
                    int sessionId = sessionRepository.getSessionWithAllParameters(movieId, cinemaHallId, sessionTime);
                    //create seat
                    for (int i = 1; i < seatNumber + 1; i++)
                    {
                        seatRepository.CreateSeat(i, sessionId);

                    }


                    return RedirectToAction("AdminSessions");
                }

                else
                {

                    //do nothing or display zaten var 

                    TempData["SessionCreateError"] = "Session has already exists in database";

                    return RedirectToAction("AdminAddSessions");

                }

            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AdminSessions(int sessionId)
        {

            ticketRepository.deleteTicketBySessionId(sessionId);
            seatRepository.deleteSeatsBySessionId(sessionId);

            movieRepository.deleteSessionById(sessionId);


            return RedirectToAction("AdminSessions");
        }

        [HttpGet]
        public IActionResult AdminSessions()
        {


            return View(movieRepository.GetAllSession());
        }

        public IActionResult AdminTickets()
        {
            List<Ticket> allTickets = ticketRepository.findAllTicketGeneralInfo();

            return View(allTickets);
        }

        public IActionResult AdminMovies()
        {

            List<Movie> movies = movieRepository.getAllMovies();

            return View(movies);
        }

        [HttpGet]
        public IActionResult AdminMoviePage(int id) // edit formunu getirir
        {

            //Movie movieDetail = movieRepository.getMovieById(id);

            //List<Actor> actors = movieRepository.getActorsById(id);

            //actorMovieViewModel viewModel= new actorMovieViewModel(movieDetail,actors);

            Movie tempMovie = movieRepository.getMovieWithCategoryAndDirectorByMovieId(id);
            MovieCreateViewModel viewModel = new MovieCreateViewModel(tempMovie, categoryRepository.getAllCategory());

            //Console.WriteLine(viewModel.movie.movieName);

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AdminMoviePage(int MovieId, string MovieName, string MovieReleaseDate, int MovieDuration,
        string MovieTrailerUrl, string MovieSummary, int DirectorId, string DirectorFirstName, string DirectorLastName, int MovieIsShowing, string MoviePhotoUrl, string MoviePosterUrl, int MovieCategoryId) // edit formundaki bilgileri kullanarak UPDATE atar
        {


            bool isShowing = false;
            if (MovieIsShowing == 1)
            {
                isShowing = true;
            }

            //yeni director database de varsa sadece filme ekle
            //yoksa oluştur ve director tablosuna ekle sonra filme ekle





            directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName);
            if (directorRepository._director == null)
            {

                directorRepository.CreateDirector(DirectorFirstName, DirectorLastName);
                directorRepository.GetDirectorByName(DirectorFirstName, DirectorLastName); //for find directorId
            }

            int directorIdTemp = directorRepository._director.directorId;



            //category değişse değişmesede update category ile yolla

            categoryRepository.editMovieHasCategory(MovieId, MovieCategoryId);


            //filmi database update
            Movie tempMovie = new Movie(MovieId, MovieName, MovieReleaseDate, MovieDuration,
         MovieTrailerUrl, MovieSummary, directorIdTemp, isShowing, MoviePhotoUrl, MoviePosterUrl);


            //int movieIdTemp = movieRepository.getMovieIdByName(MovieName);



            if (MovieName != null && MovieReleaseDate != null && MovieDuration.ToString().Length != 0 &&
        MovieTrailerUrl != null && MovieSummary != null && MoviePhotoUrl != null && MoviePosterUrl != null)
            {




                movieRepository.editMovie(tempMovie);
            }
            //List<Actor> actors = movieRepository.getActorsById(id);

            //actorMovieViewModel viewModel= new actorMovieViewModel(movieDetail,actors);

            return RedirectToAction("AdminMovies"); // return back to movie list page
        }



        public IActionResult AdminAddMovie(string MovieName, string MovieReleaseDate, int MovieDuration,
        string MovieTrailerUrl, string MovieSummary, string DirectorFirstName
        , string DirectorLastName, int MovieIsShowing, string MoviePhotoUrl, string MoviePosterUrl, string MovieCategory)
        {
            List<string> allCategoryNames = categoryRepository.getAllCategoryNames();


            if (MovieName != null && MovieReleaseDate != null &&
        MovieTrailerUrl != null && MovieSummary != null && DirectorFirstName != null &&
        DirectorLastName != null && MoviePhotoUrl != null && MoviePosterUrl != null && MovieCategory != null)
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


                    categoryRepository.SendCategoryToDatabase(categoryRepository.getCategoryIdByName(m.movieCategory), movieRepository.getMovieIdByName(m.movieName));

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

                    categoryRepository.SendCategoryToDatabase(categoryRepository.getCategoryIdByName(m.movieCategory), movieRepository.getMovieIdByName(m.movieName));
                    return RedirectToAction("AdminMovies");
                }
                else
                {

                    if (MovieName != null && MovieReleaseDate != null &&
                        MovieTrailerUrl != null && MovieSummary != null && DirectorFirstName != null &&
                        DirectorLastName != null && MoviePhotoUrl != null && MoviePosterUrl != null && MovieCategory != null)
                    {
                        TempData["MovieCreateError"] = "Movie has already exists in database";
                    }

                    return RedirectToAction("AdminAddMovie");
                }
            }
            return View(allCategoryNames);
        }

        [HttpGet]
        public IActionResult AddActor(int id, string actorName, string actorSurname)
        {
            if (actorName != null && actorSurname != null)
            {
                Actor actor = movieRepository.getActorsByName(actorName, actorSurname);

                if (actor == null)
                {

                    //create new actor
                    movieRepository.createActor(actorName, actorSurname);
                    //get created actors id
                    int actorId = movieRepository.getActorIdByName(actorName, actorSurname);



                    //attach movie and actors at movie has actors table
                    movieRepository.SendActorAndMovieRelationToDatabase(actorId, id);

                    return View(id);

                }

                else
                {

                    //add exist actor to movies cast
                    movieRepository.SendActorAndMovieRelationToDatabase(actor.actorId, id);
                    return View(id);

                }
            }
            return View(id);
        }
    }
}
