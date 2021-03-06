using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Ticket
    {
        public int ticketId { get; set; }

        public int userId { get; set; }

        public string userFirstName { get; set; }
        public string userLastName { get; set; }

        public string userEmail { get; set; }
        public int sessionId { get; set; }

        public string movieName { get; set; }
        public string cinemaHallName { get; set; }
        public string sessionTime { get; set; }
        public int seatNo { get; set; }

        public int seatId { get; set; }
        public int sessionPrice { get; set; }


        //moviename cinemahallname sessiontime seatno sessionprice yazdırırken

        public Ticket(int ticketId, int userId, int sessionId)
        {
            this.ticketId = ticketId;
            this.userId = userId;
            this.sessionId = sessionId;
        }

        public Ticket(int userId, int sessionId, string movieName, string cinemaHallName, string sessionTime,
        int seatNo, int sessionPrice)
        {

            this.userId = userId;
            this.sessionId = sessionId;
            this.movieName = movieName;
            this.cinemaHallName = cinemaHallName;
            this.sessionTime = sessionTime;
            this.seatNo = seatNo;
            this.sessionPrice = sessionPrice;

            //moviename,cinemahallname,sessiontime,sessionprice
        }

        public Ticket(string sessionTime, int sessionPrice, string cinemaHallName, string movieName)
        {


            this.movieName = movieName;
            this.cinemaHallName = cinemaHallName;
            this.sessionTime = sessionTime;

            this.sessionPrice = sessionPrice;

            //moviename,cinemahallname,sessiontime,sessionprice
        }

        public Ticket(int ticketId, int userId, int sessionId, string sessionTime, int seatId, string cinemaHallName, string movieName,
         string userFirstName, string userLastName, string userEmail)
        {
            this.ticketId = ticketId;
            this.userId = userId;
            this.sessionId = sessionId;
            this.sessionTime = sessionTime;
            this.seatId = seatId;
            this.cinemaHallName = cinemaHallName;
            this.movieName = movieName;
            this.userFirstName = userFirstName;
            this.userLastName = userLastName;
            this.userEmail = userEmail;
        }

    }
}