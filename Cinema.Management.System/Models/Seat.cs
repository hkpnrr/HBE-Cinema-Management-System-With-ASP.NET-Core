using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Management.System.Models
{
    public class Seat
    {

        public int seatId { get; set; }
        public int seatNumber { get; set; }
        public int sessionId { get; set; }

        public bool isAvailable { get; set; }

        public Seat(int seatId,int seatNumber,int sessionId,bool isAvailable)
        {   
            this.seatId=seatId;
            this.seatNumber=seatNumber;
            this.sessionId=sessionId;
            this.isAvailable=isAvailable;   
        }
    }
}