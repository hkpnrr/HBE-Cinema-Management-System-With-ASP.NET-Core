using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class CinemaHall
    {
        public int cinemaHallId { get; set; }
        public string cinemaHallName { get; set; }

        public int amountOfSeats { get; set; }
        public string cinemaHallAddress { get; set; }
        

        public CinemaHall(int cinemaHallId, string cinemaHallName ,int amountOfSeats,string cinemaHallAddress)
        {
            this.cinemaHallId = cinemaHallId;
            this.cinemaHallName = cinemaHallName;
            this.cinemaHallAddress = cinemaHallAddress;
            this.amountOfSeats = amountOfSeats;
        }


    }
}