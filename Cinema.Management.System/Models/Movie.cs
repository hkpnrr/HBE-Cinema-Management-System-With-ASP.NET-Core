using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Movie
    {
        public int movieId { get; set; }
        public string movieName { get; set; }
        public string movieReleaseDate { get; set; }
        public int movieDuration { get; set; }
        public string movieTrailerUrl { get; set; }
        public string movieSummary { get; set; }

        public bool isShowing { get; set; }

        public string moviePhotoUrl { get; set; }
        public string moviePosterUrl { get; set; }

        public string movieCategory { get; set; }

        public Director movieDirector { get; set; }

        public int directorId { get; set; }
        public int categoryId { get; set; }

        public Movie(int movieId, string movieName, string movieReleaseDate, int movieDuration, string movieTrailerUrl,
        string movieSummary, int movieDirectorId,
         bool isShowing, string moviePhotoUrl, string moviePosterUrl,
         string movieCategory, string movieDirectorFirstName, string movieDirectorLastName)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.movieReleaseDate = movieReleaseDate;
            this.movieDuration = movieDuration;
            this.movieTrailerUrl = movieTrailerUrl;
            this.movieSummary = movieSummary;

            movieDirector = new Director(movieDirectorId, movieDirectorFirstName, movieDirectorLastName);
            this.movieDirector = movieDirector;

            this.isShowing = isShowing;
            this.moviePhotoUrl = moviePhotoUrl;
            this.moviePosterUrl = moviePosterUrl;
            this.movieCategory = movieCategory;

        }

        public Movie(string movieName, string movieReleaseDate, int movieDuration, string movieTrailerUrl,
        string movieSummary, int movieDirectorId,
         bool isShowing, string moviePhotoUrl, string moviePosterUrl,
         string movieCategory, string movieDirectorFirstName, string movieDirectorLastName)
        {

            this.movieName = movieName;
            this.movieReleaseDate = movieReleaseDate;
            this.movieDuration = movieDuration;
            this.movieTrailerUrl = movieTrailerUrl;
            this.movieSummary = movieSummary;

            movieDirector = new Director(movieDirectorId, movieDirectorFirstName, movieDirectorLastName);
            this.movieDirector = movieDirector;

            this.isShowing = isShowing;
            this.moviePhotoUrl = moviePhotoUrl;
            this.moviePosterUrl = moviePosterUrl;
            this.movieCategory = movieCategory;

        }

        // EDIT MOVIE İÇİN YAZDIM
        public Movie(int movieId, string movieName, string movieReleaseDate, int movieDuration, string movieTrailerUrl,
            string movieSummary, bool isShowing, string moviePhotoUrl, string moviePosterUrl)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.movieReleaseDate = movieReleaseDate;
            this.movieDuration = movieDuration;
            this.movieTrailerUrl = movieTrailerUrl;
            this.movieSummary = movieSummary;

            this.isShowing = isShowing;
            this.moviePhotoUrl = moviePhotoUrl;
            this.moviePosterUrl = moviePosterUrl;

        }


        //for edit movie

        public Movie(int movieId,string movieName, string movieReleaseDate, 
        int movieDuration, string movieTrailerUrl,string movieSummary, 
        int movieDirectorId,bool isShowing, string moviePhotoUrl, string moviePosterUrl,
         string movieCategory,int categoryId,int directorId, string movieDirectorFirstName, string movieDirectorLastName)
        {
            this.movieId=movieId;
            this.movieName = movieName;
            this.movieReleaseDate = movieReleaseDate;
            this.movieDuration = movieDuration;
            this.movieTrailerUrl = movieTrailerUrl;
            this.movieSummary = movieSummary;

            movieDirector = new Director(movieDirectorId, movieDirectorFirstName, movieDirectorLastName);
            this.movieDirector = movieDirector;
            this.directorId=directorId;
            this.categoryId=categoryId;

            this.isShowing = isShowing;
            this.moviePhotoUrl = moviePhotoUrl;
            this.moviePosterUrl = moviePosterUrl;
            this.movieCategory = movieCategory;

        }

        public Movie(int movieId, string movieName, string movieReleaseDate, int movieDuration, string movieTrailerUrl,
        string movieSummary, int movieDirectorId,
         bool isShowing, string moviePhotoUrl, string moviePosterUrl)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.movieReleaseDate = movieReleaseDate;
            this.movieDuration = movieDuration;
            this.movieTrailerUrl = movieTrailerUrl;
            this.movieSummary = movieSummary;

            
            this.directorId = movieDirectorId;

            this.isShowing = isShowing;
            this.moviePhotoUrl = moviePhotoUrl;
            this.moviePosterUrl = moviePosterUrl;
            

        }

    }
}
