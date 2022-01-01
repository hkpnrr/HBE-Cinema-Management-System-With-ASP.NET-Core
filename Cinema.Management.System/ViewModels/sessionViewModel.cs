using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.ViewModels
{
    public class sessionViewModel
    {
        public List<CinemaHall> cinemaHalls { get; set; }

        public List<Movie> movies { get; set; }

        public sessionViewModel(List<CinemaHall> cinemaHalls,List<Movie> movies)
        {
            this.cinemaHalls=cinemaHalls;
            this.movies=movies;
        }

        
    }
}