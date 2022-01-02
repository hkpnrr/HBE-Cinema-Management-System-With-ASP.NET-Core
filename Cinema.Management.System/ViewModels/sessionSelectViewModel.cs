using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Management.System.Models;

namespace Cinema.Management.System.ViewModels
{
    public class sessionSelectViewModel
    {
        public Session session { get; set; }
        public CinemaHall cinemaHall { get; set; }
        public Movie movie { get; set; }
        

        public sessionSelectViewModel(Session session, CinemaHall cinemaHall, Movie movie)
        {
            this.session = session;
            this.cinemaHall = cinemaHall;
            this.movie = movie;
        }
    }
}