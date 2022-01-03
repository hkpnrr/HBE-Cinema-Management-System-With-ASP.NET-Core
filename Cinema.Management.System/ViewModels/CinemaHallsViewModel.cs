using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.ViewModels
{
    public class CinemaHallsViewModel
    {

        public int cinemaHallId { get; set; }
        public string cinemaHallName { get; set; }

        public string cinemaHallAddress { get; set; }

        public int movieId { get; set; }

        public string movieName { get; set; }

        public string moviePhotoUrl { get; set; }

        public CinemaHallsViewModel(int cinemaHallId, string cinemaHallName, string cinemaHallAddress, int movieId, string movieName, string moviePhotoUrl)
        {
            this.cinemaHallId = cinemaHallId;
            this.cinemaHallName = cinemaHallName;
            this.cinemaHallAddress = cinemaHallAddress;
            this.movieId = movieId;
            this.movieName = movieName;
            this.moviePhotoUrl = moviePhotoUrl;
        }

    }
}