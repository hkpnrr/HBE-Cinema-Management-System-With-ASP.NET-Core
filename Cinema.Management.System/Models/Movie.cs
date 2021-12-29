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

    


    }
}
