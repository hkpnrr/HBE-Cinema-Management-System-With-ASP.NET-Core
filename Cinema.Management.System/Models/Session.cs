using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Session
    {
        public int sessionId { get; set; }

        public int movieId { get; set; }
        public int cinemaHallId { get; set; }
        public string sessionTime { get; set; }

        public int sessionPrice { get; set; }

        public Session(int sessionId,int movieId,int cinemaHallId,string sessionTime,int sessionPrice)
        {
            this.sessionId=sessionId;
            this.movieId=movieId;
            this.cinemaHallId=cinemaHallId;
            this.sessionTime=sessionTime;
            this.sessionPrice=sessionPrice;
            
        }
        public Session(int sessionId,int movieId,int cinemaHallId,string sessionTime)
        {
            this.sessionId=sessionId;
            this.movieId=movieId;
            this.cinemaHallId=cinemaHallId;
            this.sessionTime=sessionTime;
            
        }
    }
}