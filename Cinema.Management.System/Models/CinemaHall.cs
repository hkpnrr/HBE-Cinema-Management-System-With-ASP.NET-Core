using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class CinemaHall
    {
        public int cinemaHallId { get; set; }
        public int mallId { get; set; }
        public string cinemaHallName { get; set; }
        public int amountOfSeats { get; set; }

        public CinemaHall(int cinemaHallId, int mallId, string cinemaHallName, int amountOfSeats)
        {
            this.cinemaHallId = cinemaHallId;
            this.mallId = mallId;
            this.cinemaHallName = cinemaHallName;
            this.amountOfSeats = amountOfSeats;
        }


    }
}