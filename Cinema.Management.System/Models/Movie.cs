﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Movie
    {
        public int movieId { get; set; }
        public String movieName { get; set; }
        public String movieReleaseDate { get; set; }
        public int movieDuration { get; set; }
        public String movieTrailerUrl { get; set; }
        public String movieSummary { get; set; }
        public int movieDirectorId { get; set; }

        public Boolean isShowing { get; set; }

        public Movie(int movieId, String movieName, String movieReleaseDate, int movieDuration, String movieTrailerUrl, String movieSummary, int movieDirectorId, Boolean isShowing)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.movieReleaseDate = movieReleaseDate;
            this.movieDuration = movieDuration;
            this.movieTrailerUrl = movieTrailerUrl;
            this.movieSummary = movieSummary;
            this.movieDirectorId = movieDirectorId;
            this.isShowing = isShowing;
        }
    }
}